using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class Produit
    {
        public int Ref_Prod { get; set; }
        public string Desig_Prod { get; set; }
        public string Categ_Prod { get; set; }
        public float PrixV_Prod { get; set; }
        public int Qte_prod { get; set; }

        public Produit(int Ref_Prod,string Desig_Prod,string Categ_Prod,float PrixV_Prod,int Qte_prod)
        {
            this.Ref_Prod = Ref_Prod;
            this.Desig_Prod = Desig_Prod;
            this.Categ_Prod = Categ_Prod;
            this.PrixV_Prod = PrixV_Prod;
            this.Qte_prod = Qte_prod;
        }
    }
}
