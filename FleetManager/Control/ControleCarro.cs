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
    public class ControleCarro
    {
        private CadastroCarro objetodadosCarro = new CadastroCarro();

        public DataTable MostrarCarro()
        {
            DataTable tabela = new DataTable();
            tabela = objetodadosCarro.Mostrar();
            return tabela;
        }
    }
}
