using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public class DataProvider
    {
        //protected static string ConStr = @"Data Source=.\sqlexpress;Initial Catalog=CoffeeManagement;Integrated Security=True";        
        private static string ConStr = @"Data Source=.;Initial Catalog=CoffeeManagement;Integrated Security=True";
        public SqlConnection con { get; set; }
        private static DataProvider _instance;
        private DataProvider()
        {
            con = new SqlConnection(ConStr);
        }
        public static DataProvider Instance
        {
            get
            {
                if (_instance == null) _instance = new DataProvider();
                return _instance;
            }
            private set => _instance = value;

        }
        public DataTable ExecuteTable(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            con.Close();
            return dt;
        }
        public void ExecuteNonQuery(SqlCommand cmd)
        {
            con.Open();
            cmd.Connection = con;
            cmd.ExecuteNonQuery();
            con.Close();
        }
    }
}
