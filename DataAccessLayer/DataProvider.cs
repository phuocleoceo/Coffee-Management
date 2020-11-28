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
        public DataTable GetDataTableByQuery(string query)
        {
            con.Open();
            SqlCommand cmd = new SqlCommand(query, con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public abstract void Create(T element);
        public abstract void Delete(U primaryKey);
        public abstract void Update(T element, U primaryKey);
        public abstract DataTable Read();
    }
}
