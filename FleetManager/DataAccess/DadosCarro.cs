using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System;

namespace Model
{
    public class CadastroCarro:Conexao
    {
        private Conexao con = new Conexao();

        SqlDataReader ler;
        DataTable tabela = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "select * from veiculo";
            ler = cmd.ExecuteReader();
            tabela.Load(ler);
            con.FecharConexao();
            return tabela;
        }

    }
}
