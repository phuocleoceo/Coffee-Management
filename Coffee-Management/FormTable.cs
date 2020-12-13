using System;
using Model;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;
using System.Data.SqlClient;

namespace GUILayer
{
    public partial class FormTable : Form
    {
        string strBill;
        public FormTable()
        {
            InitializeComponent();
            LoadTable();
        }
        // An 2 group box chuc nang
        private void HideGroupBox()
        {
            grbAddDrink.Visible = false;
            grbSwitchTable.Visible = false;
        }
        // Load danh sach Table
        private void LoadTable()
        {
            try
            {
                pnlTable.Controls.Clear();
                DataTable table = BUS_Table.Instance.Read();
                int x = 10;
                int y = 10;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Button btn = new Button()
                    {
                        Name = "btnTable" + (i + 1),
                        Text = table.Rows[i][1].ToString(),
                        Tag = table.Rows[i][3].ToString(),
                        Width = 100,
                        Height = 50,
                        Location = new Point(x, y),
                    };
                    if (table.Rows[i][2].ToString() == "Empty")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("snow");
                    }
                    else if (table.Rows[i][2].ToString() == "Online")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("red");
                    }
                    if (x < pnlTable.Width - 220)
                    {
                        x += 110;
                    }
                    else
                    {
                        x = 10;
                        y += 60;
                    }
                    btn.MouseClick += new MouseEventHandler(btnTable_MouseClick);
                    pnlTable.Controls.Add(btn);
                }
            }
            catch
            {
                MessageBox.Show("Database is not available ! ");
            }
        }
        // Load Bill
        public void LoadBill()
        {
            try
            {
                pnlBill.Controls.Clear();
                strBill = "";
                DataTable table = BUS_Bill.Instance.Read(txtNameTable.Text);
                int y = 10;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    strBill += (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString() + "\n";
                    Label lbl = new Label()
                    {
                        Name = "btnFB" + i,
                        Text = (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString(),
                        Width = pnlBill.Width - 20,
                        Height = 20,
                        Location = new Point(5, y)
                    };
                    y += 25;
                    pnlBill.Controls.Add(lbl);
                }
            }
            catch
            {
                MessageBox.Show("This Bill is not available");
            }
        }
        //Khi Click vao Table
        private void btnTable_MouseClick(object sender, EventArgs e)
        {
            ClickTable(sender, e);
        }
        private void ClickTable(object sender, EventArgs e)
        {
            //tra ve trang thai ban theo mau sac cua btnTable
            if (((Button)sender).BackColor.ToString() == "Color [Snow]")
            {
                txtSTT.Text = "Empty";
            }
            else if (((Button)sender).BackColor.ToString() == "Color [RED]")
            {
                txtSTT.Text = "Online";
            }
            //tra ve ten ban
            txtNameTable.Text = ((Button)sender).Text;
            //Tra ve tong tien
            txtTotal.Text = ((Button)sender).Tag.ToString();
            LoadBill();
        }
        // Su kien cho cac nut bam
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            grbAddDrink.Visible = true;
            AddDrink();
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            grbSwitchTable.Visible = true;
            SwitchTable();
        }

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            PurchaseDrink();
        }

        private void gpbTable_SizeChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        /*--------------------------------------------------------------------------------------*/
        //Them do uong
        private void AddDrink()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    //frmAddFood addF = new frmAddFood(txtNameTable.Text, txtNameFood.Text, txtSTT.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();

                }
                else if (txtSTT.Text == "Empty")
                {
                    DialogResult ms = MessageBox.Show("This Table Is Now Empty !. Open It?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ms == DialogResult.Yes)
                    {
                        //frmAddFood addF = new frmAddFood(txtNameTable.Text, txtNameFood.Text, txtSTT.Text);
                        //addF.ShowDialog();
                        //this.Show();
                        //loaddataTable();
                        //loaddataBill();
                    }
                }
            }
            catch { }
        }
        //Thanh toan
        private void PurchaseDrink()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    //frmPay addF = new frmPay(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();

                }
                else if (txtSTT.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }
        // Chuyen ban
        private void SwitchTable()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    //ReplaceTable addF = new ReplaceTable(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }
    }
}
