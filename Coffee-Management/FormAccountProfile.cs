using System;
using System.Drawing;
using System.Windows.Forms;
using Model;

namespace GUILayer
{
    public partial class FormAccountProfile : Form
    {
        public FormAccountProfile()
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
            label1.ForeColor = ThemeColor.PrimaryColor;
            label2.ForeColor = ThemeColor.PrimaryColor;
            label3.ForeColor = ThemeColor.PrimaryColor;
            label4.ForeColor = ThemeColor.PrimaryColor;
            label5.ForeColor = ThemeColor.PrimaryColor;
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormAccountProfile_Load(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {

        }

        private void txbUserName_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
