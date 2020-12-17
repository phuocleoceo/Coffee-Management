using System.Data;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public sealed class BUS_Bill : BUS<BUS_Bill, Bill, string>
    {
        public DataTable Read(string TableName)
        {
            return DAL_Bill.Instance.Read(TableName);
        }

        public void GetList(ManageList<Bill> list, string TableName)
        {
            list.Clear();
            foreach (DataRow row in Read(TableName).Rows)
            {
                list.Add(new Bill(row));
            }
        }

        public override void Create(Bill newBill)
        {
            DAL_Bill.Instance.Create(newBill);
        }

        public int GetCountDrink(string TableName, string DrinkName)
        {
            return DAL_Bill.Instance.GetCountDrink(TableName, DrinkName);
        }

        public void UpdateTableInBill(string TableNameFrom, string TableNameTo)
        {
            DAL_Bill.Instance.UpdateTableInBill(TableNameFrom, TableNameTo);
        }

        public override void Update(Bill updateBill, string oldBillID)
        {
            DAL_Bill.Instance.Update(updateBill, oldBillID);
        }

        public override void Delete(string TableName)
        {
            DAL_Bill.Instance.Delete(TableName);
        }

        public override DataTable Read()
        {
            throw new System.NotImplementedException();
        }

        public override void GetList(ManageList<Bill> list)
        {
            throw new System.NotImplementedException();
        }        
    }
}
