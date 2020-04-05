using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entities;
using ClassADO;

namespace TP4
{
    public partial class FListe_Cl : MetroFramework.Forms.MetroForm
    {
        public FListe_Cl()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            client c = new client(Convert.ToInt32(Txt_Cin.Text), Txt_Nom.Text, Txt_Pren.Text,Txt_Vil.Text,Convert.ToInt32(Txt_Tel.Text));
            ClientADO.inserer(c);
            Dg_Clt.DataSource = ClientADO.Liste_Client();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Cin.Text))
                Dg_Clt.DataSource = ClientADO.Liste_Client_ParCin(Convert.ToInt64(Txt_Cin.Text));
            else if(!string.IsNullOrEmpty(Txt_Nom.Text))
                Dg_Clt.DataSource = ClientADO.Liste_Client_ParNom(Txt_Nom.Text);
            else if (!string.IsNullOrEmpty(Txt_Pren.Text))
                Dg_Clt.DataSource = ClientADO.Liste_Client_ParPren(Txt_Pren.Text);
            else
                Dg_Clt.DataSource = ClientADO.Liste_Client();
        }

        private void Supprimer_Click(object sender, EventArgs e)
        {
            ClientADO.supprimer(Convert.ToInt64(Txt_Cin.Text));
        }

        private void Dg_Clt_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = Dg_Clt.Rows[index];
            Txt_Cin.Text = selectedRow.Cells[0].Value.ToString();
            Txt_Nom.Text = selectedRow.Cells[1].Value.ToString();
            Txt_Pren.Text = selectedRow.Cells[2].Value.ToString();
            Txt_Vil.Text = selectedRow.Cells[3].Value.ToString();
            Txt_Tel.Text = selectedRow.Cells[4].Value.ToString();
        }

        private void Modifier_Click(object sender, EventArgs e)
        {
            client c = new client(Convert.ToInt32(Txt_Cin.Text), Txt_Nom.Text, Txt_Pren.Text, Txt_Vil.Text, Convert.ToInt32(Txt_Tel.Text));
            ClientADO.modifier(c);
        }

        private void Dg_Clt_DoubleClick(object sender, EventArgs e)
        {
            

        }
        public client cl;
        private void Dg_Clt_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            cl = new client(Convert.ToInt32(this.Dg_Clt.CurrentRow.Cells[0].Value.ToString()), this.Dg_Clt.CurrentRow.Cells[1].Value.ToString(), this.Dg_Clt.CurrentRow.Cells[2].Value.ToString(), this.Dg_Clt.CurrentRow.Cells[3].Value.ToString(),Convert.ToInt32(this.Dg_Clt.CurrentRow.Cells[4].Value.ToString()));
            this.Close();
        }
    }
}
