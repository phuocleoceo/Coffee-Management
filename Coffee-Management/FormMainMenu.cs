using BusinessLayer;
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
        private string Type = FormLogin.Type;
        /*-----------------------------------------------------------------*/
        //Khai báo các Hàm
        private Button currentButton;
        private Random random;
        private int tempIndex;
        private Form activeForm;
        public FormMainMenu()
        {
            InitializeComponent();
            FormBorderStyle = FormBorderStyle.None;   //Khong Vien
            Decentralization();
            random = new Random();
        }
        //Phân quyền
        private void Decentralization()
        {
            if (Type == "Admin")
                btnAccount.Enabled = true;
            else
                btnAccount.Enabled = false;
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
        //Thiết Lập Các Click Nút

        private void btnAccount_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormAdmin(), sender);
        }
        private void btnTable_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormTable(), sender);
        }
        private void btnReporting_Click(object sender, EventArgs e)
        {
            OpenChildForm(new FormCombo(), sender);
        }

        private void btnCloseChildForm_Click(object sender, EventArgs e)
        {
            Close();            
        }
    }
}
