using Omnidroid.Resources.Scripts.Default;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts.Settings
{
    internal class Interface
    {
        static public bool MainMenu { get; set; } = true;
        static public bool ToChat = true;
        static public int Listing = 0;
        static public List<List> TheList = new();
        static public string TF = DateTime.Now.ToString(format: Journal.Time);
        static public string FavoriteColor { get; set; } = "#000000";
        static public string Header { get; set; } = "Omnidroid";
        static public bool Suggestions { get; set; } = true;
        static public bool ToSettings = false;
        static public bool Info { get; set; } = true;
        static public bool Config { get; set; } = true;
        static public int HeaderType { get; set; } = 0;
        

        static public void DisplayMainMenu()
        {
            if (MainMenu == true)
            {
                MainMenu = false;
            }
            else
            {
                MainMenu = true;
            }
        }
        static public void Explain()
        {
            Administrator.Suggest.Clear();
        }

        public class List(string _content)
        {
            public string Content { get; set; } = _content;
        }
        static public void Clear()
        {
            Info = false;
            switch (Listing)
            {
                case 1:
                    Administrator.Suggest.Add(new Administrator.Suggestions("The Administrator could be of assistance with code: \"ODD001\"."));
                    Gamma.PrePreset = true;
                    Gamma.Preset = 1;
                    break;
                case 2:
                    Administrator.Suggest.Add(new Administrator.Suggestions("When possible, The Administrator suggests."));
                    break;
                case 3:
                    Administrator.Suggest.Add(new Administrator.Suggestions("The Administrator could be of assistance with code: \"ODD003\"."));
                    Gamma.PrePreset = true;
                    Gamma.Preset = 2;
                    break;
                case 4:
                    Administrator.Suggest.Add(new Administrator.Suggestions("The Administrator could be of assistance with code: \"ODD004\"."));
                    Gamma.PrePreset = true;
                    Gamma.Preset = 3;
                    break;
            }
        }

        static public void OnExit()
        {
            Logbook.ErrorReports.Clear();
        }

        // log out
        // clear errors
    }
}
