using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entities
{
  public class client
    {
        public int cin_cl { get; set; }
        public string Nom_cl { get; set; }
        public string pren_cl { get; set; }
        public string ville_cl { get; set; }
        public int tel_cl { get; set; }

        public client(int cin_cl,string Nom_cl,string pren_cl,string ville_cl,int tel_cl)
        {
            this.cin_cl = cin_cl;
            this.Nom_cl = Nom_cl;
            this.pren_cl = pren_cl;
            this.ville_cl = ville_cl;
            this.tel_cl = tel_cl;

        }
    }
}
