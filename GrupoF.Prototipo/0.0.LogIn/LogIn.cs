using GrupoF.Prototipo._0._0.LogIn;
using GrupoF.Prototipo._0.Menu;
using GrupoF.Prototipo._3.Procesar_Orden_de_Seleccion;
using GrupoF.Prototipo.Procesar_ordenes_de_preparacion;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GrupoF.Prototipo._0._0.LogIn_form
{
    public partial class LogIn_form : Form
    {
        private LogIn_model LogIn_model = new LogIn_model();

        public LogIn_form()
        {
            InitializeComponent();
        }

        private void button_Ingresar_Click(object sender, EventArgs e)
        {
            string usuario = Usuario_textBox.Text.Trim().ToUpper();
            string contraseña = Contrasena_textbox.Text.Trim();

            string contraseñaUsuario = "";

            if (usuario == "")
            {
                MessageBox.Show("Ingrese un usuario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario_textBox.Focus();
                return;
            }

            if (contraseña == "")
            {
                MessageBox.Show("Ingrese una contrasña", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Contrasena_textbox.Focus();
                return;
            }


            if (LogIn_model.Usuarios.Any(o => o.LogIn_usuario.ToUpper() == usuario))
            {
                contraseñaUsuario = LogIn_model.Usuarios
                 .Where(o => o.LogIn_usuario.ToUpper() == usuario)
                 .Select(o => o.Contrasena_usuario)
                 .FirstOrDefault();
            }

            if (contraseña != contraseñaUsuario)
            {
                MessageBox.Show("Usuario o contraseña incorrecto.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Usuario_textBox.Focus();
                return;
            }

            if (contraseña == contraseñaUsuario)
            {
                MessageBox.Show("Usuario correcto.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.Hide();

                Menu_form nuevaForma = new Menu_form();
                nuevaForma.Show();
            }
        }

    }
}
