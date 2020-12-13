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
        string tableID, drinkID;
        int counts;
        public Bill() { }
        public Bill(int id,string tableID, string drinkID,int counts)
        {
            this.id = id;
            this.tableID = tableID;
            this.drinkID = drinkID;
            this.Counts = counts;
        }
        public Bill(DataRow row)
        {
            this.id = (int)row["id"];
            this.tableID = row["TableID"].ToString();
            this.drinkID = row["DrinkID"].ToString();
            this.counts = (int)row["Counts"];
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string TableID
        {
            get { return tableID; }
            set { tableID = value; }
        }
        public string DrinkID
        {
            get { return drinkID; }
            set { drinkID = value; }
        }
        public int Counts
        {
            get { return counts; }
            set { counts = value; }
        }
    }
}
