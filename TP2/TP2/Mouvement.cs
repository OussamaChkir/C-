using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP2
{
   public class Mouvement
    {
       
        public DateTime dateop { get; set; }
        public Double montant { get; set; }
        public string typeop { get; set; }

        public Mouvement(DateTime dateop,double montant,string typeop)
        {
            this.dateop = dateop;
            this.montant = montant;
            this.typeop = typeop;

        }
    }
    
}
