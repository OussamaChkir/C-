using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesEmployee
{
    public class Ouvrier : Employe
    {
        public DateTime dateEnt { get; set; }
        private static double SMIG = 250;

        public static double _SMIG
        {
            get { return SMIG; }
        }
        public Ouvrier(int m,string n, string p,DateTime dn,DateTime de)
        : base(m, n, p, dn)
        {
            dateEnt = de;
        }
        public override string ToString()
        {
            return "Ouvrier"+base.ToString()+"Date d'entrée"+dateEnt.ToShortDateString();
        }

        public override double GetSalaire()
        {
            double salaire;
            int Anciennete = DateTime.Now.Year - dateEnt.Year;
            if (dateEnt.AddYears(Anciennete) > DateTime.Now.Date)
                Anciennete--;
            if (_SMIG + Anciennete * 100 <= 2 * _SMIG)
                salaire = _SMIG + Anciennete * 100;
            else
                salaire = _SMIG * 2;

            return salaire;
        }
    }
}
