namespace WindowsFormsBaseDatosI
{
    partial class EliminarObrero
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
            this.botonConfirmarEliminar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // botonConfirmarEliminar
            // 
            this.botonConfirmarEliminar.Location = new System.Drawing.Point(116, 120);
            this.botonConfirmarEliminar.Name = "botonConfirmarEliminar";
            this.botonConfirmarEliminar.Size = new System.Drawing.Size(75, 23);
            this.botonConfirmarEliminar.TabIndex = 0;
            this.botonConfirmarEliminar.Text = "Confirmar";
            this.botonConfirmarEliminar.UseVisualStyleBackColor = true;
            // 
            // EliminarObrero
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(296, 155);
            this.Controls.Add(this.botonConfirmarEliminar);
            this.Name = "EliminarObrero";
            this.Text = "EliminarObrero";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button botonConfirmarEliminar;
    }
}