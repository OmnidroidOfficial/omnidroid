using Omnidroid.Resources.Scripts.Default;

namespace Omnidroid.Resources.Scripts.Settings
{
    public class Authorization
    {
        static public bool Verify { get; set; } = false;
        static public string Chars { get; set; } = "";
        static public string Tab { get; set; } = "";
        static public string TheShortcode { get; set; } = "";
        static public int ImportModus { get; set; } = 0;
        static public bool Classified { get; set; } = false;
        static public bool Failed { get; set; } = false;
        static public bool Auth { get; set; } = false;
        static public int StartDossier { get; set; } = 0;
        static public string Dossier { get; set; } = "";
        static public string Issuer { get; set; } = "";
        static public string SN { get; set; } = "000";

        static public void Credentials()
        {
            if (ImportModus != 0)
            {
                switch (ImportModus)
                {
                    case 1:
                        // confix.txt sql to list
                        break;
                    case 2:
                        // allow edit 
                        break;
                    case 3:
                        // 
                        break;

                }
                if (ImportModus == 1)
                {

                }
                else
                {

                }
            }
        }

        static public void GetCatalogus()
        {
            StartDossier = Delta.LineCount;
            Delta.Continue = StartDossier;
            Delta.ImportFile();
        }

        static public void Beta()
        {
            Oversight.Status = "The match between ID and secret phrase is sought.";
            if (Auth == true)
            {
                Oversight.Beta = false;
            }
            else
            {
                Failed = true;
                Oversight.Status = "The match is unfortunately not found.";
            }
        }

        static public void Registration()
        {
            Oversight.Status = "The match between itinerary and favorite color is sought.";
            if (Auth == true)
            {
                Oversight.Registration = false;
            }
            else
            {
                Failed = true;
                Oversight.Status = "The match is unfortunately not found.";
                Logbook.AuthLog();
            }
        }

        static public void Shortcode()
        {
            Gamma.Crypt = TheShortcode;
            SN = Gamma.Case;
            switch (Issuer)
            {
                case "KAI":
                    Gamma.KAI();
                    break;
                case "OMD":
                    Gamma.OMD();
                    break;
                case "VAL":
                    Gamma.VAL();
                    break;
            }
        }

        static public void Cancel()
        {
            if (Verify == true)
            {

            }
        }
    }
}
