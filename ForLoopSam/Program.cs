using System;

namespace ForLoopSam
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub kasutajal sisestada kolm numbrit
            //programm kuvab numbrite summa

            int sum = 0;
            for(int i = 0;i < 3;i++)
            {
                Console.WriteLine("Sisesta number.");
                int UserNumber = Convert.ToInt32(Console.ReadLine());

                sum = sum + UserNumber;
            }
            Console.WriteLine($"Your total result is {sum}");
        }
    }
}
