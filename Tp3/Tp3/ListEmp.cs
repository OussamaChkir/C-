using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Tp3
{
    public partial class ListEmp : Form
    {
        public ListEmp()
        {
            InitializeComponent();
            Dg_Patron.Visible = false;
            Dg_Cadre.Visible = false;
            Dg_Ouvrier.Visible = false;
        }

        private void Opt_P_CheckedChanged(object sender, EventArgs e)
        {
            
            Dg_Patron.Visible = true;
            Dg_Cadre.Visible = false;
            Dg_Ouvrier.Visible = false;
            for (int i=0; i < Form1.listPatron.Count; i++)
            {
                Dg_Patron.Rows.Add(Form1.listPatron.ElementAt(i).Matricule, Form1.listPatron.ElementAt(i).Nom, Form1.listPatron.ElementAt(i).Prenom, Form1.listPatron.ElementAt(i).Datenaissance, Form1.listPatron.ElementAt(i).ca, Form1.listPatron.ElementAt(i).pourcentage, Form1.listPatron.ElementAt(i).GetSalaire());
            }
        }

        private void Opt_C_CheckedChanged(object sender, EventArgs e)
        {
            Dg_Cadre.Visible = true;
            Dg_Patron.Visible = false;
            Dg_Ouvrier.Visible = false;
            for (int i = 0; i < Form1.listCadre.Count; i++)
            {
                Dg_Cadre.Rows.Add(Form1.listCadre.ElementAt(i).Matricule, Form1.listCadre.ElementAt(i).Nom, Form1.listCadre.ElementAt(i).Prenom, Form1.listCadre.ElementAt(i).Datenaissance, Form1.listCadre.ElementAt(i).index, Form1.listCadre.ElementAt(i).GetSalaire());
            }
        }

        private void Opt_O_CheckedChanged(object sender, EventArgs e)
        {
            Dg_Ouvrier.Visible = true;
            Dg_Cadre.Visible = false;
            Dg_Patron.Visible = false;
            for (int i = 0; i < Form1.listOuvrier.Count; i++)
            {
                Dg_Ouvrier.Rows.Add(Form1.listOuvrier.ElementAt(i).Matricule, Form1.listOuvrier.ElementAt(i).Nom, Form1.listOuvrier.ElementAt(i).Prenom, Form1.listOuvrier.ElementAt(i).Datenaissance, Form1.listOuvrier.ElementAt(i).dateEnt, Form1.listOuvrier.ElementAt(i).GetSalaire());
            }
        }
    }
}
