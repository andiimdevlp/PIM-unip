using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace Model
{
    public class Conexao
    {
        private SqlConnection Conectar = new SqlConnection("server=(local)\\SQLEXPRESS;DataBase=terracluster; integrated security=true");

        public SqlConnection AbrirConexao()
        {
            if (Conectar.State == System.Data.ConnectionState.Closed)
                Conectar.Open();
            return Conectar;
        }

        public SqlConnection FecharConexao()
        {
            if (Conectar.State == System.Data.ConnectionState.Open)
                Conectar.Close();
            return Conectar;
        }

        private readonly string connectionString;
        public Conexao()
        {
            connectionString = "server=(local)\\SQLEXPRESS;DataBase=terracluster; integrated security=true";
        }
        protected SqlConnection GetConnection()
        {
            return new SqlConnection(connectionString);
        }

    }
    
}
