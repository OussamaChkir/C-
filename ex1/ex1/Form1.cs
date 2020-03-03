using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex1
{
    public partial class Form1 : Form
    {
        List<float> LIST_Int = new List<float>();
        public Form1()
        {
            InitializeComponent();
        }
        void affiche()
        {
            for (int i = 0; i < LIST_Int.Count; i++)
            {
                Lst_Int.Items.Remove(LIST_Int.ElementAt(i));
                Lst_Int.Items.Add(LIST_Int.ElementAt(i));


            }
        }

        private void Btn_Ajout_Click(object sender, EventArgs e)
        {
            if (String.IsNullOrEmpty(Txt_Note.Text))
                MessageBox.Show("the note box is empty");
            else
            {
                float note = float.Parse(Txt_Note.Text);
                LIST_Int.Add(note);
                affiche();
            }
        }

        private void Btn_Supp_Click(object sender, EventArgs e)
        {
            int current =Lst_Int.SelectedIndex;
            LIST_Int.RemoveAt(current);
            Lst_Int.Items.RemoveAt(current);
            
        }

        private void Btn_Trier_Click(object sender, EventArgs e)
        {
            LIST_Int.Sort();
            affiche();
        }

        private void Btn_Inverser_Click(object sender, EventArgs e)
        {
            LIST_Int.Reverse();
            affiche();
        }

        private void Btn_Vider_Click(object sender, EventArgs e)
        {
            LIST_Int.Clear();
            affiche();
        }

        private void Btn_Rech_Click(object sender, EventArgs e)
        {
           

            if (String.IsNullOrEmpty(Txt_Note.Text))
                MessageBox.Show("the note box is empty");
            else{
                float value = float.Parse(Txt_Rech.Text);
                int i=0;
                while (i < LIST_Int.Count()+1)
                {
                    if (LIST_Int.ElementAt(i).Equals(value))
                    {
                        MessageBox.Show("elemnet rechercher est: "+value);
                        break;
                    }else if(i>LIST_Int.Count()){
                        MessageBox.Show("aucun element trouver ");
                        break;
                    }
                    else
                    {
                        i++;
                    }

                }

                }

        }

        private void Btn_Supp_Tous_Click(object sender, EventArgs e)
        {
            if(!Rdb_Sup_10.Checked && !Rdb_Egal_10.Checked && !Rdb_Inf_10.Checked)
            {
                MessageBox.Show("please choose an option");
            }
            else 
            {
                for(int i = 0; i < LIST_Int.Count; i++)
                {
                    if (Rdb_Sup_10.Checked && LIST_Int.ElementAt(i) > 10) { 

                        LIST_Int.RemoveAt(i);
                        Lst_Int.Items.RemoveAt(i);
                    }
                    else if (Rdb_Inf_10.Checked && LIST_Int.ElementAt(i) < 10)
                    { LIST_Int.RemoveAt(i);
                        Lst_Int.Items.RemoveAt(i);
                    }
                    else if (Rdb_Egal_10.Checked && LIST_Int.ElementAt(i)== 10)
                    { LIST_Int.RemoveAt(i);
                        Lst_Int.Items.RemoveAt(i);
                    }
                }    
                

                
            }
        }
    }
}
