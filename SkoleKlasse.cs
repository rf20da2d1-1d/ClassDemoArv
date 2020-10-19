using System;

namespace ClassDemoArv
{
    public class SkoleKlasse
    {
        private String _navn;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public SkoleKlasse()
        {
        }

        public SkoleKlasse(string navn)
        {
            _navn = navn;
        }

        public override string ToString()
        {
            return $"{nameof(Navn)}: {Navn}";
        }
    }
}