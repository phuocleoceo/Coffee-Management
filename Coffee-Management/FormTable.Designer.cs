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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.cbDrinkType = new System.Windows.Forms.ComboBox();
            this.btnCheckout = new System.Windows.Forms.Button();
            this.btnSwitchTable = new System.Windows.Forms.Button();
            this.cbSwitchTable = new System.Windows.Forms.ComboBox();
            this.listView1 = new System.Windows.Forms.ListView();
            this.nmDrinkCount = new System.Windows.Forms.NumericUpDown();
            this.btnRemoveDrink = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txbDrinkName = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txbDrinkPrice = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.btnAddDrink = new System.Windows.Forms.Button();
            this.dgvDrink = new System.Windows.Forms.DataGridView();
            this.DrinkName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FLPTable = new System.Windows.Forms.FlowLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).BeginInit();
            this.SuspendLayout();
            // 
            // cbDrinkType
            // 
            this.cbDrinkType.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbDrinkType.Font = new System.Drawing.Font("Cambria", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbDrinkType.FormattingEnabled = true;
            this.cbDrinkType.Location = new System.Drawing.Point(362, 7);
            this.cbDrinkType.Margin = new System.Windows.Forms.Padding(4);
            this.cbDrinkType.Name = "cbDrinkType";
            this.cbDrinkType.Size = new System.Drawing.Size(193, 25);
            this.cbDrinkType.TabIndex = 0;
            this.cbDrinkType.SelectedValueChanged += new System.EventHandler(this.cbDrinkType_SelectedValueChanged);
            // 
            // btnCheckout
            // 
            this.btnCheckout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCheckout.FlatAppearance.BorderSize = 0;
            this.btnCheckout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCheckout.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCheckout.Location = new System.Drawing.Point(769, 148);
            this.btnCheckout.Name = "btnCheckout";
            this.btnCheckout.Size = new System.Drawing.Size(178, 126);
            this.btnCheckout.TabIndex = 10;
            this.btnCheckout.Text = "Checkout";
            this.btnCheckout.UseVisualStyleBackColor = true;
            this.btnCheckout.Click += new System.EventHandler(this.btnCheck_Click);
            // 
            // btnSwitchTable
            // 
            this.btnSwitchTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSwitchTable.FlatAppearance.BorderSize = 0;
            this.btnSwitchTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSwitchTable.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnSwitchTable.Location = new System.Drawing.Point(564, 206);
            this.btnSwitchTable.Name = "btnSwitchTable";
            this.btnSwitchTable.Size = new System.Drawing.Size(91, 65);
            this.btnSwitchTable.TabIndex = 8;
            this.btnSwitchTable.Text = "Switch Table";
            this.btnSwitchTable.UseVisualStyleBackColor = true;
            // 
            // cbSwitchTable
            // 
            this.cbSwitchTable.BackColor = System.Drawing.Color.WhiteSmoke;
            this.cbSwitchTable.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.cbSwitchTable.FormattingEnabled = true;
            this.cbSwitchTable.Location = new System.Drawing.Point(662, 227);
            this.cbSwitchTable.Margin = new System.Windows.Forms.Padding(4);
            this.cbSwitchTable.Name = "cbSwitchTable";
            this.cbSwitchTable.Size = new System.Drawing.Size(89, 25);
            this.cbSwitchTable.TabIndex = 9;
            // 
            // listView1
            // 
            this.listView1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(362, 282);
            this.listView1.Margin = new System.Windows.Forms.Padding(4);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(585, 294);
            this.listView1.TabIndex = 11;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // nmDrinkCount
            // 
            this.nmDrinkCount.BackColor = System.Drawing.Color.WhiteSmoke;
            this.nmDrinkCount.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold);
            this.nmDrinkCount.Location = new System.Drawing.Point(563, 100);
            this.nmDrinkCount.Margin = new System.Windows.Forms.Padding(4);
            this.nmDrinkCount.Minimum = new decimal(new int[] {
            100,
            0,
            0,
            -2147483648});
            this.nmDrinkCount.Name = "nmDrinkCount";
            this.nmDrinkCount.Size = new System.Drawing.Size(188, 25);
            this.nmDrinkCount.TabIndex = 4;
            this.nmDrinkCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.nmDrinkCount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // btnRemoveDrink
            // 
            this.btnRemoveDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveDrink.FlatAppearance.BorderSize = 0;
            this.btnRemoveDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRemoveDrink.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnRemoveDrink.Location = new System.Drawing.Point(663, 148);
            this.btnRemoveDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnRemoveDrink.Name = "btnRemoveDrink";
            this.btnRemoveDrink.Size = new System.Drawing.Size(88, 51);
            this.btnRemoveDrink.TabIndex = 7;
            this.btnRemoveDrink.Text = "Remove";
            this.btnRemoveDrink.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(560, 10);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 22);
            this.label1.TabIndex = 13;
            this.label1.Text = "Name";
            // 
            // txbDrinkName
            // 
            this.txbDrinkName.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbDrinkName.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrinkName.Location = new System.Drawing.Point(563, 35);
            this.txbDrinkName.Name = "txbDrinkName";
            this.txbDrinkName.Size = new System.Drawing.Size(188, 25);
            this.txbDrinkName.TabIndex = 2;
            this.txbDrinkName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(766, 7);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 22);
            this.label2.TabIndex = 15;
            this.label2.Text = "Price";
            // 
            // txbDrinkPrice
            // 
            this.txbDrinkPrice.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txbDrinkPrice.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbDrinkPrice.Location = new System.Drawing.Point(769, 35);
            this.txbDrinkPrice.Name = "txbDrinkPrice";
            this.txbDrinkPrice.Size = new System.Drawing.Size(178, 25);
            this.txbDrinkPrice.TabIndex = 3;
            this.txbDrinkPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(561, 74);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 22);
            this.label3.TabIndex = 17;
            this.label3.Text = "Quantity";
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(766, 74);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 22);
            this.label4.TabIndex = 18;
            this.label4.Text = "Total";
            // 
            // txtTotal
            // 
            this.txtTotal.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTotal.Font = new System.Drawing.Font("Cambria", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTotal.Location = new System.Drawing.Point(769, 99);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(178, 25);
            this.txtTotal.TabIndex = 5;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnAddDrink
            // 
            this.btnAddDrink.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddDrink.FlatAppearance.BorderSize = 0;
            this.btnAddDrink.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAddDrink.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.btnAddDrink.Location = new System.Drawing.Point(564, 148);
            this.btnAddDrink.Margin = new System.Windows.Forms.Padding(4);
            this.btnAddDrink.Name = "btnAddDrink";
            this.btnAddDrink.Size = new System.Drawing.Size(91, 51);
            this.btnAddDrink.TabIndex = 6;
            this.btnAddDrink.Text = "Add";
            this.btnAddDrink.UseVisualStyleBackColor = true;
            // 
            // dgvDrink
            // 
            this.dgvDrink.AllowUserToAddRows = false;
            this.dgvDrink.AllowUserToResizeRows = false;
            this.dgvDrink.BackgroundColor = System.Drawing.Color.WhiteSmoke;
            this.dgvDrink.BorderStyle = System.Windows.Forms.BorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrink.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvDrink.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDrink.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DrinkName});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.LightPink;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.WhiteSmoke;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDrink.DefaultCellStyle = dataGridViewCellStyle2;
            this.dgvDrink.Location = new System.Drawing.Point(362, 39);
            this.dgvDrink.Name = "dgvDrink";
            this.dgvDrink.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDrink.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.dgvDrink.RowHeadersVisible = false;
            this.dgvDrink.Size = new System.Drawing.Size(192, 232);
            this.dgvDrink.TabIndex = 1;
            this.dgvDrink.SelectionChanged += new System.EventHandler(this.dgvDrink_SelectionChanged);
            // 
            // DrinkName
            // 
            this.DrinkName.HeaderText = "Select Drink";
            this.DrinkName.Name = "DrinkName";
            this.DrinkName.ReadOnly = true;
            this.DrinkName.Width = 190;
            // 
            // FLPTable
            // 
            this.FLPTable.Location = new System.Drawing.Point(6, 26);
            this.FLPTable.Name = "FLPTable";
            this.FLPTable.Size = new System.Drawing.Size(338, 525);
            this.FLPTable.TabIndex = 19;
            // 
            // FormTable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(953, 578);
            this.Controls.Add(this.FLPTable);
            this.Controls.Add(this.dgvDrink);
            this.Controls.Add(this.btnAddDrink);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.nmDrinkCount);
            this.Controls.Add(this.cbSwitchTable);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.btnCheckout);
            this.Controls.Add(this.btnSwitchTable);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txbDrinkPrice);
            this.Controls.Add(this.txbDrinkName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.cbDrinkType);
            this.Controls.Add(this.btnRemoveDrink);
            this.Font = new System.Drawing.Font("Cambria", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormTable";
            this.Text = "T a b l e";
            this.Load += new System.EventHandler(this.FormTable_Load_1);
            ((System.ComponentModel.ISupportInitialize)(this.nmDrinkCount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDrink)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox cbDrinkType;
        private System.Windows.Forms.Button btnCheckout;
        private System.Windows.Forms.Button btnSwitchTable;
        private System.Windows.Forms.ComboBox cbSwitchTable;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.NumericUpDown nmDrinkCount;
        private System.Windows.Forms.Button btnRemoveDrink;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txbDrinkName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txbDrinkPrice;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Button btnAddDrink;
        private System.Windows.Forms.DataGridView dgvDrink;
        private System.Windows.Forms.DataGridViewTextBoxColumn DrinkName;
        private System.Windows.Forms.FlowLayoutPanel FLPTable;
    }
}