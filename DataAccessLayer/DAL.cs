using Model;
using System.Data;
using System.Data.SqlClient;

namespace DataAccessLayer
{
    public abstract class DAL<DALType, ModelType, PKType> where DALType : new()
    {
        protected static DALType _instance;
        protected DAL() { }
        public static DALType Instance
        {
            get
            {
                if (_instance == null) _instance = new DALType();
                return _instance;
            }
            private set => _instance = value;
        }
        public abstract void Create(ModelType newElement);
        public abstract void Delete(PKType PKValue);
        public abstract void Update(ModelType updateElement, PKType PKvalue);
        public abstract DataTable Read();
    }
}
