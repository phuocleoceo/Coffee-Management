using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BussinessLayer
{
    public class BUS_Drink
    {
        DAL_Drink DAL_Drink = new DAL_Drink();
        public DataTable Read()
        {
            return DAL_Drink.Read();
        }
        public void GetList(ManageList<Drink> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {
                int id = (int)row["id"];
                string name = row["Name"].ToString();
                string type = row["Type"].ToString();
                float price = float.Parse(row["Price"].ToString());
                list.Add(new Drink(id, name, type, price));
            }
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public void Create(Drink newDrink)
        {
            DAL_Drink.Create(newDrink);
        }
        public void Delete(int deleteDrinkID)
        {
            DAL_Drink.Delete(deleteDrinkID);
        }
        public void Update(Drink updateDrink, int oldDrinkID)
        {
            DAL_Drink.Update(updateDrink, oldDrinkID);
        }
        public void getComboBoxType(ManageList<Drink> listDrink, ComboBox cb)
        {
            DAL_Drink.getComboBoxType(listDrink, cb);
        }
    }
}
