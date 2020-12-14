using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Model
{
    public class Bill
    {
        int id;
        string tablename, drinkname;
        int counts;
        public Bill() { }
        public Bill(int id,string tableID, string drinkID,int counts)
        {
            this.id = id;
            this.tablename = tableID;
            this.drinkname = drinkID;
            this.Counts = counts;
        }
        public Bill(DataRow row)
        {
            this.id = (int)row["id"];
            this.tablename = row["TableID"].ToString();
            this.drinkname = row["DrinkID"].ToString();
            this.counts = (int)row["Counts"];
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TableName
        {
            get { return tablename; }
            set { tablename = value; }
        }
        public string DrinkName
        {
            get { return drinkname; }
            set { drinkname = value; }
        }
        public int Counts
        {
            get { return counts; }
            set { counts = value; }
        }
    }
}
