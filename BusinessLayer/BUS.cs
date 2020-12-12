using System.Data;
using System.Windows.Forms;
using DataAccessLayer;
using Model;

namespace BusinessLayer
{
    public abstract class BUS<E, T, U> where E : new()
    {
        protected E DAL;
        public BUS()
        {
            DAL = new E();
        }
        public void ShowDGV(DataGridView dgv)
        {
            dgv.DataSource = null;
            dgv.Rows.Clear();
            dgv.DataSource = Read();
        }
        //public abstract DataTable GetDataTableByQuery(string query);
        public abstract void GetList(ManageList<T> list);
        public abstract DataTable Read();
        public abstract void Create(T element);
        public abstract void Delete(U data);
        public abstract void Update(T element, U data);
    }
}
