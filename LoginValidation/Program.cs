using System;

namespace LoginValidation
{
    class Program
    {
        static void Main(string[] args)
        {
            //Programm palub sisestada kasutajatunnuse ja salasõna
            //kui sisestatud kasutajatunnus on admin ja salasõna on admin1234, programm kuvab tere tulemast.
            //muul juhul konsool kuvab "Vale kasutajatunnus või salasõna"
            //kasutajal on kolm katset


            int i = 0;

            while(i < 3)
            {
                Console.WriteLine("Sisesta kasutajatunnus:");
                string UserName = Console.ReadLine();
                Console.WriteLine("Sisesta salasõna:");
                string Salasõna = Console.ReadLine();
                if (UserName == "admin" && Salasõna == "admin1234")
                {
                    Console.WriteLine("Tere tulemast!");
                    break;
                }
                else
                {
                    i++;
                    Console.WriteLine("Vale kasutajatunnus või salasõna");
                }
            }
            






        }
    }
}
