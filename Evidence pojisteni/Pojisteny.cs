using System;
using System.Collections.Generic;
using System.Text;

namespace Evidence_pojisteni
{
    class Pojisteny
    {
        /// <summary>
        /// Jméno pojištěného
        /// </summary>
        public string Jmeno { get; private set; }

        /// <summary>
        /// Příjmení pojištného
        /// </summary>
        public string Prijmeni { get; private set; }

        /// <summary>
        /// Věk pojištěného
        /// </summary>
        public int Vek { get; private set; }

        /// <summary>
        /// Telefonní číslo pojištěného
        /// </summary>
        public int TelCislo { get; private set; }

        /// <summary>
        /// Vytvoří novou instanci pojištěného
        /// </summary>
        /// <param name="jmeno"></param>
        /// <param name="prijmeni"></param>
        /// <param name="telCislo"></param>
        /// <param name="vek"></param>
        public Pojisteny(string jmeno, string prijmeni, int telCislo, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            TelCislo = telCislo;
            Vek = vek;
        }

        /// <summary>
        /// Vypíše pojištěného s jeho údaji
        /// </summary>
        /// <returns>Jméno, příjmení, věk a telefonní číslo pojištěného</returns>
        public override string ToString()
        {
            return string.Format(Jmeno.PadRight(8) + Prijmeni.PadRight(8) + Vek.ToString().PadRight(8) + TelCislo);
        }
    }
}
