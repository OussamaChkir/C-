namespace ex3
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
            this.Txt_Mot = new System.Windows.Forms.TextBox();
            this.Txt_Def = new System.Windows.Forms.RichTextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.Btn_Ajout = new System.Windows.Forms.Button();
            this.Btn_Recherche = new System.Windows.Forms.Button();
            this.Btn_Supprimer = new System.Windows.Forms.Button();
            this.Btn_Vider = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Dg_Mot = new System.Windows.Forms.DataGridView();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Mot = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Def = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Mot)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(67, 38);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(41, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Mot :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(28, 69);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Définition :";
            // 
            // Txt_Mot
            // 
            this.Txt_Mot.Location = new System.Drawing.Point(124, 37);
            this.Txt_Mot.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Mot.Name = "Txt_Mot";
            this.Txt_Mot.Size = new System.Drawing.Size(153, 22);
            this.Txt_Mot.TabIndex = 2;
            // 
            // Txt_Def
            // 
            this.Txt_Def.Location = new System.Drawing.Point(120, 70);
            this.Txt_Def.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Def.Name = "Txt_Def";
            this.Txt_Def.Size = new System.Drawing.Size(300, 78);
            this.Txt_Def.TabIndex = 3;
            this.Txt_Def.Text = "";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(299, 35);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(121, 23);
            this.button1.TabIndex = 4;
            this.button1.Text = "Nouveau";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Ajout.Location = new System.Drawing.Point(494, 11);
            this.Btn_Ajout.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(107, 26);
            this.Btn_Ajout.TabIndex = 5;
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.UseVisualStyleBackColor = true;
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Recherche
            // 
            this.Btn_Recherche.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Recherche.Location = new System.Drawing.Point(494, 43);
            this.Btn_Recherche.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Recherche.Name = "Btn_Recherche";
            this.Btn_Recherche.Size = new System.Drawing.Size(107, 29);
            this.Btn_Recherche.TabIndex = 6;
            this.Btn_Recherche.Text = "Rechercher";
            this.Btn_Recherche.UseVisualStyleBackColor = true;
            this.Btn_Recherche.Click += new System.EventHandler(this.Btn_Recherche_Click);
            // 
            // Btn_Supprimer
            // 
            this.Btn_Supprimer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Supprimer.Location = new System.Drawing.Point(494, 78);
            this.Btn_Supprimer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Supprimer.Name = "Btn_Supprimer";
            this.Btn_Supprimer.Size = new System.Drawing.Size(107, 44);
            this.Btn_Supprimer.TabIndex = 7;
            this.Btn_Supprimer.Text = "Supprimer un mot";
            this.Btn_Supprimer.UseVisualStyleBackColor = true;
            this.Btn_Supprimer.Click += new System.EventHandler(this.Btn_Supprimer_Click);
            // 
            // Btn_Vider
            // 
            this.Btn_Vider.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Vider.Location = new System.Drawing.Point(494, 128);
            this.Btn_Vider.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Btn_Vider.Name = "Btn_Vider";
            this.Btn_Vider.Size = new System.Drawing.Size(104, 25);
            this.Btn_Vider.TabIndex = 8;
            this.Btn_Vider.Text = "Vider";
            this.Btn_Vider.UseVisualStyleBackColor = true;
            this.Btn_Vider.Click += new System.EventHandler(this.Btn_Vider_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Btn_Vider);
            this.groupBox1.Controls.Add(this.Btn_Supprimer);
            this.groupBox1.Controls.Add(this.Btn_Recherche);
            this.groupBox1.Controls.Add(this.Btn_Ajout);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.Txt_Def);
            this.groupBox1.Controls.Add(this.Txt_Mot);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 17);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(613, 171);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Saisie de Mot/Définition";
            // 
            // Dg_Mot
            // 
            this.Dg_Mot.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.Dg_Mot.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Mot.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Mot,
            this.Def});
            this.Dg_Mot.Location = new System.Drawing.Point(20, 15);
            this.Dg_Mot.Name = "Dg_Mot";
            this.Dg_Mot.Size = new System.Drawing.Size(576, 204);
            this.Dg_Mot.TabIndex = 10;
            this.Dg_Mot.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Mot_CellContentClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dg_Mot);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(13, 201);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(611, 227);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste Mots /Définitions";
            // 
            // Mot
            // 
            this.Mot.HeaderText = "Mot";
            this.Mot.Name = "Mot";
            // 
            // Def
            // 
            this.Def.HeaderText = "Def";
            this.Def.Name = "Def";
            this.Def.Width = 430;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(643, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.Text = "Mon petit Dictionnaire";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Mot)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Txt_Mot;
        private System.Windows.Forms.RichTextBox Txt_Def;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button Btn_Ajout;
        private System.Windows.Forms.Button Btn_Recherche;
        private System.Windows.Forms.Button Btn_Supprimer;
        private System.Windows.Forms.Button Btn_Vider;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DataGridView Dg_Mot;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Mot;
        private System.Windows.Forms.DataGridViewTextBoxColumn Def;
    }
}

