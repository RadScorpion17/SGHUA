namespace SGHUA
{
    partial class FormLogin
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
            txtusuariologin = new Label();
            txtpasslogin = new Label();
            btningresarlogin = new Button();
            btncancelarlogin = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // txtusuariologin
            // 
            txtusuariologin.AutoSize = true;
            txtusuariologin.Location = new Point(63, 40);
            txtusuariologin.Name = "txtusuariologin";
            txtusuariologin.Size = new Size(47, 15);
            txtusuariologin.TabIndex = 0;
            txtusuariologin.Text = "Usuario";
            txtusuariologin.Click += label1_Click;
            // 
            // txtpasslogin
            // 
            txtpasslogin.AutoSize = true;
            txtpasslogin.Location = new Point(63, 124);
            txtpasslogin.Name = "txtpasslogin";
            txtpasslogin.Size = new Size(67, 15);
            txtpasslogin.TabIndex = 1;
            txtpasslogin.Text = "Contraseña";
            // 
            // btningresarlogin
            // 
            btningresarlogin.Location = new Point(92, 217);
            btningresarlogin.Name = "btningresarlogin";
            btningresarlogin.Size = new Size(75, 23);
            btningresarlogin.TabIndex = 2;
            btningresarlogin.Text = "Ingresar";
            btningresarlogin.UseVisualStyleBackColor = true;
            btningresarlogin.Click += button1_Click;
            // 
            // btncancelarlogin
            // 
            btncancelarlogin.Location = new Point(219, 217);
            btncancelarlogin.Name = "btncancelarlogin";
            btncancelarlogin.Size = new Size(75, 23);
            btncancelarlogin.TabIndex = 3;
            btncancelarlogin.Text = "Cancelar";
            btncancelarlogin.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(184, 38);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 4;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(194, 124);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(100, 23);
            textBox2.TabIndex = 5;
            // 
            // FormLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(421, 391);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(btncancelarlogin);
            Controls.Add(btningresarlogin);
            Controls.Add(txtpasslogin);
            Controls.Add(txtusuariologin);
            Name = "FormLogin";
            Text = "FormLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label txtusuariologin;
        private Label txtpasslogin;
        private Button btningresarlogin;
        private Button btncancelarlogin;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}