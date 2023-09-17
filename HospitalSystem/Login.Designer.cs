namespace HospitalSystem
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Login));
            IniciarSesionTag = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            panel1 = new Panel();
            CloseButton = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // IniciarSesionTag
            // 
            IniciarSesionTag.Font = new Font("Segoe UI", 55F, FontStyle.Regular, GraphicsUnit.Pixel);
            IniciarSesionTag.Location = new Point(118, 96);
            IniciarSesionTag.Name = "IniciarSesionTag";
            IniciarSesionTag.Size = new Size(449, 112);
            IniciarSesionTag.TabIndex = 0;
            IniciarSesionTag.Text = "Iniciar Sesión";
            IniciarSesionTag.TextAlign = ContentAlignment.MiddleLeft;
            IniciarSesionTag.Click += IniciarSesionTag_Click;
            // 
            // UsernameBox
            // 
            UsernameBox.Anchor = AnchorStyles.None;
            UsernameBox.BackColor = Color.White;
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Cursor = Cursors.IBeam;
            UsernameBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            UsernameBox.Location = new Point(130, 275);
            UsernameBox.Margin = new Padding(57, 67, 57, 67);
            UsernameBox.MaximumSize = new Size(488, 38);
            UsernameBox.MaxLength = 100;
            UsernameBox.MinimumSize = new Size(488, 38);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Usuario";
            UsernameBox.Size = new Size(488, 38);
            UsernameBox.TabIndex = 3;
            // 
            // PasswordBox
            // 
            PasswordBox.BackColor = Color.White;
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Font = new Font("Microsoft Sans Serif", 10F, FontStyle.Bold, GraphicsUnit.Point);
            PasswordBox.Location = new Point(130, 389);
            PasswordBox.Margin = new Padding(57, 67, 57, 67);
            PasswordBox.MaximumSize = new Size(488, 38);
            PasswordBox.MaxLength = 100;
            PasswordBox.MinimumSize = new Size(488, 38);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Contraseña";
            PasswordBox.Size = new Size(488, 38);
            PasswordBox.TabIndex = 4;
            PasswordBox.UseSystemPasswordChar = true;
            // 
            // LoginButton
            // 
            LoginButton.BackColor = Color.FromArgb(243, 93, 93);
            LoginButton.FlatStyle = FlatStyle.Popup;
            LoginButton.Font = new Font("Microsoft Sans Serif", 8F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.ForeColor = Color.White;
            LoginButton.Location = new Point(130, 537);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(488, 51);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Ingresar";
            LoginButton.UseVisualStyleBackColor = false;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(246, 246, 246);
            panel1.Controls.Add(CloseButton);
            panel1.Controls.Add(IniciarSesionTag);
            panel1.Controls.Add(PasswordBox);
            panel1.Controls.Add(UsernameBox);
            panel1.Controls.Add(LoginButton);
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(754, 1024);
            panel1.TabIndex = 6;
            panel1.Paint += panel1_Paint;
            // 
            // CloseButton
            // 
            CloseButton.AccessibleRole = AccessibleRole.Slider;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(12, 12);
            CloseButton.Name = "CloseButton";
            CloseButton.Size = new Size(39, 33);
            CloseButton.TabIndex = 7;
            CloseButton.Text = "X";
            CloseButton.UseVisualStyleBackColor = false;
            CloseButton.Click += CloseButton_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonFace;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(1381, 741);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label IniciarSesionTag;
        private TextBox UsernameBox;
        private TextBox PasswordBox;
        private Button LoginButton;
        private Panel panel1;
        private Button CloseButton;
    }
}