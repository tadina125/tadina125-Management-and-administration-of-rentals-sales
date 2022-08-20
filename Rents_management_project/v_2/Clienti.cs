using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_2
{
    public class Clienti : ICloneable, IComparable
    {
        private int cod;
        private string nume;
        private string prenume;
        private int varsta;
        private string adresa;

        public Clienti()
        {
            this.cod = 1000;
            this.nume = "Undefined";
            this.prenume = "Undefined";
            this.varsta = 18;
            this.adresa = "Unknown";
        }

        public Clienti(int c, string n, string p, int v, string adr)
        {
            this.cod = c;
            this.nume = n;
            this.prenume = p;
            this.varsta = v;
            this.adresa = adr;
        }

        public Clienti(Clienti c)
        {
            this.cod = c.cod;
            this.nume = c.nume;
            this.prenume = c.prenume;
            this.varsta = c.varsta;
            this.adresa = c.adresa;
        }

        public int Cod { get => cod; set => cod = value; }
        public string Nume { get => nume; set => nume = value; }
        public string Prenume { get => prenume; set => prenume = value; }
        public int Varsta { get => varsta; set => varsta = value; }
        public string Adresa { get => adresa; set => adresa = value; }

        public override string ToString()
        {
            string afisare = base.ToString() + " Client " + nume + " " + prenume + " ID: " + cod + " varsta " + varsta + " adresa: " + adresa;

            if (varsta > 18)
            {
                afisare += ", a fost inregistrat cu succes !";
            }
            else
                afisare += ", nu indeplineste criteriul de varsta ! ";
            return afisare;
        }

        public object Clone()
        {
            Clienti clona = (Clienti)this.MemberwiseClone();
            return clona;
        }

        public int CompareTo(object obj)
        {
            Clienti c = (Clienti)obj;
            if (this.cod != c.cod)
                return -1;
            else
                return string.Compare(this.nume, c.nume);
        }
    }
}
