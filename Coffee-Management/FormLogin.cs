using System;
using System.Windows.Forms;
using BusinessLayer;
using Model;

namespace GUILayer
{
    public partial class FormLogin : Form
    {
        //----------------------------------------------------------------------------------
        public static ManageList<Account> listAccount = new ManageList<Account>();
        private BUS_Account BUS_Account = new BUS_Account();
        public static int Type;  //Biên lưu vai trò của Account ( 1 Admin  0 Staff )
        //----------------------------------------------------------------------------------
        public FormLogin()
        {
            InitializeComponent();
            btnHidePass.Hide();
        }
        private void FormLogin_Load(object sender, EventArgs e)
        {
            BUS_Account.GetList(listAccount);
        }

        private bool CheckLogin(string username, string password)
        {
            for (int i = 0; i < listAccount.Count; i++)
            {
                if (String.Compare(listAccount[i].UserName, username) == 0 &&
                    String.Compare(listAccount[i].PassWord, password) == 0)
                {
                    Type = listAccount[i].Type;
                    return true;
                }
            }
            return false;
        }
        //Thiết Lập Các Click Nút
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string userName = txbUserName.Text;
            string passWord = txbPassWord.Text;
            if (CheckLogin(userName, passWord))
            {
                txbUserName.Text = String.Empty;
                txbPassWord.Text = String.Empty;
                //Show Form MainMenu
                FormMainMenu mainMenu = new FormMainMenu();
                this.Hide();
                mainMenu.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Your Password or User Name is not correct!");
            }
        }

        //Tạo một Button Có Muốn Thoát Hay Là Không
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (MessageBox.Show("Do you want to exit ?", "Confirm Navigation", MessageBoxButtons.OKCancel) != DialogResult.OK)
            {
                e.Cancel = true;
            }
        }
        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {
            txbPassWord.UseSystemPasswordChar = false;
            btnShowPass.Hide();
            btnHidePass.Show();
        }

        private void btnHidePass_Click(object sender, EventArgs e)
        {
            txbPassWord.UseSystemPasswordChar = true;
            btnHidePass.Hide();
            btnShowPass.Show();
        }
    }
}
