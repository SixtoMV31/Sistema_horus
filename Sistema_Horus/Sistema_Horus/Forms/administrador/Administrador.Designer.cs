namespace Sistema_Horus
{
    partial class Administrador
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
            pictureBox2 = new PictureBox();
            pictureBox1 = new PictureBox();
            pictureBox3 = new PictureBox();
            btnAgregarEmpleado = new Button();
            pictureBox4 = new PictureBox();
            agregaruser = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            SuspendLayout();
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(690, -2);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(109, 67);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 3;
            pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox1.Location = new Point(0, -2);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(200, 452);
            pictureBox1.TabIndex = 2;
            pictureBox1.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox3.Location = new Point(189, -2);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(610, 67);
            pictureBox3.TabIndex = 4;
            pictureBox3.TabStop = false;
            // 
            // btnAgregarEmpleado
            // 
            btnAgregarEmpleado.Location = new Point(293, 131);
            btnAgregarEmpleado.Name = "btnAgregarEmpleado";
            btnAgregarEmpleado.Size = new Size(113, 41);
            btnAgregarEmpleado.TabIndex = 5;
            btnAgregarEmpleado.Text = "Agregar Empleado";
            btnAgregarEmpleado.UseVisualStyleBackColor = true;
            btnAgregarEmpleado.Click += btnAgregarEmpleado_Click;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources.agreagar_user;
            pictureBox4.Location = new Point(232, 131);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(46, 41);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 6;
            pictureBox4.TabStop = false;
            // 
            // agregaruser
            // 
            agregaruser.AutoSize = true;
            agregaruser.BackColor = Color.FromArgb(20, 23, 32);
            agregaruser.Font = new Font("Trebuchet MS", 20.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            agregaruser.ForeColor = Color.White;
            agregaruser.Location = new Point(322, 9);
            agregaruser.Name = "agregaruser";
            agregaruser.Size = new Size(306, 35);
            agregaruser.TabIndex = 7;
            agregaruser.Text = "Registrar Nuevo Usuario";
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ControlLight;
            ClientSize = new Size(800, 450);
            Controls.Add(agregaruser);
            Controls.Add(pictureBox4);
            Controls.Add(btnAgregarEmpleado);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox1);
            Name = "Administrador";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox2;
        private PictureBox pictureBox1;
        private PictureBox pictureBox3;
        private Button btnAgregarEmpleado;
        private PictureBox pictureBox4;
        private Label agregaruser;
    }
}