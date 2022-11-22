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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMenu));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnCatMat = new System.Windows.Forms.Button();
            this.btnMateriales = new System.Windows.Forms.Button();
            this.btnCatCal = new System.Windows.Forms.Button();
            this.btnLineaCal = new System.Windows.Forms.Button();
            this.btnCalzado = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Control;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(313, 65);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Control;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnCatMat);
            this.panel2.Controls.Add(this.btnMateriales);
            this.panel2.Controls.Add(this.btnCatCal);
            this.panel2.Controls.Add(this.btnLineaCal);
            this.panel2.Controls.Add(this.btnCalzado);
            this.panel2.Location = new System.Drawing.Point(23, 71);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(266, 364);
            this.panel2.TabIndex = 1;
            // 
            // btnCatMat
            // 
            this.btnCatMat.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCatMat.Location = new System.Drawing.Point(3, 289);
            this.btnCatMat.Name = "btnCatMat";
            this.btnCatMat.Size = new System.Drawing.Size(258, 65);
            this.btnCatMat.TabIndex = 9;
            this.btnCatMat.Text = "Categoria de Materiales";
            this.btnCatMat.UseVisualStyleBackColor = true;
            // 
            // btnMateriales
            // 
            this.btnMateriales.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnMateriales.Location = new System.Drawing.Point(3, 218);
            this.btnMateriales.Name = "btnMateriales";
            this.btnMateriales.Size = new System.Drawing.Size(258, 65);
            this.btnMateriales.TabIndex = 8;
            this.btnMateriales.Text = "Materiales";
            this.btnMateriales.UseVisualStyleBackColor = true;
            // 
            // btnCatCal
            // 
            this.btnCatCal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCatCal.Location = new System.Drawing.Point(3, 147);
            this.btnCatCal.Name = "btnCatCal";
            this.btnCatCal.Size = new System.Drawing.Size(258, 65);
            this.btnCatCal.TabIndex = 7;
            this.btnCatCal.Text = "Categoria de Calzado";
            this.btnCatCal.UseVisualStyleBackColor = true;
            // 
            // btnLineaCal
            // 
            this.btnLineaCal.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnLineaCal.Location = new System.Drawing.Point(3, 76);
            this.btnLineaCal.Name = "btnLineaCal";
            this.btnLineaCal.Size = new System.Drawing.Size(258, 65);
            this.btnLineaCal.TabIndex = 6;
            this.btnLineaCal.Text = "Linea de Calzado";
            this.btnLineaCal.UseVisualStyleBackColor = true;
            // 
            // btnCalzado
            // 
            this.btnCalzado.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.btnCalzado.Location = new System.Drawing.Point(3, 5);
            this.btnCalzado.Name = "btnCalzado";
            this.btnCalzado.Size = new System.Drawing.Size(258, 65);
            this.btnCalzado.TabIndex = 5;
            this.btnCalzado.Text = "Calzado";
            this.btnCalzado.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(288, 50);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // frmMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.ClientSize = new System.Drawing.Size(313, 439);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.MaximumSize = new System.Drawing.Size(329, 478);
            this.MinimumSize = new System.Drawing.Size(329, 478);
            this.Name = "frmMenu";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "MENU";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnCatMat;
        private System.Windows.Forms.Button btnMateriales;
        private System.Windows.Forms.Button btnCatCal;
        private System.Windows.Forms.Button btnLineaCal;
        private System.Windows.Forms.Button btnCalzado;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

