using System;

namespace ClassDemoArv
{
    public class Underviser : Person
    {

        private String _fag;

        public String Fag
        {
            get {return _fag;}
            set{_fag = value;}
        }

        public Underviser(string navn, string tlf, string adr, string fag):base(navn, tlf, adr)
        {
            _fag = fag;
        }

        public Underviser():this("dummy", "no number", "a city", "SWC")
        {

        }

        public override string ToString()
        {
            return base.ToString() + $", Fag={_fag}";
        }

    }
}