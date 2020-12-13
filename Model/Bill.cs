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
        string table, drink;
        int counts;
        public Bill() { }
        public Bill(int id,string table, string drink,int counts)
        {
            this.id = id;
            this.table = table;
            this.drink = drink;
            this.Counts = counts;
        }
        public Bill(DataRow row)
        {
            this.id = (int)row["id"];
            this.table = row["Table"].ToString();
            this.drink = row["Drink"].ToString();
            this.counts = (int)row["Counts"];
        }
        public int ID
        {
            get { return id; }
            set { id = value; }
        }
        public string Table
        {
            get { return table; }
            set { table = value; }
        }
        public string Drink
        {
            get { return drink; }
            set { drink = value; }
        }
        public int Counts
        {
            get { return counts; }
            set { counts = value; }
        }
    }
}
