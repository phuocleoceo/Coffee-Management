using Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DAL_Account : DataProvider<Account, string>
    {
        public override void Create(Account newAccount)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertAccount";
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = newAccount.UserName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = newAccount.DisplayName;
            cmd.Parameters.AddWithValue("@PassWord", SqlDbType.NVarChar).Value = newAccount.PassWord;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = newAccount.Type;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Delete(string deleteUserName)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteAccount";
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = deleteUserName;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Update(Account updateAccount, string oldUserName)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateAccount";
            cmd.Parameters.AddWithValue("@UserName", SqlDbType.NVarChar).Value = updateAccount.UserName;
            cmd.Parameters.AddWithValue("@DisplayName", SqlDbType.NVarChar).Value = updateAccount.DisplayName;
            cmd.Parameters.AddWithValue("@PassWord", SqlDbType.NVarChar).Value = updateAccount.PassWord;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = updateAccount.Type;
            cmd.Parameters.AddWithValue("@oldUserName", SqlDbType.NVarChar).Value = oldUserName;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override DataTable Read()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetAccount";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
