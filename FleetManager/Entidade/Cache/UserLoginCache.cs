using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidade.Cache
{
    public static class UserLoginCache
    {
        public static int IdUsuario { get; set; }
        public static string NomeUsuario { get; set; }
        public static string NivelAcesso { get; set; }
        public static string EmailUsuario { get; set; }
    }
}
