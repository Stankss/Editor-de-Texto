namespace Editor_de_Texto
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
            this.Abrir_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Guardar_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Cerrar_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.edicionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Atras_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Adelante_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Copiar_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Cortar_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.Pegar_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.SeleccionarTodo_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.EliminarTodo_btn = new System.Windows.Forms.ToolStripMenuItem();
            this.formatoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.btn_Cortar = new System.Windows.Forms.ToolStripButton();
            this.btn_Copiar = new System.Windows.Forms.ToolStripButton();
            this.btn_Pegar = new System.Windows.Forms.ToolStripButton();
            this.ComboBox1 = new System.Windows.Forms.ToolStripComboBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.menuStrip1.SuspendLayout();
            this.toolStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.edicionToolStripMenuItem,
            this.formatoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(874, 33);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Abrir_btn,
            this.Guardar_btn,
            this.Cerrar_btn});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(88, 29);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // Abrir_btn
            // 
            this.Abrir_btn.Name = "Abrir_btn";
            this.Abrir_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
            this.Abrir_btn.Size = new System.Drawing.Size(240, 34);
            this.Abrir_btn.Text = "Abrir";
            this.Abrir_btn.Click += new System.EventHandler(this.Abrir_btn_Click);
            // 
            // Guardar_btn
            // 
            this.Guardar_btn.Name = "Guardar_btn";
            this.Guardar_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
            this.Guardar_btn.Size = new System.Drawing.Size(240, 34);
            this.Guardar_btn.Text = "Guardar";
            this.Guardar_btn.Click += new System.EventHandler(this.Guardar_btn_Click);
            // 
            // Cerrar_btn
            // 
            this.Cerrar_btn.Name = "Cerrar_btn";
            this.Cerrar_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.Cerrar_btn.Size = new System.Drawing.Size(240, 34);
            this.Cerrar_btn.Text = "Cerrar";
            this.Cerrar_btn.Click += new System.EventHandler(this.Cerrar_btn_Click);
            // 
            // edicionToolStripMenuItem
            // 
            this.edicionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Atras_btn,
            this.Adelante_btn,
            this.toolStripSeparator1,
            this.Copiar_btn,
            this.Cortar_btn,
            this.Pegar_btn,
            this.toolStripSeparator2,
            this.SeleccionarTodo_btn,
            this.EliminarTodo_btn});
            this.edicionToolStripMenuItem.Name = "edicionToolStripMenuItem";
            this.edicionToolStripMenuItem.Size = new System.Drawing.Size(85, 29);
            this.edicionToolStripMenuItem.Text = "Edicion";
            // 
            // Atras_btn
            // 
            this.Atras_btn.Name = "Atras_btn";
            this.Atras_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
            this.Atras_btn.Size = new System.Drawing.Size(317, 34);
            this.Atras_btn.Text = "Atras";
            this.Atras_btn.Click += new System.EventHandler(this.Atras_btn_Click);
            // 
            // Adelante_btn
            // 
            this.Adelante_btn.Name = "Adelante_btn";
            this.Adelante_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
            this.Adelante_btn.Size = new System.Drawing.Size(317, 34);
            this.Adelante_btn.Text = "Adelante";
            this.Adelante_btn.Click += new System.EventHandler(this.Adelante_btn_Click);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(314, 6);
            // 
            // Copiar_btn
            // 
            this.Copiar_btn.Name = "Copiar_btn";
            this.Copiar_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.C)));
            this.Copiar_btn.Size = new System.Drawing.Size(317, 34);
            this.Copiar_btn.Text = "Copiar";
            this.Copiar_btn.Click += new System.EventHandler(this.Copiar_btn_Click);
            // 
            // Cortar_btn
            // 
            this.Cortar_btn.Name = "Cortar_btn";
            this.Cortar_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.X)));
            this.Cortar_btn.Size = new System.Drawing.Size(317, 34);
            this.Cortar_btn.Text = "Cortar";
            this.Cortar_btn.Click += new System.EventHandler(this.Cortar_btn_Click);
            // 
            // Pegar_btn
            // 
            this.Pegar_btn.Name = "Pegar_btn";
            this.Pegar_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.V)));
            this.Pegar_btn.Size = new System.Drawing.Size(317, 34);
            this.Pegar_btn.Text = "Pegar";
            this.Pegar_btn.Click += new System.EventHandler(this.Pegar_btn_Click);
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(314, 6);
            // 
            // SeleccionarTodo_btn
            // 
            this.SeleccionarTodo_btn.Name = "SeleccionarTodo_btn";
            this.SeleccionarTodo_btn.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
            this.SeleccionarTodo_btn.Size = new System.Drawing.Size(317, 34);
            this.SeleccionarTodo_btn.Text = "Seleccionar Todo";
            this.SeleccionarTodo_btn.Click += new System.EventHandler(this.SeleccionarTodo_btn_Click);
            // 
            // EliminarTodo_btn
            // 
            this.EliminarTodo_btn.Name = "EliminarTodo_btn";
            this.EliminarTodo_btn.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Alt) 
            | System.Windows.Forms.Keys.X)));
            this.EliminarTodo_btn.Size = new System.Drawing.Size(317, 34);
            this.EliminarTodo_btn.Text = "Eliminar Todo";
            this.EliminarTodo_btn.Click += new System.EventHandler(this.EliminarTodo_btn_Click);
            // 
            // formatoToolStripMenuItem
            // 
            this.formatoToolStripMenuItem.Name = "formatoToolStripMenuItem";
            this.formatoToolStripMenuItem.Size = new System.Drawing.Size(96, 29);
            this.formatoToolStripMenuItem.Text = "Formato";
            this.formatoToolStripMenuItem.Click += new System.EventHandler(this.formatoToolStripMenuItem_Click);
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.toolStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btn_Cortar,
            this.btn_Copiar,
            this.btn_Pegar,
            this.ComboBox1});
            this.toolStrip1.Location = new System.Drawing.Point(0, 33);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(874, 33);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // btn_Cortar
            // 
            this.btn_Cortar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Cortar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Cortar.Image")));
            this.btn_Cortar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Cortar.Name = "btn_Cortar";
            this.btn_Cortar.Size = new System.Drawing.Size(34, 28);
            this.btn_Cortar.Text = "Cortar";
            this.btn_Cortar.Click += new System.EventHandler(this.Cortar_btn_Click);
            // 
            // btn_Copiar
            // 
            this.btn_Copiar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Copiar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Copiar.Image")));
            this.btn_Copiar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Copiar.Name = "btn_Copiar";
            this.btn_Copiar.Size = new System.Drawing.Size(34, 28);
            this.btn_Copiar.Text = "Copiar";
            this.btn_Copiar.Click += new System.EventHandler(this.Copiar_btn_Click);
            // 
            // btn_Pegar
            // 
            this.btn_Pegar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.btn_Pegar.Image = ((System.Drawing.Image)(resources.GetObject("btn_Pegar.Image")));
            this.btn_Pegar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.btn_Pegar.Name = "btn_Pegar";
            this.btn_Pegar.Size = new System.Drawing.Size(34, 28);
            this.btn_Pegar.Text = "Pegar";
            this.btn_Pegar.Click += new System.EventHandler(this.Pegar_btn_Click);
            // 
            // ComboBox1
            // 
            this.ComboBox1.Items.AddRange(new object[] {
            "10",
            "12",
            "14",
            "18",
            "20",
            "24",
            "28",
            "36",
            "42"});
            this.ComboBox1.Name = "ComboBox1";
            this.ComboBox1.Size = new System.Drawing.Size(121, 33);
            this.ComboBox1.SelectedIndexChanged += new System.EventHandler(this.Seleccionar_Tamaño);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 66);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(874, 486);
            this.richTextBox1.TabIndex = 2;
            this.richTextBox1.Text = "";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 552);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Editor de texto";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.toolStrip1.ResumeLayout(false);
            this.toolStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Abrir_btn;
        private System.Windows.Forms.ToolStripMenuItem Guardar_btn;
        private System.Windows.Forms.ToolStripMenuItem Cerrar_btn;
        private System.Windows.Forms.ToolStripMenuItem edicionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem Atras_btn;
        private System.Windows.Forms.ToolStripMenuItem Adelante_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem Copiar_btn;
        private System.Windows.Forms.ToolStripMenuItem Cortar_btn;
        private System.Windows.Forms.ToolStripMenuItem Pegar_btn;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripMenuItem SeleccionarTodo_btn;
        private System.Windows.Forms.ToolStripMenuItem EliminarTodo_btn;
        private System.Windows.Forms.ToolStripMenuItem formatoToolStripMenuItem;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.ToolStripButton btn_Cortar;
        private System.Windows.Forms.ToolStripButton btn_Copiar;
        private System.Windows.Forms.ToolStripButton btn_Pegar;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.ToolStripComboBox ComboBox1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
    }
}

