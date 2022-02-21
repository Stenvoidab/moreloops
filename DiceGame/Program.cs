using System;

namespace DiceGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //Mängus osaleb 2 mängiat arvuti (cpu) ja kasutaja (user)
            //mõlemad mängijad viskavad täringut
            //programm kontrollib kumb mängija viskas suurema numbri
            //mängia kelle skoor on suurem võidab
            //täringuid visatakse kolm korda

            Random rnd = new Random();
            int CPUrandom = rnd.Next(1, 7);
            int Userrandom = rnd.Next(1, 7);
            int CPUscore = 0;
            int Userscore = 0;

            for (int i = 0; i < 3;i++)
            {
                CPUrandom = rnd.Next(1, 7);
                Userrandom = rnd.Next(1, 7);
                Console.WriteLine($"Arvuti veeretas {CPUrandom} , Kasutaja veeretas {Userrandom}");
                if (CPUrandom > Userrandom)
                {

                    Console.WriteLine("Arvuti võit!");
                    CPUscore = CPUscore + 1;
                }
                else if (Userrandom > CPUrandom)
                {

                    Console.WriteLine("Kasutaja võit!");
                    Userscore = Userscore + 1;
                }
                else
                {
                    Console.WriteLine("Viik!");

                }
            }
            
            if(CPUscore > Userscore)
            {
                Console.WriteLine($"lõpptulemus {Userscore}:{CPUscore}, arvuti võit!");
            }
            else if(Userscore > CPUscore)
            {
                Console.WriteLine($"lõpptulemus {Userscore}:{CPUscore}, kasutaja võit!");
            }
                
            
        }
    }
}
