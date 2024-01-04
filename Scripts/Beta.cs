using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts
{
    public class Beta
    {
        public List<Asset> Assets { get; set; } = new();
        public class Asset(string _type, string _name, string _token)
        {
            public string Type { get; set; } = _type;
            public string Name { get; set; } = _name;
            public string Token { get; set; } = _token;
        }

    }
}
