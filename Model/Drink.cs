using System.Data;

namespace Model
{
    public class Drink
    {
        int id;
        string name, type;
        float price;

        public Drink() { }
        public Drink(int id, string name, string type, float price)
        {
            this.id = id;
            this.name = name;
            this.type = type;
            this.price = price;
        }
        public Drink(DataRow row)
        {
            this.id = (int)row["id"];
            this.name = row["Name"].ToString();
            this.type = row["Type"].ToString();
            this.price = float.Parse(row["price"].ToString());
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
        public string Type
        {
            get { return type; }
            set { type = value; }
        }
        public float Price
        {
            get { return price; }
            set { price = value; }
        }
    }
}
