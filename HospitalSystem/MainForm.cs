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
    }
}
