using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ex2
{
    public partial class Form1 : Form
    {
        Queue<int> QVolailles = new Queue<int>();
        Queue<int> QViandes = new Queue<int>();
        int Tick_Vol = 1;
        int Tick_Viand = 1;
        public Form1()
        {
            InitializeComponent();
        }
       void Afficher_Volailles()
        {
            for (int i = 0; i < QVolailles.Count; i++)
            {
                Lst_Volailles.Items.Remove(QVolailles.ElementAt(i));
                Lst_Volailles.Items.Add(QVolailles.ElementAt(i));


            }
        }
        void Afficher_Viandes()
        {
            for (int i = 0; i < QViandes.Count; i++)
            {
                Lst_Viandes.Items.Remove(QViandes.ElementAt(i));
                Lst_Viandes.Items.Add(QViandes.ElementAt(i));


            }
        }

        private void Btn_Tirer_Click(object sender, EventArgs e)
        {
            if(!Rdb_Volailles.Checked && !Rdb_Viandes.Checked)
            {
                MessageBox.Show("please choose your ticket");
            }else if (Rdb_Volailles.Checked)
            {
                QVolailles.Enqueue(Tick_Vol);
                Tick_Vol++;
                Afficher_Volailles();
            }
            else
            {
                QViandes.Enqueue(Tick_Viand);
                Tick_Viand++;
                Afficher_Viandes();
            }
        }

        private void Btn_Serv_Volail_Click(object sender, EventArgs e)
        {
            if (Lst_Volailles.Items.Count>0)
            {
                QVolailles.Dequeue();
                Lst_Volailles.Items.RemoveAt(0);
                
            }
            else
                MessageBox.Show("La liste est vide");
        }

        private void Btn_Serv_Viande_Click(object sender, EventArgs e)
        {
            if (Lst_Viandes.Items.Count>0) {
                QViandes.Dequeue();
                Lst_Viandes.Items.RemoveAt(0);
                
            } else
                MessageBox.Show("la liste est vide");
        }
    }
}
