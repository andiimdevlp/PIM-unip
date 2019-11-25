using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Entidade.Cache;

namespace Model
{
    public class UserDAO:Conexao
    {
        public bool Login (string user, string pass)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.Parameters.AddWithValue("@user", user);
                    cmd.Parameters.AddWithValue("@pass", pass);
                    cmd.CommandText = "select HASHBYTES('sha1','@pass') from usuario where login=@user";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //while (reader.Read())
                        //{
                        //    UserLoginCache.NomeUsuario = reader.GetString(1);
                        //    UserLoginCache.EmailUsuario = reader.GetString(3);
                        //    UserLoginCache.NivelAcesso = reader.GetString(4);
                        //}
                        return true;
                    }
                    else
                        return false;
                }

            }
        }
        public string recoverPassword(string userRequesting)
        {
            using (var con = GetConnection())
            {
                con.Open();
                using (var cmd = new SqlCommand())
                {
                    cmd.Connection = con;
                    cmd.CommandText = "select * from  usuario where login=@user or email=@email";
                    cmd.Parameters.AddWithValue("@user", userRequesting);
                    cmd.Parameters.AddWithValue("@email", userRequesting);
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.Read() == true)
                    {
                        string userName = reader.GetString(1);
                        string userMail = reader.GetString(3);
                        string userPassword = reader.GetString(5); 

                        var mailService = new MailServer.SystemSuport();
                        mailService.sendMail(
                            subject: "Recuperação de senha!",
                            body: "Olá, \n" + userName + "\n\nRecebemos sua solicitação de recuperação de senha!" +
                            "\nUse a senha: \b" + userPassword + " para realizar cadastrar uma nova senha.", recipientMail: new List<string> { userMail });

                        return "Olá, " + userName + "\nAltere sua senha para ter acesso.\n" +
                            "Por favor, verifique seu e-mail: " + userMail + "\npara onde a senha provisoria foi enviada!";
                    }
                    else
                    {
                        return "Desculpe, Usuario/E-mail não localizado";
                    }
                }
            }
        }
    }
}
