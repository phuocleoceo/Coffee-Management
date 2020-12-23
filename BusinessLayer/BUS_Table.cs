using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public sealed class BUS_Table : BUS<BUS_Table, Table, int>
    {
        public override DataTable Read()
        {
            return DAL_Table.Instance.Read();
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
            DAL_Table.Instance.Create(newTable);
        }
        public override void Delete(int deleteTableID)
        {
            DAL_Table.Instance.Delete(deleteTableID);
        }
        public override void Update(Table updateTable, int oldTableID)
        {
            DAL_Table.Instance.Update(updateTable, oldTableID);
        }
        //Dung khi Mo ban , dua ban tu Empty sang Online
        public void SetTableOnline(string TableName)
        {
            DAL_Table.Instance.SetTableOnline(TableName);
        }
        //Tinh tien cho Ban
        public void SetTotal(string TableName, float Total)
        {
            DAL_Table.Instance.SetTotal(TableName, Total);
        }
        //Xoa Ban theo ten, Delete la xoa theo ID
        public void ClearTable(string TableName)
        {
            DAL_Table.Instance.ClearTable(TableName);
        }
        //Chuyen ban
        public void MoveTable(string TableFrom, string TableTo, float Total)
        {
            DAL_Table.Instance.MoveTable(TableFrom, TableTo, Total);
        }
        //Tra ve Total cua ban bat ki
        public float getTotal(ManageList<Table> list, string TableName)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Name == TableName) 
                    return list[i].Total;
            }
            return 0;
        }
        //Danh sach cac ban co the chuyen den 
        public void getAvailableTable(ManageList<Table> list,ComboBox cb)
        {
            cb.Items.Clear();
            cb.Text = "";
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].Total == 0)
                    cb.Items.Add(list[i].Name);
            }
        }
    }
}
