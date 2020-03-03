namespace TP2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Tab_Cl = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Dg_Client = new System.Windows.Forms.DataGridView();
            this.Numero = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Titulaire = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Solde = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Txt_Sld = new System.Windows.Forms.TextBox();
            this.Txt_Tit = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Txt_Rech = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Ts_Menu = new System.Windows.Forms.ToolStrip();
            this.Btn_Ajout = new System.Windows.Forms.ToolStripButton();
            this.Btn_Supp = new System.Windows.Forms.ToolStripButton();
            this.Btn_Rech = new System.Windows.Forms.ToolStripButton();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.BtnCreerMouv = new System.Windows.Forms.Button();
            this.TxtMt = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.Rdb_Vers = new System.Windows.Forms.RadioButton();
            this.Rdb_Ret = new System.Windows.Forms.RadioButton();
            this.Datm = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.DgMouv = new System.Windows.Forms.DataGridView();
            this.DateOperation = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TypeMouvement = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Montant = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.TxtSolde = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.Txttitulaire = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Txtnum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.Dg_Extrait = new System.Windows.Forms.DataGridView();
            this.Date = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Type = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Debit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Credit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.Btn_Affiche = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.Dat_Fin = new System.Windows.Forms.DateTimePicker();
            this.Dat_Deb = new System.Windows.Forms.DateTimePicker();
            this.label12 = new System.Windows.Forms.Label();
            this.Txt_Slde = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.Txt_Titre = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.Txt_Nume = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.Tab_Cl.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Client)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.Ts_Menu.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMouv)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox7.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Extrait)).BeginInit();
            this.groupBox6.SuspendLayout();
            this.SuspendLayout();
            // 
            // Tab_Cl
            // 
            this.Tab_Cl.Controls.Add(this.tabPage1);
            this.Tab_Cl.Controls.Add(this.tabPage2);
            this.Tab_Cl.Controls.Add(this.tabPage3);
            this.Tab_Cl.Location = new System.Drawing.Point(1, 0);
            this.Tab_Cl.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Tab_Cl.Name = "Tab_Cl";
            this.Tab_Cl.SelectedIndex = 0;
            this.Tab_Cl.Size = new System.Drawing.Size(787, 454);
            this.Tab_Cl.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.Ts_Menu);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage1.Size = new System.Drawing.Size(779, 428);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Gestio des Comptes Clients";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Dg_Client);
            this.groupBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(102, 120);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(545, 292);
            this.groupBox2.TabIndex = 8;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Liste des Compte";
            // 
            // Dg_Client
            // 
            this.Dg_Client.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Client.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Numero,
            this.Titulaire,
            this.Solde});
            this.Dg_Client.Location = new System.Drawing.Point(16, 29);
            this.Dg_Client.Name = "Dg_Client";
            this.Dg_Client.Size = new System.Drawing.Size(519, 262);
            this.Dg_Client.TabIndex = 0;
            this.Dg_Client.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dg_Client_CellClick);
            // 
            // Numero
            // 
            this.Numero.HeaderText = "Numéro";
            this.Numero.Name = "Numero";
            // 
            // Titulaire
            // 
            this.Titulaire.HeaderText = "Titulaire";
            this.Titulaire.Name = "Titulaire";
            // 
            // Solde
            // 
            this.Solde.HeaderText = "Solde";
            this.Solde.Name = "Solde";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.Txt_Sld);
            this.groupBox1.Controls.Add(this.Txt_Tit);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.Txt_Rech);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(100, 12);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.groupBox1.Size = new System.Drawing.Size(548, 96);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compte Client";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(175, 62);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 16);
            this.label3.TabIndex = 6;
            this.label3.Text = "Solde";
            // 
            // Txt_Sld
            // 
            this.Txt_Sld.Location = new System.Drawing.Point(245, 61);
            this.Txt_Sld.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Sld.Name = "Txt_Sld";
            this.Txt_Sld.Size = new System.Drawing.Size(184, 20);
            this.Txt_Sld.TabIndex = 5;
            // 
            // Txt_Tit
            // 
            this.Txt_Tit.Location = new System.Drawing.Point(356, 20);
            this.Txt_Tit.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Tit.Name = "Txt_Tit";
            this.Txt_Tit.Size = new System.Drawing.Size(149, 20);
            this.Txt_Tit.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(284, 24);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(65, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "Titulaire";
            // 
            // Txt_Rech
            // 
            this.Txt_Rech.Location = new System.Drawing.Point(107, 21);
            this.Txt_Rech.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Txt_Rech.Name = "Txt_Rech";
            this.Txt_Rech.Size = new System.Drawing.Size(152, 20);
            this.Txt_Rech.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Numéro ";
            // 
            // Ts_Menu
            // 
            this.Ts_Menu.BackColor = System.Drawing.Color.Gainsboro;
            this.Ts_Menu.Dock = System.Windows.Forms.DockStyle.Left;
            this.Ts_Menu.GripStyle = System.Windows.Forms.ToolStripGripStyle.Hidden;
            this.Ts_Menu.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Btn_Ajout,
            this.Btn_Supp,
            this.Btn_Rech});
            this.Ts_Menu.Location = new System.Drawing.Point(4, 3);
            this.Ts_Menu.Name = "Ts_Menu";
            this.Ts_Menu.Size = new System.Drawing.Size(84, 422);
            this.Ts_Menu.TabIndex = 0;
            this.Ts_Menu.Text = "toolStrip1";
            this.Ts_Menu.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.toolStrip1_ItemClicked);
            // 
            // Btn_Ajout
            // 
            this.Btn_Ajout.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Ajout.Image")));
            this.Btn_Ajout.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Ajout.Name = "Btn_Ajout";
            this.Btn_Ajout.Size = new System.Drawing.Size(81, 20);
            this.Btn_Ajout.Text = "Ajouter";
            this.Btn_Ajout.Click += new System.EventHandler(this.Btn_Ajout_Click);
            // 
            // Btn_Supp
            // 
            this.Btn_Supp.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Supp.Image")));
            this.Btn_Supp.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Supp.Name = "Btn_Supp";
            this.Btn_Supp.Size = new System.Drawing.Size(81, 20);
            this.Btn_Supp.Text = "supprimer";
            this.Btn_Supp.Click += new System.EventHandler(this.Btn_Supp_Click);
            // 
            // Btn_Rech
            // 
            this.Btn_Rech.Image = ((System.Drawing.Image)(resources.GetObject("Btn_Rech.Image")));
            this.Btn_Rech.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Btn_Rech.Name = "Btn_Rech";
            this.Btn_Rech.Size = new System.Drawing.Size(81, 20);
            this.Btn_Rech.Text = "rechercher";
            this.Btn_Rech.Click += new System.EventHandler(this.Btn_Rech_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage2.Size = new System.Drawing.Size(779, 428);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Mouvement Compte";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.BtnCreerMouv);
            this.groupBox4.Controls.Add(this.TxtMt);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.groupBox5);
            this.groupBox4.Controls.Add(this.Datm);
            this.groupBox4.Controls.Add(this.label7);
            this.groupBox4.Controls.Add(this.DgMouv);
            this.groupBox4.Location = new System.Drawing.Point(21, 92);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(732, 326);
            this.groupBox4.TabIndex = 8;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Mouvements du Compte";
            // 
            // BtnCreerMouv
            // 
            this.BtnCreerMouv.Location = new System.Drawing.Point(60, 277);
            this.BtnCreerMouv.Name = "BtnCreerMouv";
            this.BtnCreerMouv.Size = new System.Drawing.Size(221, 32);
            this.BtnCreerMouv.TabIndex = 15;
            this.BtnCreerMouv.Text = "Créer mouvement Compte";
            this.BtnCreerMouv.UseVisualStyleBackColor = true;
            this.BtnCreerMouv.Click += new System.EventHandler(this.BtnCreerMouv_Click);
            // 
            // TxtMt
            // 
            this.TxtMt.Location = new System.Drawing.Point(121, 241);
            this.TxtMt.Name = "TxtMt";
            this.TxtMt.Size = new System.Drawing.Size(185, 20);
            this.TxtMt.TabIndex = 14;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(29, 242);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 15);
            this.label8.TabIndex = 13;
            this.label8.Text = "Montant";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.Rdb_Vers);
            this.groupBox5.Controls.Add(this.Rdb_Ret);
            this.groupBox5.Location = new System.Drawing.Point(32, 104);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(306, 113);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Type opération";
            // 
            // Rdb_Vers
            // 
            this.Rdb_Vers.AutoSize = true;
            this.Rdb_Vers.Location = new System.Drawing.Point(19, 76);
            this.Rdb_Vers.Name = "Rdb_Vers";
            this.Rdb_Vers.Size = new System.Drawing.Size(75, 17);
            this.Rdb_Vers.TabIndex = 11;
            this.Rdb_Vers.TabStop = true;
            this.Rdb_Vers.Text = "Versement";
            this.Rdb_Vers.UseVisualStyleBackColor = true;
            // 
            // Rdb_Ret
            // 
            this.Rdb_Ret.AutoSize = true;
            this.Rdb_Ret.Location = new System.Drawing.Point(19, 40);
            this.Rdb_Ret.Name = "Rdb_Ret";
            this.Rdb_Ret.Size = new System.Drawing.Size(56, 17);
            this.Rdb_Ret.TabIndex = 10;
            this.Rdb_Ret.TabStop = true;
            this.Rdb_Ret.Text = "Retrait";
            this.Rdb_Ret.UseVisualStyleBackColor = true;
            // 
            // Datm
            // 
            this.Datm.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Datm.Location = new System.Drawing.Point(156, 72);
            this.Datm.Name = "Datm";
            this.Datm.Size = new System.Drawing.Size(116, 20);
            this.Datm.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(31, 72);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(102, 15);
            this.label7.TabIndex = 8;
            this.label7.Text = "Date opération";
            // 
            // DgMouv
            // 
            this.DgMouv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DgMouv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DateOperation,
            this.TypeMouvement,
            this.Montant});
            this.DgMouv.Location = new System.Drawing.Point(370, 20);
            this.DgMouv.Name = "DgMouv";
            this.DgMouv.Size = new System.Drawing.Size(345, 289);
            this.DgMouv.TabIndex = 7;
            // 
            // DateOperation
            // 
            this.DateOperation.HeaderText = "DateOperation";
            this.DateOperation.Name = "DateOperation";
            // 
            // TypeMouvement
            // 
            this.TypeMouvement.HeaderText = "TypeMouvement";
            this.TypeMouvement.Name = "TypeMouvement";
            // 
            // Montant
            // 
            this.Montant.HeaderText = "Montant";
            this.Montant.Name = "Montant";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.TxtSolde);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.Txttitulaire);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.Txtnum);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Location = new System.Drawing.Point(19, 17);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(735, 65);
            this.groupBox3.TabIndex = 6;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Compte Client";
            // 
            // TxtSolde
            // 
            this.TxtSolde.Location = new System.Drawing.Point(543, 24);
            this.TxtSolde.Name = "TxtSolde";
            this.TxtSolde.Size = new System.Drawing.Size(141, 20);
            this.TxtSolde.TabIndex = 5;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(473, 27);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(34, 13);
            this.label6.TabIndex = 4;
            this.label6.Text = "Solde";
            // 
            // Txttitulaire
            // 
            this.Txttitulaire.Location = new System.Drawing.Point(313, 24);
            this.Txttitulaire.Name = "Txttitulaire";
            this.Txttitulaire.Size = new System.Drawing.Size(141, 20);
            this.Txttitulaire.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(230, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(44, 13);
            this.label5.TabIndex = 2;
            this.label5.Text = "Titulaire";
            // 
            // Txtnum
            // 
            this.Txtnum.Location = new System.Drawing.Point(82, 24);
            this.Txtnum.Name = "Txtnum";
            this.Txtnum.Size = new System.Drawing.Size(122, 20);
            this.Txtnum.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(13, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 13);
            this.label4.TabIndex = 0;
            this.label4.Text = "Numéro";
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.groupBox7);
            this.tabPage3.Controls.Add(this.groupBox6);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(779, 428);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Extrait de Compte";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.Dg_Extrait);
            this.groupBox7.Location = new System.Drawing.Point(16, 147);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(748, 270);
            this.groupBox7.TabIndex = 12;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Liste des Mouvements";
            // 
            // Dg_Extrait
            // 
            this.Dg_Extrait.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Dg_Extrait.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Date,
            this.Type,
            this.Debit,
            this.Credit});
            this.Dg_Extrait.Location = new System.Drawing.Point(109, 34);
            this.Dg_Extrait.Name = "Dg_Extrait";
            this.Dg_Extrait.Size = new System.Drawing.Size(519, 225);
            this.Dg_Extrait.TabIndex = 0;
            // 
            // Date
            // 
            this.Date.FillWeight = 120F;
            this.Date.HeaderText = "Date";
            this.Date.Name = "Date";
            this.Date.Width = 120;
            // 
            // Type
            // 
            this.Type.HeaderText = "Type";
            this.Type.Name = "Type";
            this.Type.Width = 120;
            // 
            // Debit
            // 
            this.Debit.HeaderText = "Debit";
            this.Debit.Name = "Debit";
            this.Debit.Width = 120;
            // 
            // Credit
            // 
            this.Credit.HeaderText = "Credit";
            this.Credit.Name = "Credit";
            this.Credit.Width = 120;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.Btn_Affiche);
            this.groupBox6.Controls.Add(this.label13);
            this.groupBox6.Controls.Add(this.Dat_Fin);
            this.groupBox6.Controls.Add(this.Dat_Deb);
            this.groupBox6.Controls.Add(this.label12);
            this.groupBox6.Controls.Add(this.Txt_Slde);
            this.groupBox6.Controls.Add(this.label11);
            this.groupBox6.Controls.Add(this.Txt_Titre);
            this.groupBox6.Controls.Add(this.label10);
            this.groupBox6.Controls.Add(this.Txt_Nume);
            this.groupBox6.Controls.Add(this.label9);
            this.groupBox6.Location = new System.Drawing.Point(18, 11);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(747, 119);
            this.groupBox6.TabIndex = 11;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Compte Client";
            // 
            // Btn_Affiche
            // 
            this.Btn_Affiche.Location = new System.Drawing.Point(565, 71);
            this.Btn_Affiche.Name = "Btn_Affiche";
            this.Btn_Affiche.Size = new System.Drawing.Size(94, 23);
            this.Btn_Affiche.TabIndex = 10;
            this.Btn_Affiche.Text = "Afficher";
            this.Btn_Affiche.UseVisualStyleBackColor = true;
            this.Btn_Affiche.Click += new System.EventHandler(this.Btn_Affiche_Click);
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(349, 72);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(50, 15);
            this.label13.TabIndex = 9;
            this.label13.Text = "Jusqu\'a";
            // 
            // Dat_Fin
            // 
            this.Dat_Fin.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Fin.Location = new System.Drawing.Point(405, 71);
            this.Dat_Fin.Name = "Dat_Fin";
            this.Dat_Fin.Size = new System.Drawing.Size(99, 20);
            this.Dat_Fin.TabIndex = 8;
            // 
            // Dat_Deb
            // 
            this.Dat_Deb.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.Dat_Deb.Location = new System.Drawing.Point(167, 71);
            this.Dat_Deb.Name = "Dat_Deb";
            this.Dat_Deb.Size = new System.Drawing.Size(96, 20);
            this.Dat_Deb.TabIndex = 7;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(100, 74);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(61, 15);
            this.label12.TabIndex = 6;
            this.label12.Text = "Extrait de ";
            // 
            // Txt_Slde
            // 
            this.Txt_Slde.Location = new System.Drawing.Point(495, 21);
            this.Txt_Slde.Name = "Txt_Slde";
            this.Txt_Slde.Size = new System.Drawing.Size(117, 20);
            this.Txt_Slde.TabIndex = 5;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(438, 24);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(34, 13);
            this.label11.TabIndex = 4;
            this.label11.Text = "Solde";
            // 
            // Txt_Titre
            // 
            this.Txt_Titre.Location = new System.Drawing.Point(296, 21);
            this.Txt_Titre.Name = "Txt_Titre";
            this.Txt_Titre.Size = new System.Drawing.Size(100, 20);
            this.Txt_Titre.TabIndex = 3;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(234, 24);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(44, 13);
            this.label10.TabIndex = 2;
            this.label10.Text = "Titulaire";
            // 
            // Txt_Nume
            // 
            this.Txt_Nume.Location = new System.Drawing.Point(88, 21);
            this.Txt_Nume.Name = "Txt_Nume";
            this.Txt_Nume.Size = new System.Drawing.Size(100, 20);
            this.Txt_Nume.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(16, 24);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(44, 13);
            this.label9.TabIndex = 0;
            this.label9.Text = "Numéro";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Tab_Cl);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Form1";
            this.RightToLeftLayout = true;
            this.Text = "Gestion des comptes Bancaires";
            this.Tab_Cl.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Client)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.Ts_Menu.ResumeLayout(false);
            this.Ts_Menu.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DgMouv)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Dg_Extrait)).EndInit();
            this.groupBox6.ResumeLayout(false);
            this.groupBox6.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl Tab_Cl;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Txt_Rech;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox Txt_Sld;
        private System.Windows.Forms.TextBox Txt_Tit;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView Dg_Client;
        private System.Windows.Forms.DataGridViewTextBoxColumn Numero;
        private System.Windows.Forms.DataGridViewTextBoxColumn Titulaire;
        private System.Windows.Forms.DataGridViewTextBoxColumn Solde;
        private System.Windows.Forms.ToolStrip Ts_Menu;
        private System.Windows.Forms.ToolStripButton Btn_Ajout;
        private System.Windows.Forms.ToolStripButton Btn_Supp;
        private System.Windows.Forms.ToolStripButton Btn_Rech;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Txttitulaire;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Txtnum;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox TxtSolde;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView DgMouv;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.RadioButton Rdb_Ret;
        private System.Windows.Forms.DateTimePicker Datm;
        private System.Windows.Forms.RadioButton Rdb_Vers;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BtnCreerMouv;
        private System.Windows.Forms.TextBox TxtMt;
        private System.Windows.Forms.DataGridViewTextBoxColumn DateOperation;
        private System.Windows.Forms.DataGridViewTextBoxColumn TypeMouvement;
        private System.Windows.Forms.DataGridViewTextBoxColumn Montant;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox Txt_Nume;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Txt_Titre;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox Txt_Slde;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.DateTimePicker Dat_Fin;
        private System.Windows.Forms.DateTimePicker Dat_Deb;
        private System.Windows.Forms.Button Btn_Affiche;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.DataGridView Dg_Extrait;
        private System.Windows.Forms.DataGridViewTextBoxColumn Date;
        private System.Windows.Forms.DataGridViewTextBoxColumn Type;
        private System.Windows.Forms.DataGridViewTextBoxColumn Debit;
        private System.Windows.Forms.DataGridViewTextBoxColumn Credit;
    }
}

