using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login.datos
{
   public static class Conexion
    {
        public static SqlConnection conexion = new SqlConnection();
       /* private string User = "sa";
        private string password = "TCQOJC";
        private string bd=""*/
        public static void Conectar()
        {
            try
            {
                conexion = new SqlConnection("Data Source=DESKTOP-0BRLGSJ\\SQLEXPRESS;Initial Catalog=cobranza;User ID=sa; password=TCQOJC;");
                conexion.Open();
            }
            catch (SqlException e)
            {

                MessageBox.Show(e.Message);
            }
        }
        public static void Desconectar()
        {
            try
            {
                if (conexion.State == System.Data.ConnectionState.Open) conexion.Close();
                
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
}
