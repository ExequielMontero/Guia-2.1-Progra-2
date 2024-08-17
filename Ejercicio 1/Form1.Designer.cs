namespace Ejercicio_1
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
            this.lbListar = new System.Windows.Forms.ListBox();
            this.lbRegistro = new System.Windows.Forms.ListBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.btnListar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbListar
            // 
            this.lbListar.FormattingEnabled = true;
            this.lbListar.ItemHeight = 16;
            this.lbListar.Location = new System.Drawing.Point(18, 212);
            this.lbListar.Margin = new System.Windows.Forms.Padding(4);
            this.lbListar.Name = "lbListar";
            this.lbListar.Size = new System.Drawing.Size(595, 196);
            this.lbListar.TabIndex = 1;
            // 
            // lbRegistro
            // 
            this.lbRegistro.FormattingEnabled = true;
            this.lbRegistro.ItemHeight = 16;
            this.lbRegistro.Location = new System.Drawing.Point(18, 30);
            this.lbRegistro.Margin = new System.Windows.Forms.Padding(4);
            this.lbRegistro.Name = "lbRegistro";
            this.lbRegistro.Size = new System.Drawing.Size(595, 116);
            this.lbRegistro.TabIndex = 2;
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(670, 58);
            this.btnRegistrar.Margin = new System.Windows.Forms.Padding(4);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(174, 63);
            this.btnRegistrar.TabIndex = 3;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // btnListar
            // 
            this.btnListar.Location = new System.Drawing.Point(670, 274);
            this.btnListar.Margin = new System.Windows.Forms.Padding(4);
            this.btnListar.Name = "btnListar";
            this.btnListar.Size = new System.Drawing.Size(174, 63);
            this.btnListar.TabIndex = 4;
            this.btnListar.Text = "Listar";
            this.btnListar.UseVisualStyleBackColor = true;
            this.btnListar.Click += new System.EventHandler(this.btnListar_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(867, 425);
            this.Controls.Add(this.btnListar);
            this.Controls.Add(this.btnRegistrar);
            this.Controls.Add(this.lbRegistro);
            this.Controls.Add(this.lbListar);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Registro Automotor";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbListar;
        private System.Windows.Forms.ListBox lbRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.Button btnListar;
    }
}

