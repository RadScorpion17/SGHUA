using SGHUA.Coneccion_Sqlite;
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
                Nombre = txttelefono.Text,
                Apellido = txttelefono.Text,
                Telefono = txttelefono.Text,
            };
            bool respuesta = PersonaLogica.Instancia.Guardar(objeto);
            if (respuesta) {
                mostrar_personas();
            }
        }

      public void mostrar_personas()
        {
            dgvpersonas.DataSource = null;
            dgvpersonas.DataSource = PersonaLogica.Instancia.Listar();
        }
    }
}