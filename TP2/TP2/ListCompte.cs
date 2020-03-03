using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
  public  class ListCompte
    {
        List<Compte> lcompte = new List<Compte>();
        public List<Compte> Lcompte
        {
            get { return lcompte; }
            set { lcompte = value; }
        }

        public void Ajouter(Compte c)
        {
            
            Lcompte.Add(c);
        }
        public void supprimer(Compte c)
        {
            Lcompte.Remove(c);
        }
        public void supprimer(int i)
        {
            Lcompte.RemoveAt(i);
        }
        public Compte rechercher(String numcompte)
        {
            Compte c = null;
            if (Lcompte.Count == 0)
                return null;
            else
            {
                for(int i=0;i<Lcompte.Count();i++)
                {
                    c = (Compte)Lcompte[i];
                    if (c.numcompte == numcompte)
                        break;
                }
                return c;
            }
        }
    }
}
