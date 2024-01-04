using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Omnidroid.Resources.Scripts.Default
{
    public class Personalia
    {
        static public string Record { get; set; } = "";
        static public bool Edit { get; set; } = true;
        static public string Country { get; set; } = "";
        static public string CountryName { get; set; } = "";
        static public string Name { get; set; } = "";
        static public string Region { get; set; } = "";
        static public List<Constants> Add { get; set; } = new List<Constants>() { new Constants("country", "Country", Country, "three-character string"), new Constants("country_name", "CountryName", CountryName, "capitalized string"), new Constants("name", "Name", Name, "custom string"), new Constants("region", "Region", Region, "string (config either north or south)"), new Constants("gender", "Gender", Gender!, "string (config either male, female or none of the above)"), new Constants("first_name", "FirstName", FirstName!, "capitalized string"), new Constants("last_name", "LastName", LastName!, "capitalized string"), new Constants("middle_names", "MiddleNames", MiddleNames!, "capitalized string"), new Constants("prefix", "Prefix", Prefix!, "string ante"), new Constants("suffix", "Suffix", Suffix!, "string post"), new Constants("regal", "Regal", Regal.ToString(), "boolean") };
        static public string Gender { get; set; } = "";
        static public string LastName { get; set; } = "";
        static public string FirstName { get; set; } = "";
        static public string MiddleNames { get; set; } = "";
        static public string Prefix { get; set; } = "";
        static public string Suffix { get; set; } = "";
        static public bool Regal { get; set; } = false;
        static public string Title { get; set; } = "";
        static public string MaritalStatus { get; set; } = "";
        static public string Credentials { get; set; } = "<p>@Personalia.Gender</p>\n <p>@Personalia.LastName</p> \n<p>@Personalia.FirstName</p>\n<p>@Personalia.MiddleNames\n<p>@Personalia.Prefix\n<p>@Personalia.Suffix</p>\n<p>@Personalia.Regal</p>\n<p>@Personalia.Title</p>\n<p>@Personalia.MaritalStatus</p>";
public class Constants(string _val, string _name, string _data, string _notation)
        {
            public string Value { get; set; } = _val;
            public string Name { get; set; } = _name;
            public string Data { get; set; } = _data;
            public string Notation { get; set; } = _notation;
        }

    }
}
