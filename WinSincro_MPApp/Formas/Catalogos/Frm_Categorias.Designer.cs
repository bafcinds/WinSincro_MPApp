namespace WinSincro_MPApp.Formas.Catalogos
{
    partial class Frm_Categorias
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
            FarPoint.Win.Spread.CellType.TextCellType textCellType1 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType2 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType3 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType4 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType5 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType6 = new FarPoint.Win.Spread.CellType.TextCellType();
            FarPoint.Win.Spread.CellType.TextCellType textCellType7 = new FarPoint.Win.Spread.CellType.TextCellType();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_Categorias));
            this.Grp_Global = new DevExpress.XtraEditors.GroupControl();
            this.lblpixel = new System.Windows.Forms.Label();
            this.lblalto = new System.Windows.Forms.Label();
            this.lblancho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_categorias = new System.Windows.Forms.PictureBox();
            this.Grp_Datos = new DevExpress.XtraEditors.GroupControl();
            this.vsp_categorias = new FarPoint.Win.Spread.FpSpread();
            this.vsp_categorias_Sheet1 = new FarPoint.Win.Spread.SheetView();
            this.Grp_Opciones = new DevExpress.XtraEditors.GroupControl();
            this.chk_inactivos = new System.Windows.Forms.CheckBox();
            this.Btn_Reactivar = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.Btn_Consultar = new System.Windows.Forms.Button();
            this.Btn_Nuevo = new System.Windows.Forms.Button();
            this.Btn_Desactivar = new System.Windows.Forms.Button();
            this.Btn_Salir = new System.Windows.Forms.Button();
            this.Btn_Modificar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Global)).BeginInit();
            this.Grp_Global.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).BeginInit();
            this.Grp_Datos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_categorias)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_categorias_Sheet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Opciones)).BeginInit();
            this.Grp_Opciones.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Global
            // 
            this.Grp_Global.Controls.Add(this.lblpixel);
            this.Grp_Global.Controls.Add(this.lblalto);
            this.Grp_Global.Controls.Add(this.lblancho);
            this.Grp_Global.Controls.Add(this.label1);
            this.Grp_Global.Controls.Add(this.pb_categorias);
            this.Grp_Global.Controls.Add(this.Grp_Datos);
            this.Grp_Global.Controls.Add(this.Grp_Opciones);
            this.Grp_Global.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_Global.Location = new System.Drawing.Point(0, 0);
            this.Grp_Global.Name = "Grp_Global";
            this.Grp_Global.Size = new System.Drawing.Size(931, 400);
            this.Grp_Global.TabIndex = 1;
            this.Grp_Global.Text = "Listado de Categorias.";
            // 
            // lblpixel
            // 
            this.lblpixel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblpixel.AutoSize = true;
            this.lblpixel.Location = new System.Drawing.Point(842, 319);
            this.lblpixel.Name = "lblpixel";
            this.lblpixel.Size = new System.Drawing.Size(44, 13);
            this.lblpixel.TabIndex = 174;
            this.lblpixel.Text = "Pixeles:";
            // 
            // lblalto
            // 
            this.lblalto.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblalto.AutoSize = true;
            this.lblalto.Location = new System.Drawing.Point(775, 319);
            this.lblalto.Name = "lblalto";
            this.lblalto.Size = new System.Drawing.Size(30, 13);
            this.lblalto.TabIndex = 173;
            this.lblalto.Text = "Alto:";
            // 
            // lblancho
            // 
            this.lblancho.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblancho.AutoSize = true;
            this.lblancho.Location = new System.Drawing.Point(698, 319);
            this.lblancho.Name = "lblancho";
            this.lblancho.Size = new System.Drawing.Size(41, 13);
            this.lblancho.TabIndex = 172;
            this.lblancho.Text = "Ancho:";
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(694, 133);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 171;
            this.label1.Text = "Vista Previa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_categorias
            // 
            this.pb_categorias.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.pb_categorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_categorias.Location = new System.Drawing.Point(694, 161);
            this.pb_categorias.Name = "pb_categorias";
            this.pb_categorias.Size = new System.Drawing.Size(220, 151);
            this.pb_categorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_categorias.TabIndex = 170;
            this.pb_categorias.TabStop = false;
            // 
            // Grp_Datos
            // 
            this.Grp_Datos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Grp_Datos.Controls.Add(this.vsp_categorias);
            this.Grp_Datos.Location = new System.Drawing.Point(12, 130);
            this.Grp_Datos.Name = "Grp_Datos";
            this.Grp_Datos.Size = new System.Drawing.Size(676, 234);
            this.Grp_Datos.TabIndex = 3;
            this.Grp_Datos.Text = "Datos";
            // 
            // vsp_categorias
            // 
            this.vsp_categorias.AccessibleDescription = "";
            this.vsp_categorias.AllowRowMove = true;
            this.vsp_categorias.Dock = System.Windows.Forms.DockStyle.Fill;
            this.vsp_categorias.FocusRenderer = defaultFocusIndicatorRenderer1;
            this.vsp_categorias.HorizontalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.vsp_categorias.HorizontalScrollBar.Name = "";
            this.vsp_categorias.HorizontalScrollBar.Renderer = defaultScrollBarRenderer1;
            this.vsp_categorias.HorizontalScrollBar.TabIndex = 10;
            this.vsp_categorias.HorizontalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.vsp_categorias.Location = new System.Drawing.Point(2, 20);
            this.vsp_categorias.Name = "vsp_categorias";
            this.vsp_categorias.ScrollBarTrackPolicy = FarPoint.Win.Spread.ScrollBarTrackPolicy.Both;
            this.vsp_categorias.ScrollTipPolicy = FarPoint.Win.Spread.ScrollTipPolicy.Both;
            this.vsp_categorias.Sheets.AddRange(new FarPoint.Win.Spread.SheetView[] {
            this.vsp_categorias_Sheet1});
            this.vsp_categorias.Size = new System.Drawing.Size(672, 212);
            this.vsp_categorias.Skin = FarPoint.Win.Spread.DefaultSpreadSkins.Classic;
            this.vsp_categorias.TabIndex = 0;
            this.vsp_categorias.VerticalScrollBar.Buttons = new FarPoint.Win.Spread.FpScrollBarButtonCollection("BackwardLineButton,ThumbTrack,ForwardLineButton");
            this.vsp_categorias.VerticalScrollBar.Name = "";
            this.vsp_categorias.VerticalScrollBar.Renderer = defaultScrollBarRenderer2;
            this.vsp_categorias.VerticalScrollBar.TabIndex = 11;
            this.vsp_categorias.VerticalScrollBarPolicy = FarPoint.Win.Spread.ScrollBarPolicy.AsNeeded;
            this.vsp_categorias.VisualStyles = FarPoint.Win.VisualStyles.Off;
            this.vsp_categorias.SelectionChanged += new FarPoint.Win.Spread.SelectionChangedEventHandler(this.vsp_categorias_SelectionChanged);
            this.vsp_categorias.RowDragMoveCompleted += new FarPoint.Win.Spread.DragMoveCompletedEventHandler(this.vsp_categorias_RowDragMoveCompleted);
            this.vsp_categorias.SetActiveViewport(0, -1, -1);
            // 
            // vsp_categorias_Sheet1
            // 
            this.vsp_categorias_Sheet1.Reset();
            this.vsp_categorias_Sheet1.SheetName = "Sheet1";
            // Formulas and custom names must be loaded with R1C1 reference style
            this.vsp_categorias_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.R1C1;
            vsp_categorias_Sheet1.ColumnCount = 7;
            vsp_categorias_Sheet1.RowCount = 0;
            this.vsp_categorias_Sheet1.ActiveColumnIndex = -1;
            this.vsp_categorias_Sheet1.ActiveRowIndex = -1;
            this.vsp_categorias_Sheet1.ColumnFooter.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_categorias_Sheet1.ColumnFooter.DefaultStyle.Parent = "HeaderDefault";
            this.vsp_categorias_Sheet1.ColumnFooterSheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_categorias_Sheet1.ColumnFooterSheetCornerStyle.Parent = "CornerDefault";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 0).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 0).Value = "Marca";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 1).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 1).Value = "Codigo";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 2).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 2).Value = "Categoria";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 3).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 3).Value = "Color";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 4).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 4).Value = "Url";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 5).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 5).Value = "Referencia";
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 6).BackColor = System.Drawing.Color.Khaki;
            this.vsp_categorias_Sheet1.ColumnHeader.Cells.Get(0, 6).Value = "Activo";
            this.vsp_categorias_Sheet1.ColumnHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_categorias_Sheet1.ColumnHeader.DefaultStyle.Parent = "HeaderDefault";
            this.vsp_categorias_Sheet1.Columns.Get(0).AllowAutoFilter = true;
            textCellType1.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(0).CellType = textCellType1;
            this.vsp_categorias_Sheet1.Columns.Get(0).Label = "Marca";
            this.vsp_categorias_Sheet1.Columns.Get(0).Width = 119F;
            textCellType2.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(1).CellType = textCellType2;
            this.vsp_categorias_Sheet1.Columns.Get(1).Label = "Codigo";
            this.vsp_categorias_Sheet1.Columns.Get(1).Width = 98F;
            textCellType3.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(2).CellType = textCellType3;
            this.vsp_categorias_Sheet1.Columns.Get(2).Label = "Categoria";
            this.vsp_categorias_Sheet1.Columns.Get(2).Width = 228F;
            textCellType4.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(3).CellType = textCellType4;
            this.vsp_categorias_Sheet1.Columns.Get(3).Label = "Color";
            this.vsp_categorias_Sheet1.Columns.Get(3).Width = 138F;
            textCellType5.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(4).CellType = textCellType5;
            this.vsp_categorias_Sheet1.Columns.Get(4).Label = "Url";
            this.vsp_categorias_Sheet1.Columns.Get(4).Width = 190F;
            textCellType6.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(5).CellType = textCellType6;
            this.vsp_categorias_Sheet1.Columns.Get(5).Label = "Referencia";
            this.vsp_categorias_Sheet1.Columns.Get(5).Width = 146F;
            this.vsp_categorias_Sheet1.Columns.Get(6).AllowAutoFilter = true;
            textCellType7.ReadOnly = true;
            this.vsp_categorias_Sheet1.Columns.Get(6).CellType = textCellType7;
            this.vsp_categorias_Sheet1.Columns.Get(6).Label = "Activo";
            this.vsp_categorias_Sheet1.Columns.Get(6).Width = 69F;
            this.vsp_categorias_Sheet1.RowHeader.Columns.Default.Resizable = false;
            this.vsp_categorias_Sheet1.RowHeader.DefaultStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_categorias_Sheet1.RowHeader.DefaultStyle.Parent = "RowHeaderDefault";
            this.vsp_categorias_Sheet1.SheetCornerStyle.NoteIndicatorColor = System.Drawing.Color.Red;
            this.vsp_categorias_Sheet1.SheetCornerStyle.Parent = "CornerDefault";
            this.vsp_categorias_Sheet1.ReferenceStyle = FarPoint.Win.Spread.Model.ReferenceStyle.A1;
            // 
            // Grp_Opciones
            // 
            this.Grp_Opciones.Controls.Add(this.chk_inactivos);
            this.Grp_Opciones.Controls.Add(this.Btn_Reactivar);
            this.Grp_Opciones.Controls.Add(this.Btn_Consultar);
            this.Grp_Opciones.Controls.Add(this.Btn_Nuevo);
            this.Grp_Opciones.Controls.Add(this.Btn_Desactivar);
            this.Grp_Opciones.Controls.Add(this.Btn_Salir);
            this.Grp_Opciones.Controls.Add(this.Btn_Modificar);
            this.Grp_Opciones.Location = new System.Drawing.Point(12, 23);
            this.Grp_Opciones.Name = "Grp_Opciones";
            this.Grp_Opciones.Size = new System.Drawing.Size(621, 91);
            this.Grp_Opciones.TabIndex = 2;
            this.Grp_Opciones.Text = "Opciones";
            // 
            // chk_inactivos
            // 
            this.chk_inactivos.AutoSize = true;
            this.chk_inactivos.BackColor = System.Drawing.Color.Transparent;
            this.chk_inactivos.Location = new System.Drawing.Point(528, 3);
            this.chk_inactivos.Name = "chk_inactivos";
            this.chk_inactivos.Size = new System.Drawing.Size(89, 17);
            this.chk_inactivos.TabIndex = 11;
            this.chk_inactivos.Text = "Ver Inactivos";
            this.chk_inactivos.UseVisualStyleBackColor = false;
            this.chk_inactivos.CheckedChanged += new System.EventHandler(this.chk_inactivos_CheckedChanged);
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
            this.Btn_Reactivar.Click += new System.EventHandler(this.Btn_Reactivar_Click);
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
            this.Btn_Desactivar.Click += new System.EventHandler(this.Btn_Desactivar_Click);
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
            this.Btn_Modificar.Click += new System.EventHandler(this.Btn_Modificar_Click);
            // 
            // Frm_Categorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(931, 400);
            this.ControlBox = false;
            this.Controls.Add(this.Grp_Global);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_Categorias";
            this.Text = "Catalogo de Categorias.";
            this.Load += new System.EventHandler(this.Frm_Categorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Global)).EndInit();
            this.Grp_Global.ResumeLayout(false);
            this.Grp_Global.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).EndInit();
            this.Grp_Datos.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.vsp_categorias)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vsp_categorias_Sheet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Opciones)).EndInit();
            this.Grp_Opciones.ResumeLayout(false);
            this.Grp_Opciones.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_Global;
        private DevExpress.XtraEditors.GroupControl Grp_Datos;
        private FarPoint.Win.Spread.FpSpread vsp_categorias;
        private FarPoint.Win.Spread.SheetView vsp_categorias_Sheet1;
        private DevExpress.XtraEditors.GroupControl Grp_Opciones;
        internal System.Windows.Forms.Button Btn_Reactivar;
        internal System.Windows.Forms.Button Btn_Consultar;
        internal System.Windows.Forms.Button Btn_Nuevo;
        internal System.Windows.Forms.Button Btn_Desactivar;
        internal System.Windows.Forms.Button Btn_Salir;
        internal System.Windows.Forms.Button Btn_Modificar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Label lblpixel;
        private System.Windows.Forms.Label lblalto;
        private System.Windows.Forms.Label lblancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_categorias;
        private System.Windows.Forms.CheckBox chk_inactivos;
    }
}