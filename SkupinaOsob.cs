using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10DatabazeOsob
{
    internal class SkupinaOsob
    {
        private List<Osoba> seznamOsob;
        public SkupinaOsob()
        {
            seznamOsob = new List<Osoba>();
        }
        public void PridejOsobu()
        {
            Console.WriteLine();
            Console.Write("Zadej křestní jméno: ");
            string jmeno = Console.ReadLine();
            Console.Write("Zadej příjmení: ");
            string prijmeni = Console.ReadLine();
            Console.Write("Zadej věk osoby: ");
            int vek;
            while (!int.TryParse(Console.ReadLine(), out vek)||vek<0||vek>120) Console.WriteLine("Zadej platný věk.");
            Console.WriteLine();
            seznamOsob.Add(new Osoba(jmeno, prijmeni, vek));
        }
        public void PridejOsobu(string jmeno, string prijmeni, int vek)
        {
            seznamOsob.Add(new Osoba(jmeno, prijmeni, vek));
        }
        public void VypisOsoby()
        {
            Console.WriteLine();
            foreach (Osoba o in seznamOsob) Console.WriteLine(o);
            Console.WriteLine();
        }
    }
}
