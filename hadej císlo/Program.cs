using System;

namespace hadej_císlo
{
    class Program
    {
        static void Main(string[] args)
        {
            
            
            Random random = new Random();
            int hacislo = random.Next(1, 100);
            int tipcislo;
            bool neuhodl = true;
           
            Console.WriteLine("Hadání čísla");
            Console.WriteLine("--------------------------");
            Console.WriteLine("Myslím si číslo od 1 do 100!");
            while (neuhodl);
            {
                Console.WriteLine("Tipni si číslo: ");
                tipcislo = int.Parse(Console.ReadLine());
                
                if (tipcislo > hacislo);
                {
                    Console.WriteLine("číslo je velké");
                }
                else if (tipcislo > hacislo);
                {
                    Console.WriteLine("číslo je malé");
                }
                else
                {
                    Console.WriteLine("Trefa");
                    neuhodl = false;
                }
                

            }
            Console.ReadLine();
        }
    }
}
