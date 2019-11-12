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
                    cmd.CommandText = "select HASHBYTES('sha1','@pass') from usuarios where usuario=@user";
                    cmd.CommandType = CommandType.Text;
                    SqlDataReader reader = cmd.ExecuteReader();

                    if (reader.HasRows)
                    {
                        //while (reader.Read())
                        //{
                        //    UserLoginCache.IdUsuario = reader.GetString(0);
                        //    UserLoginCache.EmailUsuario = reader.GetString(4);
                        //    UserLoginCache.NivelAcesso = reader.GetString(5);
                        //}
                        return true;
                    }
                    else
                    {
                        return false;
                    }
                }

            }
            
          
        }
    }
}
