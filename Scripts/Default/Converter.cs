namespace Omnidroid.Resources.Scripts.Default
{
    class Converter
    {
      //  static public bool Active = true;
        static public int Sign = 0;
        static public int Modus = 0;
        static public int Split = 0;
        static public string Proceeding = "Start";
        static public string Quantity = "";
        static public bool SI = true;
        static public List<Cartesian> PostSign = new();
        static public string QuantityLocus = "";
        static public string QuantityDivisio = "";
        static public string QuantityData = "";
        
        public class Cartesian(string _locus, string _divisio, string _indicator, string _data, bool _unitmode)
        {
            public string Locus { get; set; } = _locus;
            public string Divisio { get; set; } = _divisio;
            public string Indicator { get; set; } = _indicator;
            public string Data { get; set; } = _data;
            public bool UnitMode { get; set; } = _unitmode;
        }

        static public void Read()
        {
            switch (Modus)
            {
                case 0:
                    Proceeding = "Start";
                    Sign = 0;
                    SplitLine();
                    break;
                case 1:
                    Proceeding = "Restart";
                    Sign = 1;
                    ReadSign();
                    break;
            }
        }

        static public void ReadSign()
        {
            switch (Sign)
            {
                case 0:
                    break;
                case 1:
                    break;
            }
        }

        static public void SplitLine()
        {
            PostSign.Count();
        }

        static public void ReadFunction()
        {
            switch (Sign)
            {
                case 0:
                    break;
                case 1:
                    break;
            }
        }
    }
}
