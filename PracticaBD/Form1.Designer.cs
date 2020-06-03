namespace PracticaBD
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
            this.Nombretext = new System.Windows.Forms.TextBox();
            this.Idtext = new System.Windows.Forms.TextBox();
            this.Sexotext = new System.Windows.Forms.TextBox();
            this.Nombre = new System.Windows.Forms.Label();
            this.Identificacion = new System.Windows.Forms.Label();
            this.sexo = new System.Windows.Forms.Label();
            this.Guardar = new System.Windows.Forms.Button();
            this.Mostrar = new System.Windows.Forms.DataGridView();
            this.refrescar = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.correotext = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // Nombretext
            // 
            this.Nombretext.Location = new System.Drawing.Point(177, 87);
            this.Nombretext.Name = "Nombretext";
            this.Nombretext.Size = new System.Drawing.Size(100, 20);
            this.Nombretext.TabIndex = 0;
            this.Nombretext.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Idtext
            // 
            this.Idtext.Location = new System.Drawing.Point(177, 137);
            this.Idtext.Name = "Idtext";
            this.Idtext.Size = new System.Drawing.Size(100, 20);
            this.Idtext.TabIndex = 1;
            // 
            // Sexotext
            // 
            this.Sexotext.Location = new System.Drawing.Point(177, 183);
            this.Sexotext.Name = "Sexotext";
            this.Sexotext.Size = new System.Drawing.Size(100, 20);
            this.Sexotext.TabIndex = 2;
            // 
            // Nombre
            // 
            this.Nombre.AutoSize = true;
            this.Nombre.Location = new System.Drawing.Point(76, 87);
            this.Nombre.Name = "Nombre";
            this.Nombre.Size = new System.Drawing.Size(44, 13);
            this.Nombre.TabIndex = 3;
            this.Nombre.Text = "Nombre";
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Location = new System.Drawing.Point(76, 140);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(70, 13);
            this.Identificacion.TabIndex = 4;
            this.Identificacion.Text = "Identificacion";
            // 
            // sexo
            // 
            this.sexo.AutoSize = true;
            this.sexo.Location = new System.Drawing.Point(89, 190);
            this.sexo.Name = "sexo";
            this.sexo.Size = new System.Drawing.Size(31, 13);
            this.sexo.TabIndex = 5;
            this.sexo.Text = "Sexo";
            // 
            // Guardar
            // 
            this.Guardar.Location = new System.Drawing.Point(177, 302);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(65, 23);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.UseVisualStyleBackColor = true;
            this.Guardar.Click += new System.EventHandler(this.Guardar_Click);
            // 
            // Mostrar
            // 
            this.Mostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Mostrar.Location = new System.Drawing.Point(294, 69);
            this.Mostrar.Name = "Mostrar";
            this.Mostrar.Size = new System.Drawing.Size(417, 150);
            this.Mostrar.TabIndex = 8;
            this.Mostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // refrescar
            // 
            this.refrescar.Location = new System.Drawing.Point(456, 239);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 23);
            this.refrescar.TabIndex = 9;
            this.refrescar.Text = "Refrescar";
            this.refrescar.UseVisualStyleBackColor = true;
            this.refrescar.Click += new System.EventHandler(this.refrescar_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(85, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 10;
            this.label1.Text = "Correo";
            // 
            // correotext
            // 
            this.correotext.Location = new System.Drawing.Point(177, 241);
            this.correotext.Name = "correotext";
            this.correotext.Size = new System.Drawing.Size(100, 20);
            this.correotext.TabIndex = 11;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.correotext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.refrescar);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Sexotext);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Nombretext);
            this.Name = "Form1";
            this.Text = "ConectarBD";
            ((System.ComponentModel.ISupportInitialize)(this.Mostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Nombretext;
        private System.Windows.Forms.TextBox Idtext;
        private System.Windows.Forms.TextBox Sexotext;
        private System.Windows.Forms.Label Nombre;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.Label sexo;
        private System.Windows.Forms.Button Guardar;
        private System.Windows.Forms.DataGridView Mostrar;
        private System.Windows.Forms.Button refrescar;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox correotext;
    }
}

