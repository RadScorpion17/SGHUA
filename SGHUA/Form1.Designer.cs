namespace SGHUA
{
    partial class Form1
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
            Idpersona = new Label();
            Nombre = new Label();
            Apellido = new Label();
            telefono = new Label();
            txtidpersona = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txttelefono = new TextBox();
            btnguardar = new Button();
            btneditar = new Button();
            btnelimiar = new Button();
            dgvpersonas = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)dgvpersonas).BeginInit();
            SuspendLayout();
            // 
            // Idpersona
            // 
            Idpersona.AutoSize = true;
            Idpersona.Location = new Point(50, 69);
            Idpersona.Name = "Idpersona";
            Idpersona.Size = new Size(59, 15);
            Idpersona.TabIndex = 0;
            Idpersona.Text = "Idpersona";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(240, 69);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(51, 15);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(405, 69);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(51, 15);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(614, 69);
            telefono.Name = "telefono";
            telefono.Size = new Size(51, 15);
            telefono.TabIndex = 3;
            telefono.Text = "telefono";
            // 
            // txtidpersona
            // 
            txtidpersona.Location = new Point(31, 87);
            txtidpersona.Name = "txtidpersona";
            txtidpersona.Size = new Size(100, 23);
            txtidpersona.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(216, 87);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(100, 23);
            txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(382, 87);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(100, 23);
            txtapellido.TabIndex = 6;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(586, 87);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(100, 23);
            txttelefono.TabIndex = 7;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(128, 146);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(75, 23);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(317, 146);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(75, 23);
            btneditar.TabIndex = 9;
            btneditar.Text = "editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btnelimiar
            // 
            btnelimiar.Location = new Point(502, 146);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(75, 23);
            btnelimiar.TabIndex = 10;
            btnelimiar.Text = "eliminar";
            btnelimiar.UseVisualStyleBackColor = true;
            // 
            // dgvpersonas
            // 
            dgvpersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpersonas.Location = new Point(117, 192);
            dgvpersonas.Name = "dgvpersonas";
            dgvpersonas.RowHeadersWidth = 51;
            dgvpersonas.RowTemplate.Height = 25;
            dgvpersonas.Size = new Size(523, 246);
            dgvpersonas.TabIndex = 11;
            dgvpersonas.CellContentClick += dgvpersonas_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(761, 422);
            Controls.Add(dgvpersonas);
            Controls.Add(btnelimiar);
            Controls.Add(btneditar);
            Controls.Add(btnguardar);
            Controls.Add(txttelefono);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtidpersona);
            Controls.Add(telefono);
            Controls.Add(Apellido);
            Controls.Add(Nombre);
            Controls.Add(Idpersona);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dgvpersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
    }
}