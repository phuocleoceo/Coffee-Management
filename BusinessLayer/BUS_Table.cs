using System.Data;
using System.Windows.Forms;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Table
    {
        DAL_Table DAL_Table;
        public BUS_Table()
        {
            DAL_Table = new DAL_Table();
        }
        public DataTable Read()
        {
            return DAL_Table.Read();
        }
        public void GetList(ManageList<Table> list)
        {
            list.Clear();
            foreach (DataRow row in Read().Rows)
            {
                int id = (int)row["id"];
                string name = row["Name"].ToString();
                string status = row["Status"].ToString();
                list.Add(new Table(id, name, status));
            }
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public void Create(Table newTable)
        {
            DAL_Table.Create(newTable);
        }
        public void Delete(int deleteTableID)
        {
            DAL_Table.Delete(deleteTableID);
        }
        public void Update(Table updateTable, int oldTableID)
        {
            DAL_Table.Update(updateTable, oldTableID);
        }
    }
}
