namespace PracticaBD
{
    partial class Eliminarpersona
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
            this.txEliminar = new System.Windows.Forms.TextBox();
            this.Identificacion = new System.Windows.Forms.Label();
            this.AtrasEliminar = new System.Windows.Forms.Button();
            this.btEliminarAction = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txEliminar
            // 
            this.txEliminar.Location = new System.Drawing.Point(338, 189);
            this.txEliminar.Name = "txEliminar";
            this.txEliminar.Size = new System.Drawing.Size(100, 20);
            this.txEliminar.TabIndex = 1;
            this.txEliminar.TextChanged += new System.EventHandler(this.txEliminar_TextChanged);
            // 
            // Identificacion
            // 
            this.Identificacion.AutoSize = true;
            this.Identificacion.Location = new System.Drawing.Point(241, 192);
            this.Identificacion.Name = "Identificacion";
            this.Identificacion.Size = new System.Drawing.Size(70, 13);
            this.Identificacion.TabIndex = 2;
            this.Identificacion.Text = "Identificacion";
            // 
            // AtrasEliminar
            // 
            this.AtrasEliminar.Image = global::PracticaBD.Properties.Resources.application_side_contract;
            this.AtrasEliminar.Location = new System.Drawing.Point(691, 28);
            this.AtrasEliminar.Name = "AtrasEliminar";
            this.AtrasEliminar.Size = new System.Drawing.Size(75, 41);
            this.AtrasEliminar.TabIndex = 3;
            this.AtrasEliminar.UseVisualStyleBackColor = true;
            this.AtrasEliminar.Click += new System.EventHandler(this.AtrasEliminar_Click);
            // 
            // btEliminarAction
            // 
            this.btEliminarAction.Image = global::PracticaBD.Properties.Resources.delete;
            this.btEliminarAction.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btEliminarAction.Location = new System.Drawing.Point(326, 250);
            this.btEliminarAction.Name = "btEliminarAction";
            this.btEliminarAction.Size = new System.Drawing.Size(75, 49);
            this.btEliminarAction.TabIndex = 0;
            this.btEliminarAction.Text = "Eliminar";
            this.btEliminarAction.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btEliminarAction.UseVisualStyleBackColor = true;
            this.btEliminarAction.Click += new System.EventHandler(this.btEliminarAction_Click);
            // 
            // Eliminarpersona
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.AtrasEliminar);
            this.Controls.Add(this.Identificacion);
            this.Controls.Add(this.txEliminar);
            this.Controls.Add(this.btEliminarAction);
            this.Name = "Eliminarpersona";
            this.Text = "Eliminarpersona";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btEliminarAction;
        private System.Windows.Forms.TextBox txEliminar;
        private System.Windows.Forms.Label Identificacion;
        private System.Windows.Forms.Button AtrasEliminar;
    }
}