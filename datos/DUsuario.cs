using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace login.datos
{
    class DUsuario
    {
        public static bool IniciarSesion(Usuario usuario)
        {
            try
            {

            }
            catch (Exception e)
            {

                throw;
            }
            return respuesta;
        }
    }
    public class Usuario
    {
        public string id { get; set; }
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
