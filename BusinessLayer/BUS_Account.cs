using System.Data;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public sealed class BUS_Account : BUS<BUS_Account, Account, string>
    {
        public override DataTable Read()
        {
            return DAL_Account.Instance.Read();
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
            DAL_Account.Instance.Create(newAccount);
        }
        public override void Delete(string deleteUserName)
        {
            DAL_Account.Instance.Delete(deleteUserName);
        }
        public override void Update(Account updateAccount, string oldUserName)
        {
            DAL_Account.Instance.Update(updateAccount, oldUserName);
        }
    }
}
