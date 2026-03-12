namespace Sistema_Horus.Forms.administrador
{
    partial class EmpleadosR
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
            txtApaterno = new TextBox();
            txtAmaterno = new TextBox();
            txtContrasena = new TextBox();
            txtUsuario = new TextBox();
            txtNombre = new TextBox();
            comboRol = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            btnRegistrarEmpleados = new Button();
            SuspendLayout();
            // 
            // txtApaterno
            // 
            txtApaterno.Location = new Point(347, 63);
            txtApaterno.Name = "txtApaterno";
            txtApaterno.Size = new Size(100, 23);
            txtApaterno.TabIndex = 0;
            // 
            // txtAmaterno
            // 
            txtAmaterno.Location = new Point(574, 63);
            txtAmaterno.Name = "txtAmaterno";
            txtAmaterno.Size = new Size(121, 23);
            txtAmaterno.TabIndex = 1;
            // 
            // txtContrasena
            // 
            txtContrasena.Location = new Point(347, 171);
            txtContrasena.Name = "txtContrasena";
            txtContrasena.Size = new Size(100, 23);
            txtContrasena.TabIndex = 2;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(124, 171);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(100, 23);
            txtUsuario.TabIndex = 3;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(124, 63);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(100, 23);
            txtNombre.TabIndex = 4;
            // 
            // comboRol
            // 
            comboRol.FormattingEnabled = true;
            comboRol.Location = new Point(574, 171);
            comboRol.Name = "comboRol";
            comboRol.Size = new Size(121, 23);
            comboRol.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 66);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 6;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(246, 66);
            label2.Name = "label2";
            label2.Size = new Size(98, 15);
            label2.TabIndex = 7;
            label2.Text = "Apellido paterno:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(470, 66);
            label3.Name = "label3";
            label3.Size = new Size(102, 15);
            label3.TabIndex = 8;
            label3.Text = "Apellido materno:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(67, 174);
            label4.Name = "label4";
            label4.Size = new Size(50, 15);
            label4.TabIndex = 9;
            label4.Text = "Usuario:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(271, 174);
            label5.Name = "label5";
            label5.Size = new Size(70, 15);
            label5.TabIndex = 10;
            label5.Text = "Contraseña:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(541, 174);
            label6.Name = "label6";
            label6.Size = new Size(27, 15);
            label6.TabIndex = 11;
            label6.Text = "Rol:";
            // 
            // btnRegistrarEmpleados
            // 
            btnRegistrarEmpleados.Location = new Point(347, 260);
            btnRegistrarEmpleados.Name = "btnRegistrarEmpleados";
            btnRegistrarEmpleados.Size = new Size(98, 42);
            btnRegistrarEmpleados.TabIndex = 12;
            btnRegistrarEmpleados.Text = "Registrar";
            btnRegistrarEmpleados.UseVisualStyleBackColor = true;
            btnRegistrarEmpleados.Click += btnRegistrarEmpleados_Click;
            // 
            // EmpleadosR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btnRegistrarEmpleados);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboRol);
            Controls.Add(txtNombre);
            Controls.Add(txtUsuario);
            Controls.Add(txtContrasena);
            Controls.Add(txtAmaterno);
            Controls.Add(txtApaterno);
            Name = "EmpleadosR";
            Text = "EmpleadosR";
            Load += EmpleadosR_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtApaterno;
        private TextBox txtAmaterno;
        private TextBox txtContrasena;
        private TextBox txtUsuario;
        private TextBox txtNombre;
        private ComboBox comboRol;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Button btnRegistrarEmpleados;
    }
}