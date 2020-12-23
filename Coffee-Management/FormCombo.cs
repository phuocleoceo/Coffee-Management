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

            LoadCBType();
            BUS_Drink.Instance.GetList(listDrink);
        }
        /*-------------------------------------------------------------------------------------*/
        private static float Money;
        private static int Quantity;

        private void GetInput()
        {
            float BeforeMoney = float.Parse(txtMoney.Text);
            float Discount = float.Parse(txtDiscount.Text);
            Money = BeforeMoney * (1 + Discount / 100);
            Quantity = int.Parse(txtQuantity.Text);
            result = new Drink[Quantity];
            A = new int[Quantity + 1];
        }

        private void LoadCBType()
        {
            BUS_DrinkType.Instance.GetList(listType);
            for (int i = 0; i < listType.Count; i++)
            {
                cbType.Items.Add(listType[i].Name);
            }
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
            listChooseDrink.Clear();
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (listChooseType.Contains(listDrink[i].Type))
                {
                    listChooseDrink.Add(listDrink[i]);
                }
            }
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
            if (SUM == Money && Different()) AddDGV();
        }

        //Them vao DGV
        private void AddDGV()
        {
            for (int i = 0; i < result.Length; i++)
            {
                DataGridViewRow row = new DataGridViewRow();
                row.CreateCells(dgvResult);
                row.Cells[0].Value = result[i].Name;
                row.Cells[1].Value = result[i].Price;
                dgvResult.Rows.Add(row);
            }
            DataGridViewRow Line = new DataGridViewRow();
            Line.CreateCells(dgvResult);
            Line.Cells[0].Value = "--------------------------------------------";
            Line.Cells[1].Value = "------------------------";
            dgvResult.Rows.Add(Line);
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
                GetInput();
                getListChooseDrink();
                Try(1);
                btnCombo.Enabled = false;
            }
            catch
            {
                MessageBox.Show("Error ! Please Check Input Again ! ");
            }
        }


    }
}
