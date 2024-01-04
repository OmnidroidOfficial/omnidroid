using System;
using System.Web;
using Omnidroid.Resources.Scripts.Settings;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.Specialized;

namespace Omnidroid.Resources.Scripts.Default
{
    public class Oversight
    {
        static public string Time { get; set; } = DateTime.Now.ToString(format: Journal.Time);
        static public string Title { get; set; } = "Omnidroid";
        static public string Status { get; set; } = "";
        public static string DayPart { get; set; } = "Day";
        static public bool Auth { get; set; } = true;
        static public bool Summary { get; set; } = false;
        public static string TimeSection { get; set; } = DateTime.Now.ToString(format: "HH");
        static public bool SignIn { get; set; } = true;
        static public bool Register { get; set; } = true;
        static public bool Beta { get; set; }
        static public bool Registration { get; set; }
        
        static public void SetDaypart()
        {
            if ((TimeSection == "05") || (TimeSection == "06") || (TimeSection == "07") || (TimeSection == "08") || (TimeSection == "09") || (TimeSection == "10") || (TimeSection == "11"))
            {
                DayPart = "morning";
            }
            if ((TimeSection == "12") || (TimeSection == "13") || (TimeSection == "14") || (TimeSection == "15") || (TimeSection == "16") || (TimeSection == "17"))
            {
                DayPart = "afternoon";
            }
            if ((TimeSection == "18") || (TimeSection == "19") || (TimeSection == "20") || (TimeSection == "21") || (TimeSection == "22") || (TimeSection == "23") || (TimeSection == "00") || (TimeSection == "01") || (TimeSection == "02") || (TimeSection == "03") || (TimeSection == "04"))
            {
                DayPart = "evening";
            }
        }
    }
}
