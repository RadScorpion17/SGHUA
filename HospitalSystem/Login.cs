using Domain;
using Common.Cache;

namespace HospitalSystem
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            UsernameBox.Focus();
        }
        //Placeholders para los campos de contraseņa y usuarios
        private void UsernameBox_Enter(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "Usuario")
            {
                UsernameBox.Text = "";
                UsernameBox.ForeColor = Color.LightGray;
            }
        }
        private void UsernameBox_Leave(object sender, EventArgs e)
        {
            if (UsernameBox.Text == "")
            {
                UsernameBox.Text = "Usuario";
                UsernameBox.ForeColor = Color.Silver;
            }
        }

        private void PasswordBox_Enter(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "Contraseņa")
            {
                PasswordBox.Text = "";
                PasswordBox.ForeColor = Color.LightGray;
            }
        }

        private void PasswordBox_Leave(object sender, EventArgs e)
        {
            if (PasswordBox.Text == "")
            {
                PasswordBox.Text = "Contraseņa";
                PasswordBox.ForeColor = Color.Silver;
            }
        }

        private void CloseButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void LoginButton_Click(object sender, EventArgs e)
        {
            if (UsernameBox.Text != "Username" && UsernameBox.TextLength > 2)
            {
                if (PasswordBox.Text != "Password")
                {
                    UserModel user = new UserModel();
                    var validLogin = user.LoginUser(UsernameBox.Text, PasswordBox.Text);
                    if (validLogin == true)
                    {
                            MainForm mainForm = new MainForm();
                            MessageBox.Show("Exito!");
                            mainForm.Show();
                            mainForm.FormClosed += Logout;
                            this.Hide();
                        }
                    
                    else
                    {
                        msgError("Incorrect username or password entered. \n   Please try again.");
                        PasswordBox.Text = "Password";
                        PasswordBox.UseSystemPasswordChar = false;
                    }
                }
            }
        }

        private void Logout(object? sender, FormClosedEventArgs e)
        {
            PasswordBox.Text = "Password";
            PasswordBox.UseSystemPasswordChar = false;
            UsernameBox.Text = "Username";
            this.Show();
        }

        private void msgError(string msg)
        {
            MessageBox.Show(msg);
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void IniciarSesionTag_Click(object sender, EventArgs e)
        {

        }
    }
}