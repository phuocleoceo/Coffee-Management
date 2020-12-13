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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormTable));
            this.pnlFood = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.txtNameFood = new System.Windows.Forms.Label();
            this.txtPriceFood = new System.Windows.Forms.Label();
            this.gpbFood = new System.Windows.Forms.GroupBox();
            this.pnlCategory = new System.Windows.Forms.Panel();
            this.gpbCategory = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.pnlBill = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.Label();
            this.txtNameTable = new System.Windows.Forms.Label();
            this.gpbBill = new System.Windows.Forms.GroupBox();
            this.pnlTable = new System.Windows.Forms.Panel();
            this.gpbTable = new System.Windows.Forms.GroupBox();
            this.aCCOUNTBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tsmMoBan = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnSubTable3 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.tsmThemMon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmTraMon = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmThanhToan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmChuyenBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmGopBan = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmInTT = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnSubTable = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.ofdMedia = new System.Windows.Forms.OpenFileDialog();
            this.btnAddFood = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnPlusTable = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.btnReplaceTable = new System.Windows.Forms.Button();
            this.label11 = new System.Windows.Forms.Label();
            this.btnReturn = new System.Windows.Forms.Button();
            this.lblName = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.grbChucNang = new System.Windows.Forms.GroupBox();
            this.btnPay = new System.Windows.Forms.Button();
            this.tmsThemMon2 = new System.Windows.Forms.ToolStripMenuItem();
            this.tsmDatBan = new System.Windows.Forms.ToolStripMenuItem();
            this.cmnSubTable2 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gpbFood.SuspendLayout();
            this.gpbCategory.SuspendLayout();
            this.gpbBill.SuspendLayout();
            this.gpbTable.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).BeginInit();
            this.cmnSubTable3.SuspendLayout();
            this.cmnSubTable.SuspendLayout();
            this.grbChucNang.SuspendLayout();
            this.cmnSubTable2.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlFood
            // 
            this.pnlFood.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlFood.AutoScroll = true;
            this.pnlFood.Location = new System.Drawing.Point(7, 73);
            this.pnlFood.Name = "pnlFood";
            this.pnlFood.Size = new System.Drawing.Size(295, 275);
            this.pnlFood.TabIndex = 0;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(5, 33);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 18);
            this.label4.TabIndex = 14;
            this.label4.Text = "Price";
            // 
            // txtNameFood
            // 
            this.txtNameFood.Location = new System.Drawing.Point(66, 15);
            this.txtNameFood.Name = "txtNameFood";
            this.txtNameFood.Size = new System.Drawing.Size(205, 24);
            this.txtNameFood.TabIndex = 15;
            // 
            // txtPriceFood
            // 
            this.txtPriceFood.Location = new System.Drawing.Point(89, 36);
            this.txtPriceFood.Name = "txtPriceFood";
            this.txtPriceFood.Size = new System.Drawing.Size(188, 24);
            this.txtPriceFood.TabIndex = 16;
            // 
            // gpbFood
            // 
            this.gpbFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbFood.BackColor = System.Drawing.Color.White;
            this.gpbFood.Controls.Add(this.txtPriceFood);
            this.gpbFood.Controls.Add(this.txtNameFood);
            this.gpbFood.Controls.Add(this.label4);
            this.gpbFood.Controls.Add(this.label3);
            this.gpbFood.Controls.Add(this.pnlFood);
            this.gpbFood.ForeColor = System.Drawing.Color.Black;
            this.gpbFood.Location = new System.Drawing.Point(627, 199);
            this.gpbFood.Name = "gpbFood";
            this.gpbFood.Size = new System.Drawing.Size(313, 362);
            this.gpbFood.TabIndex = 14;
            this.gpbFood.TabStop = false;
            this.gpbFood.Text = "Drink List";
            // 
            // pnlCategory
            // 
            this.pnlCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnlCategory.AutoScroll = true;
            this.pnlCategory.Location = new System.Drawing.Point(10, 24);
            this.pnlCategory.Name = "pnlCategory";
            this.pnlCategory.Size = new System.Drawing.Size(295, 150);
            this.pnlCategory.TabIndex = 0;
            // 
            // gpbCategory
            // 
            this.gpbCategory.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.gpbCategory.BackColor = System.Drawing.Color.White;
            this.gpbCategory.Controls.Add(this.pnlCategory);
            this.gpbCategory.ForeColor = System.Drawing.Color.Black;
            this.gpbCategory.Location = new System.Drawing.Point(626, 14);
            this.gpbCategory.Name = "gpbCategory";
            this.gpbCategory.Size = new System.Drawing.Size(313, 184);
            this.gpbCategory.TabIndex = 13;
            this.gpbCategory.TabStop = false;
            this.gpbCategory.Text = "Catelogy";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 324);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(92, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "Tổng cộng:";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(15, 21);
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
            this.pnlBill.Location = new System.Drawing.Point(24, 66);
            this.pnlBill.Name = "pnlBill";
            this.pnlBill.Size = new System.Drawing.Size(284, 252);
            this.pnlBill.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(51, 45);
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
            this.label6.Location = new System.Drawing.Point(258, 325);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 14;
            this.label6.Text = "VNĐ";
            // 
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(267, 15);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(31, 31);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.UseVisualStyleBackColor = false;
            // 
            // txtTotal
            // 
            this.txtTotal.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.txtTotal.Location = new System.Drawing.Point(111, 324);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(134, 24);
            this.txtTotal.TabIndex = 18;
            this.txtTotal.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // txtSTT
            // 
            this.txtSTT.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.txtSTT.Location = new System.Drawing.Point(71, 16);
            this.txtSTT.Name = "txtSTT";
            this.txtSTT.Size = new System.Drawing.Size(67, 29);
            this.txtSTT.TabIndex = 17;
            this.txtSTT.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // txtNameTable
            // 
            this.txtNameTable.Location = new System.Drawing.Point(161, 15);
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
            this.gpbBill.Location = new System.Drawing.Point(289, 207);
            this.gpbBill.Name = "gpbBill";
            this.gpbBill.Size = new System.Drawing.Size(320, 354);
            this.gpbBill.TabIndex = 12;
            this.gpbBill.TabStop = false;
            this.gpbBill.Text = "Bill";
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
            this.pnlTable.Size = new System.Drawing.Size(258, 520);
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
            this.gpbTable.Size = new System.Drawing.Size(272, 552);
            this.gpbTable.TabIndex = 11;
            this.gpbTable.TabStop = false;
            this.gpbTable.Text = "Table List";
            // 
            // tsmMoBan
            // 
            this.tsmMoBan.Name = "tsmMoBan";
            this.tsmMoBan.ShortcutKeys = System.Windows.Forms.Keys.F12;
            this.tsmMoBan.Size = new System.Drawing.Size(169, 22);
            this.tsmMoBan.Text = "Mở khóa bàn";
            // 
            // cmnSubTable3
            // 
            this.cmnSubTable3.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnSubTable3.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmMoBan});
            this.cmnSubTable3.Name = "cmnSubTable";
            this.cmnSubTable3.Size = new System.Drawing.Size(170, 26);
            this.cmnSubTable3.Text = "DATTRUOC";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label3.Location = new System.Drawing.Point(338, 49);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 18);
            this.label3.TabIndex = 13;
            this.label3.Text = "VNĐ";
            // 
            // tsmThemMon
            // 
            this.tsmThemMon.Name = "tsmThemMon";
            this.tsmThemMon.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tsmThemMon.Size = new System.Drawing.Size(157, 22);
            this.tsmThemMon.Text = "Thêm món";
            // 
            // tsmTraMon
            // 
            this.tsmTraMon.Name = "tsmTraMon";
            this.tsmTraMon.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.tsmTraMon.Size = new System.Drawing.Size(157, 22);
            this.tsmTraMon.Text = "Trả món";
            // 
            // tsmThanhToan
            // 
            this.tsmThanhToan.Name = "tsmThanhToan";
            this.tsmThanhToan.ShortcutKeys = System.Windows.Forms.Keys.F3;
            this.tsmThanhToan.Size = new System.Drawing.Size(157, 22);
            this.tsmThanhToan.Text = "Thanh toán";
            // 
            // tsmChuyenBan
            // 
            this.tsmChuyenBan.Name = "tsmChuyenBan";
            this.tsmChuyenBan.ShortcutKeys = System.Windows.Forms.Keys.F4;
            this.tsmChuyenBan.Size = new System.Drawing.Size(157, 22);
            this.tsmChuyenBan.Text = "Chuyển bàn";
            // 
            // tsmGopBan
            // 
            this.tsmGopBan.Name = "tsmGopBan";
            this.tsmGopBan.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.tsmGopBan.Size = new System.Drawing.Size(157, 22);
            this.tsmGopBan.Text = "Gộp bàn";
            // 
            // tsmInTT
            // 
            this.tsmInTT.Name = "tsmInTT";
            this.tsmInTT.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.tsmInTT.Size = new System.Drawing.Size(157, 22);
            this.tsmInTT.Text = "In tạm tính";
            // 
            // cmnSubTable
            // 
            this.cmnSubTable.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnSubTable.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tsmThemMon,
            this.tsmTraMon,
            this.tsmThanhToan,
            this.tsmChuyenBan,
            this.tsmGopBan,
            this.tsmInTT});
            this.cmnSubTable.Name = "cmnSubTable";
            this.cmnSubTable.Size = new System.Drawing.Size(158, 136);
            this.cmnSubTable.Text = "ONLINE";
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // ofdMedia
            // 
            this.ofdMedia.FileName = "Media";
            this.ofdMedia.Filter = "Mp3|*.mp3|Wav|*.wav|Mp4|*.mp4|3gp|*.3gp";
            this.ofdMedia.Multiselect = true;
            // 
            // btnAddFood
            // 
            this.btnAddFood.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnAddFood.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddFood.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddFood.BackgroundImage")));
            this.btnAddFood.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnAddFood.Location = new System.Drawing.Point(18, 45);
            this.btnAddFood.Margin = new System.Windows.Forms.Padding(5);
            this.btnAddFood.Name = "btnAddFood";
            this.btnAddFood.Size = new System.Drawing.Size(54, 50);
            this.btnAddFood.TabIndex = 33;
            this.btnAddFood.UseVisualStyleBackColor = false;
            // 
            // label7
            // 
            this.label7.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(5, 24);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(94, 16);
            this.label7.TabIndex = 37;
            this.label7.Text = "Add Drink";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.Black;
            this.label8.Location = new System.Drawing.Point(82, 25);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(110, 16);
            this.label8.TabIndex = 38;
            this.label8.Text = "Đổi trả món";
            this.label8.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnPlusTable
            // 
            this.btnPlusTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPlusTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPlusTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPlusTable.BackgroundImage")));
            this.btnPlusTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPlusTable.Location = new System.Drawing.Point(110, 132);
            this.btnPlusTable.Margin = new System.Windows.Forms.Padding(5);
            this.btnPlusTable.Name = "btnPlusTable";
            this.btnPlusTable.Size = new System.Drawing.Size(55, 50);
            this.btnPlusTable.TabIndex = 36;
            this.btnPlusTable.UseVisualStyleBackColor = false;
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(169, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(122, 16);
            this.label9.TabIndex = 39;
            this.label9.Text = "Purchase";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Black;
            this.label10.Location = new System.Drawing.Point(1, 111);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(96, 16);
            this.label10.TabIndex = 40;
            this.label10.Text = "Switch Table";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReplaceTable
            // 
            this.btnReplaceTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReplaceTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReplaceTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReplaceTable.BackgroundImage")));
            this.btnReplaceTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReplaceTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnReplaceTable.Location = new System.Drawing.Point(18, 132);
            this.btnReplaceTable.Margin = new System.Windows.Forms.Padding(5);
            this.btnReplaceTable.Name = "btnReplaceTable";
            this.btnReplaceTable.Size = new System.Drawing.Size(54, 50);
            this.btnReplaceTable.TabIndex = 35;
            this.btnReplaceTable.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnReplaceTable.UseVisualStyleBackColor = false;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.Black;
            this.label11.Location = new System.Drawing.Point(90, 111);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(103, 22);
            this.label11.TabIndex = 41;
            this.label11.Text = "Gộp bàn";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnReturn
            // 
            this.btnReturn.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnReturn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnReturn.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnReturn.BackgroundImage")));
            this.btnReturn.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnReturn.Location = new System.Drawing.Point(110, 46);
            this.btnReturn.Margin = new System.Windows.Forms.Padding(5);
            this.btnReturn.Name = "btnReturn";
            this.btnReturn.Size = new System.Drawing.Size(55, 49);
            this.btnReturn.TabIndex = 42;
            this.btnReturn.UseVisualStyleBackColor = false;
            // 
            // lblName
            // 
            this.lblName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.ForeColor = System.Drawing.Color.Black;
            this.lblName.Location = new System.Drawing.Point(172, 106);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(125, 27);
            this.lblName.TabIndex = 43;
            this.lblName.Text = "account";
            this.lblName.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnBlock
            // 
            this.btnBlock.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnBlock.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnBlock.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnBlock.BackgroundImage")));
            this.btnBlock.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnBlock.Location = new System.Drawing.Point(210, 132);
            this.btnBlock.Margin = new System.Windows.Forms.Padding(5);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(54, 50);
            this.btnBlock.TabIndex = 44;
            this.btnBlock.UseVisualStyleBackColor = false;
            // 
            // grbChucNang
            // 
            this.grbChucNang.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grbChucNang.BackColor = System.Drawing.Color.White;
            this.grbChucNang.Controls.Add(this.btnPay);
            this.grbChucNang.Controls.Add(this.btnBlock);
            this.grbChucNang.Controls.Add(this.lblName);
            this.grbChucNang.Controls.Add(this.btnReturn);
            this.grbChucNang.Controls.Add(this.label11);
            this.grbChucNang.Controls.Add(this.btnReplaceTable);
            this.grbChucNang.Controls.Add(this.label10);
            this.grbChucNang.Controls.Add(this.label9);
            this.grbChucNang.Controls.Add(this.btnPlusTable);
            this.grbChucNang.Controls.Add(this.label8);
            this.grbChucNang.Controls.Add(this.label7);
            this.grbChucNang.Controls.Add(this.btnAddFood);
            this.grbChucNang.Location = new System.Drawing.Point(313, 9);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(280, 196);
            this.grbChucNang.TabIndex = 15;
            this.grbChucNang.TabStop = false;
            // 
            // btnPay
            // 
            this.btnPay.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPay.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPay.BackgroundImage")));
            this.btnPay.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPay.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPay.Location = new System.Drawing.Point(210, 45);
            this.btnPay.Margin = new System.Windows.Forms.Padding(5);
            this.btnPay.Name = "btnPay";
            this.btnPay.Size = new System.Drawing.Size(54, 49);
            this.btnPay.TabIndex = 45;
            this.btnPay.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPay.UseVisualStyleBackColor = false;
            // 
            // tmsThemMon2
            // 
            this.tmsThemMon2.Name = "tmsThemMon2";
            this.tmsThemMon2.ShortcutKeys = System.Windows.Forms.Keys.F1;
            this.tmsThemMon2.Size = new System.Drawing.Size(176, 22);
            this.tmsThemMon2.Text = "Thêm món mới";
            // 
            // tsmDatBan
            // 
            this.tsmDatBan.Name = "tsmDatBan";
            this.tsmDatBan.ShortcutKeys = System.Windows.Forms.Keys.F11;
            this.tsmDatBan.Size = new System.Drawing.Size(176, 22);
            this.tsmDatBan.Text = "Đặt giữ bàn";
            // 
            // cmnSubTable2
            // 
            this.cmnSubTable2.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.cmnSubTable2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tmsThemMon2,
            this.tsmDatBan});
            this.cmnSubTable2.Name = "cmnSubTable";
            this.cmnSubTable2.Size = new System.Drawing.Size(177, 48);
            this.cmnSubTable2.Text = "TRONG";
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 578);
            this.Controls.Add(this.gpbTable);
            this.Controls.Add(this.gpbBill);
            this.Controls.Add(this.gpbCategory);
            this.Controls.Add(this.gpbFood);
            this.Controls.Add(this.grbChucNang);
            this.Font = new System.Drawing.Font("Lucida Sans Unicode", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTable";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form Table";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.frmMain_FormClosing);
            this.gpbFood.ResumeLayout(false);
            this.gpbFood.PerformLayout();
            this.gpbCategory.ResumeLayout(false);
            this.gpbBill.ResumeLayout(false);
            this.gpbBill.PerformLayout();
            this.gpbTable.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.aCCOUNTBindingSource)).EndInit();
            this.cmnSubTable3.ResumeLayout(false);
            this.cmnSubTable.ResumeLayout(false);
            this.grbChucNang.ResumeLayout(false);
            this.cmnSubTable2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlFood;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label txtNameFood;
        private System.Windows.Forms.Label txtPriceFood;
        private System.Windows.Forms.GroupBox gpbFood;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel pnlCategory;
        private System.Windows.Forms.GroupBox gpbCategory;
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
        private System.Windows.Forms.BindingSource aCCOUNTBindingSource;
        private System.Windows.Forms.ToolStripMenuItem tsmMoBan;
        private System.Windows.Forms.ContextMenuStrip cmnSubTable3;
        private System.Windows.Forms.ToolStripMenuItem tsmThemMon;
        private System.Windows.Forms.ToolStripMenuItem tsmTraMon;
        private System.Windows.Forms.ToolStripMenuItem tsmThanhToan;
        private System.Windows.Forms.ToolStripMenuItem tsmChuyenBan;
        private System.Windows.Forms.ToolStripMenuItem tsmGopBan;
        private System.Windows.Forms.ToolStripMenuItem tsmInTT;
        private System.Windows.Forms.ContextMenuStrip cmnSubTable;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Windows.Forms.OpenFileDialog ofdMedia;
        private System.Windows.Forms.Button btnAddFood;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnPlusTable;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReplaceTable;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnReturn;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.GroupBox grbChucNang;
        private System.Windows.Forms.Button btnPay;
        private System.Windows.Forms.ToolStripMenuItem tmsThemMon2;
        private System.Windows.Forms.ToolStripMenuItem tsmDatBan;
        private System.Windows.Forms.ContextMenuStrip cmnSubTable2;

        public System.Windows.Forms.MouseEventHandler txtNameMan_MouseClick { get; set; }
    }
}