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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            this.LimpiarBoton = new System.Windows.Forms.Button();
            this.AtrasPrincipal = new System.Windows.Forms.Button();
            this.btGenerarPdf = new System.Windows.Forms.Button();
            this.CorreoEnviartex = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
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
            this.Guardar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Guardar.Location = new System.Drawing.Point(177, 292);
            this.Guardar.Name = "Guardar";
            this.Guardar.Size = new System.Drawing.Size(90, 40);
            this.Guardar.TabIndex = 6;
            this.Guardar.Text = "Guardar";
            this.Guardar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            this.refrescar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.refrescar.Image = ((System.Drawing.Image)(resources.GetObject("refrescar.Image")));
            this.refrescar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.refrescar.Location = new System.Drawing.Point(464, 241);
            this.refrescar.Name = "refrescar";
            this.refrescar.Size = new System.Drawing.Size(75, 42);
            this.refrescar.TabIndex = 9;
            this.refrescar.Text = "Refrescar";
            this.refrescar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
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
            // LimpiarBoton
            // 
            this.LimpiarBoton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LimpiarBoton.Location = new System.Drawing.Point(167, 366);
            this.LimpiarBoton.Name = "LimpiarBoton";
            this.LimpiarBoton.Size = new System.Drawing.Size(90, 46);
            this.LimpiarBoton.TabIndex = 13;
            this.LimpiarBoton.Text = "Limpiar";
            this.LimpiarBoton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.LimpiarBoton.UseVisualStyleBackColor = true;
            this.LimpiarBoton.Click += new System.EventHandler(this.LimpiarBoton_Click);
            // 
            // AtrasPrincipal
            // 
            this.AtrasPrincipal.Location = new System.Drawing.Point(636, 22);
            this.AtrasPrincipal.Name = "AtrasPrincipal";
            this.AtrasPrincipal.Size = new System.Drawing.Size(75, 23);
            this.AtrasPrincipal.TabIndex = 14;
            this.AtrasPrincipal.Text = "Atras";
            this.AtrasPrincipal.UseVisualStyleBackColor = true;
            this.AtrasPrincipal.Click += new System.EventHandler(this.AtrasPrincipal_Click);
            // 
            // btGenerarPdf
            // 
            this.btGenerarPdf.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btGenerarPdf.Location = new System.Drawing.Point(448, 366);
            this.btGenerarPdf.Name = "btGenerarPdf";
            this.btGenerarPdf.Size = new System.Drawing.Size(91, 46);
            this.btGenerarPdf.TabIndex = 15;
            this.btGenerarPdf.Text = "GenerarPdf";
            this.btGenerarPdf.UseVisualStyleBackColor = true;
            this.btGenerarPdf.Click += new System.EventHandler(this.btGenerarPdf_Click);
            // 
            // CorreoEnviartex
            // 
            this.CorreoEnviartex.Location = new System.Drawing.Point(509, 340);
            this.CorreoEnviartex.Name = "CorreoEnviartex";
            this.CorreoEnviartex.Size = new System.Drawing.Size(100, 20);
            this.CorreoEnviartex.TabIndex = 16;
            this.CorreoEnviartex.TextChanged += new System.EventHandler(this.CorreoEnviartex_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(421, 343);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 17;
            this.label2.Text = "Enviar a :";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(742, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.CorreoEnviartex);
            this.Controls.Add(this.btGenerarPdf);
            this.Controls.Add(this.AtrasPrincipal);
            this.Controls.Add(this.LimpiarBoton);
            this.Controls.Add(this.correotext);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Mostrar);
            this.Controls.Add(this.Guardar);
            this.Controls.Add(this.sexo);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.Nombre);
            this.Controls.Add(this.Sexotext);
            this.Controls.Add(this.Idtext);
            this.Controls.Add(this.Nombretext);
            this.Controls.Add(this.refrescar);
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
        private System.Windows.Forms.Button LimpiarBoton;
        private System.Windows.Forms.Button AtrasPrincipal;
        private System.Windows.Forms.Button btGenerarPdf;
        private System.Windows.Forms.TextBox CorreoEnviartex;
        private System.Windows.Forms.Label label2;
    }
}

