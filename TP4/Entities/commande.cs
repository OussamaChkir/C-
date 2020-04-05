using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
   public class commande
    {
        public int Num_cmd { get; set; }
        public int cin_cl { get; set; }
        public DateTime date_cmd { get; set; }
        public commande(int Num_cmd,int cin_cl,DateTime date_cmd)
        {
            this.Num_cmd = Num_cmd;
            this.cin_cl = cin_cl;
            this.date_cmd = date_cmd;
        }
    }
}
