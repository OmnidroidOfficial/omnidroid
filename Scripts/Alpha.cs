using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts
{
    public class Alpha
    {
        public List<Expense> Expenses { get; set; } = new();
        static public int Incoming { get; set; }
        static public int Outgoing { get; set; }
        static public int ValExport { get; set; }
        static public int ValImport { get; set; }

        static public void Summary()
        {
            //signante
        }
        public class Expense(DateTime _time, string _location, string _otherparty, string _name, string _description, string _category, int _value, bool _export)
        {
            public DateTime Time { get; set; } = _time;
            public string Location { get; set; } = _location;
            public string OtherParty { get; set; } = _otherparty;
            public string Name { get; set; } = _name;
            public int Value { get; set; } = _value;
            public string Description { get; set; } = _description;
            public string Category { get; set; } = _category;
            public bool Export { get; set; } = _export;
        }
    }
}
