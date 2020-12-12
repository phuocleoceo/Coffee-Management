using System.Data;
namespace Model
{
    public class DrinkType
    {
        int id;
        string name;

        public DrinkType() { }
        public DrinkType(int id, string name)
        {
            this.id = id;
            this.name = name;
        }
        public DrinkType(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["Name"].ToString();
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
    }
}
