using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Database;

namespace metricsflow
{
    internal class Model
    {
        protected static Model instance = null;
        protected string table;
        protected string primaryKey = "id";
        protected Database.SQLite connection;
        protected Dictionary<string, object> attributes = new Dictionary<string, object>();

        public Model()
        {
            connection = new SQLite("database.db", 3);
        }

        public object this[string name]
        {
            get
            {
                if (attributes.ContainsKey(name))
                {
                    return attributes[name];
                }
                return null;
            }
            set
            {
                attributes[name] = value;
            }
        }

        public static Model GetInstance()
        {
            if (instance == null)
            {
                instance = new Model();
            }
            return instance;
        }
    }
}
