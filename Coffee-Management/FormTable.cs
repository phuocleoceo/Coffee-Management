using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormTable : Form
    {        
        public FormTable()
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
            //foreach (Control lsv in this.Controls)
            //{
            //    if (lsv.GetType() == typeof(ListView))
            //    {
            //        ListView btn = (ListView)lsv;
            //        lsv.BackColor = ThemeColor.SecondaryColor;
            //    }
            //}
        }
        private void FormTable_Load_1(object sender, EventArgs e)
        {
            LoadTheme();
        }

        private void btnDiscount_Click(object sender, EventArgs e)
        {

        }

        private void btnAddorDeDrink_Click(object sender, EventArgs e)
        {

        }

        private void btnCheck_Click(object sender, EventArgs e)
        {

        }

        private void cbDrinkType_SelectedValueChanged(object sender, EventArgs e)
        {
        }

        private void dgvDrink_SelectionChanged(object sender, EventArgs e)
        {
            
        }
    }
}

