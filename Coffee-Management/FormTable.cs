using System;
using Model;
using System.Data;
using System.ComponentModel;
using System.Drawing;
using System.Windows.Forms;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormTable : Form
    {
        private ManageList<DrinkType> listDrinkType = new ManageList<DrinkType>();
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

        private void cbbDrinkTypeAD_SelectedIndexChanged(object sender, EventArgs e)
        {
            string DrinkTypeSelected = cbbDrinkTypeAD.Text;
            cbbDrinkAD.Items.Clear();
            cbbDrinkAD.Text = "";
            BUS_Drink.Instance.GetList(listDrink);
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (listDrink[i].Type == DrinkTypeSelected)
                    cbbDrinkAD.Items.Add(listDrink[i].Name);
            }
        }

        //Xu ly trong GroupBox Add Drink        
        private void LoadDataForAddDrinkGRB()
        {
            txtTableAD.Text = txtNameTable.Text;
            BUS_DrinkType.Instance.GetList(listDrinkType);
            cbbDrinkTypeAD.Items.Clear();
            for (int i = 0; i < listDrinkType.Count; i++)
            {
                cbbDrinkTypeAD.Items.Add(listDrinkType[i].Name);
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
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (listDrink[i].Name == cbbDrinkAD.Text)
                    return listDrink[i].Price;
            }
            return 0;
        }

        bool isDrink = false;
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
                }
                else if (txtSTT.Text == "Online")
                {
                    //Ban dang hoat dong. chi them mon
                    isCountDrink();
                    if (isDrink == false)
                    {
                        //Neu mon chua co thi them mon
                        AddNewDrink();
                    }
                    else
                    {
                        //Neu mon co roi thi tang so luong
                        IncreaseDrink();
                    }
                }
                HideGroupBox();
                LoadTable();
                LoadBill();
                //Do khong the goi duoc phuong thuc ClickTable de cap nhat lai Total Price
                float DrinkTotal = float.Parse(txtTotal.Text) + getPrice() * float.Parse(nUDQuantityAD.Value.ToString());
                txtTotal.Text = DrinkTotal.ToString();
                txtSTT.Text = "Online";
                MessageBox.Show("Add Drink Successful ! ", "Great", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Add Drink Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        /*---------------------------------SWITCH TABLE--------------------------------------------*/
        private void LoadDataForSwitchTableGRB()
        {
            txtFromTable.Text = txtNameTable.Text;
            cbbToTable.Items.Clear();
            BUS_Table.Instance.GetList(listTable);
            for (int i = 0; i < listTable.Count; i++)
            {
                if (listTable[i].Name != txtFromTable.Text)
                    cbbToTable.Items.Add(listTable[i].Name);
            }
        }

        private void btnSwitchTable_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            try
            {
                if (txtSTT.Text == "Online")
                {
                    grbSwitchTable.Visible = true;
                    LoadDataForSwitchTableGRB();
                }
                else if (txtSTT.Text == "Empty")
                {
                    MessageBox.Show("This Table Is Now Empty !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch { }
        }

        //Kiem tra xem Ban Dich co dang Online khong
        private bool CheckTableToSwitch()
        {
            BUS_Table.Instance.GetList(listTable);
            for (int i = 0; i < listTable.Count; i++)
            {
                if (listTable[i].Name == cbbToTable.Text)
                {
                    if (listTable[i].Total == 0)
                        return true;
                }
            }
            return false;
        }

        //Submit chuyen ban
        private void btnAcceptSwitch_Click(object sender, EventArgs e)
        {
            if (CheckTableToSwitch())
            {
                DialogResult ms = MessageBox.Show("Do you want to switch table " + txtFromTable.Text + " to " + cbbToTable.Text + " ?", "Submit", MessageBoxButtons.YesNo);
                if (ms == DialogResult.Yes)
                {
                    //moveTable();
                    MessageBox.Show("Switch Table Successfully !", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Switch Table Fail !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /*---------------------------------PURCHASE------------------------------------------------*/

        private void btnPurchase_Click(object sender, EventArgs e)
        {
            HideGroupBox();
            try
            {
                if (txtSTT.Text == "Online")
                {
                    DialogResult ms = MessageBox.Show("Comfirm Purchase : " + txtNameTable.Text + "\n\nTotal Price: " + txtTotal.Text + " VND", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.None);
                    if (ms == DialogResult.Yes)
                    {
                        BUS_Table.Instance.ClearTable(txtNameTable.Text);
                        BUS_Bill.Instance.ClearBill(txtNameTable.Text);
                        txtSTT.Text = "Empty";
                        txtTotal.Text = "0";
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
        /*-------------------------------PRINT BILL------------------------------------------------*/
        private void btnPrint_Click(object sender, EventArgs e)
        {
            try
            {
                printDialogBill.Document = printDocumentBill;
                if (printDialogBill.ShowDialog() == DialogResult.OK)
                {
                    printDocumentBill.Print();
                }
            }
            catch
            {
                MessageBox.Show("Can't print Bill !", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void printDocumentBill_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            DateTimePicker datetime = new DateTimePicker();
            string HoaDon = "";
            HoaDon += "\n" + "IT Coffee Shop" + "\n";
            HoaDon += "\n" + "Address : Danang University of Technology" + "\n\n\n";
            HoaDon += "\n" + "Bill " + txtNameTable.Text + "        \n\n\n";
            HoaDon += strBill;
            HoaDon += "\n\n\nTime: " + datetime.Value.ToShortTimeString() + ". " + datetime.Value.ToShortDateString() + "\n";
            HoaDon += "\nTotal Price : " + txtTotal.Text + " VNĐ\n";
            e.Graphics.DrawString(HoaDon, new Font("Arial", 15, FontStyle.Bold), Brushes.Black, 100, 200);
        }

    }
}
