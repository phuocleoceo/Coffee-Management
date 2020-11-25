using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public abstract class DataProvider<T, U>
    {
        //protected static string ConStr = @"Data Source=.\sqlexpress;Initial Catalog=CoffeeManagement;Integrated Security=True";        
        protected static string ConStr = @"Data Source=.;Initial Catalog=CoffeeManagement;Integrated Security=True";
        protected SqlConnection con;
        public DataProvider()
        {
            con = new SqlConnection(ConStr);
        }
        public abstract void Create(T element);
        public abstract void Delete(U primaryKey);
        public abstract void Update(T element, U primaryKey);
        public abstract DataTable Read();
    }
}
