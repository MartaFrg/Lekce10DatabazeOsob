using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lekce10DatabazeOsob
{
    internal class Osoba
    {
        private string _jmeno;
        private string _prijmeni;
        private int _vek;
        public Osoba(string jmeno, string prijmeni, int vek)
        {
            Jmeno = jmeno;
            Prijmeni = prijmeni;
            Vek = vek;
        }

        public string Jmeno
        {
            get
            {
                return _jmeno;
            }
            private set
            {
                _jmeno = value;
            }
        }
        public string Prijmeni

        {
            get
            {
                return _prijmeni;
            }
            private set
            {
                _prijmeni = value;
            }
        }
        public int Vek
        {
            get
            {
                return _vek;
            }
            private set
            {
                _vek = value;
            }
        }
        public bool JePlnoleta
        {
            get
            {
                if (_vek >= 18)
                {
                    return true;
                }else return false;
            }
        }
        public override string ToString()
        {
            if (JePlnoleta) return $"{Jmeno} {Prijmeni} je plnoletá osoba."; else return $"{Jmeno} {Prijmeni} není plnoletá osoba.";
        }
    }
}
