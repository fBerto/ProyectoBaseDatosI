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
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DNI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Eliminar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.verToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.obrerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenesObrasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resumenProveedoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
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
            this.Nombre,
            this.Eliminar});
            this.dgvObreros.Location = new System.Drawing.Point(12, 49);
            this.dgvObreros.Name = "dgvObreros";
            this.dgvObreros.Size = new System.Drawing.Size(534, 195);
            this.dgvObreros.TabIndex = 0;
            this.dgvObreros.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvObreros_CellContentClick);
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
            // Eliminar
            // 
            this.Eliminar.HeaderText = "Eliminar";
            this.Eliminar.Name = "Eliminar";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 266);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Base Conectada?";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.BaseConectada_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(179, 265);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(134, 24);
            this.button2.TabIndex = 2;
            this.button2.Text = "Resumenes de Obras";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ResumenesObras_Click);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(364, 265);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(161, 24);
            this.button3.TabIndex = 3;
            this.button3.Text = "Resumen Proveedores";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.ProcedimientoAlmacenado_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(208, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Tabla de los Obreros";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(558, 318);
            this.Controls.Add(this.label1);
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
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn DNI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewButtonColumn Eliminar;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem verToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem obrerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenesObrasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem resumenProveedoresToolStripMenuItem;
    }
}

