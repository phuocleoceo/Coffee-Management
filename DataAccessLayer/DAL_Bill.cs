using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_Bill:DAL<DAL_Bill,Bill,int>
    {
        public DataTable Read(string TableName)
        {
            SqlCommand cmd = new SqlCommand("GetBillByTable");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@TableName", SqlDbType.NVarChar).Value = TableName;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
        public override void Create(Bill newDrink)
        {
        }
        public override void Delete(int deleteBillID)
        {
        }
        public override void Update(Bill updateDrink, int oldBillID)
        {
        }
        public override DataTable Read()
        {
            return null;
        }
    }
}
