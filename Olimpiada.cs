using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadCompiatoriOL
{
    internal class Olimpiada : IPrint, IComparable<Olimpiada>
    {
        private string nameOlimp;
        private int tochki;
        public string NameOlimp
        {
            get { return nameOlimp; }
            set { nameOlimp = value; }
        }
        public int Tochki
        {
            get { return tochki; }
            set { tochki = value; }
        }
        public Olimpiada(string nameOlimp,int tochki)
        {
            this.nameOlimp = nameOlimp;
            this.tochki = tochki;
        }

        public void Print()
        {
            Console.WriteLine($"{this.nameOlimp}->{this.tochki}");
        }

        public int CompareTo(Olimpiada other)
        {
            return NameOlimp.CompareTo(other.NameOlimp);
        }
    }
}

