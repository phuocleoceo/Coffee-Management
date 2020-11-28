using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_DrinkType
    {
        DAL_DrinkType DAL_DrinkType;
        public BUS_DrinkType()
        {
            DAL_DrinkType = new DAL_DrinkType();
        }
        public DataTable Read()
        {
            return DAL_DrinkType.Read();
        }
        public void GetList(ManageList<DrinkType> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {
                int id = (int)row["id"];
                string name = row["Name"].ToString();
                list.Add(new DrinkType(id, name));
            }
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public void Create(DrinkType newDrinkType)
        {
            DAL_DrinkType.Create(newDrinkType);
        }
        public void Delete(int deleteDrinkTypeID)
        {
            DAL_DrinkType.Delete(deleteDrinkTypeID);
        }
        public void Update(DrinkType updateDrinkType, int oldDrinkTypeID)
        {
            DAL_DrinkType.Update(updateDrinkType, oldDrinkTypeID);
        }
    }
}
