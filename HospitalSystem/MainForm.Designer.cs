namespace HospitalSystem
{
    partial class MainForm
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
            components = new System.ComponentModel.Container();
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            bindingSource1 = new BindingSource(components);
            dataGridView1 = new DataGridView();
            AgregarBtn = new Button();
            EditarBtn = new Button();
            LimpiarBtn = new Button();
            txtidusuario = new TextBox();
            txtnombre = new TextBox();
            txtapellido = new TextBox();
            txtcedula = new TextBox();
            txttelefono = new TextBox();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)bindingSource1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle1.SelectionForeColor = Color.Gray;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(535, 20);
            dataGridView1.Margin = new Padding(3, 2, 3, 2);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(876, 463);
            dataGridView1.TabIndex = 0;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(60, 259);
            AgregarBtn.Margin = new Padding(3, 2, 3, 2);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(82, 22);
            AgregarBtn.TabIndex = 1;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(164, 259);
            EditarBtn.Margin = new Padding(3, 2, 3, 2);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(82, 22);
            EditarBtn.TabIndex = 2;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(269, 259);
            LimpiarBtn.Margin = new Padding(3, 2, 3, 2);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(82, 22);
            LimpiarBtn.TabIndex = 3;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += EliminarBtn_Click;
            // 
            // txtidusuario
            // 
            txtidusuario.Location = new Point(60, 99);
            txtidusuario.Margin = new Padding(3, 2, 3, 2);
            txtidusuario.Name = "txtidusuario";
            txtidusuario.PlaceholderText = "Id Usuario";
            txtidusuario.Size = new Size(110, 23);
            txtidusuario.TabIndex = 4;
            txtidusuario.TextChanged += textBox1_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(60, 143);
            txtnombre.Margin = new Padding(3, 2, 3, 2);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(110, 23);
            txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(209, 143);
            txtapellido.Margin = new Padding(3, 2, 3, 2);
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Size = new Size(110, 23);
            txtapellido.TabIndex = 6;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(209, 191);
            txtcedula.Margin = new Padding(3, 2, 3, 2);
            txtcedula.Name = "txtcedula";
            txtcedula.PlaceholderText = "Cedula";
            txtcedula.Size = new Size(110, 23);
            txtcedula.TabIndex = 7;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(60, 191);
            txttelefono.Margin = new Padding(3, 2, 3, 2);
            txttelefono.Name = "txttelefono";
            txttelefono.PlaceholderText = "Telefono";
            txttelefono.Size = new Size(110, 23);
            txttelefono.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(383, 259);
            button1.Margin = new Padding(3, 2, 3, 2);
            button1.Name = "button1";
            button1.Size = new Size(82, 22);
            button1.TabIndex = 9;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1434, 542);
            Controls.Add(button1);
            Controls.Add(txttelefono);
            Controls.Add(txtcedula);
            Controls.Add(txtapellido);
            Controls.Add(txtnombre);
            Controls.Add(txtidusuario);
            Controls.Add(LimpiarBtn);
            Controls.Add(EditarBtn);
            Controls.Add(AgregarBtn);
            Controls.Add(dataGridView1);
            Margin = new Padding(3, 2, 3, 2);
            Name = "MainForm";
            StartPosition = FormStartPosition.Manual;
            Text = "Admin";
            WindowState = FormWindowState.Maximized;
            Load += MainForm_Load;
            ((System.ComponentModel.ISupportInitialize)bindingSource1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private BindingSource bindingSource1;
        private DataGridView dataGridView1;
        private Button AgregarBtn;
        private Button EditarBtn;
        private Button LimpiarBtn;
        private TextBox txtidusuario;
        private TextBox txtnombre;
        private TextBox txtapellido;
        private TextBox txtcedula;
        private TextBox txttelefono;
        private Button button1;
    }
}