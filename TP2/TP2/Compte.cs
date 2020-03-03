using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
    public class Compte
    {
        List<Mouvement> list_mou = new List<Mouvement>();
        public List<Mouvement> list_mouv
        {
            get { return list_mou; }
            set { list_mou = value; }
        }
        public string numcompte { get; set; }
        public double solde { get; set; }
        public string titulaire { get; set; }

        public Compte() { }
        public Compte(string num,string titu,double solde)
        {
            this.numcompte = num;
            this.titulaire = titu;
            this.solde = solde;
        }
        public int NBmouv()
        {
            return list_mouv.Count();
        }
        public void NouveauMouv(Mouvement m)
        {
            list_mouv.Add(m);
        }
        public void retirer(double val)
        {
            solde -= val;
        }
        public void verser(double val)
        {
            solde += val;
        }
    }
}
