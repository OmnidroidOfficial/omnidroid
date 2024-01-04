using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts
{
    public class Delta
    {
        static public List<Accounts> Account = new();
        static public string FileName = "";
        static public int Case = 0;
        static public int LineCount = 0;
        static public int Continue = 0;
        static public string Category { get; set; } = "";
        static public string Subject { get; set; } = "";
        static public string File { get; set; } = "";
        static public string Abstract { get; set; } = "";
        static public string Hypothesis { get; set; } = "";

        static public void ImportFile()
        {
            switch (Case)
            {
                case 1:
                    // Local (append all)
                    break;
                case 2:
                    // start from continue, then append
                    break;
            }
        }

        public class Accounts(DateTime _time, string _editor, string _title, string _content)
        {
            public DateTime Time { get; set; } = _time;
            public string Editor { get; set; } = _editor;
            public string Title { get; set; } = _title;
            public string Content { get; set; } = _content;
        }
        // To txt file
        // Create token in iVal 
        // To server --> Echelon panel (import x export)
    }
}
