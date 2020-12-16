using System.Data;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public sealed class BUS_Bill : BUS<BUS_Bill, Bill, int>
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
        public void ClearBill(string TableName)
        {
            DAL_Bill.Instance.ClearBill(TableName);
        }

        public override void Update(Bill updateBill, int oldBillID)
        {
            DAL_Bill.Instance.Update(updateBill, oldBillID);
        }
        public override DataTable Read()
        {
            throw new System.NotImplementedException();
        }
        public override void GetList(ManageList<Bill> list)
        {
            throw new System.NotImplementedException();
        }
        public override void Delete(int deleteBillID)
        {
            throw new System.NotImplementedException();
        }
    }
}
