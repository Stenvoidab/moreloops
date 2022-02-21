using System;

namespace OrOperator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub sisestada kasutajatunnuse ja salasõna
            //kui sisestatud kasutajatunnus on admin ja salasõna on admin1234, programm kuvab tere tulemast.
            //muul juhul konsool kuvab "Vale kasutajatunnus või salasõna"

            Console.WriteLine("Sisesta kasutajatunnus:");
            string UserName = Console.ReadLine();
            Console.WriteLine("Sisesta salasõna:");
            string Salasõna = Console.ReadLine();
            if (UserName != "admin" || Salasõna != "admin1234")
            {
                Console.WriteLine("Vale kasutajatunnus või salasõna.");
            }
            else
            {
                Console.WriteLine("Tere tulemast!");
            }
        }
    }
}
