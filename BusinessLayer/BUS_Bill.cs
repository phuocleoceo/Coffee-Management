using System.Data;
using Model;
using DataAccessLayer;

namespace BusinessLayer
{
    public class BUS_Bill:BUS<BUS_Bill,Bill,int>
    {
        public DataTable Read(string TableName)
        {
            return DAL_Bill.Instance.Read(TableName);
        }
        public override DataTable Read()
        {
            throw new System.NotImplementedException();
        }
        public override void GetList(ManageList<Bill> list)
        {
            throw new System.NotImplementedException();
        }
        public override void Create(Bill newBill)
        {
            throw new System.NotImplementedException();
        }
        public override void Delete(int deleteBillID)
        {
            throw new System.NotImplementedException();
        }
        public override void Update(Bill updateBill, int oldBillID)
        {
            throw new System.NotImplementedException();
        }
    }
}
