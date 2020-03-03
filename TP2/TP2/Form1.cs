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
    public partial class Form1 : Form
    {
        Compte c;
        ListCompte lc = new ListCompte();
        

        public Form1()
        {
            InitializeComponent();
            
             
        }
        
        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            FCompte Form2 = new FCompte();
            Form2.ShowDialog();
            
            lc.Ajouter(Form2.cp);
            DataTable dt = new DataTable();
            Dg_Client.Rows.Add(Form2.cp.numcompte, Form2.cp.titulaire, Form2.cp.solde);
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            int rowIndex = Dg_Client.CurrentCell.RowIndex;
            Dg_Client.Rows.RemoveAt(rowIndex);
        }

        private void Btn_Rech_Click(object sender, EventArgs e)
        {
            string num = Txt_Rech.Text;
            if (string.IsNullOrEmpty(num))
                MessageBox.Show("textBox vide");
            else { 
             for (int i=0;i<lc.Lcompte.Count();i++)
             {
                if (lc.Lcompte.ElementAt(i).numcompte.Equals(num))
                {
                    Txt_Sld.Text = lc.Lcompte.ElementAt(i).solde.ToString();
                    Txt_Tit.Text = lc.Lcompte.ElementAt(i).titulaire.ToString();
                }
             }
            }
        }

        private void Dg_Client_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            DataGridViewRow selectedRow = Dg_Client.Rows[index];
            Txt_Rech.Text = selectedRow.Cells[0].Value.ToString();
            Txtnum.Text = selectedRow.Cells[0].Value.ToString();
            Txt_Nume.Text = selectedRow.Cells[0].Value.ToString();
            Txttitulaire.Text= selectedRow.Cells[1].Value.ToString();
            Txt_Titre.Text= selectedRow.Cells[1].Value.ToString();
            Txt_Tit.Text = selectedRow.Cells[1].Value.ToString();
            Txt_Sld.Text = selectedRow.Cells[2].Value.ToString();
            Txt_Slde.Text = selectedRow.Cells[2].Value.ToString();
            TxtSolde.Text = selectedRow.Cells[2].Value.ToString();
            DgMouv.Rows.Clear();
        }

        private void BtnCreerMouv_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Txtnum.Text) || string.IsNullOrEmpty(Txttitulaire.Text) || string.IsNullOrEmpty(TxtSolde.Text)|| string.IsNullOrEmpty(TxtMt.Text))
                MessageBox.Show("il y a  un champ vide");
            else {
                if (!Rdb_Ret.Checked && !Rdb_Vers.Checked)
                    MessageBox.Show("il fut choisi le type d'operation ");
                else
                {
                    Compte c = lc.rechercher(Txtnum.Text);
                    if (Rdb_Vers.Checked)
                    {
                        Mouvement m = new Mouvement(Datm.Value.Date, Convert.ToDouble(TxtMt.Text), "Retrait");
                        c.NouveauMouv(m);
                        c.verser(Convert.ToDouble(TxtMt.Text));
                        DgMouv.Rows.Add(m.dateop.Date, m.typeop, m.montant);
                    }
                    else if (Rdb_Ret.Checked)
                        if (Convert.ToDouble(TxtMt.Text) < Convert.ToDouble(TxtSolde.Text))
                        {
                            Mouvement m = new Mouvement(Datm.Value.Date, Convert.ToDouble(TxtMt.Text), "Versement");
                            c.NouveauMouv(m);
                            c.retirer(Convert.ToDouble(TxtMt.Text));
                            DgMouv.Rows.Add(m.dateop.Date, m.typeop, m.montant);
                            
                        }
                        else
                            MessageBox.Show("solde insufisant !!!");

                    TxtSolde.Text = c.solde.ToString();
                    Txt_Sld.Text = c.solde.ToString();
                    Txt_Slde.Text = c.solde.ToString();
                }
            
            }
        }

        private void Btn_Affiche_Click(object sender, EventArgs e)
        {if (Dg_Extrait.Rows.Count !=0)
                Dg_Extrait.Rows.Clear();
            
            Compte c = lc.rechercher(Txt_Nume.Text);
            for(int i = 0; i < c.NBmouv(); i++)
            {
                if(c.list_mouv[i].dateop>=Dat_Deb.Value.Date && c.list_mouv[i].dateop <= Dat_Fin.Value.Date)
                {
                    if (c.list_mouv[i].typeop.Equals("Retrait"))
                        Dg_Extrait.Rows.Add(c.list_mouv[i].dateop, c.list_mouv[i].typeop, "", c.list_mouv[i].montant);
                    else
                        Dg_Extrait.Rows.Add(c.list_mouv[i].dateop, c.list_mouv[i].typeop, c.list_mouv[i].montant,"" );
                }

            }

            
        }
    }
}
