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
            tabela = objetoMoviFin.MostrarFin();
            return tabela;
        }

        public void InsertFin(string valor, string departamento, string id_gasto, string comentario, string placa)
        {
            //string emissao = Convert.ToDateTime(emissao2).ToString("yyyy-MM-DD");
            //string vencimento = Convert.ToDateTime(vencimento2).ToString("yyyy-MM-dd");
            objetoMoviFin.InsertFin(valor, departamento, id_gasto, comentario, placa);
        }

        public void BaixarFin(string valor)
        {
            objetoMoviFin.BaixarFin(Convert.ToInt32(valor));
        }
        public void EstornoFin(string valor, string comentario)
        {
            objetoMoviFin.EstornoFin(Convert.ToInt32(valor), comentario);
        }
    }
}
