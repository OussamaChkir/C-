using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TP4
{
    public partial class Menu :MetroFramework.Forms.MetroForm
    {
        public Menu()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void TS_Btn_Cl_Click(object sender, EventArgs e)
        {
            FListe_Cl f = new FListe_Cl();
            f.ShowDialog();
        }

        private void TS_Btn_Pr_Click(object sender, EventArgs e)
        {
            FListe_Prod f = new FListe_Prod();
            f.ShowDialog();
        }

        private void TS_Btn_Cd_Click(object sender, EventArgs e)
        {
            FCommande f = new FCommande();
            f.ShowDialog();
        }

        private void TS_Btn_Q_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
