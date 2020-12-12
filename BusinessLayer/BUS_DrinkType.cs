using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_DrinkType:BUS<DAL_DrinkType,DrinkType,int>
    {
        public override DataTable Read()
        {
            return DAL.Read();
        }
        public override void GetList(ManageList<DrinkType> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {
                list.Add(new DrinkType(row));
            }
        }
        public override void Create(DrinkType newDrinkType)
        {
            DAL.Create(newDrinkType);
        }
        public override void Delete(int deleteDrinkTypeID)
        {
            DAL.Delete(deleteDrinkTypeID);
        }
        public override void Update(DrinkType updateDrinkType, int oldDrinkTypeID)
        {
            DAL.Update(updateDrinkType, oldDrinkTypeID);
        }
    }
}
