using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;

namespace Control
{
    public class UsuarioModel
    {
        UserDAO userDAO = new UserDAO();
        public bool LoginUser (string user, string pass)
        {
            return userDAO.Login(user, pass);
        }
        public string recoverPassword(string userRequesting)
        {
            return userDAO.recoverPassword(userRequesting);
        }
        public void CargoMetodo()
        {
            //if (UserLoginCache.NivelAcesso == Cargos.Adiminstrador)
            //{

            //}
            //if (UserLoginCache.NivelAcesso == Cargos.Recepcionista || UserLoginCache.NivelAcesso == Cargos.Contador)
            //{

            //}
        }
    }
}
