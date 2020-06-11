namespace PracticaBD
{
    partial class Principal
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
            this.btModificar = new System.Windows.Forms.Button();
            this.Salir = new System.Windows.Forms.Button();
            this.btEliminar = new System.Windows.Forms.Button();
            this.btbuscar = new System.Windows.Forms.Button();
            this.btRegistrar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btModificar
            // 
            this.btModificar.Image = global::PracticaBD.Properties.Resources.application_edit;
            this.btModificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btModificar.Location = new System.Drawing.Point(332, 216);
            this.btModificar.Name = "btModificar";
            this.btModificar.Size = new System.Drawing.Size(75, 39);
            this.btModificar.TabIndex = 5;
            this.btModificar.Text = "Modificar";
            this.btModificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btModificar.UseVisualStyleBackColor = true;
            // 
            // Salir
            // 
            this.Salir.Image = global::PracticaBD.Properties.Resources.disconnect;
            this.Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Salir.Location = new System.Drawing.Point(332, 276);
            this.Salir.Name = "Salir";
            this.Salir.Size = new System.Drawing.Size(75, 38);
            this.Salir.TabIndex = 4;
            this.Salir.Text = "Salir";
            this.Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Salir.UseVisualStyleBackColor = true;
            this.Salir.Click += new System.EventHandler(this.Salir_Click);
            // 
            // btEliminar
            // 
            this.btEliminar.Image = global::PracticaBD.Properties.Resources.application_delete;
            this.btEliminar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEliminar.Location = new System.Drawing.Point(332, 158);
            this.btEliminar.Name = "btEliminar";
            this.btEliminar.Size = new System.Drawing.Size(75, 37);
            this.btEliminar.TabIndex = 2;
            this.btEliminar.Text = "Eliminar";
            this.btEliminar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEliminar.UseVisualStyleBackColor = true;
            this.btEliminar.Click += new System.EventHandler(this.btEliminar_Click);
            // 
            // btbuscar
            // 
            this.btbuscar.Image = global::PracticaBD.Properties.Resources.application_form_magnify;
            this.btbuscar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btbuscar.Location = new System.Drawing.Point(332, 101);
            this.btbuscar.Name = "btbuscar";
            this.btbuscar.Size = new System.Drawing.Size(75, 36);
            this.btbuscar.TabIndex = 1;
            this.btbuscar.Text = "Buscar";
            this.btbuscar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btbuscar.UseVisualStyleBackColor = true;
            this.btbuscar.Click += new System.EventHandler(this.btbuscar_Click);
            // 
            // btRegistrar
            // 
            this.btRegistrar.Image = global::PracticaBD.Properties.Resources.add;
            this.btRegistrar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btRegistrar.Location = new System.Drawing.Point(332, 44);
            this.btRegistrar.Name = "btRegistrar";
            this.btRegistrar.Size = new System.Drawing.Size(75, 36);
            this.btRegistrar.TabIndex = 0;
            this.btRegistrar.Text = "Registrar";
            this.btRegistrar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btRegistrar.UseCompatibleTextRendering = true;
            this.btRegistrar.UseVisualStyleBackColor = true;
            this.btRegistrar.Click += new System.EventHandler(this.btRegistrar_Click);
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btModificar);
            this.Controls.Add(this.Salir);
            this.Controls.Add(this.btEliminar);
            this.Controls.Add(this.btbuscar);
            this.Controls.Add(this.btRegistrar);
            this.Name = "Principal";
            this.Text = "Principal";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btRegistrar;
        private System.Windows.Forms.Button btbuscar;
        private System.Windows.Forms.Button btEliminar;
        private System.Windows.Forms.Button Salir;
        private System.Windows.Forms.Button btModificar;
    }
}