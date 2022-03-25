using System;
using System.Collections.Generic;
using System.Text;

namespace Evidence_pojisteni
{
    class Evidence
    {
        /// <summary>
        /// Databáze pojištěných
        /// </summary>
        private Databaze databaze;

        /// <summary>
        /// Vytvoří novou instanci evidence pojištěných
        /// </summary>
        public Evidence()
        {
            databaze = new Databaze();
        }

        /// <summary>
        /// Vypíše úvodní obrazovky včetně menu
        /// </summary>
        public void VypisUvodniObrazovku()
        {
            Console.Clear();
            Console.WriteLine("-----------------------------");
            Console.WriteLine("Evidence pojištěných");
            Console.WriteLine("-----------------------------");
            Console.WriteLine("\nVyberte si akci:");
            Console.WriteLine("1 - Přidat nového pojištěného");
            Console.WriteLine("2 - Vypsat všechny pojištěné");
            Console.WriteLine("3 - Vyhledat pojištěného");
            Console.WriteLine("4 - Konec");
        }

        /// <summary>
        /// Vyzve uživatele k zadání údajů pojištěnce, který se následně uloží do databáze
        /// </summary>
        public void PridejPojistence()
        {
            string jmeno = ZadejJmeno();
            string prijmení = ZadejPrijmeni();
            int telCislo = ZadejTelCislo();
            int vek = ZadejVek();
            databaze.PridejPojisteneho(jmeno, prijmení, telCislo, vek);
            Console.WriteLine("\nData byla uložena. Pokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vypíše všechny pojištěnce s jejich údaji
        /// </summary>
        public void VypisPojistene()
        {
            List<Pojisteny> seznamPojistenych = databaze.VypisPojistene();

            if (seznamPojistenych.Count == 0)
            {
                Console.WriteLine("V evidenci není uložený žádný pojištěný.");
            }
            else
            {
                foreach (Pojisteny pojisteny in seznamPojistenych)
                {
                    Console.WriteLine(pojisteny);
                }
            }

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }

        /// <summary>
        /// Vypíše nalezené pojištěnce, kteří odpovídají zadanému jménu a příjmeni
        /// </summary>
        public void VypisNalezenePojistene()
        {
            string jmeno = ZadejJmeno();
            string prijmeni = ZadejPrijmeni();
            Console.WriteLine();
            List<Pojisteny> seznamNalezenychPojistenych = databaze.NajdiPojisteneho(jmeno, prijmeni);

            if (seznamNalezenychPojistenych.Count == 0)
            {
                Console.WriteLine("Žádný pojištěný se zadaným jménem a příjmením nebyl nalezen.");
            }
            else
            {
                foreach (Pojisteny pojisteny in seznamNalezenychPojistenych)
                {
                    Console.WriteLine(pojisteny);
                }
            }

            Console.WriteLine("\nPokračujte libovolnou klávesou...");
        }

        //Privátní metody sloužící pro vnitřní operace související se zadáním údajů pojištěného
        #region Privatni_metody
        private string ZadejJmeno()
        {
            Console.WriteLine("Zadejte jméno pojištěného:");
            string jmeno;
            while (string.IsNullOrWhiteSpace(jmeno = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte znovu jméno.");
            }
            return jmeno;
        }

        private string ZadejPrijmeni()
        {
            Console.WriteLine("Zadejte příjmení:");
            string prijmeni;
            while (string.IsNullOrWhiteSpace(prijmeni = Console.ReadLine()))
            {
                Console.WriteLine("Zadejte znovu příjmení.");
            }
            return prijmeni;
        }

        private int ZadejVek()
        {
            Console.WriteLine("Zadejte věk:");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek))
            {
                Console.WriteLine("Zadejte znovu věk.");
            }
            return vek;
        }

        private int ZadejTelCislo()
        {
            Console.WriteLine("Zadejte telefonní číslo:");
            int telCislo;
            while (!int.TryParse(Console.ReadLine(), out telCislo))
            {
                Console.WriteLine("Zadejte znovu telefonní číslo.");
            }
            return telCislo;
        }
        #endregion
    }
}
