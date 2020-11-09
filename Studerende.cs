using System;

namespace ClassDemoArv
{
    public class Studerende : Person
    {
        private bool _DSRMedlem;

        public bool DSRMedlem
        {
            get { return _DSRMedlem; }
            set { _DSRMedlem = value; }
        }

        public Studerende():this("dummy", "01010101", "city", false)
        {
        }

        public Studerende(string navn, string tlf, string adr, bool dsrMedlem):base(navn, tlf, adr)
        {
            //_navn = navn;
            //_tlf = tlf;
            _DSRMedlem = dsrMedlem;
        }

        public override string ToString()
        {
            return base.ToString() +  $", DSRMedlem: {DSRMedlem}";
        }
    }


}