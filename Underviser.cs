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

        public Underviser(string navn, string tlf, string fag):base(navn, tlf)
        {
            _fag = fag;
        }

        public Underviser():this("dummy", "no number", "SWC")
        {

        }

        public override string ToString()
        {
            return base.ToString() + $", Fag={_fag}";
        }

    }
}