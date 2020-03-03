using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GestionDesEmployee
{
    public class Cadre:Employe
    {
        public int index { get; set; }

        public Cadre(int m, string n, string p, DateTime dn,int index)
            :base(m, n, p, dn)
        {
            this.index = index;
        }

        public override double GetSalaire()
        {

            if (index == 1)
                return 1300;
            else if (index == 2)
                return 1500;
            else if (index == 3)
                return 1700;
            else if (index == 4)
                return 2000;
            else
                return -1;

        }
        public override string ToString()
        {
            return "Cadre"+ base.ToString()+"Indice"+index;
        }
    }
}
