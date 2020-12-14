using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_Bill : DAL<DAL_Bill, Bill, int>
    {
        public int GetCountDrink(string TableName, string DrinkName)
        {
            SqlCommand cmd = new SqlCommand("CheckDrinkTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = DrinkName;
            DataTable table = DataProvider.Instance.ExecuteTable(cmd);
            return int.Parse(table.Rows[0][0].ToString());
        }
        public DataTable Read(string TableName)
        {
            SqlCommand cmd = new SqlCommand("GetBillByTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
        public override void Create(Bill bill)
        {
            SqlCommand cmd = new SqlCommand("AddDrinkToBill");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = bill.TableName;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = bill.DrinkName;
            cmd.Parameters.AddWithValue("@Counts", SqlDbType.Int).Value = bill.Counts;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }

        public override void Update(Bill bill, int oldBillID)
        {
            SqlCommand cmd = new SqlCommand("IncreaseDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = bill.TableName;
            cmd.Parameters.AddWithValue("@DrinkName", SqlDbType.NVarChar).Value = bill.DrinkName;
            cmd.Parameters.AddWithValue("@Counts", SqlDbType.Int).Value = bill.Counts;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void ClearBill(string TableName)
        {
            SqlCommand cmd = new SqlCommand("ClearBill");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override DataTable Read()
        {
            throw new System.NotImplementedException();
        }
        public override void Delete(int deleteBillID)
        {
            throw new System.NotImplementedException();
        }
    }
}
