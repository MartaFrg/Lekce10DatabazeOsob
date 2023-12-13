using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10DatabazeOsob
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SkupinaOsob lideNaVecirku = new SkupinaOsob();
            List<Osoba> seznamOsob = new List<Osoba>();
            lideNaVecirku.PridejOsobu("Václav", "Novák", 45);
            lideNaVecirku.PridejOsobu("Josef", "Svoboda", 60);
            lideNaVecirku.PridejOsobu("Jarmila", "Procházková", 18);
            lideNaVecirku.PridejOsobu("Jakub", "Volný", 10);
            lideNaVecirku.PridejOsobu("Anna", "Pilná", 15);
            int volba = 0;
            while (volba != 3) { 
            Console.WriteLine("Vyber si možnost: \t1.přidej osobu do seznamu\n\t\t\t2.Vypiš seznam osob\n\t\t\t3.Ukonči");
            while (!int.TryParse(Console.ReadLine(), out volba) || volba < 1 || volba > 3) ;
            switch (volba)
            {
                case 1:
                    lideNaVecirku.PridejOsobu();
                    break;
                case 2:
                    lideNaVecirku.VypisOsoby();
                    break;
                case 3:
                    break;
            }
        }


        }
    }
}
