using System;

namespace ClassDemoArv
{
    public class Studerende
    {
        private string _navn;
        private string _tlf;
        private bool _DSRMedlem;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public string Tlf
        {
            get { return _tlf; }
            set { _tlf = value; }
        }

        public bool DSRMedlem
        {
            get { return _DSRMedlem; }
            set { _DSRMedlem = value; }
        }

        public Studerende():this("dummy", "01010101", false)
        {
        }

        public Studerende(string navn, string tlf, bool dsrMedlem)
        {
            _navn = navn;
            _tlf = tlf;
            _DSRMedlem = dsrMedlem;
        }

        public override string ToString()
        {
            return $"Navn: {Navn}, Tlf: {Tlf}, DSRMedlem: {DSRMedlem}";
        }
    }


}