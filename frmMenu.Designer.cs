namespace PrototipoMOANSOT2
{
    partial class frmMenu
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnClientes = new System.Windows.Forms.Button();
            this.btnProducto = new System.Windows.Forms.Button();
            this.btnPersonal = new System.Windows.Forms.Button();
            this.btnPedido = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnClientes
            // 
            this.btnClientes.Location = new System.Drawing.Point(12, 131);
            this.btnClientes.Name = "btnClientes";
            this.btnClientes.Size = new System.Drawing.Size(174, 113);
            this.btnClientes.TabIndex = 0;
            this.btnClientes.Text = "Mantenedor Proveedor";
            this.btnClientes.UseVisualStyleBackColor = true;
            this.btnClientes.Click += new System.EventHandler(this.btnClientes_Click);
            // 
            // btnProducto
            // 
            this.btnProducto.Location = new System.Drawing.Point(12, 12);
            this.btnProducto.Name = "btnProducto";
            this.btnProducto.Size = new System.Drawing.Size(174, 113);
            this.btnProducto.TabIndex = 1;
            this.btnProducto.Text = "Mantenedor Producto";
            this.btnProducto.UseVisualStyleBackColor = true;
            this.btnProducto.Click += new System.EventHandler(this.btnProducto_Click);
            // 
            // btnPersonal
            // 
            this.btnPersonal.Location = new System.Drawing.Point(12, 250);
            this.btnPersonal.Name = "btnPersonal";
            this.btnPersonal.Size = new System.Drawing.Size(174, 113);
            this.btnPersonal.TabIndex = 2;
            this.btnPersonal.Text = "Mantenedor Personal";
            this.btnPersonal.UseVisualStyleBackColor = true;
            this.btnPersonal.Click += new System.EventHandler(this.btnPersonal_Click);
            // 
            // btnPedido
            // 
            this.btnPedido.Location = new System.Drawing.Point(506, 59);
            this.btnPedido.Name = "btnPedido";
            this.btnPedido.Size = new System.Drawing.Size(174, 113);
            this.btnPedido.TabIndex = 3;
            this.btnPedido.Text = "Mantenedor Pedido";
            this.btnPedido.UseVisualStyleBackColor = true;
            this.btnPedido.Click += new System.EventHandler(this.btnPedido_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(567, 369);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(113, 76);
            this.btnSalir.TabIndex = 4;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // btnMateriales
            // 
            this.btnMateriales.Location = new System.Drawing.Point(506, 178);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(174, 113);
            this.btnMateriales.TabIndex = 5;
            this.btnMateriales.Text = "Mantenedor Materiales";
            this.btnMateriales.UseVisualStyleBackColor = true;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 457);
            this.Controls.Add(this.btnMateriales);
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnPedido);
            this.Controls.Add(this.btnPersonal);
            this.Controls.Add(this.btnProducto);
            this.Controls.Add(this.btnClientes);
            this.Name = "frmMenu";
            this.Text = "MENU";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnClientes;
        private System.Windows.Forms.Button btnProducto;
        private System.Windows.Forms.Button btnPersonal;
        private System.Windows.Forms.Button btnPedido;
        private System.Windows.Forms.Button btnSalir;
        private System.Windows.Forms.Button btnMateriales;
    }
}

