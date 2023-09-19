using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Common.Cache;
using Domain;
using Npgsql;

namespace HospitalSystem
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        public void mostrarUsuarios()
        {
            UserModel user = new UserModel();
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = user.mostrar();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            mostrarUsuarios();
        }

        private void EliminarBtn_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario()
            {
                IdUser = int.Parse(txtidusuario.Text),
            };
            UserModel metod = new UserModel();
            if (metod.eliminar(user))
            {
                limpiar();
                mostrarUsuarios();
            }
        }

        private void limpiar()
        {
            txtidusuario.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txtcedula.Text = "";
            txttelefono.Text = "";
            txtnombre.Focus();
        }

        private void AgregarBtn_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario()
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Cedula = txtcedula.Text,
                Telefono = txttelefono.Text,
            };
            UserModel metod = new UserModel();
            if (metod.guardar(user))
            {
                limpiar();
                mostrarUsuarios(); 
            }    

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void EditarBtn_Click(object sender, EventArgs e)
        {
            Usuario user = new Usuario()
            {
                IdUser = int.Parse(txtidusuario.Text),
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Cedula = txtcedula.Text,
                Telefono = txttelefono.Text,
            };
            UserModel metod = new UserModel();
            if (metod.editar(user))
            {
                limpiar();
                mostrarUsuarios();  
            }
        }
    }
}
