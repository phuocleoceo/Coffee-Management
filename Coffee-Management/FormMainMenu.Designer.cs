namespace GUILayer
{
    partial class FormMainMenu
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
            this.panelSlideMenu = new System.Windows.Forms.Panel();
            this.panelLogo = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.panelTitleBar = new System.Windows.Forms.Panel();
            this.lblTitle = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.panelDesktopPane = new System.Windows.Forms.Panel();
            this.btnCloseChildForm = new System.Windows.Forms.Button();
            this.btnReporting = new System.Windows.Forms.Button();
            this.btnAccount = new System.Windows.Forms.Button();
            this.btnTable = new System.Windows.Forms.Button();
            this.panelSlideMenu.SuspendLayout();
            this.panelLogo.SuspendLayout();
            this.panelTitleBar.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelSlideMenu
            // 
            this.panelSlideMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(76)))));
            this.panelSlideMenu.Controls.Add(this.btnReporting);
            this.panelSlideMenu.Controls.Add(this.btnAccount);
            this.panelSlideMenu.Controls.Add(this.btnTable);
            this.panelSlideMenu.Controls.Add(this.panelLogo);
            this.panelSlideMenu.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelSlideMenu.Location = new System.Drawing.Point(0, 0);
            this.panelSlideMenu.Margin = new System.Windows.Forms.Padding(4);
            this.panelSlideMenu.Name = "panelSlideMenu";
            this.panelSlideMenu.Size = new System.Drawing.Size(293, 844);
            this.panelSlideMenu.TabIndex = 20;
            // 
            // panelLogo
            // 
            this.panelLogo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(39)))), ((int)(((byte)(58)))));
            this.panelLogo.Controls.Add(this.label1);
            this.panelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelLogo.Location = new System.Drawing.Point(0, 0);
            this.panelLogo.Margin = new System.Windows.Forms.Padding(4);
            this.panelLogo.Name = "panelLogo";
            this.panelLogo.Size = new System.Drawing.Size(293, 123);
            this.panelLogo.TabIndex = 30;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Curlz MT", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label1.Location = new System.Drawing.Point(13, 34);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(248, 49);
            this.label1.TabIndex = 0;
            this.label1.Text = "IT Coffee Shop";
            // 
            // panelTitleBar
            // 
            this.panelTitleBar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(150)))), ((int)(((byte)(136)))));
            this.panelTitleBar.Controls.Add(this.btnCloseChildForm);
            this.panelTitleBar.Controls.Add(this.lblTitle);
            this.panelTitleBar.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelTitleBar.Location = new System.Drawing.Point(293, 0);
            this.panelTitleBar.Margin = new System.Windows.Forms.Padding(4);
            this.panelTitleBar.Name = "panelTitleBar";
            this.panelTitleBar.Size = new System.Drawing.Size(1268, 123);
            this.panelTitleBar.TabIndex = 40;
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Freestyle Script", 45F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.ForeColor = System.Drawing.Color.White;
            this.lblTitle.Location = new System.Drawing.Point(501, 21);
            this.lblTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(243, 89);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "H O M E";
            // 
            // panelDesktopPane
            // 
            this.panelDesktopPane.BackgroundImage = global::GUILayer.Properties.Resources.logo1;
            this.panelDesktopPane.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.panelDesktopPane.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelDesktopPane.Location = new System.Drawing.Point(293, 123);
            this.panelDesktopPane.Margin = new System.Windows.Forms.Padding(4);
            this.panelDesktopPane.Name = "panelDesktopPane";
            this.panelDesktopPane.Size = new System.Drawing.Size(1268, 721);
            this.panelDesktopPane.TabIndex = 50;
            // 
            // btnCloseChildForm
            // 
            this.btnCloseChildForm.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.btnCloseChildForm.Dock = System.Windows.Forms.DockStyle.Left;
            this.btnCloseChildForm.FlatAppearance.BorderSize = 0;
            this.btnCloseChildForm.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCloseChildForm.Image = global::GUILayer.Properties.Resources.Close;
            this.btnCloseChildForm.Location = new System.Drawing.Point(0, 0);
            this.btnCloseChildForm.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnCloseChildForm.Name = "btnCloseChildForm";
            this.btnCloseChildForm.Size = new System.Drawing.Size(117, 123);
            this.btnCloseChildForm.TabIndex = 2;
            this.btnCloseChildForm.UseVisualStyleBackColor = true;
            this.btnCloseChildForm.Click += new System.EventHandler(this.btnCloseChildForm_Click);
            // 
            // btnReporting
            // 
            this.btnReporting.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnReporting.FlatAppearance.BorderSize = 0;
            this.btnReporting.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnReporting.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReporting.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnReporting.Image = global::GUILayer.Properties.Resources.calendar2;
            this.btnReporting.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.Location = new System.Drawing.Point(0, 369);
            this.btnReporting.Margin = new System.Windows.Forms.Padding(0);
            this.btnReporting.Name = "btnReporting";
            this.btnReporting.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnReporting.Size = new System.Drawing.Size(293, 123);
            this.btnReporting.TabIndex = 5;
            this.btnReporting.Text = "      Reporting";
            this.btnReporting.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnReporting.UseVisualStyleBackColor = true;
            this.btnReporting.Click += new System.EventHandler(this.btnReporting_Click);
            // 
            // btnAccount
            // 
            this.btnAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAccount.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnAccount.FlatAppearance.BorderSize = 0;
            this.btnAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAccount.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAccount.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnAccount.Image = global::GUILayer.Properties.Resources.coffe;
            this.btnAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.Location = new System.Drawing.Point(0, 246);
            this.btnAccount.Margin = new System.Windows.Forms.Padding(4);
            this.btnAccount.Name = "btnAccount";
            this.btnAccount.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnAccount.Size = new System.Drawing.Size(293, 123);
            this.btnAccount.TabIndex = 1;
            this.btnAccount.Text = "       Admin";
            this.btnAccount.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAccount.UseVisualStyleBackColor = true;
            this.btnAccount.Click += new System.EventHandler(this.btnAccount_Click);
            // 
            // btnTable
            // 
            this.btnTable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTable.Dock = System.Windows.Forms.DockStyle.Top;
            this.btnTable.FlatAppearance.BorderSize = 0;
            this.btnTable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTable.Font = new System.Drawing.Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTable.ForeColor = System.Drawing.Color.Gainsboro;
            this.btnTable.Image = global::GUILayer.Properties.Resources.cup3;
            this.btnTable.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.Location = new System.Drawing.Point(0, 123);
            this.btnTable.Margin = new System.Windows.Forms.Padding(0);
            this.btnTable.Name = "btnTable";
            this.btnTable.Padding = new System.Windows.Forms.Padding(13, 0, 0, 0);
            this.btnTable.Size = new System.Drawing.Size(293, 123);
            this.btnTable.TabIndex = 0;
            this.btnTable.Text = "       Table";
            this.btnTable.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTable.UseVisualStyleBackColor = true;
            this.btnTable.Click += new System.EventHandler(this.btnTable_Click);
            // 
            // FormMainMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1561, 844);
            this.Controls.Add(this.panelDesktopPane);
            this.Controls.Add(this.panelTitleBar);
            this.Controls.Add(this.panelSlideMenu);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "FormMainMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.panelSlideMenu.ResumeLayout(false);
            this.panelLogo.ResumeLayout(false);
            this.panelLogo.PerformLayout();
            this.panelTitleBar.ResumeLayout(false);
            this.panelTitleBar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelSlideMenu;
        private System.Windows.Forms.Button btnTable;
        private System.Windows.Forms.Panel panelLogo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReporting;
        private System.Windows.Forms.Button btnAccount;
        private System.Windows.Forms.Panel panelTitleBar;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Panel panelDesktopPane;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button btnCloseChildForm;
    }
}