namespace Sistema_Horus
{
    partial class Login
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
            pictureBox1 = new PictureBox();
            pictureBox2 = new PictureBox();
            pictureBox3 = new PictureBox();
            pictureBox4 = new PictureBox();
            tb_contra = new TextBox();
            Pa_user = new Panel();
            Tb_User = new TextBox();
            btnIniciar_sesion = new Button();
            button1 = new Button();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).BeginInit();
            Pa_user.SuspendLayout();
            SuspendLayout();
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(320, 452);
            pictureBox1.TabIndex = 0;
            pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            pictureBox2.BackColor = Color.FromArgb(20, 23, 32);
            pictureBox2.Image = Properties.Resources.logo;
            pictureBox2.Location = new Point(0, 102);
            pictureBox2.Name = "pictureBox2";
            pictureBox2.Size = new Size(320, 193);
            pictureBox2.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox2.TabIndex = 1;
            pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            pictureBox3.Image = Properties.Resources.User;
            pictureBox3.Location = new Point(382, 127);
            pictureBox3.Name = "pictureBox3";
            pictureBox3.Size = new Size(50, 50);
            pictureBox3.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox3.TabIndex = 3;
            pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            pictureBox4.Image = Properties.Resources._lock;
            pictureBox4.Location = new Point(382, 225);
            pictureBox4.Name = "pictureBox4";
            pictureBox4.Size = new Size(50, 50);
            pictureBox4.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox4.TabIndex = 5;
            pictureBox4.TabStop = false;
            // 
            // tb_contra
            // 
            tb_contra.BorderStyle = BorderStyle.None;
            tb_contra.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tb_contra.Location = new Point(453, 235);
            tb_contra.Multiline = true;
            tb_contra.Name = "tb_contra";
            tb_contra.Size = new Size(280, 40);
            tb_contra.TabIndex = 4;
            // 
            // Pa_user
            // 
            Pa_user.Controls.Add(Tb_User);
            Pa_user.Location = new Point(453, 124);
            Pa_user.Name = "Pa_user";
            Pa_user.Size = new Size(288, 46);
            Pa_user.TabIndex = 6;
            // 
            // Tb_User
            // 
            Tb_User.BorderStyle = BorderStyle.None;
            Tb_User.Font = new Font("Segoe UI", 9.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            Tb_User.Location = new Point(5, 3);
            Tb_User.Multiline = true;
            Tb_User.Name = "Tb_User";
            Tb_User.Size = new Size(280, 40);
            Tb_User.TabIndex = 3;
            // 
            // btnIniciar_sesion
            // 
            btnIniciar_sesion.BackColor = Color.Goldenrod;
            btnIniciar_sesion.Location = new Point(453, 314);
            btnIniciar_sesion.Name = "btnIniciar_sesion";
            btnIniciar_sesion.Size = new Size(283, 39);
            btnIniciar_sesion.TabIndex = 7;
            btnIniciar_sesion.Text = "Iniciar Sesion";
            btnIniciar_sesion.UseVisualStyleBackColor = false;
            btnIniciar_sesion.Click += btnIniciar_sesion_Click;
            // 
            // button1
            // 
            button1.Location = new Point(422, 39);
            button1.Name = "button1";
            button1.Size = new Size(110, 46);
            button1.TabIndex = 8;
            button1.Text = "button1";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(button1);
            Controls.Add(btnIniciar_sesion);
            Controls.Add(Pa_user);
            Controls.Add(pictureBox4);
            Controls.Add(tb_contra);
            Controls.Add(pictureBox3);
            Controls.Add(pictureBox2);
            Controls.Add(pictureBox1);
            Name = "Login";
            Text = "Form1";
            Load += Login_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox2).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox3).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox4).EndInit();
            Pa_user.ResumeLayout(false);
            Pa_user.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox pictureBox1;
        private PictureBox pictureBox2;
        private PictureBox pictureBox3;
        private PictureBox pictureBox4;
        private TextBox tb_contra;
        private Panel Pa_user;
        private TextBox Tb_User;
        private Button btnIniciar_sesion;
        private Button button1;
    }
}
