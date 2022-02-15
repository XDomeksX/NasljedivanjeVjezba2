using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NasljedivanjeVjezba2
{
    internal class Program
    {
        class ProgramskiJezik
        {
            double postotak;

            public double Postotak { get => postotak; set => postotak = value; }
        }

        class Proceduralni : ProgramskiJezik
        {
            
        }

        class Objektni : ProgramskiJezik
        {
            
        }

        class Funkcionalni : ProgramskiJezik
        {
            
        }
        static void Main(string[] args)
        {
            // definiranje varijable sum
            double sum = 0;
            // unos podataka, instanciranje objekta i dodavanje postotka u sum
            Console.WriteLine("Upišite postotak za proceduralni:");
            string s = Console.ReadLine();
            Proceduralni x = new Proceduralni();
            x.Postotak = Convert.ToDouble(s);
            sum += x.Postotak;
            Console.WriteLine("Upišite postotak: za objektni");
            s = Console.ReadLine();
            Objektni y = new Objektni();
            y.Postotak = Convert.ToDouble(s);
            sum += y.Postotak;
            Console.WriteLine("Upišite postotak za funkcionalni:");
            s = Console.ReadLine();
            Funkcionalni z = new Funkcionalni();
            z.Postotak = Convert.ToDouble(s);
            sum += z.Postotak;
            // provjera ispravnosti podataka i ispis podataka
            if (sum != 100)
                Console.WriteLine("Podaci nisu dobro unešeni");
            else
            {
                if (x.Postotak > y.Postotak && x.Postotak > z.Postotak)
                    Console.WriteLine("Najzastupljeni su proceduralni programski jezici");
                else if (y.Postotak > z.Postotak)
                    Console.WriteLine("Najzastupljeni su objektni programski jezici");
                else
                    Console.WriteLine("Najzastupljeni su funkcionalni programski jezici");
            }
                
             Console.ReadKey();
        }
    }
}
