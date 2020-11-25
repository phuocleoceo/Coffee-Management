﻿namespace Model
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
