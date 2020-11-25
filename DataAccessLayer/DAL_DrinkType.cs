using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DAL_DrinkType:DataProvider<DrinkType,int>
    {
        public override void Create(DrinkType newDrinkType)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertDrinkType";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newDrinkType.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newDrinkType.Name;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Delete(int deleteDrinkTypeID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteDrinkType";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteDrinkTypeID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Update(DrinkType updateDrinkType, int oldDrinkTypeID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateDrinkType";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateDrinkType.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateDrinkType.Name;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldDrinkTypeID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override DataTable Read()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDrinkType";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
