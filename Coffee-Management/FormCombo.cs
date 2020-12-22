using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormCombo : Form
    {
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
            LoadCBType();
            BUS_Drink.Instance.GetList(listDrink);
            QuickSort(listDrink, 0, listDrink.Count - 1);
        }
        /*-------------------------------------------------------------------------------------*/
        private void QuickSort(ManageList<Drink> list, int left, int right)
        {
            if (left <= right)
            {
                int i = left, j = right;
                Drink x = list[(left + right) / 2];
                while (i <= j)
                {
                    while (list[i].Price > x.Price) i++;
                    while (list[j].Price < x.Price) j--;
                    if (i <= j)
                    {
                        Drink temp = list[i];
                        list[i] = list[j];
                        list[j] = temp;
                        i++;
                        j--;
                    }
                }
                if (left < j) QuickSort(list, left, j);
                if (i < right) QuickSort(list, i, right);
            }
        }
        /*-------------------------------------------------------------------------------------*/

        private ManageList<DrinkType> listType = new ManageList<DrinkType>();
        private ManageList<string> listChooseType = new ManageList<string>();
        //Load List DrinkType vào Combobox , chọn từng cái rồi bấm Add để thêm vào listChooseType
        private void LoadCBType()
        {
            BUS_DrinkType.Instance.GetList(listType);
            for (int i = 0; i < listType.Count; i++)
            {
                cbType.Items.Add(listType[i].Name);
            }
        }
        private int dem = 1;

        private void btnAddType_Click_1(object sender, EventArgs e)
        {
            if (cbType.Text != String.Empty)
            {
                listChooseType.Add(cbType.Text);
                txtType.Text += (dem++).ToString() + ". " + cbType.Text + "\r\n";
                cbType.Items.Remove(cbType.Text);
            }
        }
        /*-------------------------------------------------------------------------------------*/

        //list là List lưu trữ các List Drink tương ứng với từng DrinkType đã được chọn ở trên
        private ManageList<Drink> listDrink = new ManageList<Drink>();
        private ManageList<ManageList<Drink>> list = new ManageList<ManageList<Drink>>();
        private void GetListDrinkPerType()
        {
            //Tạo list temp để làm trung gian lưu trữ
            ManageList<Drink> temp = new ManageList<Drink>();
            /* Duyệt từng listChoosenType một (string) , duyệt listDrink tìm loại Drink có Type giống
             với listChoosenType[i] rồi kết hợp chúng thành List temp, thêm temp vào list ta được list[i]
             */
            for (int i = 0; i < listChooseType.Count; i++)
            {
                temp.Clear();
                for (int j = 0; j < listDrink.Count; j++)
                {
                    if (listDrink[j].Type == listChooseType[i])
                        temp.Add(listDrink[j]);
                }
                list.Add(temp);
            }
        }
        /*-------------------------------------------------------------------------------------*/
        private float Money;
        private void GetMoney()
        {
            float BeforeMoney = float.Parse(txtMoney.Text);
            float Discount = float.Parse(txtDiscount.Text);
            Money = BeforeMoney * (1 + Discount / 100);
        }
        /*-------------------------------------------------------------------------------------*/

        private ManageList<Drink> result = new ManageList<Drink>();
        private float SUM = 0;
        private void Try(int i)
        {
            for (int j = 0; j < list[i].Count; j++)
            {
                if (list[i][j].Price <= Money && list[i][j].Price + SUM <= Money)
                {
                    SUM += list[i][j].Price;
                    result.Add(list[i][j]);
                }
                //Neu khong tim thay thi dung ham de quy do de quay lui
                if (result[i] == null)
                {
                    result.RemoveAt(i);
                    return;
                }
                else if (i == list.Count - 1) return;
                else
                {
                    Try(i + 1);
                }
            }
        }

        private void getCombo()
        {
            Try(0);
            for (int i = 0; i < result.Count; i++)
            {
                lsvResult.Items.Add(result[i].Name);
            }
        }
        /*-------------------------------------------------------------------------------------*/
              private void btnCombo_Click(object sender, EventArgs e)
        {
            try
            {
                GetMoney();
                GetListDrinkPerType();
                getCombo();
            }
            catch (Exception exp)
            {
                MessageBox.Show(exp.Message);
                //MessageBox.Show("Error ! Please Check Input Again ! ");
            }
        }
    }
}

/*
 Thực tế thì số tiền thường lớn  + số loại đồ uống ko quá nhiều + thuật toán chỉ lấy giá trị 
tốt nhất nên dù quay lui ra rất nhiều kết quả nhưng thời gian chạy vẫn sẽ được tối ưu
 */