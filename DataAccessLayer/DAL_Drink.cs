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
        //Từ điển lưu cặp idType,stringType
        Dictionary<int, string> dictType = new Dictionary<int, string>();
        public override void Create(Drink newDrink)
        {
            //Thay Type từ string sang int
            int newDrinkType = 0;
            foreach (KeyValuePair<int, string> dict in dictType)
            {
                if (String.Compare(dict.Value, newDrink.Type) == 0)
                    newDrinkType = dict.Key;
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "InsertDrink";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = newDrink.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = newDrink.Name;
            cmd.Parameters.AddWithValue("@idType", SqlDbType.Int).Value = newDrinkType;
            cmd.Parameters.AddWithValue("@Price", SqlDbType.Real).Value = newDrink.Price;
            cmd.ExecuteNonQuery();
            con.Close();
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
            //Thay Type từ string sang int
            int updateDrinkType = 0;
            foreach (KeyValuePair<int, string> dict in dictType)
            {
                if (String.Compare(dict.Value, updateDrink.Type) == 0)
                    updateDrinkType = dict.Key;
            }
            con.Open();
            SqlCommand cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = "UpdateDrink";
            cmd.Parameters.AddWithValue("@id", SqlDbType.Int).Value = updateDrink.ID;
            cmd.Parameters.AddWithValue("@Name", SqlDbType.NVarChar).Value = updateDrink.Name;
            cmd.Parameters.AddWithValue("@idType", SqlDbType.Int).Value = updateDrinkType;
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

        // Đổ dữ liệu vào ComboBox Type             
        public void getComboBoxType(ManageList<Drink> listDrink, ComboBox cb)
        {
            cb.Items.Clear();
            int index = 1;
            for (int i = 0; i < listDrink.Count; i++)
            {
                if (dictType.ContainsValue(listDrink[i].Type) == false)
                    dictType.Add(index++, listDrink[i].Type);
            }
            foreach (string type in dictType.Values)
            {
                cb.Items.Add(type);
            }
        }
    }
}
