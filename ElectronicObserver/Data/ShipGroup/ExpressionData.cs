using ElectronicObserver.Utility.Mathematics;
using ElectronicObserver.Window;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Runtime.Serialization;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace ElectronicObserver.Data.ShipGroup {

	/// <summary>
	/// 艦船フィルタの式データ
	/// </summary>
	[DataContract( Name = "ExpressionData" )]
	public class ExpressionData : ICloneable {

		public enum ExpressionOperator {
			Equal,
			NotEqual,
			LessThan,
			LessEqual,
			GreaterThan,
			GreaterEqual,
			Contains,
			NotContains,
			BeginWith,
			NotBeginWith,
			EndWith,
			NotEndWith,
			ArrayContains,
			ArrayNotContains,
		}


		[DataMember]
		public string LeftOperand { get; set; }

		[DataMember]
		public ExpressionOperator Operator { get; set; }

		[DataMember]
		public object RightOperand { get; set; }


		[DataMember]
		public bool Enabled { get; set; }


		[IgnoreDataMember]
		private static readonly Regex regex_index = new Regex( @"\.(?<name>\w+)(\[(?<index>\d+?)\])?", RegexOptions.Compiled );

		[IgnoreDataMember]
		public static readonly Dictionary<string, string> LeftOperandNameTable = new Dictionary<string, string>() {
			{ ".MasterID", GeneralRes.UniqueID },
			{ ".ShipID", GeneralRes.ShipID },
			{ ".MasterShip.NameWithClass", GeneralRes.ShipName },
			{ ".MasterShip.ShipType", GeneralRes.ShipType },
			{ ".Level", GeneralRes.Level },
			{ ".ExpTotal", GeneralRes.Experience },
			{ ".ExpNext", GeneralRes.NextLevelNoFormat },
			{ ".ExpNextRemodel", GeneralRes.ToNextRemodel },
			{ ".HPCurrent", GeneralRes.CurrentHP },
			{ ".HPMax", GeneralRes.MaxHP },
			{ ".HPRate", GeneralRes.HPPercentage },
			{ ".Condition", GeneralRes.Condition },
			{ ".AllSlotMaster", GeneralRes.Equipment },
			{ ".SlotMaster[0]", GeneralRes.Equipment + " #1" },	//checkme: 要る?
			{ ".SlotMaster[1]", GeneralRes.Equipment + " #2" },
			{ ".SlotMaster[2]", GeneralRes.Equipment + " #3" },
			{ ".SlotMaster[3]", GeneralRes.Equipment + " #4" },
			{ ".SlotMaster[4]", GeneralRes.Equipment + " #5" },
			{ ".ExpansionSlotMaster", GeneralRes.Expansion },
			{ ".Aircraft[0]", GeneralRes.EquippedPlane + " #1" },
			{ ".Aircraft[1]", GeneralRes.EquippedPlane + " #2" },
			{ ".Aircraft[2]", GeneralRes.EquippedPlane + " #3" },
			{ ".Aircraft[3]", GeneralRes.EquippedPlane + " #4" },
			{ ".Aircraft[4]", GeneralRes.EquippedPlane + " #5" },
			{ ".AircraftTotal", GeneralRes.TotalEquippedPlanes },
			{ ".MasterShip.Aircraft[0]", GeneralRes.PlaneCapacity + " #1" },
			{ ".MasterShip.Aircraft[1]", GeneralRes.PlaneCapacity + " #2" },
			{ ".MasterShip.Aircraft[2]", GeneralRes.PlaneCapacity + " #3" },
			{ ".MasterShip.Aircraft[3]", GeneralRes.PlaneCapacity + " #4" },
			{ ".MasterShip.Aircraft[4]", GeneralRes.PlaneCapacity + " #5" },
			{ ".MasterShip.AircraftTotal", GeneralRes.TotalPlaneCapacity },		//要る？
			{ ".AircraftRate[0]", GeneralRes.PlanePercentage + " #1" },
			{ ".AircraftRate[1]", GeneralRes.PlanePercentage + " #2" },
			{ ".AircraftRate[2]", GeneralRes.PlanePercentage + " #3" },
			{ ".AircraftRate[3]", GeneralRes.PlanePercentage + " #4" },
			{ ".AircraftRate[4]", GeneralRes.PlanePercentage + " #5" },
			{ ".AircraftTotalRate", GeneralRes.TotalPlanePercentage },
			{ ".Fuel", GeneralRes.CurrentFuel },
			{ ".Ammo", GeneralRes.CurrentAmmo },
			{ ".FuelMax", GeneralRes.MaxFuel },
			{ ".AmmoMax", GeneralRes.MaxAmmo },
			{ ".FuelRate", GeneralRes.FuelPercentage },
			{ ".AmmoRate", GeneralRes.AmmoPercentage },
			{ ".SlotSize", GeneralRes.SlotCount },
			{ ".RepairingDockID", GeneralRes.RepairDock },
			{ ".RepairTime", GeneralRes.RepairTime },
			{ ".RepairSteel", GeneralRes.RepairSteel },
			{ ".RepairFuel", GeneralRes.RepairFuel },
			//強化値シリーズは省略
			{ ".FirepowerBase", GeneralRes.Base + GeneralRes.Firepower },
			{ ".TorpedoBase", GeneralRes.Base + GeneralRes.Torpedo },
			{ ".AABase", GeneralRes.Base + GeneralRes.AntiAir },
			{ ".ArmorBase", GeneralRes.Base + GeneralRes.Armor },
			{ ".EvasionBase", GeneralRes.Base + GeneralRes.Evasion },
			{ ".ASWBase", GeneralRes.Base + GeneralRes.ASW },
			{ ".LOSBase", GeneralRes.Base + GeneralRes.LoS },
			{ ".LuckBase", GeneralRes.Base + GeneralRes.Luck },
			{ ".FirepowerTotal", GeneralRes.Total + GeneralRes.Firepower },
			{ ".TorpedoTotal", GeneralRes.Total + GeneralRes.Torpedo },
			{ ".AATotal", GeneralRes.Total + GeneralRes.AntiAir },
			{ ".ArmorTotal", GeneralRes.Total + GeneralRes.Armor },
			{ ".EvasionTotal", GeneralRes.Total + GeneralRes.Evasion },
			{ ".ASWTotal", GeneralRes.Total + GeneralRes.ASW },
			{ ".LOSTotal", GeneralRes.Total + GeneralRes.LoS },
			{ ".LuckTotal", GeneralRes.Total + GeneralRes.Luck },
			{ ".BomberTotal", GeneralRes.Total + GeneralRes.Bombers },
			{ ".FirepowerRemain", GeneralRes.Firepower + GeneralRes.ModernizationRemaining },
			{ ".TorpedoRemain", GeneralRes.Torpedo + GeneralRes.ModernizationRemaining },
			{ ".AARemain", GeneralRes.AntiAir + GeneralRes.ModernizationRemaining },
			{ ".ArmorRemain", GeneralRes.Armor + GeneralRes.ModernizationRemaining },
			{ ".LuckRemain", GeneralRes.Luck + GeneralRes.ModernizationRemaining },
			{ ".Range", GeneralRes.Range },		//現在の射程
			{ ".MasterShip.Speed", GeneralRes.Speed },
			{ ".MasterShip.Rarity", GeneralRes.Rarity },
			{ ".IsLocked", GeneralRes.Lock },
			{ ".IsLockedByEquipment", GeneralRes.Equipment + " " + GeneralRes.Lock },
			{ ".SallyArea", GeneralRes.ShipLockFlag },
			{ ".FleetWithIndex", GeneralRes.AssignedFleet },
			{ ".IsMarried", GeneralRes.Married },
			{ ".AirBattlePower", GeneralRes.AirPower },
			{ ".ShellingPower", GeneralRes.Shelling + " "  + GeneralRes.Power },
			{ ".AircraftPower", GeneralRes.Bombing + " " + GeneralRes.Power },
			{ ".AntiSubmarinePower", GeneralRes.ASW + " " + GeneralRes.Power },
			{ ".TorpedoPower", GeneralRes.Torpedo + " " + GeneralRes.Power },
			{ ".NightBattlePower", GeneralRes.NightBattle + " " + GeneralRes.Power },
			{ ".MasterShip.AlbumNo", GeneralRes.EncyclopediaNumber },
			{ ".MasterShip.NameReading", GeneralRes.NameReading },
			{ ".MasterShip.RemodelBeforeShipID", GeneralRes.BeforeRemodelID },
			{ ".MasterShip.RemodelAfterShipID", GeneralRes.AfterRemodelID },
			//マスターのパラメータ系もおそらく意味がないので省略		
		};

		private static Dictionary<string, Type> ExpressionTypeTable = new Dictionary<string, Type>();


		[IgnoreDataMember]
		public static readonly Dictionary<ExpressionOperator, string> OperatorNameTable = new Dictionary<ExpressionOperator, string>() {
			{ ExpressionOperator.Equal, GeneralRes.Equal },
			{ ExpressionOperator.NotEqual, GeneralRes.NotEnrolled },
			{ ExpressionOperator.LessThan, GeneralRes.LessThan },
			{ ExpressionOperator.LessEqual, GeneralRes.LessThanOrEqual },
			{ ExpressionOperator.GreaterThan, GeneralRes.GreaterThan },
			{ ExpressionOperator.GreaterEqual, GeneralRes.GreaterThanOrEqual },
			{ ExpressionOperator.Contains, GeneralRes.Contains },
			{ ExpressionOperator.NotContains, GeneralRes.DoesNotContain },
			{ ExpressionOperator.BeginWith, GeneralRes.BeginsWith },
			{ ExpressionOperator.NotBeginWith, GeneralRes.DoesNotBeginWith },
			{ ExpressionOperator.EndWith, GeneralRes.EndsWith },
			{ ExpressionOperator.NotEndWith, GeneralRes.DoesNotEndWith },
			{ ExpressionOperator.ArrayContains, GeneralRes.Contains },
			{ ExpressionOperator.ArrayNotContains, GeneralRes.DoesNotContain },
			
		};



		public ExpressionData() {
			Enabled = true;
		}

		public ExpressionData( string left, ExpressionOperator ope, object right )
			: this() {
			LeftOperand = left;
			Operator = ope;
			RightOperand = right;
		}


		public Expression Compile( ParameterExpression paramex ) {

			Expression memberex = null;
			Expression constex = Expression.Constant( RightOperand, RightOperand.GetType() );

			{
				Match match = regex_index.Match( LeftOperand );
				if ( match.Success ) {

					do {

						if ( memberex == null ) {
							memberex = Expression.PropertyOrField( paramex, match.Groups["name"].Value );
						} else {
							memberex = Expression.PropertyOrField( memberex, match.Groups["name"].Value );
						}

						int index;
						if ( int.TryParse( match.Groups["index"].Value, out index ) ) {
							memberex = Expression.Property( memberex, "Item", Expression.Constant( index, typeof( int ) ) );
						}

					} while ( ( match = match.NextMatch() ).Success );

				} else {
					memberex = Expression.PropertyOrField( paramex, LeftOperand );
				}
			}

			Expression  condex;
			switch ( Operator ) {
				case ExpressionOperator.Equal:
					condex = Expression.Equal( memberex, constex );
					break;
				case ExpressionOperator.NotEqual:
					condex = Expression.NotEqual( memberex, constex );
					break;
				case ExpressionOperator.LessThan:
					condex = Expression.LessThan( memberex, constex );
					break;
				case ExpressionOperator.LessEqual:
					condex = Expression.LessThanOrEqual( memberex, constex );
					break;
				case ExpressionOperator.GreaterThan:
					condex = Expression.GreaterThan( memberex, constex );
					break;
				case ExpressionOperator.GreaterEqual:
					condex = Expression.GreaterThanOrEqual( memberex, constex );
					break;
				case ExpressionOperator.Contains:
					condex = Expression.Call( memberex, typeof( string ).GetMethod( "Contains", new Type[] { typeof( string ) } ), constex );
					break;
				case ExpressionOperator.NotContains:
					condex = Expression.Not( Expression.Call( memberex, typeof( string ).GetMethod( "Contains", new Type[] { typeof( string ) } ), constex ) );
					break;
				case ExpressionOperator.BeginWith:
					condex = Expression.Equal( Expression.Call( memberex, typeof( string ).GetMethod( "IndexOf", new Type[] { typeof( string ) } ), constex ), Expression.Constant( 0, typeof( int ) ) );
					break;
				case ExpressionOperator.NotBeginWith:
					condex = Expression.NotEqual( Expression.Call( memberex, typeof( string ).GetMethod( "IndexOf", new Type[] { typeof( string ) } ), constex ), Expression.Constant( 0, typeof( int ) ) );
					break;
				case ExpressionOperator.EndWith:	// returns memberex.LastIndexOf( constex ) == ( memberex.Length - constex.Length )
					condex = Expression.Equal(
						Expression.Call( memberex, typeof( string ).GetMethod( "LastIndexOf", new Type[] { typeof( string ) } ), constex ),
						Expression.Subtract( Expression.PropertyOrField( memberex, "Length" ), Expression.PropertyOrField( constex, "Length" ) ) );
					break;
				case ExpressionOperator.NotEndWith:	// returns memberex.LastIndexOf( constex ) != ( memberex.Length - constex.Length )
					condex = Expression.NotEqual(
						Expression.Call( memberex, typeof( string ).GetMethod( "LastIndexOf", new Type[] { typeof( string ) } ), constex ),
						Expression.Subtract( Expression.PropertyOrField( memberex, "Length" ), Expression.PropertyOrField( constex, "Length" ) ) );
					break;
				case ExpressionOperator.ArrayContains:	// returns Enumerable.Contains<>( memberex )
					condex = Expression.Call( typeof( Enumerable ), "Contains", new Type[] { memberex.Type.GetElementType() ?? memberex.Type.GetGenericArguments().First() }, memberex, constex );
					break;
				case ExpressionOperator.ArrayNotContains:	// returns !Enumerable.Contains<>( memberex )
					condex = Expression.Not( Expression.Call( typeof( Enumerable ), "Contains", new Type[] { memberex.Type.GetElementType() ?? memberex.Type.GetGenericArguments().First() }, memberex, constex ) );
					break;

				default:
					throw new NotImplementedException();
			}

			return condex;
		}



		public static Type GetLeftOperandType( string left ) {

			if ( ExpressionTypeTable.ContainsKey( left ) ) {
				return ExpressionTypeTable[left];

			} else if ( KCDatabase.Instance.Ships.Count > 0 ) {

				object obj = KCDatabase.Instance.Ships.Values.First();

				Match match = regex_index.Match( left );
				if ( match.Success ) {

					do {

						int index;
						if ( int.TryParse( match.Groups["index"].Value, out index ) ) {
							obj = ( (dynamic)obj.GetType().InvokeMember( match.Groups["name"].Value, System.Reflection.BindingFlags.GetProperty, null, obj, null ) )[index];
						} else {
							object obj2 = obj.GetType().InvokeMember( match.Groups["name"].Value, System.Reflection.BindingFlags.GetProperty, null, obj, null );
							if ( obj2 == null ) {	//プロパティはあるけどnull
								var type = obj.GetType().GetProperty( match.Groups["name"].Value ).GetType();
								ExpressionTypeTable.Add( left, type );
								return type;
							} else {
								obj = obj2;
							}
						}

					} while ( obj != null && ( match = match.NextMatch() ).Success );


					if ( obj != null ) {
						ExpressionTypeTable.Add( left, obj.GetType() );
						return obj.GetType();
					}
				}

			}

			return null;
		}

		public Type GetLeftOperandType() {
			return GetLeftOperandType( LeftOperand );
		}



		public override string ToString() {
			return string.Format( GeneralRes.Expression, LeftOperandToString(), RightOperandToString(), OperatorToString() );
		}


		/// <summary>
		/// 左辺値の文字列表現を求めます。
		/// </summary>
		public string LeftOperandToString() {
			if ( LeftOperandNameTable.ContainsKey( LeftOperand ) )
				return LeftOperandNameTable[LeftOperand];
			else
				return LeftOperand;
		}

		/// <summary>
		/// 演算子の文字列表現を求めます。
		/// </summary>
		public string OperatorToString() {
			return OperatorNameTable[Operator];
		}

		/// <summary>
		/// 右辺値の文字列表現を求めます。
		/// </summary>
		public string RightOperandToString() {

			if ( LeftOperand == ".MasterID" ) {
				var ship = KCDatabase.Instance.Ships[(int)RightOperand];
				if ( ship != null )
					return string.Format( "{0} ({1})", ship.MasterID, ship.NameWithLevel );
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.NotEnrolled );

			} else if ( LeftOperand == ".ShipID" ) {
				var ship = KCDatabase.Instance.MasterShips[(int)RightOperand];
				if ( ship != null )
					return string.Format( "{0} ({1})", ship.ShipID, ship.NameWithClass );
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.DoesNotExist );

			} else if ( LeftOperand == ".MasterShip.ShipType" ) {
				var shiptype = KCDatabase.Instance.ShipTypes[(int)RightOperand];
				if ( shiptype != null )
					return FormMain.Instance.Translator.GetTranslation(shiptype.Name, Utility.TranslationType.ShipTypes);
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.Undefined );

			} else if ( LeftOperand.Contains( "SlotMaster" ) ) {
				if ( (int)RightOperand == -1 ) {
					return GeneralRes.None;
				} else {
					var eq = KCDatabase.Instance.MasterEquipments[(int)RightOperand];
					if ( eq != null )
						return eq.Name;
					else
						return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.Undefined );
				}
			} else if ( LeftOperand.Contains( "Rate" ) && RightOperand is double ) {
				return ( (double)RightOperand ).ToString( "P0" );

			} else if ( LeftOperand == ".RepairTime" ) {
				return DateTimeHelper.ToTimeRemainString( DateTimeHelper.FromAPITimeSpan( (int)RightOperand ) );

			} else if ( LeftOperand == ".Range" ) {
				return Constants.GetRange( (int)RightOperand );

			} else if ( LeftOperand == ".MasterShip.Speed" ) {
				return Constants.GetSpeed( (int)RightOperand );

			} else if ( LeftOperand == ".MasterShip.Rarity" ) {
				return Constants.GetShipRarity( (int)RightOperand );

			} else if ( LeftOperand == ".MasterShip.AlbumNo" ) {
				var ship = KCDatabase.Instance.MasterShips.Values.FirstOrDefault( s => s.AlbumNo == (int)RightOperand );
				if ( ship != null )
					return string.Format( "{0} ({1})", (int)RightOperand, ship.NameWithClass );
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.DoesNotExist );

			} else if ( LeftOperand == ".MasterShip.RemodelAfterShipID" ) {

				if ( ( (int)RightOperand ) == 0 )
					return GeneralRes.FinalRemodel;

				var ship = KCDatabase.Instance.MasterShips[(int)RightOperand];
				if ( ship != null )
					return string.Format( "{0} ({1})", ship.ShipID, ship.NameWithClass );
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.DoesNotExist );

			} else if ( LeftOperand == ".MasterShip.RemodelBeforeShipID" ) {

				if ( ( (int)RightOperand ) == 0 )
					return GeneralRes.Unremodelled;

				var ship = KCDatabase.Instance.MasterShips[(int)RightOperand];
				if ( ship != null )
					return string.Format( "{0} ({1})", ship.ShipID, ship.NameWithClass );
				else
					return string.Format( "{0} {1}", (int)RightOperand, GeneralRes.DoesNotExist );

			} else if ( RightOperand is bool ) {
				return ( (bool)RightOperand ) ? "○" : "×";

			} else {
				return RightOperand.ToString();

			}

		}


		public ExpressionData Clone() {
			var clone = MemberwiseClone();		//checkme: 右辺値に参照型を含む場合死ぬ
			return (ExpressionData)clone;
		}

		object ICloneable.Clone() {
			return Clone();
		}
	}




}
