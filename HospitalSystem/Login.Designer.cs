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
            IniciarSesionTag = new Label();
            UsernameBox = new TextBox();
            PasswordBox = new TextBox();
            LoginButton = new Button();
            panel1 = new Panel();
            CloseButton = new Button();
            SuspendLayout();
            // 
            // IniciarSesionTag
            // 
            IniciarSesionTag.AutoSize = true;
            IniciarSesionTag.Font = new Font("Segoe UI", 30F, FontStyle.Regular, GraphicsUnit.Point);
            IniciarSesionTag.Location = new Point(483, 126);
            IniciarSesionTag.Name = "IniciarSesionTag";
            IniciarSesionTag.Size = new Size(316, 67);
            IniciarSesionTag.TabIndex = 0;
            IniciarSesionTag.Text = "Iniciar Sesión";
            // 
            // UsernameBox
            // 
            UsernameBox.BorderStyle = BorderStyle.None;
            UsernameBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            UsernameBox.Location = new Point(492, 239);
            UsernameBox.Margin = new Padding(5);
            UsernameBox.Name = "UsernameBox";
            UsernameBox.PlaceholderText = "Usuario";
            UsernameBox.Size = new Size(296, 23);
            UsernameBox.TabIndex = 3;
            UsernameBox.Enter += UsernameBox_Enter;
            UsernameBox.Leave += UsernameBox_Leave;
            // 
            // PasswordBox
            // 
            PasswordBox.BorderStyle = BorderStyle.None;
            PasswordBox.Cursor = Cursors.IBeam;
            PasswordBox.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            PasswordBox.Location = new Point(492, 295);
            PasswordBox.Margin = new Padding(5);
            PasswordBox.Name = "PasswordBox";
            PasswordBox.PlaceholderText = "Contraseña";
            PasswordBox.Size = new Size(298, 23);
            PasswordBox.TabIndex = 4;
            PasswordBox.Enter += PasswordBox_Enter;
            PasswordBox.Leave += PasswordBox_Leave;
            // 
            // LoginButton
            // 
            LoginButton.Font = new Font("Segoe UI", 10F, FontStyle.Regular, GraphicsUnit.Point);
            LoginButton.Location = new Point(586, 356);
            LoginButton.Name = "LoginButton";
            LoginButton.Size = new Size(106, 36);
            LoginButton.TabIndex = 5;
            LoginButton.Text = "Ingresar";
            LoginButton.UseVisualStyleBackColor = true;
            LoginButton.Click += LoginButton_Click;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Location = new Point(-2, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(311, 579);
            panel1.TabIndex = 6;
            // 
            // CloseButton
            // 
            CloseButton.AccessibleRole = AccessibleRole.Slider;
            CloseButton.BackColor = Color.Transparent;
            CloseButton.Cursor = Cursors.Hand;
            CloseButton.FlatAppearance.BorderSize = 0;
            CloseButton.FlatStyle = FlatStyle.Flat;
            CloseButton.Font = new Font("Microsoft Sans Serif", 9F, FontStyle.Regular, GraphicsUnit.Point);
            CloseButton.Location = new Point(944, 2);
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
            ClientSize = new Size(983, 575);
            Controls.Add(CloseButton);
            Controls.Add(panel1);
            Controls.Add(LoginButton);
            Controls.Add(UsernameBox);
            Controls.Add(PasswordBox);
            Controls.Add(IniciarSesionTag);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            Opacity = 0.95D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
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