using System;

namespace ClassDemoArv
{
    public class Person
    {
        protected string _navn;
        protected string _tlf;
        
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

        
        public Person():this("dummy", "01010101")
        {
        }

        public Person(string navn, string tlf)
        {
            _navn = navn;
            _tlf = tlf;
        }

        public override string ToString()
        {
            return $"Navn: {Navn}, Tlf: {Tlf}";
        }
    }
}
