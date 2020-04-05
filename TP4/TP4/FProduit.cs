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
    public partial class FProduit : MetroFramework.Forms.MetroForm
    {
        public string TypeOP;
        public FProduit()
        {
            InitializeComponent();
           
        }

        private void metroButton1_Click(object sender, EventArgs e)
        {
            
            if (TypeOP == "A")
            {
                this.Text = "ajouter produit";
                Produit p = new Produit(Convert.ToInt32(Txt_Ref.Text),Txt_Desig.Text,Cmb_Categ.Text,Convert.ToInt64(Txt_Prix.Text),Convert.ToInt32(Txt_Qte.Text));
                
                ProduitDAO.Inserer(p);
                this.Close();
            }
            else
            {
                Produit p = new Produit(Convert.ToInt32(Txt_Ref.Text), Txt_Desig.Text, Cmb_Categ.Text, Convert.ToInt64(Txt_Prix.Text), Convert.ToInt32(Txt_Qte.Text));
                ProduitDAO.modifier(p);
                this.Close();

            }
        }
    }
}
