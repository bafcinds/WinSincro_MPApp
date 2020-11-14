namespace WinSincro_MPApp.Formas
{
    partial class MDI
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MDI));
            this.MenuStrip_MDI = new System.Windows.Forms.MenuStrip();
            this.catalogosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menusToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.modificadoresToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.opcionesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.categoriasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.segmentosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.marcasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.Cbo_Empresas = new System.Windows.Forms.ComboBox();
            this.Btn_CambiaE = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.pedidosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.sistemasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.TTVentanas = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuStrip_MDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // MenuStrip_MDI
            // 
            this.MenuStrip_MDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.catalogosToolStripMenuItem,
            this.pedidosToolStripMenuItem,
            this.sistemasToolStripMenuItem,
            this.TTVentanas});
            this.MenuStrip_MDI.Location = new System.Drawing.Point(0, 0);
            this.MenuStrip_MDI.MdiWindowListItem = this.TTVentanas;
            this.MenuStrip_MDI.Name = "MenuStrip_MDI";
            this.MenuStrip_MDI.Size = new System.Drawing.Size(820, 24);
            this.MenuStrip_MDI.TabIndex = 1;
            this.MenuStrip_MDI.Text = "menuStrip1";
            // 
            // catalogosToolStripMenuItem
            // 
            this.catalogosToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.segmentosToolStripMenuItem,
            this.marcasToolStripMenuItem,
            this.categoriasToolStripMenuItem,
            this.menusToolStripMenuItem,
            this.modificadoresToolStripMenuItem,
            this.opcionesToolStripMenuItem});
            this.catalogosToolStripMenuItem.Name = "catalogosToolStripMenuItem";
            this.catalogosToolStripMenuItem.Size = new System.Drawing.Size(72, 20);
            this.catalogosToolStripMenuItem.Text = "Catalogos";
            // 
            // menusToolStripMenuItem
            // 
            this.menusToolStripMenuItem.Name = "menusToolStripMenuItem";
            this.menusToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.menusToolStripMenuItem.Text = "Menus";
            this.menusToolStripMenuItem.Click += new System.EventHandler(this.menusToolStripMenuItem_Click);
            // 
            // modificadoresToolStripMenuItem
            // 
            this.modificadoresToolStripMenuItem.Name = "modificadoresToolStripMenuItem";
            this.modificadoresToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.modificadoresToolStripMenuItem.Text = "Modificadores";
            // 
            // opcionesToolStripMenuItem
            // 
            this.opcionesToolStripMenuItem.Name = "opcionesToolStripMenuItem";
            this.opcionesToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.opcionesToolStripMenuItem.Text = "Opciones";
            // 
            // categoriasToolStripMenuItem
            // 
            this.categoriasToolStripMenuItem.Name = "categoriasToolStripMenuItem";
            this.categoriasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.categoriasToolStripMenuItem.Text = "Categorias";
            this.categoriasToolStripMenuItem.Click += new System.EventHandler(this.categoriasToolStripMenuItem_Click);
            // 
            // segmentosToolStripMenuItem
            // 
            this.segmentosToolStripMenuItem.Name = "segmentosToolStripMenuItem";
            this.segmentosToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.segmentosToolStripMenuItem.Text = "Segmentos";
            // 
            // marcasToolStripMenuItem
            // 
            this.marcasToolStripMenuItem.Name = "marcasToolStripMenuItem";
            this.marcasToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.marcasToolStripMenuItem.Text = "Marcas";
            this.marcasToolStripMenuItem.Click += new System.EventHandler(this.marcasToolStripMenuItem_Click);
            // 
            // Cbo_Empresas
            // 
            this.Cbo_Empresas.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Cbo_Empresas.FormattingEnabled = true;
            this.Cbo_Empresas.Location = new System.Drawing.Point(660, 2);
            this.Cbo_Empresas.Name = "Cbo_Empresas";
            this.Cbo_Empresas.Size = new System.Drawing.Size(157, 21);
            this.Cbo_Empresas.TabIndex = 2;
            this.Cbo_Empresas.SelectedIndexChanged += new System.EventHandler(this.Cbo_Empresas_SelectedIndexChanged);
            // 
            // Btn_CambiaE
            // 
            this.Btn_CambiaE.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Btn_CambiaE.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_CambiaE.ImageIndex = 0;
            this.Btn_CambiaE.ImageList = this.imageList1;
            this.Btn_CambiaE.Location = new System.Drawing.Point(630, 2);
            this.Btn_CambiaE.Name = "Btn_CambiaE";
            this.Btn_CambiaE.Size = new System.Drawing.Size(28, 21);
            this.Btn_CambiaE.TabIndex = 3;
            this.Btn_CambiaE.UseVisualStyleBackColor = true;
            this.Btn_CambiaE.Click += new System.EventHandler(this.Btn_CambiaE_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "if_42_62699.png");
            // 
            // pedidosToolStripMenuItem
            // 
            this.pedidosToolStripMenuItem.Name = "pedidosToolStripMenuItem";
            this.pedidosToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.pedidosToolStripMenuItem.Text = "Pedidos";
            // 
            // sistemasToolStripMenuItem
            // 
            this.sistemasToolStripMenuItem.Name = "sistemasToolStripMenuItem";
            this.sistemasToolStripMenuItem.Size = new System.Drawing.Size(65, 20);
            this.sistemasToolStripMenuItem.Text = "Sistemas";
            // 
            // TTVentanas
            // 
            this.TTVentanas.Name = "TTVentanas";
            this.TTVentanas.Size = new System.Drawing.Size(66, 20);
            this.TTVentanas.Text = "Ventanas";
            // 
            // MDI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(820, 363);
            this.Controls.Add(this.Btn_CambiaE);
            this.Controls.Add(this.Cbo_Empresas);
            this.Controls.Add(this.MenuStrip_MDI);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.MenuStrip_MDI;
            this.Name = "MDI";
            this.Text = "MDI";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MDI_Load);
            this.MenuStrip_MDI.ResumeLayout(false);
            this.MenuStrip_MDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip MenuStrip_MDI;
        private System.Windows.Forms.ToolStripMenuItem catalogosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menusToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem modificadoresToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem opcionesToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem segmentosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem marcasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem categoriasToolStripMenuItem;
        private System.Windows.Forms.ComboBox Cbo_Empresas;
        private System.Windows.Forms.Button Btn_CambiaE;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.ToolStripMenuItem pedidosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem sistemasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem TTVentanas;
    }
}