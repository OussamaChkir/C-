using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex3
{
    public partial class Form1 : Form
    {
        Dictionary<string, string> Dict_Def = new Dictionary<string, string>();
        public Form1()
        {
            InitializeComponent();
        }
        void affiche()
        {
           Dg_Mot.Rows.Clear();
            //Dg_Mot.DataSource = (from d in Dict_Def orderby d.Value select new { d.Key, d.Value }).ToList();
            foreach(KeyValuePair<string, string> Mot_Syn in Dict_Def)
            {
                Dg_Mot.Rows.Add(Mot_Syn.Key, Mot_Syn.Value);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Txt_Mot.Clear();
            Txt_Def.Clear();
            Txt_Mot.Focus();
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {

            if (String.IsNullOrEmpty(Txt_Mot.Text) || String.IsNullOrEmpty(Txt_Def.Text))
                MessageBox.Show("erreur");
            else if (Dict_Def.ContainsKey(Txt_Mot.Text))
                MessageBox.Show("Mot existe déja");
            else
            {
                Dict_Def.Add(Txt_Mot.Text, Txt_Def.Text);
                affiche();
            }
        }

        private void Btn_Recherche_Click(object sender, EventArgs e)
        {
            
            if (String.IsNullOrEmpty(Txt_Mot.Text))
                MessageBox.Show("textBox vide");
            else
            {
                String val;
                 Dict_Def.TryGetValue(Txt_Mot.Text, out val);
                if (string.IsNullOrEmpty(val))
                    Txt_Def.Text = val;
                else
                    MessageBox.Show("Mot introuvable !!");
            }

        }

        private void Btn_Supprimer_Click(object sender, EventArgs e)
        {
           
            if (string.IsNullOrEmpty(Txt_Mot.Text)) { 
                Dict_Def.Remove(Txt_Mot.Text);
             affiche();
            }
            else
                MessageBox.Show("TextBox vide");
        }

        private void Btn_Vider_Click(object sender, EventArgs e)
        {
            Dict_Def.Clear();
            affiche();
        }

        private void Dg_Mot_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
