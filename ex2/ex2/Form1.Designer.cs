namespace ex2
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
            this.Btn_Tirer = new System.Windows.Forms.Button();
            this.Rdb_Volailles = new System.Windows.Forms.RadioButton();
            this.Rdb_Viandes = new System.Windows.Forms.RadioButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.Btn_Serv_Volail = new System.Windows.Forms.Button();
            this.Btn_Serv_Viande = new System.Windows.Forms.Button();
            this.Lst_Volailles = new System.Windows.Forms.ListBox();
            this.Lst_Viandes = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // Btn_Tirer
            // 
            this.Btn_Tirer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Btn_Tirer.Location = new System.Drawing.Point(293, 20);
            this.Btn_Tirer.Name = "Btn_Tirer";
            this.Btn_Tirer.Size = new System.Drawing.Size(125, 33);
            this.Btn_Tirer.TabIndex = 0;
            this.Btn_Tirer.Text = "Trier un Ticket";
            this.Btn_Tirer.UseVisualStyleBackColor = true;
            this.Btn_Tirer.Click += new System.EventHandler(this.Btn_Tirer_Click);
            // 
            // Rdb_Volailles
            // 
            this.Rdb_Volailles.AutoSize = true;
            this.Rdb_Volailles.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Volailles.ForeColor = System.Drawing.Color.Yellow;
            this.Rdb_Volailles.Location = new System.Drawing.Point(21, 23);
            this.Rdb_Volailles.Name = "Rdb_Volailles";
            this.Rdb_Volailles.Size = new System.Drawing.Size(83, 20);
            this.Rdb_Volailles.TabIndex = 1;
            this.Rdb_Volailles.TabStop = true;
            this.Rdb_Volailles.Text = "Volatille";
            this.Rdb_Volailles.UseVisualStyleBackColor = true;
            // 
            // Rdb_Viandes
            // 
            this.Rdb_Viandes.AutoSize = true;
            this.Rdb_Viandes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Rdb_Viandes.ForeColor = System.Drawing.Color.Red;
            this.Rdb_Viandes.Location = new System.Drawing.Point(152, 23);
            this.Rdb_Viandes.Name = "Rdb_Viandes";
            this.Rdb_Viandes.Size = new System.Drawing.Size(75, 20);
            this.Rdb_Viandes.TabIndex = 2;
            this.Rdb_Viandes.TabStop = true;
            this.Rdb_Viandes.Text = "Viande";
            this.Rdb_Viandes.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Rdb_Viandes);
            this.groupBox1.Controls.Add(this.Rdb_Volailles);
            this.groupBox1.Controls.Add(this.Btn_Tirer);
            this.groupBox1.Location = new System.Drawing.Point(11, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(447, 72);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Lst_Volailles);
            this.groupBox2.Controls.Add(this.Btn_Serv_Volail);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Yellow;
            this.groupBox2.Location = new System.Drawing.Point(15, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(209, 309);
            this.groupBox2.TabIndex = 4;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Volatille";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.Lst_Viandes);
            this.groupBox3.Controls.Add(this.Btn_Serv_Viande);
            this.groupBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Red;
            this.groupBox3.Location = new System.Drawing.Point(245, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(212, 308);
            this.groupBox3.TabIndex = 5;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Viandes";
            // 
            // Btn_Serv_Volail
            // 
            this.Btn_Serv_Volail.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Serv_Volail.Location = new System.Drawing.Point(16, 23);
            this.Btn_Serv_Volail.Name = "Btn_Serv_Volail";
            this.Btn_Serv_Volail.Size = new System.Drawing.Size(177, 32);
            this.Btn_Serv_Volail.TabIndex = 0;
            this.Btn_Serv_Volail.Text = "se servir";
            this.Btn_Serv_Volail.UseVisualStyleBackColor = true;
            this.Btn_Serv_Volail.Click += new System.EventHandler(this.Btn_Serv_Volail_Click);
            // 
            // Btn_Serv_Viande
            // 
            this.Btn_Serv_Viande.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Btn_Serv_Viande.Location = new System.Drawing.Point(18, 22);
            this.Btn_Serv_Viande.Name = "Btn_Serv_Viande";
            this.Btn_Serv_Viande.Size = new System.Drawing.Size(183, 32);
            this.Btn_Serv_Viande.TabIndex = 0;
            this.Btn_Serv_Viande.Text = "se servir";
            this.Btn_Serv_Viande.UseVisualStyleBackColor = true;
            this.Btn_Serv_Viande.Click += new System.EventHandler(this.Btn_Serv_Viande_Click);
            // 
            // Lst_Volailles
            // 
            this.Lst_Volailles.FormattingEnabled = true;
            this.Lst_Volailles.ItemHeight = 16;
            this.Lst_Volailles.Location = new System.Drawing.Point(19, 68);
            this.Lst_Volailles.Name = "Lst_Volailles";
            this.Lst_Volailles.Size = new System.Drawing.Size(173, 212);
            this.Lst_Volailles.TabIndex = 1;
            // 
            // Lst_Viandes
            // 
            this.Lst_Viandes.FormattingEnabled = true;
            this.Lst_Viandes.ItemHeight = 16;
            this.Lst_Viandes.Location = new System.Drawing.Point(18, 68);
            this.Lst_Viandes.Name = "Lst_Viandes";
            this.Lst_Viandes.Size = new System.Drawing.Size(178, 212);
            this.Lst_Viandes.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(478, 450);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button Btn_Tirer;
        private System.Windows.Forms.RadioButton Rdb_Volailles;
        private System.Windows.Forms.RadioButton Rdb_Viandes;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.ListBox Lst_Volailles;
        private System.Windows.Forms.Button Btn_Serv_Volail;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ListBox Lst_Viandes;
        private System.Windows.Forms.Button Btn_Serv_Viande;
    }
}

