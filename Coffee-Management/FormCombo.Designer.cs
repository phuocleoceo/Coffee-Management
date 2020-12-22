namespace GUILayer
{
    partial class FormCombo
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
            this.btnCombo = new System.Windows.Forms.Button();
            this.txtMoney = new System.Windows.Forms.TextBox();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cbType = new System.Windows.Forms.ComboBox();
            this.txtType = new System.Windows.Forms.TextBox();
            this.lsvResult = new System.Windows.Forms.ListView();
            this.btnAddType = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCombo
            // 
            this.btnCombo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCombo.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCombo.Location = new System.Drawing.Point(364, 238);
            this.btnCombo.Name = "btnCombo";
            this.btnCombo.Size = new System.Drawing.Size(126, 72);
            this.btnCombo.TabIndex = 1;
            this.btnCombo.Text = "Combo";
            this.btnCombo.UseVisualStyleBackColor = true;
            this.btnCombo.Click += new System.EventHandler(this.btnCombo_Click);
            // 
            // txtMoney
            // 
            this.txtMoney.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMoney.Location = new System.Drawing.Point(24, 59);
            this.txtMoney.Name = "txtMoney";
            this.txtMoney.Size = new System.Drawing.Size(124, 31);
            this.txtMoney.TabIndex = 2;
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(175, 59);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(117, 31);
            this.txtDiscount.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(33, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(116, 21);
            this.label1.TabIndex = 3;
            this.label1.Text = "Money (VND)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(177, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Discount (%)";
            // 
            // cbType
            // 
            this.cbType.Font = new System.Drawing.Font("Cambria", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbType.FormattingEnabled = true;
            this.cbType.Location = new System.Drawing.Point(36, 108);
            this.cbType.Name = "cbType";
            this.cbType.Size = new System.Drawing.Size(221, 31);
            this.cbType.TabIndex = 4;
            // 
            // txtType
            // 
            this.txtType.Font = new System.Drawing.Font("Cambria", 17F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtType.Location = new System.Drawing.Point(24, 222);
            this.txtType.Multiline = true;
            this.txtType.Name = "txtType";
            this.txtType.ReadOnly = true;
            this.txtType.Size = new System.Drawing.Size(268, 332);
            this.txtType.TabIndex = 5;
            // 
            // lsvResult
            // 
            this.lsvResult.Font = new System.Drawing.Font("Cambria", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lsvResult.HideSelection = false;
            this.lsvResult.Location = new System.Drawing.Point(574, 59);
            this.lsvResult.Name = "lsvResult";
            this.lsvResult.Size = new System.Drawing.Size(292, 445);
            this.lsvResult.TabIndex = 6;
            this.lsvResult.UseCompatibleStateImageBehavior = false;
            this.lsvResult.View = System.Windows.Forms.View.Tile;
            // 
            // btnAddType
            // 
            this.btnAddType.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddType.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddType.Location = new System.Drawing.Point(99, 159);
            this.btnAddType.Name = "btnAddType";
            this.btnAddType.Size = new System.Drawing.Size(109, 48);
            this.btnAddType.TabIndex = 1;
            this.btnAddType.Text = "Add";
            this.btnAddType.UseVisualStyleBackColor = true;
            this.btnAddType.Click += new System.EventHandler(this.btnAddType_Click_1);
            // 
            // FormCombo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 578);
            this.Controls.Add(this.lsvResult);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.cbType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDiscount);
            this.Controls.Add(this.txtMoney);
            this.Controls.Add(this.btnAddType);
            this.Controls.Add(this.btnCombo);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormCombo";
            this.Text = "C o m b o";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnCombo;
        private System.Windows.Forms.TextBox txtMoney;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbType;
        private System.Windows.Forms.TextBox txtType;
        private System.Windows.Forms.ListView lsvResult;
        private System.Windows.Forms.Button btnAddType;
    }
}