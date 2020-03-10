using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using GestionDesEmployee;

namespace Tp3
{
    public partial class Form1 : Form
    {
        public static List<Patron> listPatron = new List<Patron>();
        public static List<Cadre> listCadre = new List<Cadre>();
        public static List<Ouvrier> listOuvrier = new List<Ouvrier>();
        public Form1()
        {
            InitializeComponent();
            grp_cad.Enabled = false;
            Grp_Ouv.Enabled = false;
            grp_pat.Enabled = false;
          
        }
       
    private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            
            if (string.IsNullOrEmpty(Txt_Mat.Text)||string.IsNullOrEmpty(Txt_Nom.Text)||string.IsNullOrEmpty(Txt_Pren.Text))
                MessageBox.Show("champs matricule ou nom est vide !!");
            else
            {
                
                if (Opt_P.Checked)
                {
                    if (!string.IsNullOrEmpty(Txt_CA.Text) && !string.IsNullOrEmpty(Txt_Pour.Text))
                    {
                        Patron E;
                        
                        E = new Patron(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value.Date, Convert.ToInt32(Txt_CA.Text), Convert.ToInt32(Txt_Pour.Text));
                        Dg_Emp.Rows.Add(E.Matricule, E.Nom, E.Prenom, E.Datenaissance.Date, E.GetSalaire());
                        listPatron.Add(E);
                    }
                }
                else if (Opt_C.Checked)
                {
                    int ind = 1;
                    if (Ind1.Checked)
                        ind = 1;
                    else if (Ind2.Checked)
                        ind = 2;
                    else if (Ind3.Checked)
                        ind = 3;
                    else if (Ind4.Checked)
                        ind = 4;
                    else
                    {
                        MessageBox.Show("svp choisi un indice");
                    }
                   
                    Cadre E;
                    E = new Cadre(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value, ind);
                    Dg_Emp.Rows.Add(E.Matricule, E.Nom, E.Prenom, E.Datenaissance.Date, E.GetSalaire());
                    listCadre.Add(E);

                }
                else if (Opt_O.Checked)
                {
                    Ouvrier E;
                    E = new Ouvrier(Convert.ToInt32(Txt_Mat.Text), Txt_Nom.Text, Txt_Pren.Text, Dat_Nais.Value.Date, Dat_Ent.Value.Date);
                    Dg_Emp.Rows.Add(E.Matricule, E.Nom, E.Prenom, E.Datenaissance.Date, E.GetSalaire());
                    listOuvrier.Add(E);
                }

            }
        }

        private void Opt_P_CheckedChanged(object sender, EventArgs e)
        {
            if(Opt_P.Checked)
            grp_pat.Enabled = true;
            else
            grp_pat.Enabled = false;

        }

        private void Opt_C_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_C.Checked)
                grp_cad.Enabled = true;
            else
                grp_cad.Enabled = false;
        }

        private void Opt_O_CheckedChanged(object sender, EventArgs e)
        {
            if (Opt_O.Checked)
                Grp_Ouv.Enabled = true;
            else
                Grp_Ouv.Enabled = false;
        }

        private void Btn_ListEmp_Click(object sender, EventArgs e)
        {
            ListEmp f = new ListEmp();

            f.ShowDialog();


        }
    }
}
