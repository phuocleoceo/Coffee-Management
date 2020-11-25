using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace GUILayer
{
    public partial class FormReporting : Form
    {
        public FormReporting()
        {
            InitializeComponent();
        }
        //Tạo Màu Cho Các Nút
        private void LoadTheme()
        {
            foreach (Control btns in this.Controls)
            {
                if (btns.GetType() == typeof(Button))
                {
                    Button btn = (Button)btns;
                    btn.BackColor = ThemeColor.PrimaryColor;
                    btn.ForeColor = Color.White;
                    btn.FlatAppearance.BorderColor = ThemeColor.SecondaryColor;
                }
            }
        }

        private void FormReporting_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void dtpkFromDate_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
