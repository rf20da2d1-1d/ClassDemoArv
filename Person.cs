using System;

namespace ClassDemoArv
{
    public class Person
    {
        protected string _navn;
        protected string _tlf;
        protected string _adr;
        
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

        public string Adr
        {
            get { return _adr; }
            set { _adr = value; }
        }

        
        public Person():this("dummy", "01010101", "some City")
        {
        }

        public Person(string navn, string tlf, string adr)
        {
            _navn = navn;
            _tlf = tlf;
            _adr = adr;
        }

        public override string ToString()
        {
            return $"Navn: {Navn}, Tlf: {Tlf}, Adr: {Adr}";
        }
    }
}
