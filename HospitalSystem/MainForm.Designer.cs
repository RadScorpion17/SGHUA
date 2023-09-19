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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
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
            dataGridViewCellStyle3.Font = new Font("Segoe UI", 7.20000029F, FontStyle.Regular, GraphicsUnit.Point);
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 192, 192);
            dataGridViewCellStyle3.SelectionForeColor = Color.Gray;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.True;
            dataGridView1.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            dataGridView1.BackgroundColor = SystemColors.ControlLightLight;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(630, 34);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 30;
            dataGridView1.Size = new Size(1118, 657);
            dataGridView1.TabIndex = 0;
            // 
            // AgregarBtn
            // 
            AgregarBtn.Location = new Point(68, 345);
            AgregarBtn.Name = "AgregarBtn";
            AgregarBtn.Size = new Size(94, 29);
            AgregarBtn.TabIndex = 1;
            AgregarBtn.Text = "Agregar";
            AgregarBtn.UseVisualStyleBackColor = true;
            AgregarBtn.Click += AgregarBtn_Click;
            // 
            // EditarBtn
            // 
            EditarBtn.Location = new Point(188, 345);
            EditarBtn.Name = "EditarBtn";
            EditarBtn.Size = new Size(94, 29);
            EditarBtn.TabIndex = 2;
            EditarBtn.Text = "Editar";
            EditarBtn.UseVisualStyleBackColor = true;
            EditarBtn.Click += EditarBtn_Click;
            // 
            // LimpiarBtn
            // 
            LimpiarBtn.Location = new Point(307, 345);
            LimpiarBtn.Name = "LimpiarBtn";
            LimpiarBtn.Size = new Size(94, 29);
            LimpiarBtn.TabIndex = 3;
            LimpiarBtn.Text = "Limpiar";
            LimpiarBtn.UseVisualStyleBackColor = true;
            LimpiarBtn.Click += EliminarBtn_Click;
            // 
            // txtidusuario
            // 
            txtidusuario.Location = new Point(69, 132);
            txtidusuario.Name = "txtidusuario";
            txtidusuario.PlaceholderText = "Id Usuario";
            txtidusuario.Size = new Size(125, 27);
            txtidusuario.TabIndex = 4;
            txtidusuario.TextChanged += textBox1_TextChanged;
            // 
            // txtnombre
            // 
            txtnombre.Location = new Point(69, 191);
            txtnombre.Name = "txtnombre";
            txtnombre.PlaceholderText = "Nombre";
            txtnombre.Size = new Size(125, 27);
            txtnombre.TabIndex = 5;
            // 
            // txtapellido
            // 
            txtapellido.Location = new Point(239, 191);
            txtapellido.Name = "txtapellido";
            txtapellido.PlaceholderText = "Apellido";
            txtapellido.Size = new Size(125, 27);
            txtapellido.TabIndex = 6;
            // 
            // txtcedula
            // 
            txtcedula.Location = new Point(239, 255);
            txtcedula.Name = "txtcedula";
            txtcedula.PlaceholderText = "Cedula";
            txtcedula.Size = new Size(125, 27);
            txtcedula.TabIndex = 7;
            // 
            // txttelefono
            // 
            txttelefono.Location = new Point(69, 255);
            txttelefono.Name = "txttelefono";
            txttelefono.PlaceholderText = "Telefono";
            txttelefono.Size = new Size(125, 27);
            txttelefono.TabIndex = 8;
            // 
            // button1
            // 
            button1.Location = new Point(438, 345);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 9;
            button1.Text = "Eliminar";
            button1.UseVisualStyleBackColor = true;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1778, 723);
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