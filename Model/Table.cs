using System.Data;
namespace Model
{
    public class Table
    {
        int id;
        string name, status;

        public Table() { }
        public Table(int id, string name, string status)
        {
            this.id = id;
            this.name = name;
            this.status = status;
        }
        public Table(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["Name"].ToString();
            this.status = row["Status"].ToString();
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public string Status
        {
            get { return status; }
            set { status = value; }
        }
    }
}
