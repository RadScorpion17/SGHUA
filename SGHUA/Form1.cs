using SGHUA.Coneccion_SQLite;
using SGHUA.Logica;
namespace SGHUA


{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        private void btnguardar_Click(object sender, EventArgs e)
        {
            Persona objeto = new Persona()
            {
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Telefono = txttelefono.Text,
            };
            bool respuesta = PersonaLogica.Instancia.Guardar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();
            }
        }

        public void mostrar_personas()
        {
            dgvpersonas.DataSource = null;
            dgvpersonas.DataSource = PersonaLogica.Instancia.Listar();
        }

        private void dgvpersonas_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            mostrar_personas();
        }

        public void limpiar()
        {
            txtidpersona.Text = "";
            txtnombre.Text = "";
            txtapellido.Text = "";
            txttelefono.Text = "";
            txtnombre.Focus();
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            mostrar_personas();
        }

        private void btneditar_Click(object sender, EventArgs e)
        {
            Persona objeto = new Persona()
            {
                IdPersona = int.Parse(txtidpersona.Text),
                Nombre = txtnombre.Text,
                Apellido = txtapellido.Text,
                Telefono = txttelefono.Text,
            };
            bool respuesta = PersonaLogica.Instancia.Editar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();
            }
        }

        private void btnelimiar_Click(object sender, EventArgs e)
        {
            Persona objeto = new Persona()
            {
                IdPersona = int.Parse(txtidpersona.Text),
             
            };
            bool respuesta = PersonaLogica.Instancia.Eliminar(objeto);
            if (respuesta)
            {
                limpiar();
                mostrar_personas();
            }

        }
    }
}