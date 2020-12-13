using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using System.Data;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormTableBackup : Form
    {
        /*------------------------------------------------------------------------------------------*/
        private void loadTable()
        {
            pnlTable.Controls.Clear();
            DataTable dt = BUS_Table.Instance.Read();
            int x = 10, y = 10; 
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                Button btn = new Button()
                {
                    Name = "btnTable" + i,
                    Text = dt.Rows[i][1].ToString(), 
                    Tag = dt.Rows[i][2].ToString(), 
                    Width = 100,
                    Height = 50,
                    Location = new Point(x, y),
                };
                //Set trang thai ban
                if (dt.Rows[i][2].ToString() == "Empty")
                {
                    btn.BackColor = ColorTranslator.FromHtml("snow");
                }
                else if (dt.Rows[i][2].ToString() == "Online")
                {
                    btn.BackColor = ColorTranslator.FromHtml("red");
                }
                //Xu ly vi tri button, rat cong phu :)
                if (x < pnlTable.Width - 220)
                {
                    x += 110;
                }
                else
                {
                    x = 10;
                    y += 60;
                }
                //btn.MouseClick += new MouseEventHandler(btnTable_MouseClick);
                //btn.MouseHover += new EventHandler(btnTable_MouseHover);
                pnlTable.Controls.Add(btn);
            }
        }
        /*------------------------------------------------------------------------------------------*/
        public FormTableBackup()
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
            loadTable();
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

