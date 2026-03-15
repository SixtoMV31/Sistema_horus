namespace Sistema_Horus.Forms.administrador
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
            pictureBox1 = new PictureBox();
            btnEmpleado = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            PanelControl = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox1.Location = new Point(-3, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(181, 452);
            pictureBox1.TabIndex = 1;
            pictureBox1.TabStop = false;
            // 
            // btnEmpleado
            // 
            btnEmpleado.BackColor = Color.FromArgb(20, 23, 32);
            btnEmpleado.BackgroundImageLayout = ImageLayout.Zoom;
            btnEmpleado.FlatAppearance.BorderSize = 0;
            btnEmpleado.FlatStyle = FlatStyle.Flat;
            btnEmpleado.ForeColor = SystemColors.Control;
            btnEmpleado.Image = Properties.Resources.agregar1;
            btnEmpleado.ImageAlign = ContentAlignment.MiddleLeft;
            btnEmpleado.Location = new Point(12, 192);
            btnEmpleado.Name = "btnEmpleado";
            btnEmpleado.Size = new Size(148, 40);
            btnEmpleado.TabIndex = 3;
            btnEmpleado.Text = "Ingresar empleado";
            btnEmpleado.TextAlign = ContentAlignment.MiddleRight;
            btnEmpleado.UseVisualStyleBackColor = false;
            btnEmpleado.Click += button1_Click;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(20, 25, 32);
            pictureBox2.Image = Properties.Resources.admin;
            pictureBox2.Location = new Point(40, 33);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(100, 100);
            pictureBox2.SizeMode = PictureBoxSizeMode.AutoSize;
            pictureBox2.TabIndex = 4;
            pictureBox2.TabStop = false;
            // 
            // button2
            // 
            button2.BackColor = Color.FromArgb(20, 23, 32);
            button2.BackgroundImageLayout = ImageLayout.Zoom;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = SystemColors.Control;
            button2.Image = Properties.Resources.AddProducto;
            button2.ImageAlign = ContentAlignment.MiddleLeft;
            button2.Location = new Point(12, 255);
            button2.Name = "button2";
            button2.Size = new Size(148, 40);
            button2.TabIndex = 5;
            button2.Text = "Agregar Productos";
            button2.TextAlign = ContentAlignment.MiddleRight;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.BackColor = Color.FromArgb(20, 23, 32);
            button3.BackgroundImageLayout = ImageLayout.Zoom;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = SystemColors.Control;
            button3.Image = Properties.Resources.Email;
            button3.ImageAlign = ContentAlignment.MiddleLeft;
            button3.Location = new Point(12, 318);
            button3.Name = "button3";
            button3.Size = new Size(166, 40);
            button3.TabIndex = 6;
            button3.Text = "Ingresar correo";
            button3.UseVisualStyleBackColor = false;
            // 
            // PanelControl
            // 
            PanelControl.Location = new Point(175, 0);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(625, 452);
            PanelControl.TabIndex = 7;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(800, 450);
            Controls.Add(PanelControl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(btnEmpleado);
            Controls.Add(pictureBox1);
            Name = "Administrador";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private Button btnEmpleado;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Panel PanelControl;
    }
}