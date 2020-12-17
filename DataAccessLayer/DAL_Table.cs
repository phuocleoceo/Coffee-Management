using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public sealed class DAL_Table : DAL<DAL_Table, Table, int>
    {
        public override void Create(Table newTable)
        {
            SqlCommand cmd = new SqlCommand("InsertTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = newTable.Status;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Delete(int deleteTableID)
        {
            SqlCommand cmd = new SqlCommand("DeleteTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Update(Table updateTable, int oldTableID)
        {
            SqlCommand cmd = new SqlCommand("UpdateTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = updateTable.Status;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("GetTable");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
        public void SetTableOnline(string TableName)
        {
            SqlCommand cmd = new SqlCommand("SetTableOnline");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void SetTotal(string TableName, float Total)
        {
            SqlCommand cmd = new SqlCommand("SetTotal");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            cmd.Parameters.AddWithValue("@Total", SqlDbType.Real).Value = Total;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void ClearTable(string TableName)
        {
            SqlCommand cmd = new SqlCommand("ClearTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void MoveTable(string TableFrom, string TableTo, float Total)
        {
            SqlCommand cmd = new SqlCommand("MoveTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableNameFrom", SqlDbType.NVarChar).Value = TableFrom;
            cmd.Parameters.AddWithValue("@TableNameTo", SqlDbType.NVarChar).Value = TableFrom;
            cmd.Parameters.AddWithValue("@Total", SqlDbType.Real).Value = Total;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
    }
}
