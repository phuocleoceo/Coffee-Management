using Model;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public class DAL_Drink : DataProvider<Drink, int>
    {
        public override void Create(Drink newDrink)
        {  
            try
            {
                con.Open();
                SqlCommand cmd = con.CreateCommand();
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.CommandText = "InsertDrink";
                cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newDrink.ID;
                cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newDrink.Name;
                cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = newDrink.Type;
                cmd.Parameters.AddWithValue("@Price", SqlDbType.Real).Value = newDrink.Price;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Duplicate Primary Key Value !");
            }
            finally
            {
                con.Close();
            }
        }
        public override void Delete(int deleteDrinkID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "DeleteDrink";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = deleteDrinkID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override void Update(Drink updateDrink, int oldDrinkID)
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateDrink";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateDrink.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateDrink.Name;
            cmd.Parameters.AddWithValue("@Type", SqlDbType.Int).Value = updateDrink.Type;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Real).Value = updateDrink.Price;
            cmd.Parameters.AddWithValue("@oldID", SqlDbType.Int).Value = oldDrinkID;
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public override DataTable Read()
        {
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "GetDrink";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
    }
}
