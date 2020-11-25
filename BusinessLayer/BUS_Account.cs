using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BUS_Account
    {
        private DAL_Account DAL_Account = new DAL_Account();
        public DataTable Read()
        {
            return DAL_Account.Read();
        }
        public void GetList(ManageList<Account> list)
        {
            list.Clear();              
            foreach (DataRow row in Read().Rows)
            {
                string UN = row["UserName"].ToString();
                string DN = row["DisplayName"].ToString();
                string PW = row["PassWord"].ToString();
                int Type = (int)row["Type"];
                list.Add(new Account(UN, DN, PW, Type));
            }
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public void Create(Account newAccount)
        {
            DAL_Account.Create(newAccount);
        }
        public void Delete(string deleteUserName)
        {
            DAL_Account.Delete(deleteUserName);
        }
        public void Update(Account updateAccount, string oldUserName)
        {
            DAL_Account.Update(updateAccount, oldUserName);
        }
    }
}
