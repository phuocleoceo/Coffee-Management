namespace GUILayer
{
    partial class FormTable
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.Label();
            this.txtNameTable = new System.Windows.Forms.Label();
            this.gpbBill = new System.Windows.Forms.GroupBox();
            this.btnPrint = new System.Windows.Forms.Button();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.gpbTable = new System.Windows.Forms.GroupBox();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnPurchase = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.grbAddDrink = new System.Windows.Forms.GroupBox();
            this.btnAddAD = new System.Windows.Forms.Button();
            this.txtTableAD = new System.Windows.Forms.TextBox();
            this.cbbDrinkAD = new System.Windows.Forms.ComboBox();
            this.nUDQuantityAD = new System.Windows.Forms.NumericUpDown();
            this.label11 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.grbSwitchTable = new System.Windows.Forms.GroupBox();
            this.cbbToTable = new System.Windows.Forms.ComboBox();
            this.cbbFromTable = new System.Windows.Forms.ComboBox();
            this.btnAcceptSwitch = new System.Windows.Forms.Button();
            this.label13 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.grbInfo = new System.Windows.Forms.GroupBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.printDialogBill = new System.Windows.Forms.PrintDialog();
            this.printDocumentBill = new System.Drawing.Printing.PrintDocument();
            this.gpbBill.SuspendLayout();
            this.gpbTable.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.grbAddDrink.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantityAD)).BeginInit();
            this.grbSwitchTable.SuspendLayout();
            this.grbInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(27, 395);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Price : ";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(10, 23);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 24);
            this.label2.TabIndex = 2;
            this.label2.Text = "Table : ";
            // 
            // pnlBill
            // 
            this.pnlBill.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlBill.AutoScroll = true;
            this.pnlBill.Location = new System.Drawing.Point(20, 86);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(296, 304);
            this.pnlBill.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(60, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(207, 18);
            this.label5.TabIndex = 10;
            this.label5.Text = "ID             Drink           Quantity";
            // 
            // label6
            // 
            this.label6.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.Location = new System.Drawing.Point(268, 395);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "VNĐ";
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(117, 391);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(134, 24);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSTT
            // 
            this.txtSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTT.Location = new System.Drawing.Point(184, 22);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(79, 29);
            this.txtSTT.TabIndex = 17;
            this.txtSTT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameTable
            // 
            this.txtNameTable.Location = new System.Drawing.Point(78, 21);
            this.txtNameTable.Name = "txtNameTable";
            this.txtNameTable.Size = new System.Drawing.Size(74, 27);
            this.txtNameTable.TabIndex = 16;
            // 
            // gpbBill
            // 
            this.gpbBill.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbBill.BackColor = System.Drawing.Color.White;
            this.gpbBill.Controls.Add(this.txtNameTable);
            this.gpbBill.Controls.Add(this.txtSTT);
            this.gpbBill.Controls.Add(this.txtTotal);
            this.gpbBill.Controls.Add(this.btnPrint);
            this.gpbBill.Controls.Add(this.label6);
            this.gpbBill.Controls.Add(this.label5);
            this.gpbBill.Controls.Add(this.pnlBill);
            this.gpbBill.Controls.Add(this.label2);
            this.gpbBill.Controls.Add(this.label1);
            this.gpbBill.ForeColor = System.Drawing.Color.Black;
            this.gpbBill.Location = new System.Drawing.Point(283, 142);
            this.gpbBill.Name = "gpbBill";
            this.gpbBill.Size = new System.Drawing.Size(332, 420);
            this.gpbBill.TabIndex = 12;
            this.gpbBill.TabStop = false;
            this.gpbBill.Text = "Bill";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.White;
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(284, 21);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(32, 34);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.UseVisualStyleBackColor = false;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // pnlTable
            // 
            this.pnlTable.AllowDrop = true;
            this.pnlTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlTable.AutoScroll = true;
            this.pnlTable.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pnlTable.Location = new System.Drawing.Point(7, 21);
            this.pnlTable.Name = "pnlTable";
            this.pnlTable.Size = new System.Drawing.Size(248, 524);
            this.pnlTable.TabIndex = 0;
            // 
            // gpbTable
            // 
            this.gpbTable.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbTable.BackColor = System.Drawing.Color.White;
            this.gpbTable.Controls.Add(this.pnlTable);
            this.gpbTable.ForeColor = System.Drawing.Color.Black;
            this.gpbTable.Location = new System.Drawing.Point(12, 10);
            this.gpbTable.Name = "gpbTable";
            this.gpbTable.Size = new System.Drawing.Size(261, 556);
            this.gpbTable.TabIndex = 11;
            this.gpbTable.TabStop = false;
            this.gpbTable.Text = "Table List";
            // 
            // grbChucNang
            // 
            this.grbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChucNang.BackColor = System.Drawing.Color.White;
            this.grbChucNang.Controls.Add(this.btnPurchase);
            this.grbChucNang.Controls.Add(this.btnSwitchTable);
            this.grbChucNang.Controls.Add(this.label10);
            this.grbChucNang.Controls.Add(this.label9);
            this.grbChucNang.Controls.Add(this.label7);
            this.grbChucNang.Controls.Add(this.btnAddDrink);
            this.grbChucNang.Location = new System.Drawing.Point(292, 19);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(311, 111);
            this.grbChucNang.TabIndex = 15;
            this.grbChucNang.TabStop = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurchase.BackColor = System.Drawing.Color.White;
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurchase.FlatAppearance.BorderSize = 0;
            this.btnPurchase.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPurchase.Image = global::GUILayer.Properties.Resources.Money1;
            this.btnPurchase.Location = new System.Drawing.Point(217, 51);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(5);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(51, 47);
            this.btnPurchase.TabIndex = 51;
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchase.UseVisualStyleBackColor = false;
            this.btnPurchase.Click += new System.EventHandler(this.btnPurchase_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSwitchTable.BackColor = System.Drawing.Color.White;
            this.btnSwitchTable.BackgroundImage = global::GUILayer.Properties.Resources._switch;
            this.btnSwitchTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwitchTable.FlatAppearance.BorderSize = 0;
            this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSwitchTable.Location = new System.Drawing.Point(122, 51);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(51, 47);
            this.btnSwitchTable.TabIndex = 47;
            this.btnSwitchTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnSwitchTable.UseVisualStyleBackColor = false;
            this.btnSwitchTable.Click += new System.EventHandler(this.btnSwitchTable_Click);
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(104, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 34);
            this.label10.TabIndex = 50;
            this.label10.Text = "Switch Table";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(181, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 34);
            this.label9.TabIndex = 49;
            this.label9.Text = "Purchase";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(12, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 34);
            this.label7.TabIndex = 48;
            this.label7.Text = "Add Drink";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddDrink.BackColor = System.Drawing.Color.White;
            this.btnAddDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddDrink.FlatAppearance.BorderSize = 0;
            this.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrink.Image = global::GUILayer.Properties.Resources.cart;
            this.btnAddDrink.Location = new System.Drawing.Point(30, 51);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(51, 47);
            this.btnAddDrink.TabIndex = 46;
            this.btnAddDrink.UseVisualStyleBackColor = false;
            this.btnAddDrink.Click += new System.EventHandler(this.btnAddDrink_Click);
            // 
            // grbAddDrink
            // 
            this.grbAddDrink.BackColor = System.Drawing.Color.Transparent;
            this.grbAddDrink.Controls.Add(this.btnAddAD);
            this.grbAddDrink.Controls.Add(this.txtTableAD);
            this.grbAddDrink.Controls.Add(this.cbbDrinkAD);
            this.grbAddDrink.Controls.Add(this.nUDQuantityAD);
            this.grbAddDrink.Controls.Add(this.label11);
            this.grbAddDrink.Controls.Add(this.label8);
            this.grbAddDrink.Controls.Add(this.label3);
            this.grbAddDrink.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbAddDrink.Location = new System.Drawing.Point(624, 151);
            this.grbAddDrink.Name = "grbAddDrink";
            this.grbAddDrink.Size = new System.Drawing.Size(324, 165);
            this.grbAddDrink.TabIndex = 16;
            this.grbAddDrink.TabStop = false;
            this.grbAddDrink.Text = "Add Drink : ";
            this.grbAddDrink.Visible = false;
            // 
            // btnAddAD
            // 
            this.btnAddAD.BackColor = System.Drawing.Color.White;
            this.btnAddAD.BackgroundImage = global::GUILayer.Properties.Resources.plus;
            this.btnAddAD.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddAD.FlatAppearance.BorderSize = 0;
            this.btnAddAD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddAD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.btnAddAD.Location = new System.Drawing.Point(280, 103);
            this.btnAddAD.Margin = new System.Windows.Forms.Padding(2);
            this.btnAddAD.Name = "btnAddAD";
            this.btnAddAD.Size = new System.Drawing.Size(41, 41);
            this.btnAddAD.TabIndex = 36;
            this.btnAddAD.UseVisualStyleBackColor = false;
            this.btnAddAD.Click += new System.EventHandler(this.btnAddAD_Click);
            // 
            // txtTableAD
            // 
            this.txtTableAD.Location = new System.Drawing.Point(100, 24);
            this.txtTableAD.Name = "txtTableAD";
            this.txtTableAD.Size = new System.Drawing.Size(166, 26);
            this.txtTableAD.TabIndex = 3;
            // 
            // cbbDrinkAD
            // 
            this.cbbDrinkAD.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbbDrinkAD.FormattingEnabled = true;
            this.cbbDrinkAD.Location = new System.Drawing.Point(101, 69);
            this.cbbDrinkAD.Name = "cbbDrinkAD";
            this.cbbDrinkAD.Size = new System.Drawing.Size(164, 27);
            this.cbbDrinkAD.TabIndex = 2;
            // 
            // nUDQuantityAD
            // 
            this.nUDQuantityAD.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nUDQuantityAD.Location = new System.Drawing.Point(103, 112);
            this.nUDQuantityAD.Name = "nUDQuantityAD";
            this.nUDQuantityAD.Size = new System.Drawing.Size(163, 32);
            this.nUDQuantityAD.TabIndex = 1;
            this.nUDQuantityAD.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(10, 114);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(90, 20);
            this.label11.TabIndex = 0;
            this.label11.Text = "Quantity : ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(33, 72);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 0;
            this.label8.Text = "Drink : ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 20);
            this.label3.TabIndex = 0;
            this.label3.Text = "Table : ";
            // 
            // grbSwitchTable
            // 
            this.grbSwitchTable.BackColor = System.Drawing.Color.Transparent;
            this.grbSwitchTable.Controls.Add(this.cbbToTable);
            this.grbSwitchTable.Controls.Add(this.cbbFromTable);
            this.grbSwitchTable.Controls.Add(this.btnAcceptSwitch);
            this.grbSwitchTable.Controls.Add(this.label13);
            this.grbSwitchTable.Controls.Add(this.label12);
            this.grbSwitchTable.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbSwitchTable.Location = new System.Drawing.Point(627, 365);
            this.grbSwitchTable.Name = "grbSwitchTable";
            this.grbSwitchTable.Size = new System.Drawing.Size(305, 142);
            this.grbSwitchTable.TabIndex = 17;
            this.grbSwitchTable.TabStop = false;
            this.grbSwitchTable.Text = "Switch Table : ";
            this.grbSwitchTable.Visible = false;
            // 
            // cbbToTable
            // 
            this.cbbToTable.FormattingEnabled = true;
            this.cbbToTable.Location = new System.Drawing.Point(107, 95);
            this.cbbToTable.Name = "cbbToTable";
            this.cbbToTable.Size = new System.Drawing.Size(131, 27);
            this.cbbToTable.TabIndex = 19;
            // 
            // cbbFromTable
            // 
            this.cbbFromTable.FormattingEnabled = true;
            this.cbbFromTable.Location = new System.Drawing.Point(107, 38);
            this.cbbFromTable.Name = "cbbFromTable";
            this.cbbFromTable.Size = new System.Drawing.Size(131, 27);
            this.cbbFromTable.TabIndex = 18;
            // 
            // btnAcceptSwitch
            // 
            this.btnAcceptSwitch.BackColor = System.Drawing.Color.White;
            this.btnAcceptSwitch.BackgroundImage = global::GUILayer.Properties.Resources.down;
            this.btnAcceptSwitch.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAcceptSwitch.FlatAppearance.BorderSize = 0;
            this.btnAcceptSwitch.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAcceptSwitch.Location = new System.Drawing.Point(256, 54);
            this.btnAcceptSwitch.Margin = new System.Windows.Forms.Padding(2);
            this.btnAcceptSwitch.Name = "btnAcceptSwitch";
            this.btnAcceptSwitch.Size = new System.Drawing.Size(41, 41);
            this.btnAcceptSwitch.TabIndex = 17;
            this.btnAcceptSwitch.UseVisualStyleBackColor = false;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(29, 95);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(44, 20);
            this.label13.TabIndex = 0;
            this.label13.Text = "To : ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Lucida Sans Unicode", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(10, 38);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(65, 20);
            this.label12.TabIndex = 0;
            this.label12.Text = "From : ";
            // 
            // grbInfo
            // 
            this.grbInfo.Controls.Add(this.pictureBox3);
            this.grbInfo.Controls.Add(this.pictureBox2);
            this.grbInfo.Controls.Add(this.pictureBox1);
            this.grbInfo.Controls.Add(this.label16);
            this.grbInfo.Controls.Add(this.label15);
            this.grbInfo.Controls.Add(this.label14);
            this.grbInfo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbInfo.Location = new System.Drawing.Point(635, 20);
            this.grbInfo.Name = "grbInfo";
            this.grbInfo.Size = new System.Drawing.Size(297, 110);
            this.grbInfo.TabIndex = 18;
            this.grbInfo.TabStop = false;
            this.grbInfo.Text = "IT Coffee Shop : ";
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(239, 80);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 23);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 3;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(239, 51);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 23);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(238, 19);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(24, 25);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(54, 81);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(109, 19);
            this.label16.TabIndex = 0;
            this.label16.Text = "Lê Mạnh Duy";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(52, 53);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(169, 19);
            this.label15.TabIndex = 0;
            this.label15.Text = "Nguyễn Khoa Hoàng";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(51, 25);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(165, 19);
            this.label14.TabIndex = 0;
            this.label14.Text = "Trương Minh Phước";
            // 
            // printDialogBill
            // 
            this.printDialogBill.UseEXDialog = true;
            // 
            // printDocumentBill
            // 
            this.printDocumentBill.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocumentBill_PrintPage);
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 578);
            this.Controls.Add(this.grbInfo);
            this.Controls.Add(this.grbSwitchTable);
            this.Controls.Add(this.grbAddDrink);
            this.Controls.Add(this.gpbTable);
            this.Controls.Add(this.gpbBill);
            this.Controls.Add(this.grbChucNang);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Table";
            this.gpbBill.ResumeLayout(false);
            this.gpbBill.PerformLayout();
            this.gpbTable.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.grbAddDrink.ResumeLayout(false);
            this.grbAddDrink.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nUDQuantityAD)).EndInit();
            this.grbSwitchTable.ResumeLayout(false);
            this.grbSwitchTable.PerformLayout();
            this.grbInfo.ResumeLayout(false);
            this.grbInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        public System.Windows.Forms.Panel pnlBill;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Label txtTotal;
        private System.Windows.Forms.Label txtSTT;
        private System.Windows.Forms.Label txtNameTable;
        private System.Windows.Forms.GroupBox gpbBill;
        private System.Windows.Forms.Panel pnlTable;
        private System.Windows.Forms.GroupBox gpbTable;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnPurchase;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.GroupBox grbAddDrink;
        private System.Windows.Forms.GroupBox grbSwitchTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NumericUpDown nUDQuantityAD;
        private System.Windows.Forms.ComboBox cbbDrinkAD;
        private System.Windows.Forms.TextBox txtTableAD;
        private System.Windows.Forms.Button btnAddAD;
        private System.Windows.Forms.ComboBox cbbToTable;
        private System.Windows.Forms.ComboBox cbbFromTable;
        private System.Windows.Forms.Button btnAcceptSwitch;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox grbInfo;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PrintDialog printDialogBill;
        private System.Drawing.Printing.PrintDocument printDocumentBill;

        public System.Windows.Forms.MouseEventHandler txtNameMan_MouseClick { get; set; }
    }
}