using ClassADO;
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

namespace TP4
{
    public partial class FListe_Prod : MetroFramework.Forms.MetroForm
    {
        public FListe_Prod()
        {
            InitializeComponent();
        }

        private void Ajouter_Click(object sender, EventArgs e)
        {
            FProduit f = new FProduit();
            f.TypeOP = "A";
            f.ShowDialog();
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            FProduit f = new FProduit();
            f.TypeOP = "M";
            DataTable dt = new DataTable();
            dt = ProduitDAO.List_Prod_Ref(Txt_Ref.Text);
            f.Txt_Ref.Text= dt.Rows[0]["Ref_Prod"].ToString();
            f.Txt_Desig.Text = dt.Rows[0]["Desig_Prod"].ToString();
            f.Cmb_Categ.Text = dt.Rows[0]["Categ_Prod"].ToString();
            f.Txt_Prix.Text = dt.Rows[0]["PrixV_Prod"].ToString();
            f.Txt_Qte.Text = dt.Rows[0]["Qte_prod"].ToString();
            f.ShowDialog();
        }

        private void Rechercher_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(Txt_Ref.Text))
            {
                DG_Prod.DataSource = ProduitDAO.List_Prod_Ref(Txt_Ref.Text);
            }else if(!string.IsNullOrEmpty(Txt_Desig.Text))
                DG_Prod.DataSource = ProduitDAO.List_Prod_Des(Txt_Desig.Text);
            else if(!string.IsNullOrEmpty(Cmb_Categ.Text))
                DG_Prod.DataSource = ProduitDAO.List_Prod_ParCateg(Cmb_Categ.Text);
        }

        private void refrech_Click(object sender, EventArgs e)
        {
            DG_Prod.DataSource =ProduitDAO.Liste_Produit();
        }

        private void DG_Prod_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int index = e.RowIndex;
            DataGridViewRow selectedRow = DG_Prod.Rows[index];
            Txt_Ref.Text= selectedRow.Cells[0].Value.ToString();
            Txt_Desig.Text= selectedRow.Cells[1].Value.ToString();
            Cmb_Categ.Text = selectedRow.Cells[2].Value.ToString();


        }

        private void supprimer_Click(object sender, EventArgs e)
        {
            
                ProduitDAO.supprimer(Txt_Ref.Text);
                DG_Prod.DataSource = ProduitDAO.Liste_Produit();

            
        }

        private void Vider_Click(object sender, EventArgs e)
        {
            ProduitDAO.supp_all();
        }
       public Produit p;
        private void DG_Prod_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            p = new Produit(Convert.ToInt32(this.DG_Prod.CurrentRow.Cells[0].Value.ToString()), this.DG_Prod.CurrentRow.Cells[1].Value.ToString(), this.DG_Prod.CurrentRow.Cells[2].Value.ToString(), Convert.ToInt64(this.DG_Prod.CurrentRow.Cells[3].Value.ToString()), Convert.ToInt32(this.DG_Prod.CurrentRow.Cells[4].Value.ToString()));
            this.Close();
        }
    }
}
