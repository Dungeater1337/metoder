using System; 

namespace uppgift_6_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Skriv in ett värder");
            int tal1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett värder");
            int tal2 = int.Parse(Console.ReadLine());
            Console.WriteLine("Skriv in ett värder");
            int tal3 = int.Parse(Console.ReadLine());

            int summa = Adderar(tal1, tal2, tal3);
            Console.WriteLine(summa);
        }

        static int Adderar(int tal1, int tal2, int tal3)
        {
          int summa = tal1 + tal2 + tal3;
            return summa;
        }
    }
}