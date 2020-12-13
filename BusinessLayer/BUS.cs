using System.Data;
using System.Windows.Forms;
using Model;
using System.Data.SqlClient;
using DataAccessLayer;

namespace BusinessLayer
{
    public abstract class BUS<BUSType, ModelType, PKType> where BUSType : new()
    {
        protected static BUSType _instance;
        protected BUS() { }
        public static BUSType Instance
        {
            get
            {
                if (_instance == null) _instance = new BUSType();
                return _instance;
            }
            private set => _instance = value;
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        public DataTable ExcecuteTable(SqlCommand cmd)
        {
            return DataProvider.Instance.ExecuteTable(cmd);
        }
        public void ExecuteNonQuery(SqlCommand cmd)
        {
            DataProvider.Instance.ExecuteNonQuery(cmd);
        }
        public abstract void GetList(ManageList<ModelType> list);
        public abstract DataTable Read();
        public abstract void Create(ModelType element);
        public abstract void Delete(PKType data);
        public abstract void Update(ModelType element, PKType data);
    }
}
