namespace Sistema_Horus.Empleado
{
    partial class OpcionesEmpleadocs
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
            panel1 = new Panel();
            btn_AgregarCliente = new Button();
            panel3 = new Panel();
            btnVentas = new Button();
            panel2 = new Panel();
            pictureBox1 = new PictureBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            panelContenedor = new Panel();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(20, 23, 32);
            panel1.Controls.Add(btn_AgregarCliente);
            panel1.Controls.Add(panel3);
            panel1.Controls.Add(panel2);
            panel1.Dock = DockStyle.Left;
            panel1.Location = new Point(0, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(200, 450);
            panel1.TabIndex = 0;
            // 
            // btn_AgregarCliente
            // 
            btn_AgregarCliente.BackColor = Color.FromArgb(20, 23, 32);
            btn_AgregarCliente.Dock = DockStyle.Top;
            btn_AgregarCliente.FlatAppearance.BorderSize = 0;
            btn_AgregarCliente.FlatStyle = FlatStyle.Flat;
            btn_AgregarCliente.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btn_AgregarCliente.ForeColor = SystemColors.ControlLightLight;
            btn_AgregarCliente.Image = Properties.Resources.agregarcliente1;
            btn_AgregarCliente.ImageAlign = ContentAlignment.MiddleLeft;
            btn_AgregarCliente.Location = new Point(0, 172);
            btn_AgregarCliente.Name = "btn_AgregarCliente";
            btn_AgregarCliente.Size = new Size(200, 55);
            btn_AgregarCliente.TabIndex = 3;
            btn_AgregarCliente.Text = "        Registrar Cliente";
            btn_AgregarCliente.TextAlign = ContentAlignment.MiddleLeft;
            btn_AgregarCliente.UseVisualStyleBackColor = false;
            btn_AgregarCliente.Click += btn_AgregarCliente_Click;
            // 
            // panel3
            // 
            panel3.Controls.Add(btnVentas);
            panel3.Dock = DockStyle.Top;
            panel3.Location = new Point(0, 125);
            panel3.Name = "panel3";
            panel3.Size = new Size(200, 47);
            panel3.TabIndex = 2;
            // 
            // btnVentas
            // 
            btnVentas.BackColor = Color.FromArgb(20, 23, 32);
            btnVentas.FlatAppearance.BorderSize = 0;
            btnVentas.FlatStyle = FlatStyle.Flat;
            btnVentas.Font = new Font("Tahoma", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVentas.ForeColor = SystemColors.ControlLightLight;
            btnVentas.Image = Properties.Resources.ventass;
            btnVentas.ImageAlign = ContentAlignment.MiddleLeft;
            btnVentas.Location = new Point(0, 3);
            btnVentas.Name = "btnVentas";
            btnVentas.Size = new Size(200, 55);
            btnVentas.TabIndex = 0;
            btnVentas.Text = "        Realizar Venta";
            btnVentas.TextAlign = ContentAlignment.MiddleLeft;
            btnVentas.UseVisualStyleBackColor = false;
            btnVentas.Click += btnVentas_Click;
            // 
            // panel2
            // 
            panel2.Controls.Add(pictureBox1);
            panel2.Dock = DockStyle.Top;
            panel2.Location = new Point(0, 0);
            panel2.Name = "panel2";
            panel2.Size = new Size(200, 125);
            panel2.TabIndex = 1;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.logo;
            pictureBox1.Location = new Point(12, 12);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(171, 90);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // panelContenedor
            // 
            panelContenedor.BackColor = SystemColors.ControlLightLight;
            panelContenedor.Dock = DockStyle.Fill;
            panelContenedor.Location = new Point(200, 0);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(600, 450);
            panelContenedor.TabIndex = 1;
            // 
            // OpcionesEmpleadocs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(panelContenedor);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "OpcionesEmpleadocs";
            Text = "OpcionesEmpleadocs";
            panel1.ResumeLayout(false);
            panel3.ResumeLayout(false);
            panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private Panel panel1;
        private Panel panel2;
        private PictureBox pictureBox1;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Panel panel3;
        private Button btnVentas;
        private Button btn_AgregarCliente;
        private Panel panelContenedor;
    }
}