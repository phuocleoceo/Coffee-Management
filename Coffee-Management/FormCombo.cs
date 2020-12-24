using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormCombo : Form
    {
        private ManageList<Drink> listDrink = new ManageList<Drink>();
        private ManageList<DrinkType> listType = new ManageList<DrinkType>();
        private ManageList<string> listChooseType = new ManageList<string>();
        private ManageList<Drink> listChooseDrink = new ManageList<Drink>();
        public FormCombo()
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
            Display.FormatTable(dgvResult);
            BUS_DrinkType.Instance.GetList(listType);
            BUS_DrinkType.Instance.LoadDrinkTypeToComboBox(listType, cbType);
            BUS_Drink.Instance.GetList(listDrink);
        }

        /*-------------------------------------------------------------------------------------*/
        private static float Money;
        private static float LeastMoney;
        private static int Quantity;
        //Lay cac du lieu can thiet
        private void GetInput()
        {
            Money = float.Parse(txtMoney.Text);
            LeastMoney = float.Parse(txtLessMoney.Text);
            Quantity = int.Parse(txtQuantity.Text);
            result = new Drink[Quantity];
            A = new int[Quantity + 1];
        }

        // Thêm Type được chọn vào list ChooseType , đồng thời hiện lên textbox
        private int dem = 1;
        private void btnAddType_Click(object sender, EventArgs e)
        {
            if (cbType.Text != String.Empty)
            {
                listChooseType.Add(cbType.Text);
                txtType.Text += (dem++).ToString() + ". " + cbType.Text + "\r\n";
                cbType.Items.Remove(cbType.Text);
            }
        }

        // Thu duoc list cac Drink thuoc Type da chon
        private void getListChooseDrink()
        {
            BUS_Drink.Instance.getListDrinkWithManyType(listDrink, listChooseDrink, listChooseType);
            BUS_Drink.Instance.QuickSort(listChooseDrink, 0, listChooseDrink.Count - 1);
        }
        /*-------------------------------------------------------------------------------------*/
        private Drink[] result;
        private int[] A;

        //Lay to hop C(Quantity,listChooseDrink.Count)
        private void Try(int i)
        {
            for (int j = 1 + A[i - 1]; j <= listChooseDrink.Count - Quantity + i; j++)
            {
                A[i] = j;
                result[i - 1] = listChooseDrink[j - 1];
                //if (ckbDiffType.Checked && i >= 2 && (result[i - 1].Type == result[i - 2].Type)) return;
                if (i == Quantity) Check();
                else Try(i + 1);
            }
        }
        //Kiem tra xem tong cac Drink co bang Money khong
        private void Check()
        {
            float SUM = 0;
            for (int i = 0; i < result.Length; i++)
            {
                SUM += result[i].Price;
            }
            if (!ckbLessEqual.Checked && SUM == Money && Different()) AddDGV();
            else if (ckbLessEqual.Checked && SUM <= Money && SUM >= LeastMoney && Different()) AddDGV();
        }

        //Them vao DGV
        private void AddDGV()
        {
            float EndPrice = 0;
            for (int i = 0; i < result.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResult);
                row.Cells[0].Value = result[i].Name;
                row.Cells[1].Value = result[i].Price;
                dgvResult.Rows.Add(row);
                EndPrice += result[i].Price;
            }
            //Gia tien
            DataGridViewRow Price = new DataGridViewRow();
            Price.CreateCells(dgvResult);
            Price.DefaultCellStyle.BackColor = Color.GreenYellow;
            Price.Cells[0].Value = "---------Price After Discount : ---";
            //Price.Cells[1].Value = "-----  " + EndPrice + "  ----";
            Price.Cells[1].Value = "-----  " + (EndPrice * (1 - float.Parse(txtDiscount.Text) / 100)) + "  ----";
            dgvResult.Rows.Add(Price);
        }

        //Kiem tra khac nhau
        private bool Different()
        {
            if (ckbDiffType.Checked)
            {
                for (int i = 0; i < result.Length - 1; i++)
                {
                    for (int j = i + 1; j < result.Length; j++)
                    {
                        if (result[i].Type == result[j].Type) return false;
                    }
                }
                return true;
            }
            else return true;
        }

        /*-------------------------------------------------------------------------------------*/
        private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                ResetDGV();
                GetInput();
                getListChooseDrink();
                Try(1);
            }
            catch
            {
                MessageBox.Show("Error ! Please Check Input Again ! ");
            }
        }
        //Reset Input
        private void ResetDGV()
        {
            dgvResult.DataSource = null;
            dgvResult.Rows.Clear();
        }

        //Chon <= Money thi cho phep nhap Less Money
        private void ckbLessEqual_CheckStateChanged(object sender, EventArgs e)
        {
            if (ckbLessEqual.Checked) txtLessMoney.Enabled = true;
            else
            {
                txtLessMoney.Text = "0";
                txtLessMoney.Enabled = false;
            }
        }
        //Quantity > Type thi khong the chon cac do uong khac Type duoc
        private void txtQuantity_TextChanged(object sender, EventArgs e)
        {
            if (txtQuantity.Text != String.Empty)
            {
                if (int.Parse(txtQuantity.Text) > listChooseType.Count)
                    ckbDiffType.Enabled = false;
                else ckbDiffType.Enabled = true;
            }
        }
    }
}
