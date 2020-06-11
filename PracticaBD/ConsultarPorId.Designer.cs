namespace PracticaBD
{
    partial class ConsultarPorId
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
            this.dtMostrar = new System.Windows.Forms.DataGridView();
            this.CIdentificacion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CNombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CSexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.CCorreo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Identitext = new System.Windows.Forms.Label();
            this.idregistradatext = new System.Windows.Forms.TextBox();
            this.Buscartext = new System.Windows.Forms.Button();
            this.VolverBoton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrar)).BeginInit();
            this.SuspendLayout();
            // 
            // dtMostrar
            // 
            this.dtMostrar.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtMostrar.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.CIdentificacion,
            this.CNombre,
            this.CSexo,
            this.CCorreo});
            this.dtMostrar.Location = new System.Drawing.Point(143, 32);
            this.dtMostrar.Name = "dtMostrar";
            this.dtMostrar.Size = new System.Drawing.Size(452, 169);
            this.dtMostrar.TabIndex = 0;
            this.dtMostrar.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // CIdentificacion
            // 
            this.CIdentificacion.HeaderText = "Identificacion";
            this.CIdentificacion.Name = "CIdentificacion";
            // 
            // CNombre
            // 
            this.CNombre.HeaderText = "Nombre";
            this.CNombre.Name = "CNombre";
            // 
            // CSexo
            // 
            this.CSexo.HeaderText = "Sexo";
            this.CSexo.Name = "CSexo";
            // 
            // CCorreo
            // 
            this.CCorreo.HeaderText = "Correo";
            this.CCorreo.Name = "CCorreo";
            // 
            // Identitext
            // 
            this.Identitext.AutoSize = true;
            this.Identitext.Location = new System.Drawing.Point(173, 255);
            this.Identitext.Name = "Identitext";
            this.Identitext.Size = new System.Drawing.Size(70, 13);
            this.Identitext.TabIndex = 1;
            this.Identitext.Text = "Identificacion";
            // 
            // idregistradatext
            // 
            this.idregistradatext.Location = new System.Drawing.Point(273, 252);
            this.idregistradatext.Name = "idregistradatext";
            this.idregistradatext.Size = new System.Drawing.Size(100, 20);
            this.idregistradatext.TabIndex = 2;
            this.idregistradatext.TextChanged += new System.EventHandler(this.idregistradatext_TextChanged);
            // 
            // Buscartext
            // 
            this.Buscartext.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscartext.Image = global::PracticaBD.Properties.Resources.application_form_magnify;
            this.Buscartext.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscartext.Location = new System.Drawing.Point(284, 306);
            this.Buscartext.Name = "Buscartext";
            this.Buscartext.Size = new System.Drawing.Size(75, 37);
            this.Buscartext.TabIndex = 3;
            this.Buscartext.Text = "Buscar";
            this.Buscartext.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscartext.UseVisualStyleBackColor = true;
            this.Buscartext.Click += new System.EventHandler(this.Buscartext_Click);
            // 
            // VolverBoton
            // 
            this.VolverBoton.Image = global::PracticaBD.Properties.Resources.application_side_contract;
            this.VolverBoton.Location = new System.Drawing.Point(696, 30);
            this.VolverBoton.Name = "VolverBoton";
            this.VolverBoton.Size = new System.Drawing.Size(75, 34);
            this.VolverBoton.TabIndex = 4;
            this.VolverBoton.TabStop = false;
            this.VolverBoton.UseVisualStyleBackColor = true;
            this.VolverBoton.Click += new System.EventHandler(this.VolverBoton_Click);
            // 
            // ConsultarPorId
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.VolverBoton);
            this.Controls.Add(this.Buscartext);
            this.Controls.Add(this.idregistradatext);
            this.Controls.Add(this.Identitext);
            this.Controls.Add(this.dtMostrar);
            this.Name = "ConsultarPorId";
            this.Text = "ConsultarPorId";
            ((System.ComponentModel.ISupportInitialize)(this.dtMostrar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dtMostrar;
        private System.Windows.Forms.Label Identitext;
        private System.Windows.Forms.TextBox idregistradatext;
        private System.Windows.Forms.Button Buscartext;
        private System.Windows.Forms.Button VolverBoton;
        private System.Windows.Forms.DataGridViewTextBoxColumn CIdentificacion;
        private System.Windows.Forms.DataGridViewTextBoxColumn CNombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn CSexo;
        private System.Windows.Forms.DataGridViewTextBoxColumn CCorreo;
    }
}