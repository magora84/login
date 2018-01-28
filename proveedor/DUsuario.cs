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
        public static SqlDataReader CheckLogin(string usuario, string password)
        {

            SqlDataReader reader = null;
            try
            {
                Conexion.Conectar();
                SqlCommand comando = new SqlCommand();
                comando.Connection = Conexion.conexion;
                comando.CommandText = "select id,nombre,usuario,departamento,email,perfil,estatus,sucursal,perfil,celular from usuarios where usuario like @usuario and password like @password";
                comando.Parameters.Add("@usuario", SqlDbType.VarChar).Value = usuario;
                comando.Parameters.Add("@password", SqlDbType.VarChar).Value = password;
                comando.ExecuteReader();
               
                if (reader.HasRows)
                {
                   
                   Usuarios oUsuario = new Usuarios();
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
            catch (Exception e)
            {
                MessageBox.Show("ocurrio un error Detalle " +e.Message);
                
             }
            return reader;
        }
    }
    public class Usuarios
    {
        public int Id { get; set; }
        public string Usuario { get; set; }
        public string Password { get; set; }
        public string Nombre { get; set; }
        public string Departamento { get; set; }
        public string Celular { get; set; }
        public string Estatus { get; set; }
        public string Email { get; set; }
        public string Sucursal { get; set; }
        public DateTime Fecha_creacion { get; set; }
        public DateTime Fecha_actualizacion { get; set; }
        public string Perfil { get; set; }
    }
}
