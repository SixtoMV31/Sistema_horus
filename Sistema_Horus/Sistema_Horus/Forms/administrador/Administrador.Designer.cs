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
            btnEmpleado = new Button();
            pictureBox2 = new PictureBox();
            button2 = new Button();
            button3 = new Button();
            PanelControl = new Panel();
            label1 = new Label();
            panel1 = new Panel();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            PanelControl.SuspendLayout();
            SuspendLayout();
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
            button3.Size = new Size(163, 40);
            button3.TabIndex = 6;
            button3.Text = "Ingresar correo";
            button3.UseVisualStyleBackColor = false;
            // 
            // PanelControl
            // 
            PanelControl.Controls.Add(label1);
            PanelControl.Location = new Point(181, 33);
            PanelControl.Name = "PanelControl";
            PanelControl.Size = new Size(621, 463);
            PanelControl.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(26, 172);
            label1.Name = "label1";
            label1.Size = new Size(531, 15);
            label1.TabIndex = 0;
            label1.Text = "Esto es un panel implementado donde se implementaran los formularios de cada boton presionado";
            // 
            // panel1
            // 
            panel1.Anchor = AnchorStyles.None;
            panel1.BackColor = Color.FromArgb(20, 23, 32);
            panel1.ForeColor = Color.Cornsilk;
            panel1.Location = new Point(-3, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(181, 487);
            panel1.TabIndex = 2;
            panel1.Paint += panel1_Paint;
            // 
            // Administrador
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.White;
            ClientSize = new Size(890, 484);
            Controls.Add(PanelControl);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(pictureBox2);
            Controls.Add(btnEmpleado);
            Controls.Add(panel1);
            Name = "Administrador";
            Text = "Administrador";
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            PanelControl.ResumeLayout(false);
            PanelControl.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Button btnEmpleado;
        private PictureBox pictureBox2;
        private Button button2;
        private Button button3;
        private Panel PanelControl;
        private Panel panel1;
        private Label label1;
    }
}