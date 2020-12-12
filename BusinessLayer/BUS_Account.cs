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
                list.Add(new Account(row));
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
