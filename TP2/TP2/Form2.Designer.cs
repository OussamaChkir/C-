namespace TP2
{
    partial class FCompte
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
            this.Btn_Valid = new System.Windows.Forms.Button();
            this.Txtsolde = new System.Windows.Forms.TextBox();
            this.Txttitulaire = new System.Windows.Forms.TextBox();
            this.Txtnumcompte = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Valid);
            this.groupBox1.Controls.Add(this.Txtsolde);
            this.groupBox1.Controls.Add(this.Txttitulaire);
            this.groupBox1.Controls.Add(this.Txtnumcompte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(13, 15);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(353, 234);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Création Nouveau Compte";
            // 
            // Btn_Valid
            // 
            this.Btn_Valid.Location = new System.Drawing.Point(179, 185);
            this.Btn_Valid.Name = "Btn_Valid";
            this.Btn_Valid.Size = new System.Drawing.Size(111, 23);
            this.Btn_Valid.TabIndex = 6;
            this.Btn_Valid.Text = "Valider";
            this.Btn_Valid.UseVisualStyleBackColor = true;
            this.Btn_Valid.Click += new System.EventHandler(this.Btn_Valid_Click);
            // 
            // Txtsolde
            // 
            this.Txtsolde.Location = new System.Drawing.Point(151, 139);
            this.Txtsolde.Name = "Txtsolde";
            this.Txtsolde.Size = new System.Drawing.Size(163, 20);
            this.Txtsolde.TabIndex = 5;
            // 
            // Txttitulaire
            // 
            this.Txttitulaire.Location = new System.Drawing.Point(151, 97);
            this.Txttitulaire.Name = "Txttitulaire";
            this.Txttitulaire.Size = new System.Drawing.Size(163, 20);
            this.Txttitulaire.TabIndex = 4;
            // 
            // Txtnumcompte
            // 
            this.Txtnumcompte.Location = new System.Drawing.Point(151, 53);
            this.Txtnumcompte.Name = "Txtnumcompte";
            this.Txtnumcompte.Size = new System.Drawing.Size(163, 20);
            this.Txtnumcompte.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(50, 143);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 2;
            this.label3.Text = "Solde";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(37, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Titulaire";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(37, 53);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Numéro";
            // 
            // FCompte
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 259);
            this.Controls.Add(this.groupBox1);
            this.Name = "FCompte";
            this.Text = "FCompte";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txtsolde;
        private System.Windows.Forms.TextBox Txttitulaire;
        private System.Windows.Forms.TextBox Txtnumcompte;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn_Valid;
    }
}