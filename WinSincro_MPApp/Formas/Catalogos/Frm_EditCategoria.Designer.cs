namespace WinSincro_MPApp.Formas.Catalogos
{
    partial class Frm_EditCategoria
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_EditCategoria));
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.Btn_BCat = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblColor = new DevExpress.XtraEditors.LabelControl();
            this.Color_Edit = new DevExpress.XtraEditors.ColorEdit();
            this.lblpixel = new System.Windows.Forms.Label();
            this.lblalto = new System.Windows.Forms.Label();
            this.lblancho = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pb_categorias = new System.Windows.Forms.PictureBox();
            this.txtReferencia = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.txtMarca = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.Btn_Marca = new System.Windows.Forms.Button();
            this.txtDescripcion = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Edit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categorias)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.Btn_BCat);
            this.groupControl1.Controls.Add(this.textBox1);
            this.groupControl1.Controls.Add(this.lblColor);
            this.groupControl1.Controls.Add(this.Color_Edit);
            this.groupControl1.Controls.Add(this.lblpixel);
            this.groupControl1.Controls.Add(this.lblalto);
            this.groupControl1.Controls.Add(this.lblancho);
            this.groupControl1.Controls.Add(this.label1);
            this.groupControl1.Controls.Add(this.pb_categorias);
            this.groupControl1.Controls.Add(this.txtReferencia);
            this.groupControl1.Controls.Add(this.textBox7);
            this.groupControl1.Controls.Add(this.txtMarca);
            this.groupControl1.Controls.Add(this.textBox5);
            this.groupControl1.Controls.Add(this.Btn_Marca);
            this.groupControl1.Controls.Add(this.txtDescripcion);
            this.groupControl1.Controls.Add(this.textBox3);
            this.groupControl1.Controls.Add(this.txtCodigo);
            this.groupControl1.Controls.Add(this.textBox2);
            this.groupControl1.Controls.Add(this.Btn_Cancelar);
            this.groupControl1.Controls.Add(this.Btn_Guardar);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(661, 281);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Datos";
            // 
            // Btn_BCat
            // 
            this.Btn_BCat.ImageIndex = 0;
            this.Btn_BCat.ImageList = this.imageList1;
            this.Btn_BCat.Location = new System.Drawing.Point(560, 23);
            this.Btn_BCat.Name = "Btn_BCat";
            this.Btn_BCat.Size = new System.Drawing.Size(29, 23);
            this.Btn_BCat.TabIndex = 174;
            this.Btn_BCat.UseVisualStyleBackColor = true;
            this.Btn_BCat.Click += new System.EventHandler(this.Btn_BCat_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "busqui.png");
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox1.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox1.Location = new System.Drawing.Point(8, 89);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(109, 21);
            this.textBox1.TabIndex = 173;
            this.textBox1.Text = "Color:";
            // 
            // lblColor
            // 
            this.lblColor.Appearance.BackColor = System.Drawing.Color.Transparent;
            this.lblColor.Appearance.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold);
            this.lblColor.Appearance.Options.UseBackColor = true;
            this.lblColor.Appearance.Options.UseFont = true;
            this.lblColor.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblColor.Location = new System.Drawing.Point(299, 89);
            this.lblColor.Name = "lblColor";
            this.lblColor.Size = new System.Drawing.Size(86, 20);
            this.lblColor.TabIndex = 172;
            this.lblColor.Text = "#FFFFFF";
            // 
            // Color_Edit
            // 
            this.Color_Edit.AllowHtmlTextInToolTip = DevExpress.Utils.DefaultBoolean.True;
            this.Color_Edit.Cursor = System.Windows.Forms.Cursors.WaitCursor;
            this.Color_Edit.EditValue = System.Drawing.Color.Empty;
            this.Color_Edit.Location = new System.Drawing.Point(123, 90);
            this.Color_Edit.Name = "Color_Edit";
            this.Color_Edit.Properties.AllowHtmlDraw = DevExpress.Utils.DefaultBoolean.True;
            this.Color_Edit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.Color_Edit.Properties.ShowCustomColors = false;
            this.Color_Edit.Properties.ShowSystemColors = false;
            this.Color_Edit.Size = new System.Drawing.Size(173, 20);
            this.Color_Edit.TabIndex = 170;
            this.Color_Edit.UseWaitCursor = true;
            this.Color_Edit.EditValueChanged += new System.EventHandler(this.Color_Edit_EditValueChanged);
            // 
            // lblpixel
            // 
            this.lblpixel.AutoSize = true;
            this.lblpixel.Location = new System.Drawing.Point(559, 211);
            this.lblpixel.Name = "lblpixel";
            this.lblpixel.Size = new System.Drawing.Size(44, 13);
            this.lblpixel.TabIndex = 169;
            this.lblpixel.Text = "Pixeles:";
            // 
            // lblalto
            // 
            this.lblalto.AutoSize = true;
            this.lblalto.Location = new System.Drawing.Point(492, 211);
            this.lblalto.Name = "lblalto";
            this.lblalto.Size = new System.Drawing.Size(30, 13);
            this.lblalto.TabIndex = 168;
            this.lblalto.Text = "Alto:";
            // 
            // lblancho
            // 
            this.lblancho.AutoSize = true;
            this.lblancho.Location = new System.Drawing.Point(415, 211);
            this.lblancho.Name = "lblancho";
            this.lblancho.Size = new System.Drawing.Size(41, 13);
            this.lblancho.TabIndex = 167;
            this.lblancho.Text = "Ancho:";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(64)))));
            this.label1.Location = new System.Drawing.Point(397, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(220, 23);
            this.label1.TabIndex = 166;
            this.label1.Text = "Vista Previa";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pb_categorias
            // 
            this.pb_categorias.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pb_categorias.Location = new System.Drawing.Point(411, 53);
            this.pb_categorias.Name = "pb_categorias";
            this.pb_categorias.Size = new System.Drawing.Size(220, 151);
            this.pb_categorias.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pb_categorias.TabIndex = 165;
            this.pb_categorias.TabStop = false;
            // 
            // txtReferencia
            // 
            this.txtReferencia.Location = new System.Drawing.Point(123, 117);
            this.txtReferencia.MaxLength = 200;
            this.txtReferencia.Name = "txtReferencia";
            this.txtReferencia.Size = new System.Drawing.Size(132, 21);
            this.txtReferencia.TabIndex = 164;
            this.txtReferencia.Tag = "nombre";
            // 
            // textBox7
            // 
            this.textBox7.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox7.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox7.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox7.Location = new System.Drawing.Point(8, 117);
            this.textBox7.Name = "textBox7";
            this.textBox7.ReadOnly = true;
            this.textBox7.Size = new System.Drawing.Size(109, 21);
            this.textBox7.TabIndex = 163;
            this.textBox7.Text = "Codigo Referencia:";
            // 
            // txtMarca
            // 
            this.txtMarca.Location = new System.Drawing.Point(123, 147);
            this.txtMarca.MaxLength = 255;
            this.txtMarca.Name = "txtMarca";
            this.txtMarca.Size = new System.Drawing.Size(205, 21);
            this.txtMarca.TabIndex = 162;
            this.txtMarca.Tag = "nombre";
            // 
            // textBox5
            // 
            this.textBox5.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox5.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox5.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox5.Location = new System.Drawing.Point(8, 147);
            this.textBox5.Name = "textBox5";
            this.textBox5.ReadOnly = true;
            this.textBox5.Size = new System.Drawing.Size(109, 21);
            this.textBox5.TabIndex = 161;
            this.textBox5.Text = "Marca Asociada:";
            // 
            // Btn_Marca
            // 
            this.Btn_Marca.ImageIndex = 0;
            this.Btn_Marca.ImageList = this.imageList1;
            this.Btn_Marca.Location = new System.Drawing.Point(328, 146);
            this.Btn_Marca.Name = "Btn_Marca";
            this.Btn_Marca.Size = new System.Drawing.Size(29, 23);
            this.Btn_Marca.TabIndex = 160;
            this.Btn_Marca.UseVisualStyleBackColor = true;
            this.Btn_Marca.Click += new System.EventHandler(this.Btn_Marca_Click);
            // 
            // txtDescripcion
            // 
            this.txtDescripcion.Location = new System.Drawing.Point(123, 62);
            this.txtDescripcion.MaxLength = 100;
            this.txtDescripcion.Name = "txtDescripcion";
            this.txtDescripcion.Size = new System.Drawing.Size(234, 21);
            this.txtDescripcion.TabIndex = 159;
            this.txtDescripcion.Tag = "nombre";
            // 
            // textBox3
            // 
            this.textBox3.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox3.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox3.Location = new System.Drawing.Point(8, 62);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(109, 21);
            this.textBox3.TabIndex = 158;
            this.textBox3.Text = "Descripcion:";
            // 
            // txtCodigo
            // 
            this.txtCodigo.BackColor = System.Drawing.Color.White;
            this.txtCodigo.Location = new System.Drawing.Point(123, 35);
            this.txtCodigo.MaxLength = 8;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.ReadOnly = true;
            this.txtCodigo.Size = new System.Drawing.Size(71, 21);
            this.txtCodigo.TabIndex = 157;
            this.txtCodigo.Tag = "nombre";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(8, 35);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(109, 21);
            this.textBox2.TabIndex = 156;
            this.textBox2.Text = "Codigo:";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Location = new System.Drawing.Point(184, 246);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(95, 23);
            this.Btn_Cancelar.TabIndex = 155;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            this.Btn_Cancelar.Click += new System.EventHandler(this.Btn_Cancelar_Click);
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Guardar.Location = new System.Drawing.Point(83, 246);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(95, 23);
            this.Btn_Guardar.TabIndex = 154;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            this.Btn_Guardar.Click += new System.EventHandler(this.Btn_Guardar_Click);
            // 
            // Frm_EditCategoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(661, 281);
            this.ControlBox = false;
            this.Controls.Add(this.groupControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditCategoria";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edicion de Categoria";
            this.Load += new System.EventHandler(this.Frm_EditCategoria_Load);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Color_Edit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pb_categorias)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.TextBox txtDescripcion;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox txtMarca;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Button Btn_Marca;
        private System.Windows.Forms.TextBox txtReferencia;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.Label lblpixel;
        private System.Windows.Forms.Label lblalto;
        private System.Windows.Forms.Label lblancho;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pb_categorias;
        private System.Windows.Forms.Button Btn_BCat;
        private System.Windows.Forms.TextBox textBox1;
        internal DevExpress.XtraEditors.LabelControl lblColor;
        internal DevExpress.XtraEditors.ColorEdit Color_Edit;
    }
}