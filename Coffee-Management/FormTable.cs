using System;
using System.ComponentModel;
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
            LoadCatelogy();
        }
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

        //Ham load BILL
        public void LoadBill()
        {
            try
            {
                pnlBill.Controls.Clear();
                strBill = "";
                DataTable table = BUS_Bill.Instance.Read(txtNameTable.Text);
                //BUS_Table.Instance.loadBillInfo(txtNameTable.Text);
                //Load thong tin cac mon trong bill 
                int y = 10;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    //Thêm vào bill
                    strBill += (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString() + "\n";
                    Label lbl = new Label()
                    {
                        Name = "btnFB" + i,
                        //in ra man hinh tung mon nhu vay no moi dep :)
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
            }
        }

        //Ham Load CATEGORY
        private void LoadCatelogy()
        {
            try
            {
                ////Don rac
                //pnlCategory.Controls.Clear();
                //DataTable table = BUS_Table.Instance.Read();
                //int x = 10;
                //for (int i = 0; i < table.Rows.Count; i++)
                //{
                //    Button btn = new Button()
                //    {
                //        Name = "btnFood" + i,
                //        Text = table.Rows[i][0].ToString(), //name category
                //        Width = 120,
                //        Height = pnlCategory.Height - 40,
                //        Location = new Point(x, pnlCategory.Location.Y - 20),
                //        BackColor = ColorTranslator.FromHtml("Snow"),
                //    };
                //    x += 130;
                //    pnlCategory.Controls.Add(btn);
                //    btn.Click += new EventHandler(btnCategory_Click);
                //}
                ////san tien mo luon 1 food dau tien
                //loaddataFood(table.Rows[0][0].ToString());
            }
            catch
            {
            }
        }

        //Ham Load Food
        private void loaddataFood(string nameCategory)
        {
            try
            {
                //Don rac
                pnlFood.Controls.Clear();
                DataTable table = null; // provider.loadFood(nameCategory);
                txtNameFood.Text = table.Rows[0][0].ToString(); //ten cua thang food hien tai
                txtPriceFood.Text = table.Rows[0][2].ToString();  //gia cua thang food hien tai
                int y = 10;
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    Button btn = new Button()
                    {
                        Name = "btnFood" + i,
                        Text = table.Rows[i][0].ToString(), //name foods
                        Tag = table.Rows[i][2].ToString(), //Price food
                        Width = pnlFood.Width - 40,
                        Height = 50,
                        Location = new Point(pnlFood.Location.X, y),
                        BackColor = ColorTranslator.FromHtml("Snow"),
                    };
                    y += 60;
                    btn.Click += new EventHandler(btnFB_Click);
                    pnlFood.Controls.Add(btn);
                }
            }
            catch
            {
            }
        }

        //Su kien Mouseclick vao btnTABLE
        private void btnTable_MouseClick(object sender, EventArgs e)
        {
            ClickTable(sender, e);
        }
        private void ClickTable(object sender, EventArgs e)
        {
            //tra ve trang thai ban theo mau sac cua btnTable
            if (((Button)sender).BackColor.ToString() == "Color [Snow]")
            {
                txtSTT.Text = "EMPTY";
            }
            else if (((Button)sender).BackColor.ToString() == "Color [RED]")
            {
                txtSTT.Text = "ONLINE";
            }
            //tra ve ten ban
            txtNameTable.Text = ((Button)sender).Text;
            //Tra ve tong tien
            txtTotal.Text = ((Button)sender).Tag.ToString();
            LoadBill();
        }

        //Su kien click btnCATEGORY
        private void btnCategory_Click(object sender, EventArgs e)
        {
            string nameCate = ((Button)sender).Text;
            //Load mon theo yeu cau click cua Category
            loaddataFood(nameCate);
        }

        //Su kiem click btnFood
        private void btnFB_Click(object sender, EventArgs e)
        {
            //Gan text button mon an => text groupbox . cho no dep
            txtNameFood.Text = ((Button)sender).Text;
            txtPriceFood.Text = ((Button)sender).Tag.ToString();
        }

        //Ham xu ly Category
        private void tmiCategory_Click(object sender, EventArgs e)
        {
            try
            {
                //frmAdCategory frm = new frmAdCategory();
                //frm.ShowDialog();
                //this.Show();
                //loaddataCategory();
            }
            catch { }
        }

        //di den quan ly food
        private void tmiFood_Click(object sender, EventArgs e)
        {
            try
            {
                //frmAdFood frm = new frmAdFood();
                //frm.ShowDialog();
                //this.Show();
                //loaddataCategory();
            }
            catch { }
        }

        //di den quan ly table
        private void tmiTable_Click(object sender, EventArgs e)
        {
            try
            {
                //frmAdTables frm = new frmAdTables();
                //frm.ShowDialog();
                //this.Show();
                //loaddataTable();
            }
            catch { }
        }

        //di den thang Account
        private void tmiAccount_Click(object sender, EventArgs e)
        {
            try
            {
                //frmAdAccount frm = new frmAdAccount();
                //frm.ShowDialog();
                //this.Show();
            }
            catch { }
        }

        //Neu kich thuoc table thay doi thi load lai table cho phu hop
        private void gpbTable_SizeChanged(object sender, EventArgs e)
        {
            LoadTable();
        }


        //Su kien nhan button them mon
        private void btnAddFood_Click(object sender, EventArgs e)
        {
            AddFood();
        }
        private void AddFood()
        {
            try
            {
                if (txtSTT.Text == "ONLINE")
                {
                    //frmAddFood addF = new frmAddFood(txtNameTable.Text, txtNameFood.Text, txtSTT.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "DATTRUOC")
                {
                    MessageBox.Show("Bàn đã được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSTT.Text == "TRONG")
                {
                    DialogResult ms = MessageBox.Show("Bàn này đang trống. Mở bàn nhé?", "Lỗi", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
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

        //Nhan nut thanh toan
        private void btnPay_Click(object sender, EventArgs e)
        {
            PayFood();
        }
        private void PayFood()
        {
            try
            {
                if (txtSTT.Text == "ONLINE")
                {
                    //frmPay addF = new frmPay(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "DATTRUOC")
                {
                    MessageBox.Show("Bàn đã được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSTT.Text == "TRONG")
                {
                    MessageBox.Show("Bàn này đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //Nut chuyen ban
        private void btnReplaceTable_Click(object sender, EventArgs e)
        {
            ReplaceTable();
        }
        private void ReplaceTable()
        {
            try
            {
                if (txtSTT.Text == "ONLINE")
                {
                    //ReplaceTable addF = new ReplaceTable(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "DATTRUOC")
                {
                    MessageBox.Show("Bàn đã được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSTT.Text == "TRONG")
                {
                    MessageBox.Show("Bàn này đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //Gop ban
        private void btnPlusTable_Click(object sender, EventArgs e)
        {
            PlusTable();
        }
        private void PlusTable()
        {
            try
            {
                if (txtSTT.Text == "ONLINE")
                {
                    //PlusTable addF = new PlusTable(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "DATTRUOC")
                {
                    MessageBox.Show("Bàn đã được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSTT.Text == "TRONG")
                {
                    MessageBox.Show("Bàn này đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //Tra mon
        private void btnReturn_Click(object sender, EventArgs e)
        {
            ReturnFood();
        }
        private void ReturnFood()
        {
            try
            {
                if (txtSTT.Text == "ONLINE")
                {
                    //ReFood addF = new ReFood(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    //loaddataTable();
                    //loaddataBill();
                }
                else if (txtSTT.Text == "DATTRUOC")
                {
                    MessageBox.Show("Bàn đã được đặt", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else if (txtSTT.Text == "TRONG")
                {
                    MessageBox.Show("Bàn này đang trống", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //Khoa man hinh
        private void btnBlock_Click(object sender, EventArgs e)
        {
            //Block addF = new Block(username, lblName.Text, password);
            //addF.ShowDialog();
            //this.Show();
        }

        //In hoa don
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {

            }
            catch
            {
                MessageBox.Show("Không thể in hóa đơn!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //PrintDocument
        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            ////Chuoi hoa don
            //string HoaDon = "";
            //HoaDon += "\n" + txtNameMan.Text + "\n";
            //HoaDon += "\n" + txtAdress.Text + "\n\n\n";
            //HoaDon += "\n" + "           HÓA ĐƠN " + txtNameTable.Text + "        \n\n\n";
            //HoaDon += strBill;
            //HoaDon += "\n\n\nThời gian: " + datetime.Value.ToShortTimeString() + ". " + datetime.Value.ToShortDateString() + "\n";
            //HoaDon += "\nTổng cộng: " + txtTotal.Text + " VNĐ\n";
            //e.Graphics.DrawString(HoaDon, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 100, 200);
        }

        //Sua tai khoan
        private void tmiChange_Click(object sender, EventArgs e)
        {
            try
            {
                //ChangePersional addF = new ChangePersional(username, lblName.Text, password);
                //addF.ShowDialog();
                //this.Show();
                //loaddataTable();
                //loaddataBill();
            }
            catch
            {
                MessageBox.Show("Không thể thay đổi thông tin!", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        //Logout
        private void tmiLogout_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        //load context menu ban online
        private void cmnSubTable_Opening(object sender, CancelEventArgs e)
        {
        }
        //menu context SubTable
        private void tsmThemMon_Click(object sender, EventArgs e)
        {
            AddFood();
        }
        private void tsmTraMon_Click(object sender, EventArgs e)
        {
            ReturnFood();
        }
        private void tsmThanhToan_Click(object sender, EventArgs e)
        {
            PayFood();
        }
        private void tsmChuyenBan_Click(object sender, EventArgs e)
        {
            ReplaceTable();
        }
        private void tsmGopBan_Click(object sender, EventArgs e)
        {
            PlusTable();
        }


        //Context Menu ban trong
        private void cmnSubTable2_Opening(object sender, CancelEventArgs e)
        {
        }
        private void tmsThemMon2_Click(object sender, EventArgs e)
        {
            AddFood();
        }
        //Dat ban
        private void tsmDatBan_Click(object sender, EventArgs e)
        {
            try
            {
                //provider.Datban("DATTRUOC", txtNameTable.Text);
                LoadTable();
            }
            catch { }
        }


        //Context Menu ban trong
        private void cmnSubTable3_Opening(object sender, CancelEventArgs e)
        {
        }
        //Mo ban
        private void tsmMoBan_Click(object sender, EventArgs e)
        {
            try
            {
                //provider.Datban("TRONG",txtNameTable.Text);
                LoadTable();
            }
            catch { }
        }
    }
}
