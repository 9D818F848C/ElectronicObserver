using Codeplex.Data;
using ElectronicObserver.Observer.kcsapi;
using ElectronicObserver.Utility;
using ElectronicObserver.Utility.Mathematics;
using Titanium.Web.Proxy;
using Titanium.Web.Proxy.Network;
using Titanium.Web.Proxy.Extensions;
using Titanium.Web.Proxy.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Web;
using System.Windows.Forms;

namespace ElectronicObserver.Observer {


	public sealed class APIObserver {


		#region Singleton

		private static readonly APIObserver instance = new APIObserver();

		public static APIObserver Instance {
			get { return instance; }
		}

		#endregion


		public APIDictionary APIList { get; private set; }

		public string ServerAddress { get; private set; }
		public int ProxyPort { get; private set; }

		public delegate void ProxyStartedEventHandler();
		public event ProxyStartedEventHandler ProxyStarted = delegate { };

		private Control UIControl;
		private APIKancolleDB DBSender;

        // Item 1: it's last modified time.
        // Item 2: the time we're expected to ask for cache control.
        private Dictionary<string, Tuple<DateTime, DateTime>> cacheControl;

		private APIObserver() {

			APIList = new APIDictionary();
			APIList.Add( new kcsapi.api_start2() );
			APIList.Add( new kcsapi.api_get_member.basic() );
			APIList.Add( new kcsapi.api_get_member.slot_item() );
			APIList.Add( new kcsapi.api_get_member.useitem() );
			APIList.Add( new kcsapi.api_get_member.kdock() );
			APIList.Add( new kcsapi.api_port.port() );
			APIList.Add( new kcsapi.api_get_member.ship2() );
			APIList.Add( new kcsapi.api_get_member.questlist() );
			APIList.Add( new kcsapi.api_get_member.ndock() );
			APIList.Add( new kcsapi.api_req_kousyou.getship() );
			APIList.Add( new kcsapi.api_req_hokyu.charge() );
			APIList.Add( new kcsapi.api_req_kousyou.destroyship() );
			APIList.Add( new kcsapi.api_req_kousyou.destroyitem2() );
			APIList.Add( new kcsapi.api_req_member.get_practice_enemyinfo() );
			APIList.Add( new kcsapi.api_get_member.picture_book() );
			APIList.Add( new kcsapi.api_req_mission.start() );
			APIList.Add( new kcsapi.api_get_member.ship3() );
			APIList.Add( new kcsapi.api_req_kaisou.powerup() );
			APIList.Add( new kcsapi.api_req_map.start() );
			APIList.Add( new kcsapi.api_req_map.next() );
			APIList.Add( new kcsapi.api_req_kousyou.createitem() );
			APIList.Add( new kcsapi.api_req_sortie.battle() );
			APIList.Add( new kcsapi.api_req_sortie.battleresult() );
			APIList.Add( new kcsapi.api_req_battle_midnight.battle() );
			APIList.Add( new kcsapi.api_req_battle_midnight.sp_midnight() );
			APIList.Add( new kcsapi.api_req_combined_battle.battle() );
			APIList.Add( new kcsapi.api_req_combined_battle.midnight_battle() );
			APIList.Add( new kcsapi.api_req_combined_battle.sp_midnight() );
			APIList.Add( new kcsapi.api_req_combined_battle.airbattle() );
			APIList.Add( new kcsapi.api_req_combined_battle.battleresult() );
			APIList.Add( new kcsapi.api_req_practice.battle() );
			APIList.Add( new kcsapi.api_req_practice.midnight_battle() );
			APIList.Add( new kcsapi.api_req_practice.battle_result() );
			APIList.Add( new kcsapi.api_get_member.deck() );
			APIList.Add( new kcsapi.api_get_member.mapinfo() );
			APIList.Add( new kcsapi.api_req_combined_battle.battle_water() );
			APIList.Add( new kcsapi.api_req_combined_battle.goback_port() );
			APIList.Add( new kcsapi.api_req_kousyou.remodel_slot() );
			APIList.Add( new kcsapi.api_get_member.material() );
			APIList.Add( new kcsapi.api_req_mission.result() );
			APIList.Add( new kcsapi.api_req_ranking.getlist() );
			APIList.Add( new kcsapi.api_req_sortie.airbattle() );
			APIList.Add( new kcsapi.api_get_member.ship_deck() );
			APIList.Add( new kcsapi.api_req_kaisou.marriage() );
			APIList.Add( new kcsapi.api_req_hensei.preset_select() );
			APIList.Add( new kcsapi.api_req_kaisou.slot_exchange_index() );
			APIList.Add( new kcsapi.api_get_member.record() );
			APIList.Add( new kcsapi.api_get_member.payitem() );
			APIList.Add( new kcsapi.api_req_kousyou.remodel_slotlist() );
			APIList.Add( new kcsapi.api_req_sortie.ld_airbattle() );
			APIList.Add( new kcsapi.api_req_combined_battle.ld_airbattle() );
			APIList.Add( new kcsapi.api_get_member.require_info() );

			APIList.Add( new kcsapi.api_req_quest.clearitemget() );
			APIList.Add( new kcsapi.api_req_nyukyo.start() );
			APIList.Add( new kcsapi.api_req_nyukyo.speedchange() );
			APIList.Add( new kcsapi.api_req_kousyou.createship() );
			APIList.Add( new kcsapi.api_req_kousyou.createship_speedchange() );
			APIList.Add( new kcsapi.api_req_hensei.change() );
			APIList.Add( new kcsapi.api_req_member.updatedeckname() );
			APIList.Add( new kcsapi.api_req_kaisou.remodeling() );
			APIList.Add( new kcsapi.api_req_kaisou.open_exslot() );
			APIList.Add( new kcsapi.api_req_map.select_eventmap_rank() );
			APIList.Add( new kcsapi.api_req_hensei.combined() );
			APIList.Add( new kcsapi.api_req_member.updatecomment() );


			ServerAddress = null;

			DBSender = new APIKancolleDB();

            cacheControl = new Dictionary<string, Tuple<DateTime, DateTime>>();

            //HttpProxy.AfterSessionComplete += HttpProxy_AfterSessionComplete;
            //HttpProxy.AfterReadRequestHeaders += HttpProxy_AfterReadRequestHeaders;
            //HttpProxy.AfterReadResponseHeaders += HttpProxy_AfterReadResponseHeaders;
            ProxyServer.BeforeRequest += ProxyServer_BeforeRequest;
            ProxyServer.BeforeResponse += ProxyServer_BeforeResponse;
            
            
		}

        private void ProxyServer_BeforeRequest(object sender, Titanium.Web.Proxy.EventArguments.SessionEventArgs e)
        {
            var request = e.ProxySession.Request;
            string path = request.RequestUri.PathAndQuery;
            Utility.Configuration.ConfigurationData.ConfigConnection c = Utility.Configuration.Config.Connection;

            if (path.Contains("/kcsapi/"))
            {
                string body = e.GetRequestBodyAsString();

                //保存
                if (c.SaveReceivedData && c.SaveRequest)
                {
                    Task.Run((Action)(() => {
                        SaveRequest(path, body);
                    }));
                }
                UIControl.BeginInvoke((Action)(() => { LoadRequest(path, body); }));
            }
            if (path.Contains(".mp3"))
            {
                Logger.Add(1, $"Requesting audio: {path}");
                string[] substrings = path.Split('/');
                switch (substrings[3])
                {
                    case "titlecall":
                        DialogueTranslator.Add(DialogueType.Titlecall, substrings[4], substrings[5].Split('.')[0]);
                        break;
                    case "kc9999":
                        DialogueTranslator.Add(DialogueType.NPC, "npc", substrings[4].Split('.')[0]);
                        break;
                    case "kc9998":
                        DialogueTranslator.Add(DialogueType.Enemy, "enemy", substrings[4].Split('.')[0]);
                        break;
                    default:
                        DialogueTranslator.Add(DialogueType.Shipgirl, substrings[3].Substring(2), substrings[4].Split('.')[0]);
                        break;
                }
                if (request.RequestHeaders.Where(h => h.Name == "If-Modified-Since").Count() > 0)
                {
                    if(cacheControl.ContainsKey(path))
                    {
                        if(cacheControl[path].Item2 < DateTime.Now)
                        {
                            return;
                        }
                        else
                        {
                            e.NotModified(cacheControl[path].Item1);
                        }
                    }
                }
            }
        }

        private void ProxyServer_BeforeResponse(object sender, Titanium.Web.Proxy.EventArguments.SessionEventArgs e)
        {
            Utility.Configuration.ConfigurationData.ConfigConnection c = Utility.Configuration.Config.Connection;

            string path = e.ProxySession.Request.RequestUri.PathAndQuery;
            if(path.Contains(".mp3"))
            {
                var cacheControlHeader = e.ProxySession.Response.ResponseHeaders.Where(h => h.Name == "Cache-Control").First();
                var lastModifiedHeader = e.ProxySession.Response.ResponseHeaders.Where(h => h.Name == "Last-Modified").First();
                Regex re = new Regex("([0-9]+)");
                var match = re.Match(cacheControlHeader.Value);
                if(!string.IsNullOrWhiteSpace(match.Value))
                {
                    int seconds = int.Parse(match.Value);
                    cacheControl.Add(path, new Tuple<DateTime, DateTime>(DateTime.Parse(lastModifiedHeader.Value), DateTime.Now.AddSeconds(seconds)));
                }
                cacheControlHeader.Value = "public, no-cache, max-age=0";
            }
            if (c.SaveReceivedData)
            {

                try
                {

                    if (!Directory.Exists(c.SaveDataPath))
                        Directory.CreateDirectory(c.SaveDataPath);


                    if (c.SaveResponse && path.Contains("/kcsapi/"))
                    {

                        // 非同期で書き出し処理するので取っておく
                        // stringはイミュータブルなのでOK
                        string body = e.GetResponseBodyAsString();

                        Task.Run((Action)(() => {
                            SaveResponse(path, body);
                        }));

                    }
                    else if (path.Contains("/kcs/") &&
                      ((c.SaveSWF && e.ResponseContentType == "application/x-shockwave-flash") || c.SaveOtherFile))
                    {

                        string saveDataPath = c.SaveDataPath; // スレッド間の競合を避けるため取っておく
                        string tpath = string.Format("{0}\\{1}", saveDataPath, path.Substring(path.IndexOf("/kcs/") + 5).Replace("/", "\\"));
                        {
                            int index = tpath.IndexOf("?");
                            if (index != -1)
                            {
                                if (Utility.Configuration.Config.Connection.ApplyVersion)
                                {
                                    string over = tpath.Substring(index + 1);
                                    int vindex = over.LastIndexOf("VERSION=", StringComparison.CurrentCultureIgnoreCase);
                                    if (vindex != -1)
                                    {
                                        string version = over.Substring(vindex + 8).Replace('.', '_');
                                        tpath = tpath.Insert(tpath.LastIndexOf('.', index), "_v" + version);
                                        index += version.Length + 2;
                                    }

                                }

                                tpath = tpath.Remove(index);
                            }
                        }

                        // 非同期で書き出し処理するので取っておく
                        byte[] responseCopy = e.GetResponseBody();

                        Task.Run((Action)(() => {
                            try
                            {
                                lock (this)
                                {
                                    // 同時に書き込みが走るとアレなのでロックしておく

                                    Directory.CreateDirectory(Path.GetDirectoryName(tpath));

                                    //System.Diagnostics.Debug.WriteLine( oSession.fullUrl + " => " + tpath );
                                    using (var sw = new System.IO.BinaryWriter(System.IO.File.OpenWrite(tpath)))
                                    {
                                        sw.Write(responseCopy);
                                    }
                                }

                                Utility.Logger.Add(1, string.Format(LoggerRes.SavedAPI, tpath.Remove(0, saveDataPath.Length + 1)));

                            }
                            catch (IOException ex)
                            {   //ファイルがロックされている; 頻繁に出るのでエラーレポートを残さない

                                Utility.Logger.Add(3, LoggerRes.FailedSaveAPI + ex.Message);
                            }
                        }));

                    }

                }
                catch (Exception ex)
                {

                    Utility.ErrorReporter.SendErrorReport(ex, LoggerRes.FailedSaveAPI);
                }
            }




            if (path.Contains("/kcsapi/") && e.ResponseContentType == "text/plain")
            {

                // 非同期でGUIスレッドに渡すので取っておく
                // stringはイミュータブルなのでOK
                string body = e.GetResponseBodyAsString();
                UIControl.BeginInvoke((Action)(() => { LoadResponse(path, body); }));

                // kancolle-db.netに送信する
                if (Utility.Configuration.Config.Connection.SendDataToKancolleDB)
                {
                    Task.Run((Action)(() => DBSender.ExecuteSession(e)));
                }

            }

            if (ServerAddress == null && path.Contains("/kcsapi/"))
            {
                ServerAddress = e.ProxySession.Request.RequestUri.Host;
            }
        }
        
        /// <summary>
        /// 通信の受信を開始します。
        /// </summary>
        /// <param name="portID">受信に使用するポート番号。</param>
        /// <param name="UIControl">GUI スレッドで実行するためのオブジェクト。中身は何でもいい</param>
        /// <returns>実際に使用されるポート番号。</returns>
        public int Start( int portID, Control UIControl ) {

			Utility.Configuration.ConfigurationData.ConfigConnection c = Utility.Configuration.Config.Connection;


			this.UIControl = UIControl;
           
			try {

                //if ( c.UseUpstreamProxy )
                //	HttpProxy.UpstreamProxyConfig = new ProxyConfig( ProxyConfigType.SpecificProxy, c.UpstreamProxyAddress, c.UpstreamProxyPort );
                //else if ( c.UseSystemProxy )
                //	HttpProxy.UpstreamProxyConfig = new ProxyConfig( ProxyConfigType.SystemProxy );
                //else
                //	HttpProxy.UpstreamProxyConfig = new ProxyConfig( ProxyConfigType.DirectAccess );

                //HttpProxy.Startup( portID, false, false );
                var endPoint = new ExplicitProxyEndPoint(System.Net.IPAddress.Any, portID, false);
                ProxyPort = portID;
                ProxyServer.AddEndPoint(endPoint);
                ProxyServer.Start();

				ProxyStarted();
				Utility.Logger.Add( 2, string.Format( LoggerRes.APIObserverStarted, portID ) );
			} catch ( Exception ex ) {

				Utility.Logger.Add( 3, LoggerRes.APIObserverFailed + ex.Message );
				ProxyPort = 0;
			}


			return ProxyPort;
		}


		/// <summary>
		/// 通信の受信を停止します。
		/// </summary>
		public void Stop() {

            ProxyServer.Stop();

			Utility.Logger.Add( 2, LoggerRes.APIObserverStopped );
		}



		public APIBase this[string key] {
			get {
				if ( APIList.ContainsKey( key ) ) return APIList[key];
				else return null;
			}
		}




		//void HttpProxy_AfterSessionComplete( Session session ) {

		//	Utility.Configuration.ConfigurationData.ConfigConnection c = Utility.Configuration.Config.Connection;

		//	string baseurl = session.Request.PathAndQuery;

		//	//debug
		//	//Utility.Logger.Add( 1, baseurl );


		//	// request
		//	if ( baseurl.Contains( "/kcsapi/" ) ) {

		//		string url = baseurl;
		//		string body = session.Request.BodyAsString;

		//		//保存
		//		if ( c.SaveReceivedData && c.SaveRequest ) {
		//			Task.Run( (Action)( () => {
		//				SaveRequest( url, body );
		//			} ) );
		//		}
		//		UIControl.BeginInvoke( (Action)( () => { LoadRequest( url, body ); } ) );
		//	}



		//	//response
		//	//保存
			

		//}



		public void LoadRequest( string path, string data ) {

			string shortpath = path.Substring( path.LastIndexOf( "/kcsapi/" ) + 8 );

			try {

				//Utility.Logger.Add( 1, LoggerRes.RecievedRequest + shortpath );

				SystemEvents.UpdateTimerEnabled = false;


				var parsedData = new Dictionary<string, string>();
				data = HttpUtility.UrlDecode( data );

				foreach ( string unit in data.Split( "&".ToCharArray() ) ) {
					string[] pair = unit.Split( "=".ToCharArray() );
					parsedData.Add( pair[0], pair[1] );
				}


				APIList.OnRequestReceived( shortpath, parsedData );


			} catch ( Exception ex ) {

				ErrorReporter.SendErrorReport( ex, LoggerRes.RequestError, shortpath, data );

			} finally {

				SystemEvents.UpdateTimerEnabled = true;

			}

		}


		public void LoadResponse( string path, string data ) {

			string shortpath = path.Substring( path.LastIndexOf( "/kcsapi/" ) + 8 );

			try {

				//Utility.Logger.Add( 1, LoggerRes.RecievedResponse + shortpath );

				SystemEvents.UpdateTimerEnabled = false;


				var json = DynamicJson.Parse( data.Substring( 7 ) );		//remove "svdata="

				int result = (int)json.api_result;
				if ( result != 1 ) {
					var ex = new ArgumentException( LoggerRes.ResponseHadErrorCode + result );
					Utility.ErrorReporter.SendErrorReport( ex, LoggerRes.ResponseHadErrorCode );
					throw ex;
				}


				if ( shortpath == "api_get_member/ship2" )
					APIList.OnResponseReceived( shortpath, json );
				else if ( json.IsDefined( "api_data" ) )
					APIList.OnResponseReceived( shortpath, json.api_data );
				else
					APIList.OnResponseReceived( shortpath, null );


			} catch ( Exception ex ) {

				ErrorReporter.SendErrorReport( ex, LoggerRes.ResponseError, shortpath, data );

			} finally {

				SystemEvents.UpdateTimerEnabled = true;

			}

		}


		private void SaveRequest( string url, string body ) {

			try {

				string tpath = string.Format( "{0}\\{1}Q@{2}.json", Utility.Configuration.Config.Connection.SaveDataPath, DateTimeHelper.GetTimeStamp(), url.Substring( url.LastIndexOf( "/kcsapi/" ) + 8 ).Replace( "/", "@" ) );

				using ( var sw = new System.IO.StreamWriter( tpath, false, Encoding.UTF8 ) ) {
					sw.Write( body );
				}


			} catch ( Exception ex ) {

				Utility.ErrorReporter.SendErrorReport( ex, LoggerRes.FailedSaveAPI );

			}
		}


		private void SaveResponse( string url, string body ) {

			try {

				string tpath = string.Format( "{0}\\{1}S@{2}.json", Utility.Configuration.Config.Connection.SaveDataPath, DateTimeHelper.GetTimeStamp(), url.Substring( url.LastIndexOf( "/kcsapi/" ) + 8 ).Replace( "/", "@" ) );

				using ( var sw = new System.IO.StreamWriter( tpath, false, Encoding.UTF8 ) ) {
					sw.Write( body );
				}

			} catch ( Exception ex ) {

				Utility.ErrorReporter.SendErrorReport( ex, LoggerRes.FailedSaveAPI );

			}



		}

	}



}
