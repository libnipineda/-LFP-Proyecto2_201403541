namespace _LFP_Proyecto2_201403541
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.abrirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.guardarComoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salirToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.documentoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarTraduccionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.generarReportesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaTokenToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaSímbolosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tablaTokenErroresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.limpiarDocumentosRecientesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ayudaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.acercaDeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.richTextBox3 = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.documentoToolStripMenuItem,
            this.ayudaToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1099, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.abrirToolStripMenuItem,
            this.guardarComoToolStripMenuItem,
            this.salirToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // abrirToolStripMenuItem
            // 
            this.abrirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            this.abrirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.abrirToolStripMenuItem.Text = "Abrir";
            this.abrirToolStripMenuItem.Click += new System.EventHandler(this.abrirToolStripMenuItem_Click);
            // 
            // guardarComoToolStripMenuItem
            // 
            this.guardarComoToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.guardarComoToolStripMenuItem.Name = "guardarComoToolStripMenuItem";
            this.guardarComoToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.guardarComoToolStripMenuItem.Text = "Guardar Como";
            this.guardarComoToolStripMenuItem.Click += new System.EventHandler(this.guardarComoToolStripMenuItem_Click);
            // 
            // salirToolStripMenuItem
            // 
            this.salirToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.salirToolStripMenuItem.Name = "salirToolStripMenuItem";
            this.salirToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salirToolStripMenuItem.Text = "Salir";
            this.salirToolStripMenuItem.Click += new System.EventHandler(this.salirToolStripMenuItem_Click);
            // 
            // documentoToolStripMenuItem
            // 
            this.documentoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.generarTraduccionToolStripMenuItem,
            this.generarReportesToolStripMenuItem,
            this.limpiarDocumentosRecientesToolStripMenuItem});
            this.documentoToolStripMenuItem.Name = "documentoToolStripMenuItem";
            this.documentoToolStripMenuItem.Size = new System.Drawing.Size(82, 20);
            this.documentoToolStripMenuItem.Text = "Documento";
            // 
            // generarTraduccionToolStripMenuItem
            // 
            this.generarTraduccionToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generarTraduccionToolStripMenuItem.Name = "generarTraduccionToolStripMenuItem";
            this.generarTraduccionToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.generarTraduccionToolStripMenuItem.Text = "Generar Traduccion";
            this.generarTraduccionToolStripMenuItem.Click += new System.EventHandler(this.generarTraduccionToolStripMenuItem_Click);
            // 
            // generarReportesToolStripMenuItem
            // 
            this.generarReportesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.generarReportesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.tablaTokenToolStripMenuItem,
            this.tablaSímbolosToolStripMenuItem,
            this.tablaTokenErroresToolStripMenuItem});
            this.generarReportesToolStripMenuItem.Name = "generarReportesToolStripMenuItem";
            this.generarReportesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.generarReportesToolStripMenuItem.Text = "Generar Reportes";
            // 
            // tablaTokenToolStripMenuItem
            // 
            this.tablaTokenToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaTokenToolStripMenuItem.Name = "tablaTokenToolStripMenuItem";
            this.tablaTokenToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tablaTokenToolStripMenuItem.Text = "Tabla Token";
            this.tablaTokenToolStripMenuItem.Click += new System.EventHandler(this.tablaTokenToolStripMenuItem_Click);
            // 
            // tablaSímbolosToolStripMenuItem
            // 
            this.tablaSímbolosToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaSímbolosToolStripMenuItem.Name = "tablaSímbolosToolStripMenuItem";
            this.tablaSímbolosToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tablaSímbolosToolStripMenuItem.Text = "Tabla símbolos";
            this.tablaSímbolosToolStripMenuItem.Click += new System.EventHandler(this.tablaSímbolosToolStripMenuItem_Click);
            // 
            // tablaTokenErroresToolStripMenuItem
            // 
            this.tablaTokenErroresToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.tablaTokenErroresToolStripMenuItem.Name = "tablaTokenErroresToolStripMenuItem";
            this.tablaTokenErroresToolStripMenuItem.Size = new System.Drawing.Size(174, 22);
            this.tablaTokenErroresToolStripMenuItem.Text = "Tabla Token Errores";
            this.tablaTokenErroresToolStripMenuItem.Click += new System.EventHandler(this.tablaTokenErroresToolStripMenuItem_Click);
            // 
            // limpiarDocumentosRecientesToolStripMenuItem
            // 
            this.limpiarDocumentosRecientesToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.limpiarDocumentosRecientesToolStripMenuItem.Name = "limpiarDocumentosRecientesToolStripMenuItem";
            this.limpiarDocumentosRecientesToolStripMenuItem.Size = new System.Drawing.Size(234, 22);
            this.limpiarDocumentosRecientesToolStripMenuItem.Text = "Limpiar documentos recientes";
            this.limpiarDocumentosRecientesToolStripMenuItem.Click += new System.EventHandler(this.limpiarDocumentosRecientesToolStripMenuItem_Click);
            // 
            // ayudaToolStripMenuItem
            // 
            this.ayudaToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.acercaDeToolStripMenuItem});
            this.ayudaToolStripMenuItem.Name = "ayudaToolStripMenuItem";
            this.ayudaToolStripMenuItem.Size = new System.Drawing.Size(53, 20);
            this.ayudaToolStripMenuItem.Text = "Ayuda";
            // 
            // acercaDeToolStripMenuItem
            // 
            this.acercaDeToolStripMenuItem.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.acercaDeToolStripMenuItem.Name = "acercaDeToolStripMenuItem";
            this.acercaDeToolStripMenuItem.Size = new System.Drawing.Size(132, 22);
            this.acercaDeToolStripMenuItem.Text = "Acerca de..";
            this.acercaDeToolStripMenuItem.Click += new System.EventHandler(this.acercaDeToolStripMenuItem_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(11, 54);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(529, 414);
            this.richTextBox1.TabIndex = 1;
            this.richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(559, 54);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(523, 414);
            this.richTextBox2.TabIndex = 2;
            this.richTextBox2.Text = "";
            // 
            // richTextBox3
            // 
            this.richTextBox3.BackColor = System.Drawing.SystemColors.MenuText;
            this.richTextBox3.ForeColor = System.Drawing.Color.LimeGreen;
            this.richTextBox3.Location = new System.Drawing.Point(11, 509);
            this.richTextBox3.Name = "richTextBox3";
            this.richTextBox3.Size = new System.Drawing.Size(1069, 197);
            this.richTextBox3.TabIndex = 3;
            this.richTextBox3.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(18, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "EDITOR DE TEXTO";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(567, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "TRADUCCION";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(17, 484);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "CONSOLA";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.MidnightBlue;
            this.ClientSize = new System.Drawing.Size(1099, 718);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBox3);
            this.Controls.Add(this.richTextBox2);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "[LFP]Proyecto 2";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem guardarComoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salirToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem documentoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarTraduccionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem generarReportesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaTokenToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaSímbolosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem tablaTokenErroresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem limpiarDocumentosRecientesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ayudaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem acercaDeToolStripMenuItem;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.RichTextBox richTextBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ToolStripMenuItem abrirToolStripMenuItem;
    }
}

