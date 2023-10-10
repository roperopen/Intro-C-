using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intro_C_
{
    internal class Solution
    {
       public void Uppgift1a()
        {
            Console.WriteLine("Vad heter du?");
            var namn = Console.ReadLine();
            Console.WriteLine("Välkommen "  +  namn + "!");
            Console.WriteLine();
        }

       public void Uppgift1b() 
        {
            double bredd = 9.6;
            double höjd = 5.4;
            double area = bredd * höjd /2;
            Console.WriteLine("Triangel");
            Console.WriteLine("bredd " + bredd);
            Console.WriteLine("Höjd " + höjd);
            Console.WriteLine("Area " + area);
            Console.WriteLine();
        }

       public void Uppgift1c()
        {
            Console.WriteLine("Ange en siffra för triangelns bredd");
            var variable = Console.ReadLine();
            double decimaltal = Convert.ToDouble(variable);
            Console.WriteLine("Ange en siffra för triangelns höjd");
            var variable2 = Console.ReadLine();
            double decimaltal2 = Convert.ToDouble(variable2);
            double area = decimaltal * decimaltal2 /2;
            Console.WriteLine("Triangel");
            Console.WriteLine("Bredd " + decimaltal);
            Console.WriteLine("Höjd " + decimaltal2);
            Console.WriteLine("Area " + area);
            Console.WriteLine();
        }

       public void Uppgift1d() 
        {
            Console.WriteLine("Ange ett tal");
            var text = Console.ReadLine();
            double tal = Convert.ToDouble(text);
            Console.WriteLine("Ange ytterligare ett tal");
            var text2 = Console.ReadLine();
            double tal2 = Convert.ToDouble(text2);
            double summa = tal + tal2;
            Console.WriteLine("summan av dina tal är " + summa);
        }

        /*public void Uppgift2a()
        {
            Console.WriteLine("Gissa mitt favorittal");
            var text = Console.ReadLine();
            double tal = Convert.ToDouble(text);
            if (tal == 3)
            {
                Console.WriteLine("Du gissade rätt");
            }
            else
            {
                Console.WriteLine("Du gissade fel");
            }
        }*/

        /*public void Uppgift2b()
        {
            Random randomGenerator = new Random();
            int antalTärningsögon = randomGenerator.Next(1, 7);

            Random randomGenerator2 = new Random();
            int antalTärningsögon2 = randomGenerator.Next(1, 7);

            Console.WriteLine("Det kostar 5kr att spela tärning. Lika ger vinst:");
            Console.WriteLine("Vill Du satsa");
            var v = Console.ReadLine();
            if(v == "ja" || v== "Ja")
            {
                Console.WriteLine("Tärningarna visar: " + antalTärningsögon +", " + antalTärningsögon2);
                if (antalTärningsögon == antalTärningsögon2)
                {
                    Console.WriteLine("grattis du vann 10kr.");
                }
                else
                {
                    Console.WriteLine("Game Over");
                }
            }
            else
            {
                Console.WriteLine("Ha en trevlig dag");
            }
        }*/
    }

        /*public void Uppgift3a()
        {
            int räknare = 1;
            while (räknare < 6)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 1;
            }
            Console.WriteLine();
        }*/

        /*public void uppgift3b()
        {
            int räknare = 5;
            while(räknare < 21)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare + 3;
            }
            Console.WriteLine();
        }*/

        /*public void Uppgift3c()
        {
            int räknare = 10;
            while (räknare > -1)
            {
                Console.WriteLine("" + räknare);
                räknare = räknare - 1;
            }
        }*/

    }

}
