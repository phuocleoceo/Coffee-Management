using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Table:BUS<DAL_Table,Table,int>
    {
        public override DataTable Read()
        {
            return DAL.Read();
        }
        public override void GetList(ManageList<Table> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {                
                list.Add(new Table(row));
            }
        }
        public override void Create(Table newTable)
        {
            DAL.Create(newTable);
        }
        public override void Delete(int deleteTableID)
        {
            DAL.Delete(deleteTableID);
        }
        public override void Update(Table updateTable, int oldTableID)
        {
            DAL.Update(updateTable, oldTableID);
        }
    }
}
