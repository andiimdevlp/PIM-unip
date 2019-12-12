using System.Collections.Generic;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Linq;
using System.Data;
using System;

namespace Model
{
    public class Cadastro:Conexao
    {
        private Conexao con = new Conexao();

        SqlDataReader ler;
        DataTable tabela = new DataTable();
        SqlCommand cmd = new SqlCommand();

        public DataTable Mostrar()
        {
            cmd.Connection = con.AbrirConexao();
            //cmd.CommandText = "select placa as PLACA, * from veiculo";
            cmd.CommandText = "MostrarCarro";
            cmd.CommandType = CommandType.StoredProcedure;
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

        public void Excluir(string placa, string renavam)
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "ExcluirCarro";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.Parameters.AddWithValue("@renavam", renavam);
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();

        }

        public DataTable MostrarFin()
        {
            cmd.Connection = con.AbrirConexao();
            //cmd.CommandText = "select placa as PLACA, * from veiculo";
            cmd.CommandText = "MostrarFin";
            cmd.CommandType = CommandType.StoredProcedure;
            ler = cmd.ExecuteReader();
            tabela.Load(ler);
            con.FecharConexao();
            return tabela;
        }

        public void InsertFin( string valor, string departamento, string id_gasto, string comentario, string placa)
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "InserirFinan";
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddWithValue("@valor_financeiro", valor);
            cmd.Parameters.AddWithValue("@id_gasto", id_gasto);
            cmd.Parameters.AddWithValue("@id_depart", departamento);
            cmd.Parameters.AddWithValue("@comentario", comentario);
            cmd.Parameters.AddWithValue("@placa", placa);
            cmd.ExecuteNonQuery();       
            

            cmd.Parameters.Clear();
        }

        public void BaixarFin(int valor)
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "update mov_fin set data_baixa= GETDATE() where id_financeiro ='" + valor + "'";
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        }
        public void EstornoFin(int valor, string comentario)
        {
            cmd.Connection = con.AbrirConexao();
            cmd.CommandText = "update mov_fin set data_baixa='"+ comentario + "' where id_financeiro ='" + valor + "'";
            cmd.ExecuteNonQuery();

            cmd.Parameters.Clear();
        }
    }
}
