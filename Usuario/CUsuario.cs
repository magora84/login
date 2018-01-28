using login.datos;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.Login
{
    class CLogin
    {
        public static Usuarios CheckLogin(Usuario usuario)
        {
            Usuarios oUsuario = null;
            SqlDataReader reader = DUsuario.CheckLogin(usuario);
            if (reader.HasRows)
            {
                oUsuario = new Usuarios();
                reader.Read();
                oUsuario.Id = Convert.ToInt32(reader[0]);
                oUsuario.nombre = Convert.ToString(reader[1]);
                oUsuario.usuario = Convert.ToString(reader[2]);
                oUsuario.departamento = Convert.ToString(reader[3]);
                oUsuario.email = Convert.ToString(reader[4]);
                oUsuario.perfil = Convert.ToString(reader[5]);
                oUsuario.celular = Convert.ToString(reader[6]);
            }
            reader.Close();
            return oUsuario;
        
        }
    }
}
