﻿using ElectronicObserver.Data;
using ElectronicObserver.Observer;
using ElectronicObserver.Resource;
using ElectronicObserver.Utility.Data;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WeifenLuo.WinFormsUI.Docking;

namespace ElectronicObserver.Window {

	public partial class FormInformation : DockContent {

		private int _ignorePort;
		private List<int> _inSortie;

		public FormInformation( FormMain parent ) {
			InitializeComponent();

			_ignorePort = 0;
			_inSortie = null;

			ConfigurationChanged();

			Icon = ResourceManager.ImageToIcon( ResourceManager.Instance.Icons.Images[(int)ResourceManager.IconContent.FormInformation] );
		}


		private void FormInformation_Load( object sender, EventArgs e ) {

			APIObserver o = APIObserver.Instance;

			o["api_port/port"].ResponseReceived += Updated;
			o["api_req_member/get_practice_enemyinfo"].ResponseReceived += Updated;
			o["api_get_member/picture_book"].ResponseReceived += Updated;
			o["api_req_kousyou/createitem"].ResponseReceived += Updated;
			o["api_get_member/mapinfo"].ResponseReceived += Updated;
			o["api_req_mission/result"].ResponseReceived += Updated;
			o["api_req_ranking/getlist"].ResponseReceived += Updated;
			o["api_req_practice/battle_result"].ResponseReceived += Updated;
			o["api_req_sortie/battleresult"].ResponseReceived += Updated;
			o["api_req_combined_battle/battleresult"].ResponseReceived += Updated;
			o["api_req_hokyu/charge"].ResponseReceived += Updated;
			o["api_req_map/start"].ResponseReceived += Updated;
			o["api_req_practice/battle"].ResponseReceived += Updated;

			Utility.Configuration.Instance.ConfigurationChanged += ConfigurationChanged;
		}


		void ConfigurationChanged() {

			Font = TextInformation.Font = Utility.Configuration.Config.UI.MainFont;
            BackColor = Utility.ThemeManager.GetColor(Utility.Configuration.Config.UI.Theme, Utility.ThemeColors.BackgroundColor);
            ForeColor = Utility.ThemeManager.GetColor(Utility.Configuration.Config.UI.Theme, Utility.ThemeColors.MainFontColor);
            TextInformation.BackColor = Utility.ThemeManager.GetColor(Utility.Configuration.Config.UI.Theme, Utility.ThemeColors.BackgroundColor);
            TextInformation.ForeColor = Utility.ThemeManager.GetColor(Utility.Configuration.Config.UI.Theme, Utility.ThemeColors.MainFontColor);
        }


		void Updated( string apiname, dynamic data ) {

			switch ( apiname ) {

				case "api_port/port":
					if ( _ignorePort > 0 )
						_ignorePort--;
					else
						TextInformation.Text = "";		//とりあえずクリア

					if ( _inSortie != null ) {
						TextInformation.Text = GetConsumptionResource( data );
					}
					_inSortie = null;
					break;

				case "api_req_member/get_practice_enemyinfo":
					TextInformation.Text = GetPracticeEnemyInfo( data );
					break;

				case "api_get_member/picture_book":
					TextInformation.Text = GetAlbumInfo( data );
					break;

				case "api_req_kousyou/createitem":
					TextInformation.Text = GetCreateItemInfo( data );
					break;

				case "api_get_member/mapinfo":
					TextInformation.Text = GetMapGauge( data );
					break;

				case "api_req_mission/result":
					TextInformation.Text = GetExpeditionResult( data );
					_ignorePort = 1;
					break;

				case "api_req_ranking/getlist":
					TextInformation.Text = GetRankingData( data );
					break;

				case "api_req_practice/battle_result":
				case "api_req_sortie/battleresult":
				case "api_req_combined_battle/battleresult":
					TextInformation.Text = GetBattleResult( data );
					break;

				case "api_req_hokyu/charge":
					TextInformation.Text = GetSupplyInformation( data );
					break;

				case "api_req_map/start":
					_inSortie = KCDatabase.Instance.Fleet.Fleets.Values.Where( f => f.IsInSortie || f.ExpeditionState == 1 ).Select( f => f.FleetID ).ToList();
					break;

				case "api_req_practice/battle":
					_inSortie = new List<int>() { KCDatabase.Instance.Battle.BattleDay.Initial.FriendFleetID };
					break;
			}

		}


		private string GetPracticeEnemyInfo( dynamic data ) {

			StringBuilder sb = new StringBuilder();
			sb.AppendLine( GeneralRes.PracticeReport );
            sb.AppendLine("Admiral Name: " + data.api_nickname);
			sb.AppendLine( GeneralRes.EnemyFleetName + ":" + data.api_deckname );

			{
				int ship1lv = (int)data.api_deck.api_ships[0].api_id != -1 ? (int)data.api_deck.api_ships[0].api_level : 1;
				int ship2lv = (int)data.api_deck.api_ships[1].api_id != -1 ? (int)data.api_deck.api_ships[1].api_level : 1;

				// 経験値テーブルが拡張されたとき用の対策
				ship1lv = Math.Min( ship1lv, ExpTable.ShipExp.Keys.Max() );
				ship2lv = Math.Min( ship2lv, ExpTable.ShipExp.Keys.Max() );

				double expbase = ExpTable.ShipExp[ship1lv].Total / 100.0 + ExpTable.ShipExp[ship2lv].Total / 300.0;
				if ( expbase >= 500.0 )
					expbase = 500.0 + Math.Sqrt( expbase - 500.0 );
				sb.AppendLine( GeneralRes.TotalExperienceGained + ": " + (int)expbase );
				sb.AppendLine( GeneralRes.SVictory + ": " + (int)( expbase * 1.2 ) );


				// 練巡ボーナス計算 - きたない
				var fleet = KCDatabase.Instance.Fleet[1];
				if ( fleet.MembersInstance.Any( s => s != null && s.MasterShip.ShipType == 21 ) ) {
					var members = fleet.MembersInstance;
					var subCT = members.Skip( 1 ).Where( s => s != null && s.MasterShip.ShipType == 21 );

					double bonus;

					// 旗艦が練巡
					if ( members[0] != null && members[0].MasterShip.ShipType == 21 ) {

						int level = members[0].Level;

						if ( subCT != null && subCT.Any() ) {
							// 旗艦+随伴
							if ( level < 10 ) bonus = 1.10;
							else if ( level < 30 ) bonus = 1.13;
							else if ( level < 60 ) bonus = 1.16;
							else if ( level < 100 ) bonus = 1.20;
							else bonus = 1.25;

						} else {
							// 旗艦のみ
							if ( level < 10 ) bonus = 1.05;
							else if ( level < 30 ) bonus = 1.08;
							else if ( level < 60 ) bonus = 1.12;
							else if ( level < 100 ) bonus = 1.15;
							else bonus = 1.20;
						}

					} else {

						int level = subCT.Max( s => s.Level );

						if ( subCT.Count() > 1 ) {
							// 随伴複数	
							if ( level < 10 ) bonus = 1.04;
							else if ( level < 30 ) bonus = 1.06;
							else if ( level < 60 ) bonus = 1.08;
							else if ( level < 100 ) bonus = 1.12;
							else bonus = 1.175;

						} else {
							// 随伴単艦
							if ( level < 10 ) bonus = 1.03;
							else if ( level < 30 ) bonus = 1.05;
							else if ( level < 60 ) bonus = 1.07;
							else if ( level < 100 ) bonus = 1.10;
							else bonus = 1.15;
						}
					}

					sb.AppendFormat( "(" + GeneralRes.TrainingBonus + ": {0} /" + GeneralRes.SVictory + ": {1})\r\n", (int)( expbase * bonus ), (int)( (int)( expbase * 1.2 ) * bonus ) );


				}
			}

			return sb.ToString();
		}


		private string GetAlbumInfo( dynamic data ) {

			StringBuilder sb = new StringBuilder();

			if ( data != null && data.api_list() && data.api_list != null ) {

				if ( data.api_list[0].api_yomi() ) {
                    //艦娘図鑑
                    const int bound = 70;		// 図鑑1ページあたりの艦船数
					int startIndex = ( ( (int)data.api_list[0].api_index_no - 1 ) / bound ) * bound + 1;
					bool[] flags = Enumerable.Repeat<bool>( false, bound ).ToArray();

                    sb.AppendLine(GeneralRes.DamagedArtUnseen);

					foreach ( dynamic elem in data.api_list ) {

						flags[(int)elem.api_index_no - startIndex] = true;

						dynamic[] state = elem.api_state;
						for ( int i = 0; i < state.Length; i++ ) {
							if ( (int)state[i][1] == 0 ) {

								var target = KCDatabase.Instance.MasterShips[(int)elem.api_table_id[i]];
								if ( target != null )		//季節の衣替え艦娘の場合存在しないことがある
									sb.AppendLine( target.Name );
							}
						}

					}

					sb.AppendLine( GeneralRes.UnseenShips );
					for ( int i = 0; i < bound; i++ ) {
						if ( !flags[i] ) {
							ShipDataMaster ship = KCDatabase.Instance.MasterShips.Values.FirstOrDefault( s => s.AlbumNo == startIndex + i );
							if ( ship != null ) {
								sb.AppendLine( ship.Name );
							}
						}
					}

				} else {
					//装備図鑑
					const int bound = 70;		// 図鑑1ページあたりの装備数
					int startIndex = ( ( (int)data.api_list[0].api_index_no - 1 ) / bound ) * bound + 1;
					bool[] flags = Enumerable.Repeat<bool>( false, bound ).ToArray();

					foreach ( dynamic elem in data.api_list ) {

						flags[(int)elem.api_index_no - startIndex] = true;
					}

					sb.AppendLine( GeneralRes.UnseenEquips );
					for ( int i = 0; i < bound; i++ ) {
						if ( !flags[i] ) {
							EquipmentDataMaster eq = KCDatabase.Instance.MasterEquipments.Values.FirstOrDefault( s => s.AlbumNo == startIndex + i );
							if ( eq != null ) {
								sb.AppendLine( eq.Name );
							}
						}
					}
				}
			}

			return sb.ToString();
		}


		private string GetCreateItemInfo( dynamic data ) {

			if ( (int)data.api_create_flag == 0 ) {

				StringBuilder sb = new StringBuilder();
				sb.AppendLine( GeneralRes.DevelopmentFailed );
				sb.AppendLine( data.api_fdata );

				EquipmentDataMaster eqm = KCDatabase.Instance.MasterEquipments[int.Parse( ( (string)data.api_fdata ).Split( ",".ToCharArray() )[1] )];
				if ( eqm != null )
					sb.AppendLine( eqm.Name );


				return sb.ToString();

			} else
				return "";
		}


		private string GetMapGauge( dynamic data ) {

			StringBuilder sb = new StringBuilder();
			sb.AppendLine( GeneralRes.MapGauges );

			foreach ( dynamic elem in data ) {

				int mapID = (int)elem.api_id;
				MapInfoData map = KCDatabase.Instance.MapInfo[mapID];

				if ( map != null ) {
					if ( map.RequiredDefeatedCount != -1 && elem.api_defeat_count() ) {

						sb.AppendFormat( "{0}-{1}: " + GeneralRes.Defeated + " {2}/{3} " + GeneralRes.Times + "\r\n", map.MapAreaID, map.MapInfoID, (int)elem.api_defeat_count, map.RequiredDefeatedCount );

					} else if ( elem.api_eventmap() ) {

						string difficulty = "";
						if ( elem.api_eventmap.api_selected_rank() ) {
							difficulty = "[" + Constants.GetDifficulty( (int)elem.api_eventmap.api_selected_rank ) + "] ";
						}

						sb.AppendFormat( "{0}-{1} {2}: {3} {4}/{5}\r\n",
							map.MapAreaID, map.MapInfoID, difficulty,
							elem.api_eventmap.api_gauge_type() && (int)elem.api_eventmap.api_gauge_type == 3 ? "TP" : "HP",
							(int)elem.api_eventmap.api_now_maphp, (int)elem.api_eventmap.api_max_maphp );

					}
				}
			}

			return sb.ToString();
		}


		private string GetExpeditionResult( dynamic data ) {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine( GeneralRes.ExpeditionReturned );
			sb.AppendLine( FormMain.Instance.Translator.GetTranslation(data.api_quest_name, Utility.TranslationType.ExpeditionTitle) + "\r\n" );
			sb.AppendFormat( GeneralRes.Result + ": {0}\r\n", Constants.GetExpeditionResult( (int)data.api_clear_result ) );
			sb.AppendFormat( GeneralRes.AdmiralXP + ": +{0}\r\n", (int)data.api_get_exp );
			sb.AppendFormat( GeneralRes.ShipXP + ": +{0}\r\n", ( (int[])data.api_get_ship_exp ).Min() );

			return sb.ToString();
		}


		private string GetRankingData( dynamic data ) {

			StringBuilder sb = new StringBuilder();

			foreach ( dynamic elem in data.api_list ) {

				sb.AppendFormat( "{0}: {1} {2} Lv. {3} / {4} exp.\r\n",
					(int)elem.api_no,
					elem.api_nickname,
					Constants.GetAdmiralRank( (int)elem.api_rank ),
					(int)elem.api_level,
					(int)elem.api_experience
					);

			}

			return sb.ToString();
		}


		private string GetBattleResult( dynamic data ) {
			StringBuilder sb = new StringBuilder();

			sb.AppendLine( "[" + GeneralRes.BattleComplete +  "]" );
			sb.AppendFormat( GeneralRes.EnemyName, FormMain.Instance.Translator.GetTranslation(data.api_enemy_info.api_deck_name, Utility.TranslationType.Operations) );
			sb.AppendFormat( GeneralRes.WinRank + ": {0}\r\n", data.api_win_rank );
			sb.AppendFormat( GeneralRes.AdmiralXP + ": +{0}\r\n", (int)data.api_get_exp );

			return sb.ToString();
		}


		private string GetSupplyInformation( dynamic data ) {

			StringBuilder sb = new StringBuilder();

			sb.AppendLine( GeneralRes.ResupplyComplete );
			sb.AppendFormat( GeneralRes.BauxiteUsage, (int)data.api_use_bou, (int)data.api_use_bou / 5 );

			return sb.ToString();
		}


		private string GetConsumptionResource( dynamic data ) {

			StringBuilder sb = new StringBuilder();
			int fuel_supply = 0,
				fuel_repair = 0,
				ammo = 0,
				steel = 0,
				bauxite = 0;


			sb.AppendLine( GeneralRes.FleetReturned );

			foreach ( var f in KCDatabase.Instance.Fleet.Fleets.Values.Where( f => _inSortie.Contains( f.FleetID ) ) ) {

				fuel_supply += f.MembersInstance.Sum( s => s == null ? 0 : (int)Math.Floor( ( s.FuelMax - s.Fuel ) * ( s.IsMarried ? 0.85 : 1.0 ) ) );
				ammo += f.MembersInstance.Sum( s => s == null ? 0 : (int)Math.Floor( ( s.AmmoMax - s.Ammo ) * ( s.IsMarried ? 0.85 : 1.0 ) ) );
				bauxite += f.MembersInstance.Sum( s => s == null ? 0 : s.Aircraft.Zip( s.MasterShip.Aircraft, ( current, max ) => new { Current = current, Max = max } ).Sum( a => ( a.Max - a.Current ) * 5 ) );

				fuel_repair += f.MembersInstance.Sum( s => s == null ? 0 : s.RepairFuel );
				steel += f.MembersInstance.Sum( s => s == null ? 0 : s.RepairSteel );

			}

			sb.AppendFormat( GeneralRes.ResupplyString,
				fuel_supply, fuel_repair, fuel_supply + fuel_repair, ammo, steel, bauxite, bauxite / 5 );

			return sb.ToString();
		}




		protected override string GetPersistString() {
			return "Information";
		}

	}

}
