using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Omnidroid.Resources.Scripts
{
    public class Epsilon
    {
        static public List<Interpretation> Calculus = new();
        public class Interpretation(string _text)
        {
            public string Line { get; set; } = _text;
        }

        static public void AboutInterpreter()
        {
            Calculus.Add(new Interpretation("Convert calculus to prose."));
            Calculus.Add(new Interpretation("Sign Interpreter: independent prose for the quantity and/or unit(s)."));
            Calculus.Add(new Interpretation("Function Interpreter: relative prose for the quantity and/or unit(s)."));
            Calculus.Add(new Interpretation("The Interpreter: Start, proceed, export to iVal."));
            Calculus.Add(new Interpretation("Add information/detail to interpretation with iVal."));
        }
    }
}
