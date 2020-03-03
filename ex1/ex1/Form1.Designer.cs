namespace ex1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Btn_Supp = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Txt_Note = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_Vider = new System.Windows.Forms.Button();
            this.Btn_Inverser = new System.Windows.Forms.Button();
            this.Btn_Trier = new System.Windows.Forms.Button();
            this.Lst_Int = new System.Windows.Forms.ListBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Rech = new System.Windows.Forms.Button();
            this.Txt_Rech = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.Rdb_Sup_10 = new System.Windows.Forms.RadioButton();
            this.Rdb_Egal_10 = new System.Windows.Forms.RadioButton();
            this.Rdb_Inf_10 = new System.Windows.Forms.RadioButton();
            this.Btn_Supp_Tous = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox5);
            this.groupBox1.Controls.Add(this.groupBox4);
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Location = new System.Drawing.Point(13, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 419);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "action sur la liste";
            // 
            // Btn_Supp
            // 
            this.Btn_Supp.Location = new System.Drawing.Point(177, 65);
            this.Btn_Supp.Name = "Btn_Supp";
            this.Btn_Supp.Size = new System.Drawing.Size(104, 39);
            this.Btn_Supp.TabIndex = 3;
            this.Btn_Supp.Text = "supprimer element séléct";
            this.Btn_Supp.UseVisualStyleBackColor = true;
            this.Btn_Supp.Click += new System.EventHandler(this.Btn_Supp_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Location = new System.Drawing.Point(31, 66);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(126, 39);
            this.Btn_Ajout.TabIndex = 2;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Txt_Note
            // 
            this.Txt_Note.Location = new System.Drawing.Point(102, 30);
            this.Txt_Note.Name = "Txt_Note";
            this.Txt_Note.Size = new System.Drawing.Size(180, 20);
            this.Txt_Note.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 32);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "saisie une note";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_Vider);
            this.groupBox2.Controls.Add(this.Btn_Inverser);
            this.groupBox2.Controls.Add(this.Btn_Trier);
            this.groupBox2.Controls.Add(this.Lst_Int);
            this.groupBox2.Location = new System.Drawing.Point(385, 18);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(180, 418);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "liste d\'entier";
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Location = new System.Drawing.Point(34, 392);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Size = new System.Drawing.Size(113, 20);
            this.Btn_Vider.TabIndex = 3;
            this.Btn_Vider.Text = "vider";
            this.Btn_Vider.UseVisualStyleBackColor = true;
            this.Btn_Vider.Click += new System.EventHandler(this.Btn_Vider_Click);
            // 
            // Btn_Inverser
            // 
            this.Btn_Inverser.Location = new System.Drawing.Point(32, 363);
            this.Btn_Inverser.Name = "Btn_Inverser";
            this.Btn_Inverser.Size = new System.Drawing.Size(115, 23);
            this.Btn_Inverser.TabIndex = 2;
            this.Btn_Inverser.Text = "inverser";
            this.Btn_Inverser.UseVisualStyleBackColor = true;
            this.Btn_Inverser.Click += new System.EventHandler(this.Btn_Inverser_Click);
            // 
            // Btn_Trier
            // 
            this.Btn_Trier.Location = new System.Drawing.Point(34, 331);
            this.Btn_Trier.Name = "Btn_Trier";
            this.Btn_Trier.Size = new System.Drawing.Size(113, 26);
            this.Btn_Trier.TabIndex = 1;
            this.Btn_Trier.Text = "trier";
            this.Btn_Trier.UseVisualStyleBackColor = true;
            this.Btn_Trier.Click += new System.EventHandler(this.Btn_Trier_Click);
            // 
            // Lst_Int
            // 
            this.Lst_Int.FormattingEnabled = true;
            this.Lst_Int.Location = new System.Drawing.Point(16, 33);
            this.Lst_Int.Name = "Lst_Int";
            this.Lst_Int.Size = new System.Drawing.Size(148, 277);
            this.Lst_Int.TabIndex = 0;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Btn_Supp);
            this.groupBox3.Controls.Add(this.Btn_Ajout);
            this.groupBox3.Controls.Add(this.Txt_Note);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(6, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(317, 118);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            // 
            // Btn_Rech
            // 
            this.Btn_Rech.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Rech.Location = new System.Drawing.Point(189, 15);
            this.Btn_Rech.Name = "Btn_Rech";
            this.Btn_Rech.Size = new System.Drawing.Size(111, 28);
            this.Btn_Rech.TabIndex = 5;
            this.Btn_Rech.Text = "Rechercher";
            this.Btn_Rech.UseVisualStyleBackColor = true;
            this.Btn_Rech.Click += new System.EventHandler(this.Btn_Rech_Click);
            // 
            // Txt_Rech
            // 
            this.Txt_Rech.Location = new System.Drawing.Point(14, 20);
            this.Txt_Rech.Name = "Txt_Rech";
            this.Txt_Rech.Size = new System.Drawing.Size(164, 20);
            this.Txt_Rech.TabIndex = 6;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.Txt_Rech);
            this.groupBox4.Controls.Add(this.Btn_Rech);
            this.groupBox4.Location = new System.Drawing.Point(6, 152);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(317, 79);
            this.groupBox4.TabIndex = 7;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "chercher un valeur";
            // 
            // Rdb_Sup_10
            // 
            this.Rdb_Sup_10.AutoSize = true;
            this.Rdb_Sup_10.Location = new System.Drawing.Point(21, 22);
            this.Rdb_Sup_10.Name = "Rdb_Sup_10";
            this.Rdb_Sup_10.Size = new System.Drawing.Size(43, 17);
            this.Rdb_Sup_10.TabIndex = 8;
            this.Rdb_Sup_10.TabStop = true;
            this.Rdb_Sup_10.Text = ">10";
            this.Rdb_Sup_10.UseVisualStyleBackColor = true;
            // 
            // Rdb_Egal_10
            // 
            this.Rdb_Egal_10.AutoSize = true;
            this.Rdb_Egal_10.Location = new System.Drawing.Point(103, 19);
            this.Rdb_Egal_10.Name = "Rdb_Egal_10";
            this.Rdb_Egal_10.Size = new System.Drawing.Size(43, 17);
            this.Rdb_Egal_10.TabIndex = 9;
            this.Rdb_Egal_10.TabStop = true;
            this.Rdb_Egal_10.Text = "=10";
            this.Rdb_Egal_10.UseVisualStyleBackColor = true;
            // 
            // Rdb_Inf_10
            // 
            this.Rdb_Inf_10.AutoSize = true;
            this.Rdb_Inf_10.Location = new System.Drawing.Point(198, 19);
            this.Rdb_Inf_10.Name = "Rdb_Inf_10";
            this.Rdb_Inf_10.Size = new System.Drawing.Size(43, 17);
            this.Rdb_Inf_10.TabIndex = 10;
            this.Rdb_Inf_10.TabStop = true;
            this.Rdb_Inf_10.Text = "<10";
            this.Rdb_Inf_10.UseVisualStyleBackColor = true;
            // 
            // Btn_Supp_Tous
            // 
            this.Btn_Supp_Tous.Location = new System.Drawing.Point(157, 51);
            this.Btn_Supp_Tous.Name = "Btn_Supp_Tous";
            this.Btn_Supp_Tous.Size = new System.Drawing.Size(123, 34);
            this.Btn_Supp_Tous.TabIndex = 11;
            this.Btn_Supp_Tous.Text = "supprimer Tous";
            this.Btn_Supp_Tous.UseVisualStyleBackColor = true;
            this.Btn_Supp_Tous.Click += new System.EventHandler(this.Btn_Supp_Tous_Click);
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Btn_Supp_Tous);
            this.groupBox5.Controls.Add(this.Rdb_Inf_10);
            this.groupBox5.Controls.Add(this.Rdb_Egal_10);
            this.groupBox5.Controls.Add(this.Rdb_Sup_10);
            this.groupBox5.Location = new System.Drawing.Point(6, 251);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(316, 105);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "suppression avec condition";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(581, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button Btn_Supp;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.TextBox Txt_Note;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Btn_Vider;
        private System.Windows.Forms.Button Btn_Inverser;
        private System.Windows.Forms.Button Btn_Trier;
        private System.Windows.Forms.ListBox Lst_Int;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.TextBox Txt_Rech;
        private System.Windows.Forms.Button Btn_Rech;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button Btn_Supp_Tous;
        private System.Windows.Forms.RadioButton Rdb_Inf_10;
        private System.Windows.Forms.RadioButton Rdb_Egal_10;
        private System.Windows.Forms.RadioButton Rdb_Sup_10;
    }
}

