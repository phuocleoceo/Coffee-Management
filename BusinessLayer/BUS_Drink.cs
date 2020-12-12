using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Drink:BUS<DAL_Drink,Drink,int>
    {
        public override DataTable Read()
        {
            return DAL.Read();
        }
        public override void GetList(ManageList<Drink> list)
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
        public override void Create(Drink newDrink)
        {
            DAL.Create(newDrink);
        }
        public override void Delete(int deleteDrinkID)
        {
            DAL.Delete(deleteDrinkID);
        }
        public override void Update(Drink updateDrink, int oldDrinkID)
        {
            DAL.Update(updateDrink, oldDrinkID);
        }
    }
}
