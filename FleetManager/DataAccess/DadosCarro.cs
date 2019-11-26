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

        public void Insert(string placa, string modelo, string cor, string ano, string renavam, string marca)
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "InserirCarro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@modelo", modelo);
            cmd.Parameters.AddWithValue("@cor", cor);
            cmd.Parameters.AddWithValue("@ano", ano);
            cmd.Parameters.AddWithValue("@renavam", renavam);
            cmd.Parameters.AddWithValue("@marca", marca);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        }

    }
}
