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

        public Studerende():this("dummy", "01010101", false)
        {
        }

        public Studerende(string navn, string tlf, bool dsrMedlem):base(navn, tlf)
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