namespace Sistema_Horus.Forms.administrador
{
    partial class ProductosR
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
            txtNameProducto = new TextBox();
            txtTipo = new TextBox();
            txtUnidad = new TextBox();
            txtPase = new TextBox();
            TxtMayoreo = new TextBox();
            txtCantidad = new TextBox();
            txtModeloTelefono = new TextBox();
            label1 = new Label();
            label4 = new Label();
            label2 = new Label();
            label3 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            btnAddProductos = new Button();
            SuspendLayout();
            // 
            // txtNameProducto
            // 
            txtNameProducto.Location = new Point(165, 66);
            txtNameProducto.Name = "txtNameProducto";
            txtNameProducto.Size = new Size(100, 23);
            txtNameProducto.TabIndex = 0;
            // 
            // txtTipo
            // 
            txtTipo.Location = new Point(631, 66);
            txtTipo.Name = "txtTipo";
            txtTipo.Size = new Size(100, 23);
            txtTipo.TabIndex = 2;
            // 
            // txtUnidad
            // 
            txtUnidad.Location = new Point(420, 214);
            txtUnidad.Name = "txtUnidad";
            txtUnidad.Size = new Size(100, 23);
            txtUnidad.TabIndex = 3;
            // 
            // txtPase
            // 
            txtPase.Location = new Point(420, 138);
            txtPase.Name = "txtPase";
            txtPase.Size = new Size(100, 23);
            txtPase.TabIndex = 4;
            // 
            // TxtMayoreo
            // 
            TxtMayoreo.Location = new Point(420, 66);
            TxtMayoreo.Name = "TxtMayoreo";
            TxtMayoreo.Size = new Size(100, 23);
            TxtMayoreo.TabIndex = 5;
            // 
            // txtCantidad
            // 
            txtCantidad.Location = new Point(165, 214);
            txtCantidad.Name = "txtCantidad";
            txtCantidad.Size = new Size(100, 23);
            txtCantidad.TabIndex = 6;
            // 
            // txtModeloTelefono
            // 
            txtModeloTelefono.Location = new Point(165, 138);
            txtModeloTelefono.Name = "txtModeloTelefono";
            txtModeloTelefono.Size = new Size(100, 23);
            txtModeloTelefono.TabIndex = 7;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(14, 71);
            label1.Name = "label1";
            label1.Size = new Size(145, 18);
            label1.TabIndex = 8;
            label1.Text = "Nombre del producto";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.Location = new Point(27, 143);
            label4.Name = "label4";
            label4.Size = new Size(132, 18);
            label4.TabIndex = 11;
            label4.Text = "Modelo de telefono";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(95, 219);
            label2.Name = "label2";
            label2.Size = new Size(64, 18);
            label2.TabIndex = 12;
            label2.Text = "Cantidad";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(297, 71);
            label3.Name = "label3";
            label3.Size = new Size(108, 18);
            label3.TabIndex = 13;
            label3.Text = "Precio Mayoreo";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label5.Location = new Point(323, 143);
            label5.Name = "label5";
            label5.Size = new Size(82, 18);
            label5.TabIndex = 14;
            label5.Text = "Precio Pase";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label6.Location = new Point(310, 219);
            label6.Name = "label6";
            label6.Size = new Size(95, 18);
            label6.TabIndex = 15;
            label6.Text = "Precio Unidad";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Tahoma", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label7.Location = new Point(579, 71);
            label7.Name = "label7";
            label7.Size = new Size(36, 18);
            label7.TabIndex = 16;
            label7.Text = "Tipo";
            // 
            // btnAddProductos
            // 
            btnAddProductos.Location = new Point(323, 292);
            btnAddProductos.Name = "btnAddProductos";
            btnAddProductos.Size = new Size(105, 49);
            btnAddProductos.TabIndex = 17;
            btnAddProductos.Text = "Agregar";
            btnAddProductos.UseVisualStyleBackColor = true;
            btnAddProductos.Click += btnAddProductos_Click;
            // 
            // ProductosR
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(800, 450);
            Controls.Add(btnAddProductos);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(label1);
            Controls.Add(txtModeloTelefono);
            Controls.Add(txtCantidad);
            Controls.Add(TxtMayoreo);
            Controls.Add(txtPase);
            Controls.Add(txtUnidad);
            Controls.Add(txtTipo);
            Controls.Add(txtNameProducto);
            Name = "ProductosR";
            Text = "ProductosR";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtNameProducto;
        private TextBox txtTipo;
        private TextBox txtUnidad;
        private TextBox txtPase;
        private TextBox TxtMayoreo;
        private TextBox txtCantidad;
        private TextBox txtModeloTelefono;
        private Label label1;
        private Label label4;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private Label label7;
        private Button btnAddProductos;
    }
}