using System;

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
            Studerende studerende1 = new Studerende("Margrethe","10020033", false);
            Studerende studerende2 = new Studerende("Henrik","10020033", true);
            Underviser uv1  = new Underviser("Peter", "45454545", "SWC");



            // udskriver de 4 objekter
            //System.Console.WriteLine(klasse);
            System.Console.WriteLine(studerende1);
            System.Console.WriteLine(studerende2);
            System.Console.WriteLine(uv1);
        }

    }
}