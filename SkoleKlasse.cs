using System;
using System.Collections.Generic;


namespace ClassDemoArv
{
    public class SkoleKlasse
    {
        private String _navn;
        private List<Underviser> _undervisere;
        private List<Studerende> _studerende;

        public string Navn
        {
            get { return _navn; }
            set { _navn = value; }
        }

        public SkoleKlasse()
        {
            _undervisere = new List<Underviser>();
            _studerende = new List<Studerende>();
        }

        public SkoleKlasse(string navn)
        {
            _navn = navn;
            _undervisere = new List<Underviser>();
            _studerende = new List<Studerende>();
        }

        /*
        * metoder til at håndtere undervisere og studerende
        */

        // add Students or Teachers
        public void AddStudent(Studerende s){
            _studerende.Add(s);
        }
        public void AddTeacher(Underviser u){
            _undervisere.Add(u);
        }

        // show all teachers who teach in course
        public List<Underviser> GetTeachers(String Fag)
        {
            List<Underviser> undervisere = new List<Underviser>();

            foreach (var uv in _undervisere)
            {
                if (uv.Fag == Fag){
                    undervisere.Add(uv);
                    
                }
            }

            return undervisere;
        }

        

        // show all student who are member of DSR

        // show all student living in Roskilde

        // show number of DSR member as part of number of students

        // show numbers of DSR members in Roskilde
        














        public override string ToString()
        {
            return $"Klassens Navn: {Navn} \nUndervisere [\n{String.Join('\n', _undervisere)}] \nStuderende [\n{String.Join('\n', _studerende)}]";
        }
    }
}