namespace practicaTema3
{
    partial class Form1
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
            this.lblMensaje1 = new System.Windows.Forms.Label();
            this.btnUsuario1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblMensaje1
            // 
            this.lblMensaje1.AutoSize = true;
            this.lblMensaje1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMensaje1.Location = new System.Drawing.Point(80, 64);
            this.lblMensaje1.Name = "lblMensaje1";
            this.lblMensaje1.Size = new System.Drawing.Size(419, 37);
            this.lblMensaje1.TabIndex = 0;
            this.lblMensaje1.Text = "Sigo haciendo mas commits";
            // 
            // btnUsuario1
            // 
            this.btnUsuario1.BackColor = System.Drawing.Color.Bisque;
            this.btnUsuario1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUsuario1.Location = new System.Drawing.Point(87, 124);
            this.btnUsuario1.Name = "btnUsuario1";
            this.btnUsuario1.Size = new System.Drawing.Size(162, 40);
            this.btnUsuario1.TabIndex = 1;
            this.btnUsuario1.Text = "Usuario1";
            this.btnUsuario1.UseVisualStyleBackColor = false;
            this.btnUsuario1.Click += new System.EventHandler(this.btnUsuario1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightGray;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnUsuario1);
            this.Controls.Add(this.lblMensaje1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblMensaje1;
        private System.Windows.Forms.Button btnUsuario1;
    }
}

