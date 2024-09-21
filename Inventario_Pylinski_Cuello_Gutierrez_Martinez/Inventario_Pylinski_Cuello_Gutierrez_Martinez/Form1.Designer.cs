namespace Inventario_Pylinski_Cuello_Gutierrez_Martinez
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.Sesion = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.sesionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.TXTname = new System.Windows.Forms.TextBox();
            this.TXTcontraseña = new System.Windows.Forms.TextBox();
            this.BTNiniciar = new System.Windows.Forms.Button();
            this.pcbRetroceder1 = new System.Windows.Forms.PictureBox();
            this.Sesion.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetroceder1)).BeginInit();
            this.SuspendLayout();
            // 
            // Sesion
            // 
            this.Sesion.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.Sesion.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.sesionToolStripMenuItem});
            this.Sesion.Name = "Sesion";
            this.Sesion.Size = new System.Drawing.Size(109, 26);
            this.Sesion.Text = "Sesion";
            // 
            // sesionToolStripMenuItem
            // 
            this.sesionToolStripMenuItem.Name = "sesionToolStripMenuItem";
            this.sesionToolStripMenuItem.Size = new System.Drawing.Size(108, 22);
            this.sesionToolStripMenuItem.Text = "Sesion";
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(18, 18);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // TXTname
            // 
            this.TXTname.Location = new System.Drawing.Point(218, 215);
            this.TXTname.Multiline = true;
            this.TXTname.Name = "TXTname";
            this.TXTname.Size = new System.Drawing.Size(215, 34);
            this.TXTname.TabIndex = 2;
            // 
            // TXTcontraseña
            // 
            this.TXTcontraseña.Location = new System.Drawing.Point(218, 255);
            this.TXTcontraseña.Multiline = true;
            this.TXTcontraseña.Name = "TXTcontraseña";
            this.TXTcontraseña.Size = new System.Drawing.Size(215, 38);
            this.TXTcontraseña.TabIndex = 3;
            // 
            // BTNiniciar
            // 
            this.BTNiniciar.BackColor = System.Drawing.Color.PowderBlue;
            this.BTNiniciar.FlatAppearance.BorderColor = System.Drawing.Color.LightBlue;
            this.BTNiniciar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BTNiniciar.ForeColor = System.Drawing.Color.Black;
            this.BTNiniciar.Location = new System.Drawing.Point(262, 369);
            this.BTNiniciar.Name = "BTNiniciar";
            this.BTNiniciar.Size = new System.Drawing.Size(75, 23);
            this.BTNiniciar.TabIndex = 4;
            this.BTNiniciar.Text = "Login";
            this.BTNiniciar.UseVisualStyleBackColor = false;
            this.BTNiniciar.Click += new System.EventHandler(this.BTNiniciar_Click);
            // 
            // pcbRetroceder1
            // 
            this.pcbRetroceder1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pcbRetroceder1.BackColor = System.Drawing.Color.Lavender;
            this.pcbRetroceder1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pcbRetroceder1.BackgroundImage")));
            this.pcbRetroceder1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pcbRetroceder1.Image = ((System.Drawing.Image)(resources.GetObject("pcbRetroceder1.Image")));
            this.pcbRetroceder1.Location = new System.Drawing.Point(12, 12);
            this.pcbRetroceder1.Name = "pcbRetroceder1";
            this.pcbRetroceder1.Size = new System.Drawing.Size(40, 40);
            this.pcbRetroceder1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pcbRetroceder1.TabIndex = 41;
            this.pcbRetroceder1.TabStop = false;
            this.pcbRetroceder1.Click += new System.EventHandler(this.pcbRetroceder1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Inventario_Pylinski_Cuello_Gutierrez_Martinez.Properties.Resources.login;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(608, 505);
            this.Controls.Add(this.pcbRetroceder1);
            this.Controls.Add(this.BTNiniciar);
            this.Controls.Add(this.TXTcontraseña);
            this.Controls.Add(this.TXTname);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Sesion.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pcbRetroceder1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ContextMenuStrip Sesion;
        private System.Windows.Forms.ToolStripMenuItem sesionToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox TXTname;
        private System.Windows.Forms.TextBox TXTcontraseña;
        private System.Windows.Forms.Button BTNiniciar;
        private System.Windows.Forms.PictureBox pcbRetroceder1;
    }
}

