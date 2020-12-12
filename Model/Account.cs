using System.Data;
namespace Model
{
    public class Account
    {
        private string username;
        private string displayname;
        private string password;
        private int type;
        public Account() { }
        public Account(string username, string displayname, string password, int type)
        {
            this.username = username;
            this.displayname = displayname;
            this.password = password;
            this.type = type;
        }
        public Account(DataRow row)
        {
            this.username = row["UserName"].ToString();
            this.displayname = row["DisplayName"].ToString();
            this.password = row["PassWord"].ToString();
            this.type = (int)row["Type"];
        }
        public string UserName
        {
            get { return username; }
            set { username = value; }
        }
        public string DisplayName
        {
            get { return displayname; }
            set { displayname = value; }
        }
        public string PassWord
        {
            get { return password; }
            set { password = value; }
        }
        public int Type
        {
            get { return type; }
            set { type = value; }
        }
    }
}
