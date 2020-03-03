using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP2
{
    public partial class FCompte : Form
    {
       
        public FCompte()
        {
            InitializeComponent();

        }
        public Compte cp;
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Btn_Valid_Click(object sender, EventArgs e)
        {       
                cp = new Compte(Txtnumcompte.Text,Txttitulaire.Text, Convert.ToDouble(Txtsolde.Text));
            this.Close();


        }
    }
}
