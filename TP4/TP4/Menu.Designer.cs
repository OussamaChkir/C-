namespace TP4
{
    partial class Menu
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Menu));
            this.TS_menu = new System.Windows.Forms.ToolStrip();
            this.TS_Btn_Cl = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Pr = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Cd = new System.Windows.Forms.ToolStripButton();
            this.TS_Btn_Q = new System.Windows.Forms.ToolStripButton();
            this.TS_menu.SuspendLayout();
            this.SuspendLayout();
            // 
            // TS_menu
            // 
            this.TS_menu.ImageScalingSize = new System.Drawing.Size(30, 30);
            this.TS_menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TS_Btn_Cl,
            this.TS_Btn_Pr,
            this.TS_Btn_Cd,
            this.TS_Btn_Q});
            this.TS_menu.Location = new System.Drawing.Point(27, 69);
            this.TS_menu.Name = "TS_menu";
            this.TS_menu.Padding = new System.Windows.Forms.Padding(1);
            this.TS_menu.Size = new System.Drawing.Size(609, 56);
            this.TS_menu.TabIndex = 2;
            this.TS_menu.Text = "toolStrip1";
            // 
            // TS_Btn_Cl
            // 
            this.TS_Btn_Cl.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Btn_Cl.ForeColor = System.Drawing.Color.Green;
            this.TS_Btn_Cl.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cl.Image")));
            this.TS_Btn_Cl.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cl.Name = "TS_Btn_Cl";
            this.TS_Btn_Cl.Size = new System.Drawing.Size(54, 51);
            this.TS_Btn_Cl.Text = "Clients";
            this.TS_Btn_Cl.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Cl.Click += new System.EventHandler(this.TS_Btn_Cl_Click);
            // 
            // TS_Btn_Pr
            // 
            this.TS_Btn_Pr.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Btn_Pr.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.TS_Btn_Pr.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Pr.Image")));
            this.TS_Btn_Pr.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Pr.Name = "TS_Btn_Pr";
            this.TS_Btn_Pr.Size = new System.Drawing.Size(64, 51);
            this.TS_Btn_Pr.Text = "Produits";
            this.TS_Btn_Pr.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Pr.Click += new System.EventHandler(this.TS_Btn_Pr_Click);
            // 
            // TS_Btn_Cd
            // 
            this.TS_Btn_Cd.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Btn_Cd.ForeColor = System.Drawing.SystemColors.Highlight;
            this.TS_Btn_Cd.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Cd.Image")));
            this.TS_Btn_Cd.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Cd.Name = "TS_Btn_Cd";
            this.TS_Btn_Cd.Size = new System.Drawing.Size(88, 51);
            this.TS_Btn_Cd.Text = "Commandes";
            this.TS_Btn_Cd.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Cd.Click += new System.EventHandler(this.TS_Btn_Cd_Click);
            // 
            // TS_Btn_Q
            // 
            this.TS_Btn_Q.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TS_Btn_Q.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.TS_Btn_Q.Image = ((System.Drawing.Image)(resources.GetObject("TS_Btn_Q.Image")));
            this.TS_Btn_Q.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.TS_Btn_Q.Name = "TS_Btn_Q";
            this.TS_Btn_Q.Size = new System.Drawing.Size(56, 51);
            this.TS_Btn_Q.Text = "Quitter";
            this.TS_Btn_Q.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.TS_Btn_Q.Click += new System.EventHandler(this.TS_Btn_Q_Click);
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(663, 335);
            this.Controls.Add(this.TS_menu);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.IsMdiContainer = true;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Menu";
            this.Padding = new System.Windows.Forms.Padding(27, 69, 27, 23);
            this.Text = "Gestion des commandes des Clients";
            this.TextAlign = MetroFramework.Forms.MetroFormTextAlign.Center;
            this.TransparencyKey = System.Drawing.Color.Empty;
            this.TS_menu.ResumeLayout(false);
            this.TS_menu.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ToolStrip TS_menu;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cl;
        private System.Windows.Forms.ToolStripButton TS_Btn_Pr;
        private System.Windows.Forms.ToolStripButton TS_Btn_Cd;
        private System.Windows.Forms.ToolStripButton TS_Btn_Q;
    }
}

