using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts.Settings
{
    internal class Journal
    {
        static public string Sign { get; set; } = "$";
        static public bool Ante { get; set; } = true;
        static public string Time { get; set; } = "format: yyyy/MM/dd hh:mm tt";
        static public string CurrencyLocation1 = "before";
        static public string CurrencyLocation2 = "after";
        static public string CurrencyLocation { get; set; } = "";
        static public string ImportReference = "IN";
        static public string ExportReference = "OUT";
        static public int ImportRate { get; set; } = 50;
    }
}
