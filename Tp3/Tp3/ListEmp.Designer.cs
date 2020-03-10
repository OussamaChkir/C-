namespace Tp3
{
    partial class ListEmp
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
            this.Opt_P = new System.Windows.Forms.RadioButton();
            this.Opt_C = new System.Windows.Forms.RadioButton();
            this.Opt_O = new System.Windows.Forms.RadioButton();
            this.Dg_Patron = new System.Windows.Forms.DataGridView();
            this.Matricule = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prénom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DateNaiss = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ChiffAff = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Pour = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dg_Cadre = new System.Windows.Forms.DataGridView();
            this.Matricule1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatNaiss1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Indice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Dg_Ouvrier = new System.Windows.Forms.DataGridView();
            this.Matricule2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Prenom2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatNaiss2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DatEnt = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Salaire2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Patron)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Cadre)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Ouvrier)).BeginInit();
            this.SuspendLayout();
            // 
            // Opt_P
            // 
            this.Opt_P.AutoSize = true;
            this.Opt_P.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_P.Location = new System.Drawing.Point(166, 48);
            this.Opt_P.Name = "Opt_P";
            this.Opt_P.Size = new System.Drawing.Size(67, 19);
            this.Opt_P.TabIndex = 0;
            this.Opt_P.TabStop = true;
            this.Opt_P.Text = "Patron";
            this.Opt_P.UseVisualStyleBackColor = true;
            this.Opt_P.CheckedChanged += new System.EventHandler(this.Opt_P_CheckedChanged);
            // 
            // Opt_C
            // 
            this.Opt_C.AutoSize = true;
            this.Opt_C.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_C.Location = new System.Drawing.Point(323, 48);
            this.Opt_C.Name = "Opt_C";
            this.Opt_C.Size = new System.Drawing.Size(63, 19);
            this.Opt_C.TabIndex = 1;
            this.Opt_C.TabStop = true;
            this.Opt_C.Text = "Cadre";
            this.Opt_C.UseVisualStyleBackColor = true;
            this.Opt_C.CheckedChanged += new System.EventHandler(this.Opt_C_CheckedChanged);
            // 
            // Opt_O
            // 
            this.Opt_O.AutoSize = true;
            this.Opt_O.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Opt_O.Location = new System.Drawing.Point(484, 48);
            this.Opt_O.Name = "Opt_O";
            this.Opt_O.Size = new System.Drawing.Size(71, 19);
            this.Opt_O.TabIndex = 2;
            this.Opt_O.TabStop = true;
            this.Opt_O.Text = "Ouvrier";
            this.Opt_O.UseVisualStyleBackColor = true;
            this.Opt_O.CheckedChanged += new System.EventHandler(this.Opt_O_CheckedChanged);
            // 
            // Dg_Patron
            // 
            this.Dg_Patron.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Patron.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule,
            this.Nom,
            this.Prénom,
            this.DateNaiss,
            this.ChiffAff,
            this.Pour,
            this.Salaire});
            this.Dg_Patron.Location = new System.Drawing.Point(12, 103);
            this.Dg_Patron.Name = "Dg_Patron";
            this.Dg_Patron.Size = new System.Drawing.Size(737, 186);
            this.Dg_Patron.TabIndex = 3;
            this.Dg_Patron.Visible = false;
            // 
            // Matricule
            // 
            this.Matricule.HeaderText = "Matricule";
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
            // DateNaiss
            // 
            this.DateNaiss.HeaderText = "DateNaissance";
            this.DateNaiss.Name = "DateNaiss";
            // 
            // ChiffAff
            // 
            this.ChiffAff.HeaderText = "Chiffre Affaire";
            this.ChiffAff.Name = "ChiffAff";
            // 
            // Pour
            // 
            this.Pour.HeaderText = "Pourcentage";
            this.Pour.Name = "Pour";
            // 
            // Salaire
            // 
            this.Salaire.HeaderText = "Salaire";
            this.Salaire.Name = "Salaire";
            // 
            // Dg_Cadre
            // 
            this.Dg_Cadre.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Cadre.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule1,
            this.Nom1,
            this.Prenom1,
            this.DatNaiss1,
            this.Indice,
            this.Salaire1});
            this.Dg_Cadre.Location = new System.Drawing.Point(12, 103);
            this.Dg_Cadre.Name = "Dg_Cadre";
            this.Dg_Cadre.Size = new System.Drawing.Size(737, 185);
            this.Dg_Cadre.TabIndex = 4;
            // 
            // Matricule1
            // 
            this.Matricule1.HeaderText = "Matricule";
            this.Matricule1.Name = "Matricule1";
            // 
            // Nom1
            // 
            this.Nom1.HeaderText = "Nom";
            this.Nom1.Name = "Nom1";
            // 
            // Prenom1
            // 
            this.Prenom1.HeaderText = "Prenom";
            this.Prenom1.Name = "Prenom1";
            // 
            // DatNaiss1
            // 
            this.DatNaiss1.HeaderText = "DatNaiss";
            this.DatNaiss1.Name = "DatNaiss1";
            // 
            // Indice
            // 
            this.Indice.HeaderText = "Indice";
            this.Indice.Name = "Indice";
            // 
            // Salaire1
            // 
            this.Salaire1.HeaderText = "Salaire";
            this.Salaire1.Name = "Salaire1";
            // 
            // Dg_Ouvrier
            // 
            this.Dg_Ouvrier.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Ouvrier.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Matricule2,
            this.Nom2,
            this.Prenom2,
            this.DatNaiss2,
            this.DatEnt,
            this.Salaire2});
            this.Dg_Ouvrier.Location = new System.Drawing.Point(12, 103);
            this.Dg_Ouvrier.Name = "Dg_Ouvrier";
            this.Dg_Ouvrier.Size = new System.Drawing.Size(737, 185);
            this.Dg_Ouvrier.TabIndex = 5;
            this.Dg_Ouvrier.Visible = false;
            // 
            // Matricule2
            // 
            this.Matricule2.HeaderText = "Matricule";
            this.Matricule2.Name = "Matricule2";
            // 
            // Nom2
            // 
            this.Nom2.HeaderText = "Nom";
            this.Nom2.Name = "Nom2";
            // 
            // Prenom2
            // 
            this.Prenom2.HeaderText = "Prenom";
            this.Prenom2.Name = "Prenom2";
            // 
            // DatNaiss2
            // 
            this.DatNaiss2.HeaderText = "DatNaiss";
            this.DatNaiss2.Name = "DatNaiss2";
            // 
            // DatEnt
            // 
            this.DatEnt.HeaderText = "Dat Entrée";
            this.DatEnt.Name = "DatEnt";
            // 
            // Salaire2
            // 
            this.Salaire2.HeaderText = "Salaire";
            this.Salaire2.Name = "Salaire2";
            // 
            // ListEmp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 315);
            this.Controls.Add(this.Dg_Ouvrier);
            this.Controls.Add(this.Dg_Cadre);
            this.Controls.Add(this.Dg_Patron);
            this.Controls.Add(this.Opt_O);
            this.Controls.Add(this.Opt_C);
            this.Controls.Add(this.Opt_P);
            this.Name = "ListEmp";
            this.Text = "ListEmp";
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Patron)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Cadre)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Ouvrier)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton Opt_P;
        private System.Windows.Forms.RadioButton Opt_C;
        private System.Windows.Forms.RadioButton Opt_O;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prénom;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateNaiss;
        private System.Windows.Forms.DataGridViewTextBoxColumn ChiffAff;
        private System.Windows.Forms.DataGridViewTextBoxColumn Pour;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom1;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatNaiss1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Indice;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Matricule2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Prenom2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatNaiss2;
        private System.Windows.Forms.DataGridViewTextBoxColumn DatEnt;
        private System.Windows.Forms.DataGridViewTextBoxColumn Salaire2;
        public System.Windows.Forms.DataGridView Dg_Ouvrier;
        public System.Windows.Forms.DataGridView Dg_Patron;
        public System.Windows.Forms.DataGridView Dg_Cadre;
    }
}