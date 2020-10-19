using System;

namespace ClassDemoArv
{
    class Program
    {
        static void Main(string[] args)
        {
            ArvWorker worker = new ArvWorker();
            worker.MyCode();

            Console.WriteLine("Programmet er færdigt");
        }
    }
}
