using System.Data;
using System.Data.SqlClient;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Table : BUS<BUS_Table, Table, int>
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
        public void SetTableOnline(string TableName)
        {
            DAL_Table.Instance.SetTableOnline(TableName);
        }
        public void SetTotal(string TableName, float Total)
        {
            DAL_Table.Instance.SetTotal(TableName, Total);
        }
        public void ClearTable(string TableName)
        {
            DAL_Table.Instance.ClearTable(TableName);
        }
    }
}
