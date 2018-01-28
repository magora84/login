using login.datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void btnenviar_Click(object sender, EventArgs e)
        {
           string password = txtPassword.Text;
            string usuario = txtUser.Text;
        
            if (password == "" || usuario == "")
            {
                MessageBox.Show("por favor introduscalos 2 valores");
                txtPassword.Focus();
                return;
            }
            else
            {
                Usuarios oUsuario = new Usuarios();
                oUsuario.Usuario = Convert.ToString(usuario);
                oUsuario.Password = Convert.ToString(password);
               Usuarios buscar =DUsuario.CheckLogin(oUsuario);

                if (buscar != null)
                {
                    MessageBox.Show("existe");
                }
                else
                {
                    MessageBox.Show("no existe");
                }

            }
        }
    }
}
