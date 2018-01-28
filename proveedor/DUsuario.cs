using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.datos
{
    class DUsuario
    {
        public static SqlDataReader CheckLogin(Usuario usuario)
        {
            SqlDataReader reader = null;
            try
            {
                Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.conexion;
                comando.CommandText = "select * from usuarios where usuario like @usuario and password like @password";
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario.usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = usuario.usuario;
                comando.ExecuteReader();


            }
            catch (Exception e)
            {
                MessageBox.Show(" ocurrio un error Detalle" +e.Message);
                
             }
            return reader;
        }
    }
    public class Usuario
    {
        public int id { get; set; }
        public string usuario {get; set;}
        public string password { get; set; }
        public string departamento { get; set; }
        public string estatus { get; set; }
        public string email { get; set; }
        public string sucursal { get; set; }
        public DateTime fecha_creacion { get; set; }
        public DateTime fecha_actualizacion { get; set; }
        public string perfil { get; set; }
    }
}
