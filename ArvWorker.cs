using System;
using System.Collections.Generic;

namespace ClassDemoArv
{
    public class ArvWorker 
    {
        public ArvWorker()
        {

        }

        public void MyCode()
        {
            // here comes the code

            // making an object of each class
            SkoleKlasse klasse = new SkoleKlasse("1D");
            Studerende studerende1 = new Studerende("Margrethe","10020033", "København", false);
            Studerende studerende2 = new Studerende("Henrik","10020033", "København", true);
            Underviser uv1  = new Underviser("Peter", "45454545", "Roskilde", "SWC");



            // udskriver de 4 objekter
            //System.Console.WriteLine(klasse);
            System.Console.WriteLine(studerende1);
            System.Console.WriteLine(studerende2);
            System.Console.WriteLine(uv1);


            /*
            * indsætter undervisere og studerende i klassen
            */
            klasse.AddTeacher(uv1);
            klasse.AddTeacher(new Underviser("Vibeke", "98765432", "Vanløse", "SWD"));
            klasse.AddTeacher(new Underviser("Jakb", "77886655", "Ringsted", "SWD"));
            klasse.AddTeacher(new Underviser("Mohammed", "22377455", "Nørrebro", "SWC"));
            klasse.AddStudent(studerende1);
            klasse.AddStudent(studerende2);
            klasse.AddStudent(new Studerende("Anders", "22334455", "Roskilde", false));
            klasse.AddStudent(new Studerende("Anders B", "99334455", "Roskilde", false));
            klasse.AddStudent(new Studerende("Michael", "22338855", "København", true));
            klasse.AddStudent(new Studerende("Jens Peter", "919827364", "Næstved", false));
            //System.Console.WriteLine("===========================================");
            //System.Console.WriteLine(klasse);
            //System.Console.WriteLine("===========================================");
            
            System.Console.WriteLine("Yoga");
            List<Underviser> liste =  klasse.GetTeachers("Yoga");

            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }
            

            System.Console.WriteLine("SWC");
            liste = klasse.GetTeachers("SWC");
            foreach (var item in liste)
            {
                System.Console.WriteLine(item);
            }



        }

    }
}