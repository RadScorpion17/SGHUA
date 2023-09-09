namespace SGHUA.Views
{
    partial class Login
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            usernameBox = new TextBox();
            passwordBox = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            loginButton = new Button();
            SuspendLayout();
            // 
            // usernameBox
            // 
            usernameBox.BackColor = SystemColors.Menu;
            usernameBox.BorderStyle = BorderStyle.None;
            usernameBox.Location = new Point(57, 173);
            usernameBox.Name = "usernameBox";
            usernameBox.Size = new Size(213, 20);
            usernameBox.TabIndex = 0;
            // 
            // passwordBox
            // 
            passwordBox.BackColor = SystemColors.Menu;
            passwordBox.BorderStyle = BorderStyle.None;
            passwordBox.Location = new Point(57, 244);
            passwordBox.Name = "passwordBox";
            passwordBox.Size = new Size(213, 20);
            passwordBox.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(57, 150);
            label1.Name = "label1";
            label1.Size = new Size(75, 20);
            label1.TabIndex = 2;
            label1.Text = "Username";
            label1.Click += label1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(57, 221);
            label2.Name = "label2";
            label2.Size = new Size(83, 20);
            label2.TabIndex = 3;
            label2.Text = "Contraseña";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 20F, FontStyle.Regular, GraphicsUnit.Point);
            label3.Location = new Point(57, 50);
            label3.Name = "label3";
            label3.Size = new Size(215, 46);
            label3.TabIndex = 4;
            label3.Text = "Iniciar Sesion";
            // 
            // loginButton
            // 
            loginButton.Location = new Point(119, 303);
            loginButton.Name = "loginButton";
            loginButton.Size = new Size(94, 29);
            loginButton.TabIndex = 5;
            loginButton.Text = "Ingresar";
            loginButton.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(332, 450);
            Controls.Add(loginButton);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(passwordBox);
            Controls.Add(usernameBox);
            ForeColor = SystemColors.InactiveCaptionText;
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox usernameBox;
        private TextBox passwordBox;
        private Label label1;
        private Label label2;
        private Label label3;
        private Button loginButton;
    }
}