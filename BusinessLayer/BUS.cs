using System.Data;
using System.Windows.Forms;
using DataAccessLayer;
using Model;

namespace BusinessLayer
{
    public abstract class BUS<DALType, ModelType, PKType> where DALType : new()
    {
        public BUS() { }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        //public abstract DataTable GetDataTableByQuery(string query);
        public abstract void GetList(ManageList<ModelType> list);
        public abstract DataTable Read();
        public abstract void Create(ModelType element);
        public abstract void Delete(PKType data);
        public abstract void Update(ModelType element, PKType data);
    }
}
