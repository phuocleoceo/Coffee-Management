using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Account:BUS<DAL_Account,Account,string>
    {
        public override DataTable Read()
        {
            return DAL.Read();
        }
        public override void GetList(ManageList<Account> list)
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
        public override void Create(Account newAccount)
        {
            DAL.Create(newAccount);
        }
        public override void Delete(string deleteUserName)
        {
            DAL.Delete(deleteUserName);
        }
        public override void Update(Account updateAccount, string oldUserName)
        {
            DAL.Update(updateAccount, oldUserName);
        }
    }
}
