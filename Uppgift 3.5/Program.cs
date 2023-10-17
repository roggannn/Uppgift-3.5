using System;

namespace uppgift
{
    class Program
    {
        static void Main(string[] args) 
        {
            Console.WriteLine("Skriv in ett tal");
            double tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett till tal");
            double tal2 = double.Parse(Console.ReadLine());
            Task.Delay(200).Wait();
            Console.Clear();
            Console.WriteLine("Välj vilket räknesätt du vill använda mellan de två talen.");
            Console.WriteLine("");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraktion");
            Console.WriteLine("3. Multiplikation");
            Console.WriteLine("4. Division");
            Console.WriteLine("");
            string svar = Console.ReadLine();

            switch (svar)
            {
                case "1":
                Console.WriteLine("Uträkningen blir : " + tal1 + " + " +  tal2 + " = " + (tal1+tal2));
                break;

                case "2":
                Console.WriteLine("Uträkningen blir : " + tal1 + " - " + tal2 + " = " + (tal1-tal2));
                break;

                case "3":
                Console.WriteLine("Uträkningen blir : " + tal1 + " x " + tal2 + " = " + (tal1 * tal2));
                break;

                case "4":
                Console.WriteLine("Uträkningen blir : " + tal1 + " / " + tal2 + " = " + (tal1 / tal2));
                break;

                default:
                Console.WriteLine("Skriv in en av siffrorna ovan, tack.");
                Task.Delay(500).Wait();
                break;
            }
            Console.ReadKey();

        }
    }
}