namespace Sistema_Horus.Empleado
{
    partial class FormRegistrarClientes
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
            txt_NombreCliente = new TextBox();
            label1 = new Label();
            label2 = new Label();
            txt_A_MaternoCliente = new TextBox();
            label3 = new Label();
            txt_A_PaternoCliente = new TextBox();
            label4 = new Label();
            txt_Nombre_Local = new TextBox();
            label5 = new Label();
            txt_TelefonoCliente = new TextBox();
            label6 = new Label();
            txt_Detalle_Clientte = new TextBox();
            sqlCommand1 = new Microsoft.Data.SqlClient.SqlCommand();
            label7 = new Label();
            btn_RegistrarCliente = new Button();
            dt_Fecha_Registro = new DateTimePicker();
            SuspendLayout();
            // 
            // txt_NombreCliente
            // 
            txt_NombreCliente.Location = new Point(126, 53);
            txt_NombreCliente.Name = "txt_NombreCliente";
            txt_NombreCliente.Size = new Size(143, 23);
            txt_NombreCliente.TabIndex = 0;
            
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(25, 61);
            label1.Name = "label1";
            label1.Size = new Size(51, 15);
            label1.TabIndex = 1;
            label1.Text = "Nombre";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(25, 206);
            label2.Name = "label2";
            label2.Size = new Size(99, 15);
            label2.TabIndex = 3;
            label2.Text = "Apellido Materno";
            // 
            // txt_A_MaternoCliente
            // 
            txt_A_MaternoCliente.Location = new Point(126, 198);
            txt_A_MaternoCliente.Name = "txt_A_MaternoCliente";
            txt_A_MaternoCliente.Size = new Size(143, 23);
            txt_A_MaternoCliente.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(25, 131);
            label3.Name = "label3";
            label3.Size = new Size(95, 15);
            label3.TabIndex = 5;
            label3.Text = "Apellido Paterno";
            // 
            // txt_A_PaternoCliente
            // 
            txt_A_PaternoCliente.Location = new Point(126, 123);
            txt_A_PaternoCliente.Name = "txt_A_PaternoCliente";
            txt_A_PaternoCliente.Size = new Size(143, 23);
            txt_A_PaternoCliente.TabIndex = 4;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(291, 61);
            label4.Name = "label4";
            label4.Size = new Size(106, 15);
            label4.TabIndex = 7;
            label4.Text = "Nombre /No Local";
            // 
            // txt_Nombre_Local
            // 
            txt_Nombre_Local.Location = new Point(403, 53);
            txt_Nombre_Local.Name = "txt_Nombre_Local";
            txt_Nombre_Local.Size = new Size(143, 23);
            txt_Nombre_Local.TabIndex = 6;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(302, 131);
            label5.Name = "label5";
            label5.Size = new Size(53, 15);
            label5.TabIndex = 9;
            label5.Text = "Telefono";
            // 
            // txt_TelefonoCliente
            // 
            txt_TelefonoCliente.Location = new Point(403, 123);
            txt_TelefonoCliente.Name = "txt_TelefonoCliente";
            txt_TelefonoCliente.Size = new Size(143, 23);
            txt_TelefonoCliente.TabIndex = 8;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(302, 206);
            label6.Name = "label6";
            label6.Size = new Size(84, 15);
            label6.TabIndex = 11;
            label6.Text = "Fecha Registro";
            // 
            // txt_Detalle_Clientte
            // 
            txt_Detalle_Clientte.Location = new Point(126, 266);
            txt_Detalle_Clientte.Name = "txt_Detalle_Clientte";
            txt_Detalle_Clientte.Size = new Size(420, 23);
            txt_Detalle_Clientte.TabIndex = 12;
            // 
            // sqlCommand1
            // 
            sqlCommand1.CommandTimeout = 30;
            sqlCommand1.EnableOptimizedParameterBinding = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(25, 274);
            label7.Name = "label7";
            label7.Size = new Size(73, 15);
            label7.TabIndex = 13;
            label7.Text = "Mas Detalles";
            // 
            // btn_RegistrarCliente
            // 
            btn_RegistrarCliente.Location = new Point(221, 326);
            btn_RegistrarCliente.Name = "btn_RegistrarCliente";
            btn_RegistrarCliente.Size = new Size(176, 49);
            btn_RegistrarCliente.TabIndex = 14;
            btn_RegistrarCliente.Text = "Registrar";
            btn_RegistrarCliente.UseVisualStyleBackColor = true;
            btn_RegistrarCliente.Click += btn_RegistrarCliente_Click;
            // 
            // dt_Fecha_Registro
            // 
            dt_Fecha_Registro.Location = new Point(399, 198);
            dt_Fecha_Registro.Name = "dt_Fecha_Registro";
            dt_Fecha_Registro.Size = new Size(147, 23);
            dt_Fecha_Registro.TabIndex = 15;
            // 
            // FormRegistrarClientes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(600, 450);
            Controls.Add(dt_Fecha_Registro);
            Controls.Add(btn_RegistrarCliente);
            Controls.Add(label7);
            Controls.Add(txt_Detalle_Clientte);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(txt_TelefonoCliente);
            Controls.Add(label4);
            Controls.Add(txt_Nombre_Local);
            Controls.Add(label3);
            Controls.Add(txt_A_PaternoCliente);
            Controls.Add(label2);
            Controls.Add(txt_A_MaternoCliente);
            Controls.Add(label1);
            Controls.Add(txt_NombreCliente);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormRegistrarClientes";
            Text = "RegistrarClientes";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txt_NombreCliente;
        private Label label1;
        private Label label2;
        private TextBox txt_A_MaternoCliente;
        private Label label3;
        private TextBox txt_A_PaternoCliente;
        private Label label4;
        private TextBox txt_Nombre_Local;
        private Label label5;
        private TextBox txt_TelefonoCliente;
        private Label label6;
        private TextBox txt_Detalle_Clientte;
        private Microsoft.Data.SqlClient.SqlCommand sqlCommand1;
        private Label label7;
        private Button btn_RegistrarCliente;
        private DateTimePicker dt_Fecha_Registro;
    }
}