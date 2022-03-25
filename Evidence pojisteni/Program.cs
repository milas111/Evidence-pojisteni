using System;

namespace Evidence_pojisteni
{
    class Program
    {
        static void Main(string[] args)
        {
            //Vytvoření instance evidence pojištěných
            Evidence evidence = new Evidence();
            char volba = '0';
            //Cyklus, ve kterém běží celý program
            while (volba != '4')
            {
                evidence.VypisUvodniObrazovku();
                volba = Console.ReadKey().KeyChar;
                Console.WriteLine();
                Console.WriteLine();
                switch (volba)
                {
                    case '1':
                        evidence.PridejPojistence();
                        break;
                    case '2':
                        evidence.VypisPojistene();
                        break;
                    case '3':
                        evidence.VypisNalezenePojistene();
                        break;
                    case '4':
                        Console.WriteLine("Pro ukončení stiskněte libovolnou klávesu...");
                        break;

                    default:
                        Console.WriteLine("Neplatná volba, stiskněte libovolnou klávesu a znovu vyberte akci.");
                        break;
                }
                Console.ReadKey();
            }
        }
    }
}
