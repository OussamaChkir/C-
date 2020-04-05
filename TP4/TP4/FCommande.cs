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
    public partial class FCommande : MetroFramework.Forms.MetroForm
    {
        float totalCde=0;
        public List<LigneCommande> list_commande =new List<LigneCommande>();
        public FCommande()
        {
            InitializeComponent();
        }

        private void Vider_Clt_Click(object sender, EventArgs e)
        {
            Txt_cin.Text = string.Empty;
            Txt_nom.Text = string.Empty;
            Txt_prenom.Text = string.Empty;
            Txt_vil.Text = string.Empty;
            Txt_tel.Text = string.Empty;
        }

        private void Nouv_Clt_Click(object sender, EventArgs e)
        {
            FListe_Cl f = new FListe_Cl();
            f.ShowDialog();
            Txt_cin.Text = f.cl.cin_cl.ToString();
            Txt_nom.Text = f.cl.Nom_cl.ToString();
            Txt_prenom.Text = f.cl.pren_cl.ToString();
            Txt_vil.Text = f.cl.ville_cl.ToString();
            Txt_tel.Text = f.cl.tel_cl.ToString();
        }

        private void Nouv_lig_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Qte.Text))
                MessageBox.Show("qte empty");
            else { 
            FListe_Prod f = new FListe_Prod();
            f.ShowDialog();
           Dg_Prod.Rows.Add(f.p.Ref_Prod, f.p.Desig_Prod, f.p.PrixV_Prod, Qte.Text,f.p.PrixV_Prod*Convert.ToInt32(Qte.Text));
            LigneCommande lc = new LigneCommande(Convert.ToInt32(Txt_NumCde.Text),Convert.ToInt32(f.p.Ref_Prod),Convert.ToInt32(Qte.Text));
            list_commande.Add(lc);
                totalCde += f.p.PrixV_Prod * Convert.ToInt32(Qte.Text);
                Txt_TotalCde.Text = totalCde.ToString();
            }
        }

        private void Vider_Cde_Click(object sender, EventArgs e)
        {
            Txt_NumCde.Text = string.Empty;
            totalCde = 0;
            Txt_TotalCde.Text = totalCde.ToString();
            Dg_Prod.Rows.Clear();
        }

        private void Nouveau_Cde_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txt_NumCde.Text) || string.IsNullOrEmpty(Txt_cin.Text))
                MessageBox.Show("please fill the empty Box");
            else
            {
                commande c = new commande(Convert.ToInt32(Txt_NumCde.Text),Convert.ToInt32(Txt_cin.Text), Date_Cde.Value.Date);
                CommandeDAO.Inserer(c, list_commande);
                list_commande.Clear();
            }
        }

        private void Txt_NumCde_KeyPress(object sender, KeyPressEventArgs e)
        {
            
            if(e.KeyChar == (char)13)
            {
                Boolean val = CommandeDAO.Existe_Commande(Txt_NumCde.Text);
                if (val)
                {
                    Pan_LigC.Visible = true;
                    DataTable dtlc = LigneCommandeDAO.List_LigneCommande_ParNum(Txt_NumCde.Text);
                    foreach (DataRow row in dtlc.Rows) {
                        DataTable dtpr = ProduitDAO.List_Prod_Ref(row["Ref_Prod"].ToString());
                        Dg_Prod.Rows.Add(row["Ref_Prod"].ToString(),dtpr.Rows[0]["Desig_Prod"].ToString(), dtpr.Rows[0]["PrixV_Prod"].ToString(), row["qte"].ToString(),Convert.ToInt32(dtpr.Rows[0]["PrixV_Prod"].ToString())*Convert.ToInt32( row["qte"].ToString()));
                        totalCde += Convert.ToInt32(dtpr.Rows[0]["PrixV_Prod"].ToString()) * Convert.ToInt32(row["qte"].ToString());
                            }
                    DataTable dtc = CommandeDAO.List_Com_Num(Txt_NumCde.Text);
                    DataTable dt = ClientADO.Liste_Client_ParCin(Convert.ToInt64(dtc.Rows[0]["cin_cl"].ToString()));
                    Txt_cin.Text = dt.Rows[0]["cin_cl"].ToString();
                    Txt_nom.Text = dt.Rows[0]["Nom_cl"].ToString();
                    Txt_prenom.Text = dt.Rows[0]["pren_cl"].ToString();
                    Txt_vil.Text = dt.Rows[0]["ville_cl"].ToString();
                    Txt_tel.Text = dt.Rows[0]["tel_cl"].ToString();
                    Txt_TotalCde.Text = totalCde.ToString();
                }
                else
                {
                    Pan_LigC.Visible = true;
                }
                
            }
        }

        private void Supp_Lig_Click(object sender, EventArgs e)
        {
            if(Dg_Prod != null) { 
            int i = Dg_Prod.CurrentCell.RowIndex;
            Boolean exist = LigneCommandeDAO.Existe_listCommande(Txt_NumCde.Text, Dg_Prod.Rows[i].Cells[0].Value.ToString());
            totalCde -= Convert.ToInt32(Dg_Prod.Rows[i].Cells[4].Value.ToString());
            if (exist)
            {
                LigneCommandeDAO.delete(Txt_NumCde.Text, Dg_Prod.Rows[i].Cells[0].Value.ToString());
                Dg_Prod.Rows.RemoveAt(i);
            }
            else
            {
                Dg_Prod.Rows.RemoveAt(i);
                list_commande.RemoveAt(i);
            }
            Txt_TotalCde.Text = totalCde.ToString();
            }
        }

        private void Modif_Lig_Click(object sender, EventArgs e)
        {
            int i = Dg_Prod.CurrentCell.RowIndex;
            if (string.IsNullOrEmpty(Qte.Text))
                MessageBox.Show("textBox Quantities is empty !!");
            else
                LigneCommandeDAO.modifier(Txt_NumCde.Text, Dg_Prod.Rows[i].Cells[0].Value.ToString(), Qte.Text);

        }
    }
}
