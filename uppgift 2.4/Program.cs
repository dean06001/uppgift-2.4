using System;
namespace uppgift_2_4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Det här är lön1");
            double lön1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Det här är lön2");
            double lön2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Det här är lön3");
            double lön3 = double.Parse(Console.ReadLine());

            double medelvärde = (lön1 + lön2 + lön3) / 3;
            Console.WriteLine("medellönen av lönerna är" + medelvärde);
            Console.ReadKey();
           
        }
    }
}