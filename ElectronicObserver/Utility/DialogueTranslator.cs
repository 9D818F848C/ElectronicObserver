﻿using Newtonsoft.Json;
using ElectronicObserver.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace ElectronicObserver.Utility
{
    public delegate void DialogueAddedEventHandler(DialogueData d);

    public sealed class DialogueTranslator
    {
        private static readonly DialogueTranslator instance = new DialogueTranslator();
        public static DialogueTranslator Instance { get { return instance; } }

        public event DialogueAddedEventHandler DialogueAdded = delegate { };

        private List<DialogueData> dialogue;
        private dynamic quotes;
        private static Dictionary<string, ShipDataMaster> shipCache = new Dictionary<string, ShipDataMaster>();
        // Diffs are from KC3. Licensed under MIT.
        private static List<int> voiceDiffs = new List<int>{ 
            2475,    0,    0, 8691, 7847, 3595, 1767, 3311, 2507,
            9651, 5321, 4473, 7117, 5947, 9489, 2669, 8741, 6149,
            1301, 7297, 2975, 6413, 8391, 9705, 2243, 2091, 4231,
            3107, 9499, 4205, 6013, 3393, 6401, 6985, 3683, 9447,
            3287, 5181, 7587, 9353, 2135, 4947, 5405, 5223, 9457,
            5767, 9265, 8191, 3927, 3061, 2805, 3273, 7331};
        private static Dictionary<string, int> specialDiffs = new Dictionary<string, int> {
            { "1555", 2 }, // valentines 2016, hinamatsuri 2015
            { "3347", 3 }, // valentines 2016, hinamatsuri 2015
            { "6547", 2 }, // whiteday 2015
			{ "1471", 3 } // whiteday 2015
        };

        private DialogueTranslator()
        {
            dialogue = new List<DialogueData>();
            // Right now, I'm using the JSON raw from KC3
            // I plan on implementing something that'll use less RAM and such later,
            // but if I want something out quickly, this'll have to do.
            WebClient client = new WebClient();
            string quotesJson = client.DownloadString("https://raw.githubusercontent.com/KC3Kai/kc3-translations/master/data/en/quotes.json");
            quotes = JsonConvert.DeserializeObject(quotesJson);
            int i = 0;
        }

        public static void Add(DialogueType type, string identifier, string filename)
        {
            DialogueData data = new DialogueData() { Time = DateTime.Now };
            string voiceLine = "-1";
            string newIdentifier = "";

            switch (type)
            {
                case DialogueType.Titlecall:
                    data.Ship = "Title Call";
                    newIdentifier = "titlecall_" + identifier;
                    voiceLine = filename;
                    break;
                case DialogueType.NPC:
                    data.Ship = "NPC";
                    newIdentifier = "npc";
                    voiceLine = filename;
                    break;
                case DialogueType.Shipgirl:
                    ShipDataMaster master;
                    // This lookup is gonna be slow if it's our first time.
                    // To save time on lookups later, we're gonna do some caching.
                    // Ironic that I'm caching here while specifically subverting cache in requests.
                    if (shipCache.ContainsKey(identifier))
                        master = shipCache[identifier];
                    else
                    {
                        master = KCDatabase.Instance.MasterShips.Where(kvp => kvp.Value.ResourceName == identifier)
                            .Select(kvp => kvp.Value).FirstOrDefault();
                        lock (shipCache)
                        {
                            shipCache.Add(identifier, master);
                        }
                    }
                    newIdentifier = master.ShipID.ToString();
                    data.Ship = master.Name;
                    voiceLine = getVoiceLineNumber(master.ShipID, filename).ToString();
                    break;
                default:
                    data = null;
                    break;
            }
            if (data == null) return;
            if (Instance.quotes[newIdentifier] != null)
            {
                if (Instance.quotes[newIdentifier][voiceLine] != null)
                {
                    data.Line = Instance.quotes[newIdentifier][voiceLine].ToString();
                }
                else
                {
                    if (specialDiffs.ContainsKey(voiceLine))
                    {
                        if (Instance.quotes[newIdentifier][specialDiffs[voiceLine].ToString()] != null)
                        {
                            data.Line = Instance.quotes[newIdentifier][specialDiffs[voiceLine].ToString()];
                        }
                        else data.Line = "<unknown>";
                    }
                    else data.Line = "<unknown>";
                }
            }
            else data.Line = "<unknown>";
            lock (Instance)
            {
                Instance.dialogue.Add(data);
            }
            Instance.DialogueAdded(data);
            Logger.Add(2, $"Hacktastic Subtitle: {data.Ship}: \"{data.Line}\"");
        }

        /// <summary>
        /// METHOD ADAPTED FROM KC3改.
        /// LICENSED UNDER MIT LICENSE, (c) Dragonjet and contributors.
        /// Gets the voice number from its filename.
        /// </summary>
        private static int getVoiceLineNumber(int id, string filename)
        {
            int computedDiff = getVoiceDiffByFilename(id, filename);
            int computedIndex = voiceDiffs.IndexOf(computedDiff);
            if (computedIndex > -1) return computedIndex + 1;
            else return computedDiff;
        }

        /// <summary>
        /// METHOD ADAPTED FROM KC3改.
        /// LICENSED UNDER MIT LICENSE, (C) Dragonjet and contributors.
        /// Gets the voice key by filename.
        /// </summary>
        private static int getVoiceDiffByFilename(int id, string filename)
        {
            int number;
            bool success;
            success = int.TryParse(filename, out number);
            if (!success)
            {
                throw new ArgumentException("Sound filename is not a number!");
            }
            else
            {
                int k = 17 * (id + 7);
                int r = number - 100000;
                for (int i = 0; i < 1000; ++i)
                {
                    int a = r + i * 99173;
                    if (a % k == 0)
                    {
                        return a / k;
                    }
                }
            }
            return -1;
        }
    }

    public enum DialogueType
    {
        Titlecall,
        NPC,
        Shipgirl
    }

    public class DialogueData
    {
        public DateTime Time { get; set; }
        public string Ship { get; set; }
        public string Line { get; set; }
    }
}
