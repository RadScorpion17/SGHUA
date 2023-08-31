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
            Idpersona.Location = new Point(57, 92);
            Idpersona.Name = "Idpersona";
            Idpersona.Size = new Size(75, 20);
            Idpersona.TabIndex = 0;
            Idpersona.Text = "Idpersona";
            // 
            // Nombre
            // 
            Nombre.AutoSize = true;
            Nombre.Location = new Point(274, 92);
            Nombre.Name = "Nombre";
            Nombre.Size = new Size(64, 20);
            Nombre.TabIndex = 1;
            Nombre.Text = "Nombre";
            // 
            // Apellido
            // 
            Apellido.AutoSize = true;
            Apellido.Location = new Point(463, 92);
            Apellido.Name = "Apellido";
            Apellido.Size = new Size(66, 20);
            Apellido.TabIndex = 2;
            Apellido.Text = "Apellido";
            // 
            // telefono
            // 
            telefono.AutoSize = true;
            telefono.Location = new Point(702, 92);
            telefono.Name = "telefono";
            telefono.Size = new Size(65, 20);
            telefono.TabIndex = 3;
            telefono.Text = "telefono";
            // 
            // txtidpersona
            // 
            txtidpersona.Location = new Point(35, 116);
            txtidpersona.Margin = new Padding(3, 4, 3, 4);
            txtidpersona.Name = "txtidpersona";
            txtidpersona.Size = new Size(114, 27);
            txtidpersona.TabIndex = 4;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(247, 116);
            txtnombre.Margin = new Padding(3, 4, 3, 4);
            txtnombre.Name = "txtnombre";
            txtnombre.Size = new Size(114, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(437, 116);
            txtapellido.Margin = new Padding(3, 4, 3, 4);
            txtapellido.Name = "txtapellido";
            txtapellido.Size = new Size(114, 27);
            txtapellido.TabIndex = 6;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(670, 116);
            txttelefono.Margin = new Padding(3, 4, 3, 4);
            txttelefono.Name = "txttelefono";
            txttelefono.Size = new Size(114, 27);
            txttelefono.TabIndex = 7;
            // 
            // btnguardar
            // 
            btnguardar.Location = new Point(146, 195);
            btnguardar.Margin = new Padding(3, 4, 3, 4);
            btnguardar.Name = "btnguardar";
            btnguardar.Size = new Size(86, 31);
            btnguardar.TabIndex = 8;
            btnguardar.Text = "guardar";
            btnguardar.UseVisualStyleBackColor = true;
            btnguardar.Click += btnguardar_Click;
            // 
            // btneditar
            // 
            btneditar.Location = new Point(362, 195);
            btneditar.Margin = new Padding(3, 4, 3, 4);
            btneditar.Name = "btneditar";
            btneditar.Size = new Size(86, 31);
            btneditar.TabIndex = 9;
            btneditar.Text = "editar";
            btneditar.UseVisualStyleBackColor = true;
            // 
            // btnelimiar
            // 
            btnelimiar.Location = new Point(574, 195);
            btnelimiar.Margin = new Padding(3, 4, 3, 4);
            btnelimiar.Name = "btnelimiar";
            btnelimiar.Size = new Size(86, 31);
            btnelimiar.TabIndex = 10;
            btnelimiar.Text = "eliminar";
            btnelimiar.UseVisualStyleBackColor = true;
            // 
            // dgvpersonas
            // 
            dgvpersonas.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvpersonas.Location = new Point(134, 256);
            dgvpersonas.Margin = new Padding(3, 4, 3, 4);
            dgvpersonas.Name = "dgvpersonas";
            dgvpersonas.RowHeadersWidth = 51;
            dgvpersonas.RowTemplate.Height = 25;
            dgvpersonas.Size = new Size(598, 328);
            dgvpersonas.TabIndex = 11;
            dgvpersonas.CellContentClick += dgvpersonas_CellContentClick;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(870, 563);
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
            Margin = new Padding(3, 4, 3, 4);
            Name = "Form1";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)dgvpersonas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label Idpersona;
        private Label Nombre;
        private Label Apellido;
        private Label telefono;
        private TextBox txtidpersona;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txttelefono;
        private Button btnguardar;
        private Button btneditar;
        private Button btnelimiar;
        private DataGridView dgvpersonas;
    }
}