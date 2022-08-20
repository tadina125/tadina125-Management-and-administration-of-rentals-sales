using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace v_2
{
    class Filme:ICloneable, IComparable
    {
        private string categorie;
        private string denumire;
        private int an_lansare;
        private float pret;
        private string disponibil;

        public Filme()
        {
            Categorie = "N/A";
            denumire = "Unknown";
            an_lansare = 0000;
            pret = 0.0f;
            Disponibil = "Disponibil";
        }

        public Filme(string cat, string d, int an, float pr, string dis)
        {
            Categorie = cat;
            denumire = d;
            an_lansare = an;
            pret = pr;
            Disponibil = dis;
        }

        public string Denumire { get => denumire; set => denumire = value; }
        public int An_lansare { get => an_lansare; set => an_lansare = value; }
        public float Pret { get => pret; set => pret = value; }
        public string Categorie { get => categorie; set => categorie = value; }
        public string Disponibil { get => disponibil; set => disponibil = value; }

        public object Clone()
        {
            Filme clona = (Filme)this.MemberwiseClone();
            return clona;
        }

        public override string ToString()
        {
            string afisare = base.ToString() + " Filmul  " + denumire + ", " + an_lansare + ", categorie " +" are ca pret de inchiriere " + pret + disponibil;

            return afisare;
        }

        public int CompareTo(object obj)
        {
            Filme f = (Filme)obj;
            if (this.pret < f.pret)
                return -1;
            else
                 if (this.pret > f.pret)
                return 1;
            else
                //return 0;
                return string.Compare(this.denumire, f.denumire);
        }
    }
}
