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
            this.btnPrint = new System.Windows.Forms.Button();
            this.txtTotal = new System.Windows.Forms.Label();
            this.txtSTT = new System.Windows.Forms.Label();
            this.txtNameTable = new System.Windows.Forms.Label();
            this.gpbBill = new System.Windows.Forms.GroupBox();
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
            this.grbSwitchTable = new System.Windows.Forms.GroupBox();
            this.gpbBill.SuspendLayout();
            this.gpbTable.SuspendLayout();
            this.grbChucNang.SuspendLayout();
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
            // btnPrint
            // 
            this.btnPrint.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnPrint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPrint.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPrint.BackgroundImage")));
            this.btnPrint.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPrint.Location = new System.Drawing.Point(293, 16);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(31, 31);
            this.btnPrint.TabIndex = 15;
            this.btnPrint.UseVisualStyleBackColor = false;
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
            this.gpbBill.Location = new System.Drawing.Point(286, 142);
            this.gpbBill.Name = "gpbBill";
            this.gpbBill.Size = new System.Drawing.Size(332, 420);
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
            this.grbChucNang.Location = new System.Drawing.Point(295, 19);
            this.grbChucNang.Name = "grbChucNang";
            this.grbChucNang.Size = new System.Drawing.Size(311, 111);
            this.grbChucNang.TabIndex = 15;
            this.grbChucNang.TabStop = false;
            // 
            // btnPurchase
            // 
            this.btnPurchase.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnPurchase.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnPurchase.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnPurchase.BackgroundImage")));
            this.btnPurchase.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnPurchase.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnPurchase.Location = new System.Drawing.Point(217, 53);
            this.btnPurchase.Margin = new System.Windows.Forms.Padding(5);
            this.btnPurchase.Name = "btnPurchase";
            this.btnPurchase.Size = new System.Drawing.Size(47, 46);
            this.btnPurchase.TabIndex = 51;
            this.btnPurchase.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btnPurchase.UseVisualStyleBackColor = false;
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.btnSwitchTable.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnSwitchTable.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnSwitchTable.BackgroundImage")));
            this.btnSwitchTable.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnSwitchTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btnSwitchTable.Location = new System.Drawing.Point(125, 55);
            this.btnSwitchTable.Margin = new System.Windows.Forms.Padding(5);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(43, 43);
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
            this.btnAddDrink.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.btnAddDrink.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnAddDrink.BackgroundImage")));
            this.btnAddDrink.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
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
            this.grbAddDrink.Location = new System.Drawing.Point(624, 18);
            this.grbAddDrink.Name = "grbAddDrink";
            this.grbAddDrink.Size = new System.Drawing.Size(317, 175);
            this.grbAddDrink.TabIndex = 16;
            this.grbAddDrink.TabStop = false;
            this.grbAddDrink.Text = "Add Drink : ";
            this.grbAddDrink.Visible = false;
            // 
            // grbSwitchTable
            // 
            this.grbSwitchTable.Location = new System.Drawing.Point(624, 213);
            this.grbSwitchTable.Name = "grbSwitchTable";
            this.grbSwitchTable.Size = new System.Drawing.Size(317, 349);
            this.grbSwitchTable.TabIndex = 17;
            this.grbSwitchTable.TabStop = false;
            this.grbSwitchTable.Text = "Switch Table : ";
            this.grbSwitchTable.Visible = false;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(953, 578);
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

        public System.Windows.Forms.MouseEventHandler txtNameMan_MouseClick { get; set; }
    }
}