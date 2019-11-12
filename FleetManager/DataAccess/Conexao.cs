using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public abstract class Conexao
    {
        private readonly string connectionString;
        public Conexao()
        {
            connectionString = "server=DESKTOP-8B1VJMJ\\SQLEXPRESS;DataBase=FLEETMANAGER; integrated security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }
    }
}
