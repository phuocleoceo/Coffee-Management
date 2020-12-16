using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public sealed class DAL_Drink : DAL<DAL_Drink, Drink, int>
    {
        public override void Create(Drink newDrink)
        {
            SqlCommand cmd = new SqlCommand("InsertDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newDrink.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newDrink.Name;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = newDrink.Type;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Real).Value = newDrink.Price;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Delete(int deleteDrinkID)
        {
            SqlCommand cmd = new SqlCommand("DeleteDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteDrinkID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override void Update(Drink updateDrink, int oldDrinkID)
        {
            SqlCommand cmd = new SqlCommand("UpdateDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateDrink.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateDrink.Name;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = updateDrink.Type;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Real).Value = updateDrink.Price;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldDrinkID;
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public override DataTable Read()
        {
            SqlCommand cmd = new SqlCommand("GetDrink");
            cmd.CommandType = CommandType.StoredProcedure;
            return DataProvider.Instance.ExecuteTable(cmd);
        }
    }
}
