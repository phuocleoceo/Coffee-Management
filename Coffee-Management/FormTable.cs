using System;
using System.Drawing;
using System.Windows.Forms;
using Model;
using BusinessLayer;

namespace GUILayer
{
    public partial class FormTable : Form
    {
        private ManageList<Table> listTable = FormMainMenu.listTable;
        private ManageList<Drink> listDrink = FormMainMenu.listDrink;
        private void getComboBoxSwitchTable(ManageList<Table> list, ComboBox cb)
        {
            for (int i = 0; i < list.Count; i++)
            {
                cb.Items.Add(list[i].Name);
            }
        }
        private void getComboBoxDrinkType(ManageList<Drink> list, ComboBox cb)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (!cb.Items.Contains(list[i].Type))
                    cb.Items.Add(list[i].Type);
            }
        }
        private void getListDrink(ManageList<Drink> list, DataGridView dgv, string DrinkType)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Type == DrinkType)
                {
                    DataGridViewRow row = new DataGridViewRow();
                    row.CreateCells(dgv);
                    row.Cells[0].Value = list[i].Name;
                    dgv.Rows.Add(row);
                }
            }
        }
        private void getListViewTable(ManageList<Table> list, ListView lsv)
        {
            for (int i = 0; i < list.Count; i++)
            {
                lsv.Items.Add(list[i].Name);
            }
        }
        /*----------------------------------------------------------------------*/
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
            Display.FormatMiniTable(dgvDrink);
            getComboBoxSwitchTable(listTable, cbSwitchTable);
            getComboBoxDrinkType(listDrink, cbDrinkType);
            Display.FormatListViewTable(listViewTable);
            getListViewTable(listTable, listViewTable);
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
            dgvDrink.Rows.Clear();
            dgvDrink.DataSource = null;
            getListDrink(listDrink, dgvDrink, cbDrinkType.Text);
        }

        private void dgvDrink_SelectionChanged(object sender, EventArgs e)
        {
            string currentDrinkName = dgvDrink.CurrentRow.Cells[0].Value.ToString();
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (listDrink[i].Name == currentDrinkName)
                {
                    txbDrinkName.Text = listDrink[i].Name;
                    txbDrinkPrice.Text = listDrink[i].Price.ToString();
                }
            }
        }
    }
}

