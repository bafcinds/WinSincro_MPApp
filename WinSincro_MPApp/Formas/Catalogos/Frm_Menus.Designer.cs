namespace WinSincro_MPApp.Formas.Catalogos
{
    partial class Frm_Menus
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
            FarPoint.Win.Spread.DefaultFocusIndicatorRenderer defaultFocusIndicatorRenderer1 = new FarPoint.Win.Spread.DefaultFocusIndicatorRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer1 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            FarPoint.Win.Spread.DefaultScrollBarRenderer defaultScrollBarRenderer2 = new FarPoint.Win.Spread.DefaultScrollBarRenderer();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Menus));
            this.Grp_Global = new DevExpress.XtraEditors.GroupControl();
            this.Grp_Datos = new DevExpress.XtraEditors.GroupControl();
            this.vsp_menus = new FarPoint.Win.Spread.FpSpread();
            this.vsp_menus_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.Grp_Opciones = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Reactivar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Desactivar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Global)).BeginInit();
            this.Grp_Global.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).BeginInit();
            this.Grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_menus)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_menus_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Opciones)).BeginInit();
            this.Grp_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Global
            // 
            this.Grp_Global.Controls.Add(this.Grp_Datos);
            this.Grp_Global.Controls.Add(this.Grp_Opciones);
            this.Grp_Global.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_Global.Location = new System.Drawing.Point(0, 0);
            this.Grp_Global.Name = "Grp_Global";
            this.Grp_Global.Size = new System.Drawing.Size(683, 485);
            this.Grp_Global.TabIndex = 0;
            this.Grp_Global.Text = "Listado de Menus";
            // 
            // Grp_Datos
            // 
            this.Grp_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_Datos.Controls.Add(this.vsp_menus);
            this.Grp_Datos.Location = new System.Drawing.Point(12, 130);
            this.Grp_Datos.Name = "Grp_Datos";
            this.Grp_Datos.Size = new System.Drawing.Size(650, 319);
            this.Grp_Datos.TabIndex = 3;
            this.Grp_Datos.Text = "Datos";
            // 
            // vsp_menus
            // 
            this.vsp_menus.AccessibleDescription = "";
            this.vsp_menus.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsp_menus.FocusRenderer = defaultFocusIndicatorRenderer1;
            this.vsp_menus.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.vsp_menus.HorizontalScrollBar.Name = "";
            this.vsp_menus.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.vsp_menus.HorizontalScrollBar.TabIndex = 2;
            this.vsp_menus.Location = new System.Drawing.Point(2, 20);
            this.vsp_menus.Name = "vsp_menus";
            this.vsp_menus.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.vsp_menus_Sheet1});
            this.vsp_menus.Size = new System.Drawing.Size(646, 297);
            this.vsp_menus.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.vsp_menus.TabIndex = 0;
            this.vsp_menus.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.vsp_menus.VerticalScrollBar.Name = "";
            this.vsp_menus.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.vsp_menus.VerticalScrollBar.TabIndex = 3;
            this.vsp_menus.VisualStyles = FarPoint.Win.VisualStyles.Off;
            // 
            // vsp_menus_Sheet1
            // 
            this.vsp_menus_Sheet1.Reset();
            this.vsp_menus_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.vsp_menus_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            this.vsp_menus_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_menus_Sheet1.ColumnFooter.DefaultStyle.Parent = "HeaderDefault";
            this.vsp_menus_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_menus_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerDefault";
            this.vsp_menus_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_menus_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.vsp_menus_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_menus_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.vsp_menus_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_menus_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.vsp_menus_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // Grp_Opciones
            // 
            this.Grp_Opciones.Controls.Add(this.Btn_Reactivar);
            this.Grp_Opciones.Controls.Add(this.Btn_Consultar);
            this.Grp_Opciones.Controls.Add(this.Btn_Nuevo);
            this.Grp_Opciones.Controls.Add(this.Btn_Desactivar);
            this.Grp_Opciones.Controls.Add(this.Btn_Salir);
            this.Grp_Opciones.Controls.Add(this.Btn_Modificar);
            this.Grp_Opciones.Location = new System.Drawing.Point(12, 23);
            this.Grp_Opciones.Name = "Grp_Opciones";
            this.Grp_Opciones.Size = new System.Drawing.Size(650, 91);
            this.Grp_Opciones.TabIndex = 2;
            this.Grp_Opciones.Text = "Opciones";
            // 
            // Btn_Reactivar
            // 
            this.Btn_Reactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Reactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Reactivar.ImageIndex = 0;
            this.Btn_Reactivar.ImageList = this.imageList1;
            this.Btn_Reactivar.Location = new System.Drawing.Point(288, 23);
            this.Btn_Reactivar.Name = "Btn_Reactivar";
            this.Btn_Reactivar.Size = new System.Drawing.Size(93, 59);
            this.Btn_Reactivar.TabIndex = 10;
            this.Btn_Reactivar.Tag = "118";
            this.Btn_Reactivar.Text = "Reactivar";
            this.Btn_Reactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Reactivar.UseVisualStyleBackColor = true;
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "1364077543_go-back.png");
            this.imageList1.Images.SetKeyName(1, "1373495296_page_white_add.png");
            this.imageList1.Images.SetKeyName(2, "1419636619_edit-notes.png");
            this.imageList1.Images.SetKeyName(3, "ACTUALIZAR.png");
            this.imageList1.Images.SetKeyName(4, "door_out.png");
            this.imageList1.Images.SetKeyName(5, "ELIMINAR.png");
            this.imageList1.Images.SetKeyName(6, "IMPRIMIR.png");
            // 
            // Btn_Consultar
            // 
            this.Btn_Consultar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Consultar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Consultar.ImageIndex = 6;
            this.Btn_Consultar.ImageList = this.imageList1;
            this.Btn_Consultar.Location = new System.Drawing.Point(382, 23);
            this.Btn_Consultar.Name = "Btn_Consultar";
            this.Btn_Consultar.Size = new System.Drawing.Size(93, 59);
            this.Btn_Consultar.TabIndex = 9;
            this.Btn_Consultar.Tag = "118";
            this.Btn_Consultar.Text = "Consultar";
            this.Btn_Consultar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Consultar.UseVisualStyleBackColor = true;
            // 
            // Btn_Nuevo
            // 
            this.Btn_Nuevo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Nuevo.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Nuevo.ImageIndex = 1;
            this.Btn_Nuevo.ImageList = this.imageList1;
            this.Btn_Nuevo.Location = new System.Drawing.Point(6, 23);
            this.Btn_Nuevo.Name = "Btn_Nuevo";
            this.Btn_Nuevo.Size = new System.Drawing.Size(93, 59);
            this.Btn_Nuevo.TabIndex = 8;
            this.Btn_Nuevo.Tag = "116";
            this.Btn_Nuevo.Text = "Agregar";
            this.Btn_Nuevo.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Nuevo.UseVisualStyleBackColor = true;
            this.Btn_Nuevo.Click += new System.EventHandler(this.Btn_Nuevo_Click);
            // 
            // Btn_Desactivar
            // 
            this.Btn_Desactivar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Desactivar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Desactivar.ImageIndex = 5;
            this.Btn_Desactivar.ImageList = this.imageList1;
            this.Btn_Desactivar.Location = new System.Drawing.Point(194, 23);
            this.Btn_Desactivar.Name = "Btn_Desactivar";
            this.Btn_Desactivar.Size = new System.Drawing.Size(93, 59);
            this.Btn_Desactivar.TabIndex = 7;
            this.Btn_Desactivar.Tag = "118";
            this.Btn_Desactivar.Text = "Desactivar";
            this.Btn_Desactivar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Desactivar.UseVisualStyleBackColor = true;
            // 
            // Btn_Salir
            // 
            this.Btn_Salir.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Salir.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Salir.ImageIndex = 4;
            this.Btn_Salir.ImageList = this.imageList1;
            this.Btn_Salir.Location = new System.Drawing.Point(476, 23);
            this.Btn_Salir.Name = "Btn_Salir";
            this.Btn_Salir.Size = new System.Drawing.Size(93, 59);
            this.Btn_Salir.TabIndex = 6;
            this.Btn_Salir.Text = "Salir";
            this.Btn_Salir.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Salir.UseVisualStyleBackColor = true;
            this.Btn_Salir.Click += new System.EventHandler(this.Btn_Salir_Click);
            // 
            // Btn_Modificar
            // 
            this.Btn_Modificar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.Btn_Modificar.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Btn_Modificar.ImageIndex = 3;
            this.Btn_Modificar.ImageList = this.imageList1;
            this.Btn_Modificar.Location = new System.Drawing.Point(100, 23);
            this.Btn_Modificar.Name = "Btn_Modificar";
            this.Btn_Modificar.Size = new System.Drawing.Size(93, 59);
            this.Btn_Modificar.TabIndex = 5;
            this.Btn_Modificar.Tag = "117";
            this.Btn_Modificar.Text = "Modificar ";
            this.Btn_Modificar.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Btn_Modificar.UseVisualStyleBackColor = true;
            // 
            // Frm_Menus
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 485);
            this.ControlBox = false;
            this.Controls.Add(this.Grp_Global);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Menus";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Catalogo de Menus.";
            this.AutoSizeChanged += new System.EventHandler(this.Frm_Menus_AutoSizeChanged);
            this.Activated += new System.EventHandler(this.Frm_Menus_Activated);
            this.Load += new System.EventHandler(this.Frm_Menus_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Global)).EndInit();
            this.Grp_Global.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).EndInit();
            this.Grp_Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vsp_menus)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_menus_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Opciones)).EndInit();
            this.Grp_Opciones.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_Global;
        private DevExpress.XtraEditors.GroupControl Grp_Datos;
        private FarPoint.Win.Spread.FpSpread vsp_menus;
        private FarPoint.Win.Spread.SheetView vsp_menus_Sheet1;
        private DevExpress.XtraEditors.GroupControl Grp_Opciones;
        private System.Windows.Forms.ImageList imageList1;
        internal System.Windows.Forms.Button Btn_Reactivar;
        internal System.Windows.Forms.Button Btn_Consultar;
        internal System.Windows.Forms.Button Btn_Nuevo;
        internal System.Windows.Forms.Button Btn_Desactivar;
        internal System.Windows.Forms.Button Btn_Salir;
        internal System.Windows.Forms.Button Btn_Modificar;
    }
}