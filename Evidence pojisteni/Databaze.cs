using System;
using System.Collections.Generic;
using System.Text;

namespace Evidence_pojisteni
{
    class Databaze
    {
        /// <summary>
        /// Kolekce, do které se ukládají pojištění
        /// </summary>
        private List<Pojisteny> seznamPojistenych;

        /// <summary>
        /// Vytvoří novou instanci databáze
        /// </summary>
        public Databaze()
        {
            seznamPojistenych = new List<Pojisteny>();
        }

        /// <summary>
        /// Metoda pro přidání pojištěného do databáze
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telCislo"></param>
        /// <param name="vek"></param>
        public void PridejPojisteneho(string jmeno, string prijmeni, int telCislo, int vek)
        {
            seznamPojistenych.Add(new Pojisteny(jmeno, prijmeni, telCislo, vek));
        }

        /// <summary>
        /// Vrací kolekci, ve které jsou uloženi pojištění
        /// </summary>
        /// <returns>Kolekce s pojištěnými</returns>
        public List<Pojisteny> VypisPojistene()
        {
            return seznamPojistenych;
        }

        /// <summary>
        /// Metoda pro nalezené pojištěného v databázi na základě jeho jména a příjmení
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <returns>Pojištěný v databázi</returns>
        public List<Pojisteny> NajdiPojisteneho(string jmeno, string prijmeni)
        {
            List<Pojisteny> nalezeniPojisteni = new List<Pojisteny>();
            foreach (Pojisteny pojisteny in seznamPojistenych)
            {
                if ((pojisteny.Jmeno == jmeno) && (pojisteny.Prijmeni == prijmeni))
                {
                    nalezeniPojisteni.Add(pojisteny);
                }
            }

            return nalezeniPojisteni;
        }
    }
}
