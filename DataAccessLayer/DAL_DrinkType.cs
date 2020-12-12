using Model;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DAL_DrinkType
    {
        public void Create(DrinkType newDrinkType)
        {
            SqlCommand cmd = new SqlCommand("InsertDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newDrinkType.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newDrinkType.Name;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void Delete(int deleteDrinkTypeID)
        {
            SqlCommand cmd = new SqlCommand("DeleteDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteDrinkTypeID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public void Update(DrinkType updateDrinkType, int oldDrinkTypeID)
        {
            SqlCommand cmd = new SqlCommand("UpdateDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateDrinkType.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateDrinkType.Name;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldDrinkTypeID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("GetDrinkType");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
    }
}
