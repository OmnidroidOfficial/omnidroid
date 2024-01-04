using Omnidroid.Resources.Scripts.Settings;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts.Default
{
    public class Administrator
    {
        static public List<Correspondence> Tab = new();
        static public int Preset { get; set; } = 0;
        static public bool PrePreset { get; set; } = true;
        static public int M { get; set; } = 0;
        static public string val { get; set; } = "";
        static public bool Options { get; set; } = true;
        static public string a { get; set; } = "";
        static public string b { get; set; } = "";
        static public string c { get; set; } = "";
        static public string d { get; set; } = "";
        static public bool Preparation { get; set; } = false;
        public class Correspondence(string _align, string _aligntext, DateTime _time, string _sender, string _content)
        {
            public string Align { get; set; } = _align;
            public string TextAlign { get; set; } = _aligntext;
            public DateTime Time { get; set; } = _time;
            public string Sender { get; set; } = _sender;
            public string Content { get; set; } = _content;
        }
        static public void PresetZero()
        {
            if (Preparation == false)
            {
                Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", Credentials.Name + "!"));
                Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "Good" + Oversight.DayPart + "."));
                Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "How may I be of assistance?"));
                a = "Preset";
                b = "Citation";
                c = "Explanation";
                d = "Take Note";
                M = 1;
                Preparation = true;
            }
            else
            {
                if (val != "")
                {
                    switch (M)
                    {
                        case 1:
                            Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "You have selected" + c + "."));
                            a = "";
                            b = "";
                            c = "";
                            d = "";
                            break;

                    }
                }
            }
        }
        static public void Correspond()
        {
            if (PrePreset == true)
            {
                switch (Preset)
                {
                    case 1:
                        PresetOne();
                        break;
                    case 2:
                        PresetTwo();
                        break;
                    case 3:
                        PresetThree();
                        break;
                }
            }
            else
            {
                PresetZero();
                M++;
            }
        }
        static public void A()
        {
            val = a;
            switch (M)
            {
                case 1:
                    Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "Preset."));
                    a = "Continue";
                    M++;
                    break;
            }
        }

        static public void B()
        {
            val = b;
            switch (M)
            {
                case 1:
                    Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "Citation."));
                    b = "Continue";
                    M++;
                    break;

            }
        }

        static public void C()
        {
            val = c;
            switch (M)
            {
                case 1:
                    Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "Explanation."));
                    c = "Continue";
                    M++;
                    break;

            }
        }

        static public void D()
        {
            val = d;
            switch (M)
            {
                case 1:
                    Tab.Add(new Correspondence("right", "right", DateTime.Now, "The Administrator", "Take Note."));
                    d = "Continue";
                    M++;
                    break;

            }
        }
        static public void PresetOne()
        {
            if (M != 0)
            {
                Logbook.s = 1;
            }
            else
            {

            }
        }
        static public void PresetTwo()
        {
            Logbook.s = 2;
        }
        static public void PresetThree()
        {
            Logbook.s = 3;
        }

        // inquiry @ Error Log (Classify)
    }
}
