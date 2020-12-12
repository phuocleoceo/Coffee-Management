using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DataAccessLayer
{
    public sealed class DataProvider
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
            DataTable dt = new DataTable();
            try
            {
                con.Open();
                cmd.Connection = con;
                SqlDataAdapter da = new SqlDataAdapter(cmd);
                da.Fill(dt);
                return dt;
            }
            catch (SqlException)
            {
                MessageBox.Show("Duplicate PK Value ! ");
                return null;
            }
            finally
            {
                con.Close();
            }
        }
        public void ExecuteNonQuery(SqlCommand cmd)
        {
            try
            {
                con.Open();
                cmd.Connection = con;
                cmd.ExecuteNonQuery();
            }
            catch (SqlException)
            {
                MessageBox.Show("Duplicate PK Value ! ");
            }
            finally
            {
                con.Close();
            }
        }
    }
}
