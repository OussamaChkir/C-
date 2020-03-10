namespace Tp3
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Mat = new System.Windows.Forms.TextBox();
            this.Txt_Nom = new System.Windows.Forms.TextBox();
            this.Txt_Pren = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Dat_Nais = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Grp_Ouv = new System.Windows.Forms.GroupBox();
            this.Dat_Ent = new System.Windows.Forms.DateTimePicker();
            this.label8 = new System.Windows.Forms.Label();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.grp_cad = new System.Windows.Forms.GroupBox();
            this.Ind4 = new System.Windows.Forms.RadioButton();
            this.Ind3 = new System.Windows.Forms.RadioButton();
            this.Ind2 = new System.Windows.Forms.RadioButton();
            this.Ind1 = new System.Windows.Forms.RadioButton();
            this.label7 = new System.Windows.Forms.Label();
            this.grp_pat = new System.Windows.Forms.GroupBox();
            this.Txt_Pour = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txt_CA = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Opt_O = new System.Windows.Forms.RadioButton();
            this.Opt_C = new System.Windows.Forms.RadioButton();
            this.Opt_P = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Btn_ListEmp = new System.Windows.Forms.Button();
            this.Dg_Emp = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatedeNaissance = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            this.Grp_Ouv.SuspendLayout();
            this.grp_cad.SuspendLayout();
            this.grp_pat.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Emp)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "Matricule";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(13, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 15);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nom";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 122);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 15);
            this.label3.TabIndex = 2;
            this.label3.Text = "Prenom";
            // 
            // Txt_Mat
            // 
            this.Txt_Mat.Location = new System.Drawing.Point(86, 65);
            this.Txt_Mat.Name = "Txt_Mat";
            this.Txt_Mat.Size = new System.Drawing.Size(100, 21);
            this.Txt_Mat.TabIndex = 3;
            // 
            // Txt_Nom
            // 
            this.Txt_Nom.Location = new System.Drawing.Point(86, 91);
            this.Txt_Nom.Name = "Txt_Nom";
            this.Txt_Nom.Size = new System.Drawing.Size(100, 21);
            this.Txt_Nom.TabIndex = 4;
            // 
            // Txt_Pren
            // 
            this.Txt_Pren.Location = new System.Drawing.Point(86, 117);
            this.Txt_Pren.Name = "Txt_Pren";
            this.Txt_Pren.Size = new System.Drawing.Size(100, 21);
            this.Txt_Pren.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(5, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 36);
            this.label4.TabIndex = 6;
            this.label4.Text = "Date de Naissance";
            // 
            // Dat_Nais
            // 
            this.Dat_Nais.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dat_Nais.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Nais.Location = new System.Drawing.Point(86, 154);
            this.Dat_Nais.Name = "Dat_Nais";
            this.Dat_Nais.Size = new System.Drawing.Size(100, 21);
            this.Dat_Nais.TabIndex = 7;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Grp_Ouv);
            this.groupBox1.Controls.Add(this.Btn_Ajout);
            this.groupBox1.Controls.Add(this.grp_cad);
            this.groupBox1.Controls.Add(this.grp_pat);
            this.groupBox1.Controls.Add(this.Opt_O);
            this.groupBox1.Controls.Add(this.Opt_C);
            this.groupBox1.Controls.Add(this.Opt_P);
            this.groupBox1.Controls.Add(this.Dat_Nais);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.Txt_Pren);
            this.groupBox1.Controls.Add(this.Txt_Nom);
            this.groupBox1.Controls.Add(this.Txt_Mat);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 18);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(727, 195);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Employé";
            // 
            // Grp_Ouv
            // 
            this.Grp_Ouv.Controls.Add(this.Dat_Ent);
            this.Grp_Ouv.Controls.Add(this.label8);
            this.Grp_Ouv.Location = new System.Drawing.Point(561, 65);
            this.Grp_Ouv.Name = "Grp_Ouv";
            this.Grp_Ouv.Size = new System.Drawing.Size(152, 85);
            this.Grp_Ouv.TabIndex = 25;
            this.Grp_Ouv.TabStop = false;
            // 
            // Dat_Ent
            // 
            this.Dat_Ent.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dat_Ent.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Ent.Location = new System.Drawing.Point(21, 48);
            this.Dat_Ent.Name = "Dat_Ent";
            this.Dat_Ent.Size = new System.Drawing.Size(114, 21);
            this.Dat_Ent.TabIndex = 23;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(18, 17);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(94, 15);
            this.label8.TabIndex = 22;
            this.label8.Text = "Date d\'entrée";
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout.Location = new System.Drawing.Point(561, 155);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(152, 35);
            this.Btn_Ajout.TabIndex = 24;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // grp_cad
            // 
            this.grp_cad.Controls.Add(this.Ind4);
            this.grp_cad.Controls.Add(this.Ind3);
            this.grp_cad.Controls.Add(this.Ind2);
            this.grp_cad.Controls.Add(this.Ind1);
            this.grp_cad.Controls.Add(this.label7);
            this.grp_cad.Location = new System.Drawing.Point(423, 65);
            this.grp_cad.Name = "grp_cad";
            this.grp_cad.Size = new System.Drawing.Size(112, 124);
            this.grp_cad.TabIndex = 21;
            this.grp_cad.TabStop = false;
            // 
            // Ind4
            // 
            this.Ind4.AutoSize = true;
            this.Ind4.Location = new System.Drawing.Point(19, 95);
            this.Ind4.Name = "Ind4";
            this.Ind4.Size = new System.Drawing.Size(33, 19);
            this.Ind4.TabIndex = 20;
            this.Ind4.TabStop = true;
            this.Ind4.Text = "4";
            this.Ind4.UseVisualStyleBackColor = true;
            // 
            // Ind3
            // 
            this.Ind3.AutoSize = true;
            this.Ind3.Location = new System.Drawing.Point(19, 72);
            this.Ind3.Name = "Ind3";
            this.Ind3.Size = new System.Drawing.Size(33, 19);
            this.Ind3.TabIndex = 19;
            this.Ind3.TabStop = true;
            this.Ind3.Text = "3";
            this.Ind3.UseVisualStyleBackColor = true;
            // 
            // Ind2
            // 
            this.Ind2.AutoSize = true;
            this.Ind2.Location = new System.Drawing.Point(19, 49);
            this.Ind2.Name = "Ind2";
            this.Ind2.Size = new System.Drawing.Size(33, 19);
            this.Ind2.TabIndex = 18;
            this.Ind2.TabStop = true;
            this.Ind2.Text = "2";
            this.Ind2.UseVisualStyleBackColor = true;
            // 
            // Ind1
            // 
            this.Ind1.AutoSize = true;
            this.Ind1.Location = new System.Drawing.Point(19, 27);
            this.Ind1.Name = "Ind1";
            this.Ind1.Size = new System.Drawing.Size(33, 19);
            this.Ind1.TabIndex = 17;
            this.Ind1.TabStop = true;
            this.Ind1.Text = "1";
            this.Ind1.UseVisualStyleBackColor = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(16, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 16;
            this.label7.Text = "Indice";
            // 
            // grp_pat
            // 
            this.grp_pat.Controls.Add(this.Txt_Pour);
            this.grp_pat.Controls.Add(this.label6);
            this.grp_pat.Controls.Add(this.Txt_CA);
            this.grp_pat.Controls.Add(this.label5);
            this.grp_pat.Location = new System.Drawing.Point(271, 65);
            this.grp_pat.Name = "grp_pat";
            this.grp_pat.Size = new System.Drawing.Size(138, 125);
            this.grp_pat.TabIndex = 15;
            this.grp_pat.TabStop = false;
            // 
            // Txt_Pour
            // 
            this.Txt_Pour.Location = new System.Drawing.Point(19, 89);
            this.Txt_Pour.Name = "Txt_Pour";
            this.Txt_Pour.Size = new System.Drawing.Size(100, 21);
            this.Txt_Pour.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(16, 71);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(88, 15);
            this.label6.TabIndex = 13;
            this.label6.Text = "Pourcentage";
            // 
            // Txt_CA
            // 
            this.Txt_CA.Location = new System.Drawing.Point(16, 41);
            this.Txt_CA.Name = "Txt_CA";
            this.Txt_CA.Size = new System.Drawing.Size(100, 21);
            this.Txt_CA.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(13, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(106, 15);
            this.label5.TabIndex = 11;
            this.label5.Text = "Chiffre d\'affaire";
            // 
            // Opt_O
            // 
            this.Opt_O.AutoSize = true;
            this.Opt_O.Location = new System.Drawing.Point(567, 32);
            this.Opt_O.Name = "Opt_O";
            this.Opt_O.Size = new System.Drawing.Size(71, 19);
            this.Opt_O.TabIndex = 10;
            this.Opt_O.TabStop = true;
            this.Opt_O.Text = "Ouvrier";
            this.Opt_O.UseVisualStyleBackColor = true;
            this.Opt_O.CheckedChanged += new System.EventHandler(this.Opt_O_CheckedChanged);
            // 
            // Opt_C
            // 
            this.Opt_C.AutoSize = true;
            this.Opt_C.Location = new System.Drawing.Point(464, 32);
            this.Opt_C.Name = "Opt_C";
            this.Opt_C.Size = new System.Drawing.Size(63, 19);
            this.Opt_C.TabIndex = 9;
            this.Opt_C.TabStop = true;
            this.Opt_C.Text = "Cadre";
            this.Opt_C.UseVisualStyleBackColor = true;
            this.Opt_C.CheckedChanged += new System.EventHandler(this.Opt_C_CheckedChanged);
            // 
            // Opt_P
            // 
            this.Opt_P.AutoSize = true;
            this.Opt_P.Location = new System.Drawing.Point(353, 32);
            this.Opt_P.Name = "Opt_P";
            this.Opt_P.Size = new System.Drawing.Size(67, 19);
            this.Opt_P.TabIndex = 8;
            this.Opt_P.TabStop = true;
            this.Opt_P.Text = "Patron";
            this.Opt_P.UseVisualStyleBackColor = true;
            this.Opt_P.CheckedChanged += new System.EventHandler(this.Opt_P_CheckedChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Btn_ListEmp);
            this.groupBox2.Controls.Add(this.Dg_Emp);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(14, 219);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(724, 220);
            this.groupBox2.TabIndex = 9;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Employés";
            // 
            // Btn_ListEmp
            // 
            this.Btn_ListEmp.Location = new System.Drawing.Point(263, 189);
            this.Btn_ListEmp.Name = "Btn_ListEmp";
            this.Btn_ListEmp.Size = new System.Drawing.Size(177, 30);
            this.Btn_ListEmp.TabIndex = 1;
            this.Btn_ListEmp.Text = "Liste des Employés";
            this.Btn_ListEmp.UseVisualStyleBackColor = true;
            this.Btn_ListEmp.Click += new System.EventHandler(this.Btn_ListEmp_Click);
            // 
            // Dg_Emp
            // 
            this.Dg_Emp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Emp.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prénom,
            this.DatedeNaissance,
            this.Salaire});
            this.Dg_Emp.Location = new System.Drawing.Point(17, 24);
            this.Dg_Emp.Name = "Dg_Emp";
            this.Dg_Emp.Size = new System.Drawing.Size(693, 155);
            this.Dg_Emp.TabIndex = 0;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "matricule";
            this.Matricule.Name = "Matricule";
            // 
            // Nom
            // 
            this.Nom.HeaderText = "Nom";
            this.Nom.Name = "Nom";
            // 
            // Prénom
            // 
            this.Prénom.HeaderText = "Prénom";
            this.Prénom.Name = "Prénom";
            // 
            // DatedeNaissance
            // 
            this.DatedeNaissance.HeaderText = "DatedeNaissance";
            this.DatedeNaissance.Name = "DatedeNaissance";
            this.DatedeNaissance.Width = 150;
            // 
            // Salaire
            // 
            this.Salaire.HeaderText = "Salaire";
            this.Salaire.Name = "Salaire";
            this.Salaire.Width = 120;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(762, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Grp_Ouv.ResumeLayout(false);
            this.Grp_Ouv.PerformLayout();
            this.grp_cad.ResumeLayout(false);
            this.grp_cad.PerformLayout();
            this.grp_pat.ResumeLayout(false);
            this.grp_pat.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Emp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Mat;
        private System.Windows.Forms.TextBox Txt_Nom;
        private System.Windows.Forms.TextBox Txt_Pren;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DateTimePicker Dat_Nais;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton Opt_P;
        private System.Windows.Forms.RadioButton Opt_C;
        private System.Windows.Forms.RadioButton Opt_O;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txt_CA;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txt_Pour;
        private System.Windows.Forms.GroupBox grp_pat;
        private System.Windows.Forms.RadioButton Ind4;
        private System.Windows.Forms.RadioButton Ind3;
        private System.Windows.Forms.RadioButton Ind2;
        private System.Windows.Forms.RadioButton Ind1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox grp_cad;
        private System.Windows.Forms.GroupBox Grp_Ouv;
        private System.Windows.Forms.DateTimePicker Dat_Ent;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dg_Emp;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatedeNaissance;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire;
        private System.Windows.Forms.Button Btn_ListEmp;
    }
}

