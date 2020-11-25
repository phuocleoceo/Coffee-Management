using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_Table : DataProvider<Table, int>
    {
        public override void Create(Table newTable)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertTable";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = newTable.Status;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Delete(int deleteTableID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteTable";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteTableID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Update(Table updateTable, int oldTableID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateTable";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = updateTable.Status;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldTableID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override DataTable Read()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetTable";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
