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
        private ManageList<Drink> listDrink = new ManageList<Drink>();
        private ManageList<Table> listTable = new ManageList<Table>();
        private ManageList<Bill> listBill = new ManageList<Bill>();
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
        /*---------------------------------TABLE + BILL-----------------------------------------------*/
        
        // Load danh sach Table
        private void LoadTable()
        {
            try
            {
                pnlTable.Controls.Clear();
                BUS_Table.Instance.GetList(listTable);
                int x = 10;
                int y = 10;
                for (int i = 0; i < listTable.Count; i++)
                {
                    Button btn = new Button()
                    {
                        Name = "btnTable" + (i + 1),
                        Text = listTable[i].Name,
                        Tag = listTable[i].Total.ToString(),
                        Width = 100,
                        Height = 50,
                        Location = new Point(x, y),
                    };
                    if (listTable[i].Status == "Empty")
                    {
                        btn.BackColor = ColorTranslator.FromHtml("snow");
                    }
                    else if (listTable[i].Status == "Online")
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

                    //pnlTable.Controls.Clear();
                    //DataTable table = BUS_Table.Instance.Read();
                    //int x = 10;
                    //int y = 10;
                    //for (int i = 0; i < table.Rows.Count; i++)
                    //{
                    //    Button btn = new Button()
                    //    {
                    //        Name = "btnTable" + (i + 1),
                    //        Text = table.Rows[i][1].ToString(),
                    //        Tag = table.Rows[i][3].ToString(),
                    //        Width = 100,
                    //        Height = 50,
                    //        Location = new Point(x, y),
                    //    };
                    //    if (table.Rows[i][2].ToString() == "Empty")
                    //    {
                    //        btn.BackColor = ColorTranslator.FromHtml("snow");
                    //    }
                    //    else if (table.Rows[i][2].ToString() == "Online")
                    //    {
                    //        btn.BackColor = ColorTranslator.FromHtml("red");
                    //    }
                    //    if (x < pnlTable.Width - 220)
                    //    {
                    //        x += 110;
                    //    }
                    //    else
                    //    {
                    //        x = 10;
                    //        y += 60;
                    //    }
                    //    btn.MouseClick += new MouseEventHandler(btnTable_MouseClick);
                    //    pnlTable.Controls.Add(btn);
                    //}
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
                BUS_Bill.Instance.GetList(listBill, txtNameTable.Text);
                int y = 10;
                for (int i = 0; i < listBill.Count; i++)
                {
                    strBill += (i + 1) + ".     " + listBill[i].DrinkName + "  X  " + listBill[i].Counts.ToString() + "\n";
                    Label lbl = new Label()
                    {
                        Name = "btnFB" + i,
                        Text = (i + 1) + ".     " + listBill[i].DrinkName + "  X  " + listBill[i].Counts.ToString(),
                        Width = pnlBill.Width - 20,
                        Height = 20,
                        Location = new Point(5, y)
                    };
                    y += 25;
                    pnlBill.Controls.Add(lbl);
                }

                //pnlBill.Controls.Clear();
                //strBill = "";
                //DataTable table = BUS_Bill.Instance.Read(txtNameTable.Text);
                //int y = 10;
                //for (int i = 0; i < table.Rows.Count; i++)
                //{
                //    strBill += (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString() + "\n";
                //    Label lbl = new Label()
                //    {
                //        Name = "btnFB" + i,
                //        Text = (i + 1) + ".     " + table.Rows[i][2].ToString() + "  X  " + table.Rows[i][3].ToString(),
                //        Width = pnlBill.Width - 20,
                //        Height = 20,
                //        Location = new Point(5, y)
                //    };
                //    y += 25;
                //    pnlBill.Controls.Add(lbl);
                //}
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
            else if (((Button)sender).BackColor.ToString() == "Color [Red]")
            {
                txtSTT.Text = "Online";
            }
            //tra ve ten ban
            txtNameTable.Text = ((Button)sender).Text;
            //Tra ve tong tien
            txtTotal.Text = ((Button)sender).Tag.ToString();
            LoadBill();
        }
        private void gpbTable_SizeChanged(object sender, EventArgs e)
        {
            LoadTable();
        }

        /*---------------------------------ADD DRINK-----------------------------------------------*/
        
        //Xu lu khi chon chuc nang Add Drink
        private void btnAddDrink_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            AddDrink();
        }
        //Them do uong
        private void AddDrink()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    grbAddDrink.Visible = true;
                    LoadDataForAddDrinkGRB();
                }
                else if (txtSTT.Text == "Empty")
                {
                    DialogResult ms = MessageBox.Show("This Table Is Now Empty !. Open It?", "Error", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (ms == DialogResult.Yes)
                    {
                        grbAddDrink.Visible = true;
                        LoadDataForAddDrinkGRB();
                    }
                }
            }
            catch { }
        }

        //Xu ly trong GroupBox Add Drink
        bool isDrink = false;
        private void LoadDataForAddDrinkGRB()
        {
            txtTableAD.Text = txtNameTable.Text;
            ManageList<Drink> listDrink = new ManageList<Drink>();
            BUS_Drink.Instance.GetList(listDrink);
            for (int i = 0; i < listDrink.Count; i++)
            {
                cbbDrinkAD.Items.Add(listDrink[i].Name);
            }
        }
        //Chuyen trang thai Table sang Online
        private void SetTableOnline()
        {
            BUS_Table.Instance.SetTableOnline(txtNameTable.Text);
        }
        //Tinh tong tien
        private void setTotal()
        {
            float DrinkTotal = getPrice() * float.Parse(nUDQuantityAD.Value.ToString());
            BUS_Table.Instance.SetTotal(txtNameTable.Text, DrinkTotal);
        }
        //Them do uong moi
        private void AddNewDrink()
        {
            Bill bill = new Bill(txtTableAD.Text, cbbDrinkAD.Text, Int32.Parse(nUDQuantityAD.Value.ToString()));
            BUS_Bill.Instance.Create(bill);
            setTotal();
        }
        //Tang so do uong
        private void IncreaseDrink()
        {
            Bill bill = new Bill(txtTableAD.Text, cbbDrinkAD.Text, Int32.Parse(nUDQuantityAD.Value.ToString()));
            BUS_Bill.Instance.Update(bill, 0);
            setTotal();
        }
        //Lay gia do uong
        private float getPrice()
        {
            BUS_Drink.Instance.GetList(listDrink);
            for(int i = 0; i < listDrink.Count; i++)
            {
                if (listDrink[i].Name == cbbDrinkAD.Text)
                    return listDrink[i].Price;
            }
            return 0;
        }
        //Kiem tra xem mon da ton tai chua , neu co roi thi true
        public void isCountDrink()
        {
            try
            {
                int CountDrink = BUS_Bill.Instance.GetCountDrink(txtTableAD.Text, cbbDrinkAD.Text);
                if (CountDrink > 0)
                {
                    isDrink = true;
                }
            }
            catch
            {
                isDrink = false;
            }
        }
        //Submit AddDrink GRB
        private void btnAddAD_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtSTT.Text == "Empty")
                {
                    SetTableOnline();
                    AddNewDrink();
                    LoadTable();
                    LoadBill();
                }
                else if (txtSTT.Text == "Online")
                {
                    //Ban dang hoat dong. chi them mon
                    isCountDrink();
                    if (isDrink == false)
                    {
                        //Neu mon chua co thi them mon
                        AddNewDrink();
                        LoadTable();
                        LoadBill();
                    }
                    else
                    {
                        //Neu mon co roi thi tang so luong
                        IncreaseDrink();
                        LoadTable();
                        LoadBill();
                    }
                }
                MessageBox.Show("Add Drink Successful ! ", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Add Drink Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*---------------------------------SWITCH TABLE--------------------------------------------*/

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            SwitchTable();
        }
        // Chuyen ban
        private void SwitchTable()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    grbSwitchTable.Visible = true;
                    //ReplaceTable addF = new ReplaceTable(txtNameTable.Text);
                    //addF.ShowDialog();
                    //this.Show();
                    LoadTable();
                    LoadBill();
                }
                else if (txtSTT.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        /*---------------------------------PURCHASE------------------------------------------------*/

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            PurchaseDrink();
        }
        //Thanh toan
        private void PurchaseDrink()
        {
            try
            {
                if (txtSTT.Text == "Online")
                {
                    DialogResult ms = MessageBox.Show("Comfirm Purchase : " + txtNameTable.Text + "\nTotal Price: " + txtTotal.Text + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (ms == DialogResult.Yes)
                    {
                        BUS_Table.Instance.ClearTable(txtNameTable.Text);
                        BUS_Bill.Instance.ClearBill(txtNameTable.Text);
                        MessageBox.Show("Purchase success !  " + txtNameTable.Text, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);                        
                    }
                    LoadTable();
                    LoadBill();
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
