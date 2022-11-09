namespace WindowsFormsBaseDatosI
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
            this.dgvObreros = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.labelNombreTabla = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenesObrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.labelCargarObrero = new System.Windows.Forms.Label();
            this.textBoxDNI = new System.Windows.Forms.TextBox();
            this.textBoxNombre = new System.Windows.Forms.TextBox();
            this.buttonCargarObrero = new System.Windows.Forms.Button();
            this.labelNombre = new System.Windows.Forms.Label();
            this.labelDNI = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvObreros)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvObreros
            // 
            this.dgvObreros.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvObreros.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.DNI,
            this.Nombre});
            this.dgvObreros.Location = new System.Drawing.Point(12, 40);
            this.dgvObreros.Name = "dgvObreros";
            this.dgvObreros.Size = new System.Drawing.Size(534, 195);
            this.dgvObreros.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(361, 332);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Base Conectada?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BaseConectada_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(345, 292);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resumenes de Obras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResumenesObras_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(331, 251);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Resumen Proveedores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ProcedimientoAlmacenado_Click);
            // 
            // labelNombreTabla
            // 
            this.labelNombreTabla.AutoSize = true;
            this.labelNombreTabla.Location = new System.Drawing.Point(231, 24);
            this.labelNombreTabla.Name = "labelNombreTabla";
            this.labelNombreTabla.Size = new System.Drawing.Size(105, 13);
            this.labelNombreTabla.TabIndex = 4;
            this.labelNombreTabla.Text = "Tabla de los Obreros";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.verToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(558, 24);
            this.menuStrip1.TabIndex = 5;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // verToolStripMenuItem
            // 
            this.verToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.obrerosToolStripMenuItem,
            this.resumenesObrasToolStripMenuItem,
            this.resumenProveedoresToolStripMenuItem});
            this.verToolStripMenuItem.Name = "verToolStripMenuItem";
            this.verToolStripMenuItem.Size = new System.Drawing.Size(35, 20);
            this.verToolStripMenuItem.Text = "Ver";
            // 
            // obrerosToolStripMenuItem
            // 
            this.obrerosToolStripMenuItem.Name = "obrerosToolStripMenuItem";
            this.obrerosToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.obrerosToolStripMenuItem.Text = "Obreros";
            this.obrerosToolStripMenuItem.Click += new System.EventHandler(this.obrerosToolStripMenuItem_Click);
            // 
            // resumenesObrasToolStripMenuItem
            // 
            this.resumenesObrasToolStripMenuItem.Name = "resumenesObrasToolStripMenuItem";
            this.resumenesObrasToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.resumenesObrasToolStripMenuItem.Text = "Resumenes Obras";
            this.resumenesObrasToolStripMenuItem.Click += new System.EventHandler(this.resumenesObrasToolStripMenuItem_Click);
            // 
            // resumenProveedoresToolStripMenuItem
            // 
            this.resumenProveedoresToolStripMenuItem.Name = "resumenProveedoresToolStripMenuItem";
            this.resumenProveedoresToolStripMenuItem.Size = new System.Drawing.Size(191, 22);
            this.resumenProveedoresToolStripMenuItem.Text = "Resumen Proveedores";
            this.resumenProveedoresToolStripMenuItem.Click += new System.EventHandler(this.resumenProveedoresToolStripMenuItem_Click);
            // 
            // Codigo
            // 
            this.Codigo.DataPropertyName = "Codigo";
            this.Codigo.HeaderText = "Codigo";
            this.Codigo.Name = "Codigo";
            // 
            // DNI
            // 
            this.DNI.DataPropertyName = "Dni";
            this.DNI.HeaderText = "DNI";
            this.DNI.Name = "DNI";
            // 
            // Nombre
            // 
            this.Nombre.DataPropertyName = "Nombre";
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            // 
            // labelCargarObrero
            // 
            this.labelCargarObrero.AutoSize = true;
            this.labelCargarObrero.Location = new System.Drawing.Point(13, 257);
            this.labelCargarObrero.Name = "labelCargarObrero";
            this.labelCargarObrero.Size = new System.Drawing.Size(89, 13);
            this.labelCargarObrero.TabIndex = 6;
            this.labelCargarObrero.Text = "Cargue un obrero";
            // 
            // textBoxDNI
            // 
            this.textBoxDNI.Location = new System.Drawing.Point(12, 296);
            this.textBoxDNI.Name = "textBoxDNI";
            this.textBoxDNI.Size = new System.Drawing.Size(100, 20);
            this.textBoxDNI.TabIndex = 7;
            // 
            // textBoxNombre
            // 
            this.textBoxNombre.Location = new System.Drawing.Point(132, 296);
            this.textBoxNombre.Name = "textBoxNombre";
            this.textBoxNombre.Size = new System.Drawing.Size(100, 20);
            this.textBoxNombre.TabIndex = 8;
            // 
            // buttonCargarObrero
            // 
            this.buttonCargarObrero.Location = new System.Drawing.Point(84, 332);
            this.buttonCargarObrero.Name = "buttonCargarObrero";
            this.buttonCargarObrero.Size = new System.Drawing.Size(75, 23);
            this.buttonCargarObrero.TabIndex = 9;
            this.buttonCargarObrero.Text = "Confirmar";
            this.buttonCargarObrero.UseVisualStyleBackColor = true;
            this.buttonCargarObrero.Click += new System.EventHandler(this.buttonCargarObrero_Click);
            // 
            // labelNombre
            // 
            this.labelNombre.AutoSize = true;
            this.labelNombre.Location = new System.Drawing.Point(132, 280);
            this.labelNombre.Name = "labelNombre";
            this.labelNombre.Size = new System.Drawing.Size(44, 13);
            this.labelNombre.TabIndex = 10;
            this.labelNombre.Text = "Nombre";
            // 
            // labelDNI
            // 
            this.labelDNI.AutoSize = true;
            this.labelDNI.Location = new System.Drawing.Point(13, 280);
            this.labelDNI.Name = "labelDNI";
            this.labelDNI.Size = new System.Drawing.Size(26, 13);
            this.labelDNI.TabIndex = 11;
            this.labelDNI.Text = "DNI";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 377);
            this.Controls.Add(this.labelDNI);
            this.Controls.Add(this.labelNombre);
            this.Controls.Add(this.buttonCargarObrero);
            this.Controls.Add(this.textBoxNombre);
            this.Controls.Add(this.textBoxDNI);
            this.Controls.Add(this.labelCargarObrero);
            this.Controls.Add(this.labelNombreTabla);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.dgvObreros);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form_LoadTablaObreros);
            ((System.ComponentModel.ISupportInitialize)(this.dgvObreros)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvObreros;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label labelNombreTabla;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenesObrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenProveedoresToolStripMenuItem;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.Label labelCargarObrero;
        private System.Windows.Forms.TextBox textBoxDNI;
        private System.Windows.Forms.TextBox textBoxNombre;
        private System.Windows.Forms.Button buttonCargarObrero;
        private System.Windows.Forms.Label labelNombre;
        private System.Windows.Forms.Label labelDNI;
    }
}

