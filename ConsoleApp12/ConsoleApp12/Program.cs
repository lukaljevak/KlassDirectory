using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //unos putanje mape
            Console.WriteLine("Unesi putanju mape");
            string putanja = Console.ReadLine();
            //provjera postoji li mapa
            if (Directory.Exists(putanja))
            {
                Console.WriteLine("Mapa postoji!");
                //ako postoji ispisuje sve datoteke u mapi
                Console.WriteLine("Ispis datoteka");
                foreach (string datoteka in Directory.GetFiles(putanja))
                {
                    Console.WriteLine("Datoteka");
                }
                //putanja podmape
                string putanjaPodmape = putanja + "\\bla";
                //provjera postoji li podmapa, ako ne postoji, kreiramo je
                if (!Directory.Exists(putanjaPodmape))
                {
                    Directory.CreateDirectory(putanjaPodmape);
                    Console.WriteLine("Mapa" + putanjaPodmape + " je napravljena.");
                }
                //ispis podmapa
                foreach(string podmapa in Directory.GetDirectories(putanja)) 
                {
                    Console.WriteLine(podmapa);
                }
                Directory.Delete(putanjaPodmape);
                Console.WriteLine("Ispis podmapa nakon brisanja:");
            }
            //ako ne postoji, kreiramo mapu
            else 
            {
                Directory.CreateDirectory(putanja);
                Console.WriteLine("Mapa" + putanja + "je napravljena");
            }
            Console.ReadKey();
        }
    }
}
