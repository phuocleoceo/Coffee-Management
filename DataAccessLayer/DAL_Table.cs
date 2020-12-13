using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_Table : DAL<DAL_Table, Table, int>
    {
        public override void Create(Table newTable)
        {
            SqlCommand cmd = new SqlCommand("InsertTable");
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = newTable.Status;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Delete(int deleteTableID)
        {
            SqlCommand cmd = new SqlCommand("DeleteTable");
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Update(Table updateTable, int oldTableID)
        {
            SqlCommand cmd = new SqlCommand("UpdateTable");
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateTable.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateTable.Name;
            cmd.Parameters.AddWithValue("@Status", SqlDbType.NVarChar).Value = updateTable.Status;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldTableID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("GetTable");
            return DataProvider.Instance.ExecuteTable(cmd);
        }
    }
}
