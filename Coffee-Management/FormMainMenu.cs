using BussinessLayer;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using Model;

namespace GUILayer
{
    public partial class FormMainMenu : Form
    {
        /*-----------------------------------------------------------------*/
        public static ManageList<Table> listTable = new ManageList<Table>();
        public static ManageList<Drink> listDrink = new ManageList<Drink>();
        private BUS_Drink BUS_Drink = new BUS_Drink();
        private BUS_Table BUS_Table = new BUS_Table();
        private int Type = FormLogin.Type;
        /*-----------------------------------------------------------------*/
        //Khai báo các Hàm
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            Decentralization();
            hideSubMenu();
            random = new Random();
        }
        private void FormMainMenu_Load(object sender, EventArgs e)
        {
            BUS_Table.GetList(listTable);
            BUS_Drink.GetList(listDrink);
        }
        //Phân quyền
        private void Decentralization()
        {
            if (Type == 1)
                btnAdmin.Enabled = true;
            else
                btnAdmin.Enabled = false;
        }
        //Lựa Chọn Màu
        private Color SelectThemeColor()
        {
            int index = random.Next(ThemeColor.ColorList.Count);
            while (tempIndex == index)
            {
                index = random.Next(ThemeColor.ColorList.Count);
            }
            tempIndex = index;
            string color = ThemeColor.ColorList[index];
            return ColorTranslator.FromHtml(color);
        }
        //Kích Hoạt Nút Bấm - Có Đổi Màu
        private void ActivateButton(object btnSender)
        {
            if (btnSender != null)
            {
                if (currentButton != (Button)btnSender)
                {
                    DisableButton();
                    Color color = SelectThemeColor();
                    currentButton = (Button)btnSender;
                    currentButton.BackColor = color;
                    currentButton.ForeColor = Color.White;
                    currentButton.Font = new Font("Monotype Corsiva", 24F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                    panelTitleBar.BackColor = color;
                    panelLogo.BackColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                    ThemeColor.PrimaryColor = color;
                    ThemeColor.SecondaryColor = ThemeColor.ChangeColorBrightness(color, -0.3);
                }
            }
        }
        //Kích Hoạt Nút Bấm - Xoá Màu
        private void DisableButton()
        {
            foreach (Control previousBtn in panelSlideMenu.Controls)
            {
                if (previousBtn.GetType() == typeof(Button))
                {
                    previousBtn.BackColor = Color.FromArgb(51, 51, 76);
                    previousBtn.ForeColor = Color.Gainsboro;
                    previousBtn.Font = new Font("Monotype Corsiva", 22F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                }
            }
        }
        //Mở Ra Các Form Con
        private void OpenChildForm(Form childForm, object btnSender)
        {
            if (activeForm != null)
                activeForm.Close();
            ActivateButton(btnSender);
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.None;
            this.panelDesktopPane.Controls.Add(childForm);
            this.panelDesktopPane.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitle.Text = childForm.Text;
        }
        //Hiện Sub Menu
        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }
        //Ẩn Sub Menu
        private void hideSubMenu()
        {
            panelAccountSubMenu.Visible = false;
        }
        //Thiết Lập Các Click Nút

        private void btnAccount_Click(object sender, EventArgs e)
        {

            OpenChildForm(new FormAccount(), sender);
            showSubMenu(panelAccountSubMenu);
        }
        private void btnAdmin_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdmin(), sender);
            hideSubMenu();
        }
        private void btnAccountProfile_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAccountProfile(), sender);
            hideSubMenu();
        }
        private void btnLogout_Click(object sender, EventArgs e)
        {
            //OpenChildForm(new FormLogin(), sender);
            hideSubMenu();
            Close();
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTable(), sender);
            hideSubMenu();
        }
        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormReporting(), sender);
            hideSubMenu();
        }
    }
}
