using System;

namespace K8U2_Primzahlen_HarderingNils
{
    class Zahl
    {
        public bool IsPrime(int value)
        {
            if (value <= 1)
                return false;
            else
            {
                if (value > 2)
                {
                    for (int i = 2; i <= (value / 2) + 1; i++)
                        if (value % i == 0)
                            return false;
                }
            }

            return true;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Zahl zahlObjekt = new Zahl();
            Console.WriteLine("Niedrigste Zahl: ");
            int low = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Höhste Zahl:   ");
            int high = Convert.ToInt32(Console.ReadLine());
            for (int i = low; i <= high; i++)
            {
                if (zahlObjekt.IsPrime(i))
                {
                    Console.Write("{0}\t", i);
                }
            }
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
