using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public sealed class BUS_DrinkType : BUS<BUS_DrinkType, DrinkType, int>
    {
        public override DataTable Read()
        {
            return DAL_DrinkType.Instance.Read();
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
            DAL_DrinkType.Instance.Create(newDrinkType);
        }
        public override void Delete(int deleteDrinkTypeID)
        {
            DAL_DrinkType.Instance.Delete(deleteDrinkTypeID);
        }
        public override void Update(DrinkType updateDrinkType, int oldDrinkTypeID)
        {
            DAL_DrinkType.Instance.Update(updateDrinkType, oldDrinkTypeID);
        }
        //Load danh sach DrinkType vao ComboBox
        public void LoadDrinkTypeToComboBox(ManageList<DrinkType> list,ComboBox cb)
        {
            cb.Items.Clear();
            GetList(list);
            for (int i = 0; i < list.Count; i++)
            {
                cb.Items.Add(list[i].Name);
            }
        }        
    }
}
