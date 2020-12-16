using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public sealed class DAL_Account : DAL<DAL_Account, Account, string>
    {
        public override void Create(Account newAccount)
        {
            SqlCommand cmd = new SqlCommand("InsertAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = newAccount.UserName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = newAccount.DisplayName;
            cmd.Parameters.AddWithValue("@PassWord", SqlDbType.NVarChar).Value = newAccount.PassWord;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = newAccount.Type;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Delete(string deleteUserName)
        {
            SqlCommand cmd = new SqlCommand("DeleteAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = deleteUserName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Update(Account updateAccount, string oldUserName)
        {
            SqlCommand cmd = new SqlCommand("UpdateAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = updateAccount.UserName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = updateAccount.DisplayName;
            cmd.Parameters.AddWithValue("@PassWord", SqlDbType.NVarChar).Value = updateAccount.PassWord;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = updateAccount.Type;
            cmd.Parameters.AddWithValue("@oldUserName", SqlDbType.NVarChar).Value = oldUserName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("GetAccount");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
    }
}
