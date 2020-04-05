using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public  class LigneCommande
    {
        public int num_cmd { get; set; }
        public int Ref_Prod { get; set; }
        public int qte { get; set; }
        public LigneCommande(int num_cmd,int Ref_Prod,int qte)
        {
            this.num_cmd = num_cmd;
            this.Ref_Prod = Ref_Prod;
            this.qte = qte;
        }
    }
}
