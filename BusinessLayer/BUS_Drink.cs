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
                list.Add(new Drink(row));
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
