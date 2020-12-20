namespace GUILayer
{
    partial class FormReporting
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.dtgvReport = new System.Windows.Forms.DataGridView();
            this.dtpkFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpkToDate = new System.Windows.Forms.DateTimePicker();
            this.btnViewbill = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dtgvReport);
            this.panel1.Location = new System.Drawing.Point(12, 72);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(915, 494);
            this.panel1.TabIndex = 0;
            // 
            // dtgvReport
            // 
            this.dtgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgvReport.Location = new System.Drawing.Point(0, 0);
            this.dtgvReport.Name = "dtgvReport";
            this.dtgvReport.Size = new System.Drawing.Size(915, 494);
            this.dtgvReport.TabIndex = 3;
            // 
            // dtpkFromDate
            // 
            this.dtpkFromDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpkFromDate.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpkFromDate.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpkFromDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkFromDate.Location = new System.Drawing.Point(29, 21);
            this.dtpkFromDate.Name = "dtpkFromDate";
            this.dtpkFromDate.Size = new System.Drawing.Size(308, 30);
            this.dtpkFromDate.TabIndex = 0;
            this.dtpkFromDate.ValueChanged += new System.EventHandler(this.dtpkFromDate_ValueChanged);
            // 
            // dtpkToDate
            // 
            this.dtpkToDate.CalendarMonthBackground = System.Drawing.Color.WhiteSmoke;
            this.dtpkToDate.CalendarTitleBackColor = System.Drawing.Color.LightPink;
            this.dtpkToDate.CalendarTitleForeColor = System.Drawing.Color.WhiteSmoke;
            this.dtpkToDate.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpkToDate.Location = new System.Drawing.Point(586, 21);
            this.dtpkToDate.Name = "dtpkToDate";
            this.dtpkToDate.Size = new System.Drawing.Size(308, 30);
            this.dtpkToDate.TabIndex = 2;
            // 
            // btnViewbill
            // 
            this.btnViewbill.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnViewbill.Font = new System.Drawing.Font("Cambria", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewbill.Location = new System.Drawing.Point(387, 12);
            this.btnViewbill.Name = "btnViewbill";
            this.btnViewbill.Size = new System.Drawing.Size(144, 45);
            this.btnViewbill.TabIndex = 1;
            this.btnViewbill.Text = "Information";
            this.btnViewbill.UseVisualStyleBackColor = true;
            // 
            // FormReporting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(939, 578);
            this.Controls.Add(this.btnViewbill);
            this.Controls.Add(this.dtpkToDate);
            this.Controls.Add(this.dtpkFromDate);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "FormReporting";
            this.Text = "R e p o r t i n g";
            this.Load += new System.EventHandler(this.FormReporting_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView dtgvReport;
        private System.Windows.Forms.DateTimePicker dtpkToDate;
        private System.Windows.Forms.DateTimePicker dtpkFromDate;
        private System.Windows.Forms.Button btnViewbill;
    }
}