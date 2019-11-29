using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Model;

namespace Control
{
    public class CrudBanco
    {
        #region cadastro de veiculos

        private Cadastro objetodadosCarro = new Cadastro();

        public DataTable MostrarCarro()
        {
            DataTable tabela = new DataTable();
            tabela = objetodadosCarro.Mostrar();
            return tabela;
        }
        public void InsertCarro (string placa, string modelo, string cor, string ano, string renavam, string marca)
        {
            objetodadosCarro.Insert(placa, modelo, cor, ano, renavam, marca);
        }

        public void ExcluirCarro (string placa, string renavam)
        {
            objetodadosCarro.Excluir(placa, renavam);
        }

        #endregion

        private Cadastro objetoMoviFin = new Cadastro();

        public DataTable MostrarFin()
        {
            DataTable tabela = new DataTable();
            tabela = objetoMoviFin.Mostrar();
            return tabela;
        }

        public void InsertFin(string departamento, string id_gasto, double valor, string emissao, string vencimento, string comentario, string placa, string descricao)
        {
            objetodadosCarro.InsertFin(departamento, id_gasto, valor, emissao, vencimento, baixa, comentario, placa, descricao);
        }

    }
}
