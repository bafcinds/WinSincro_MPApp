namespace WinSincro_MPApp.Formas.Catalogos
{
    partial class Frm_EditMenu
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
            this.Grp_Datos = new DevExpress.XtraEditors.GroupControl();
            this.Btn_Cancelar = new System.Windows.Forms.Button();
            this.Btn_Guardar = new System.Windows.Forms.Button();
            this.txtcodigocupon = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).BeginInit();
            this.Grp_Datos.SuspendLayout();
            this.SuspendLayout();
            // 
            // Grp_Datos
            // 
            this.Grp_Datos.Controls.Add(this.Btn_Cancelar);
            this.Grp_Datos.Controls.Add(this.Btn_Guardar);
            this.Grp_Datos.Controls.Add(this.txtcodigocupon);
            this.Grp_Datos.Controls.Add(this.textBox2);
            this.Grp_Datos.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Grp_Datos.Location = new System.Drawing.Point(0, 0);
            this.Grp_Datos.Name = "Grp_Datos";
            this.Grp_Datos.Size = new System.Drawing.Size(404, 261);
            this.Grp_Datos.TabIndex = 0;
            this.Grp_Datos.Text = "Datos";
            // 
            // Btn_Cancelar
            // 
            this.Btn_Cancelar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Cancelar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Cancelar.Location = new System.Drawing.Point(216, 216);
            this.Btn_Cancelar.Name = "Btn_Cancelar";
            this.Btn_Cancelar.Size = new System.Drawing.Size(95, 23);
            this.Btn_Cancelar.TabIndex = 153;
            this.Btn_Cancelar.Text = "Cancelar";
            this.Btn_Cancelar.UseVisualStyleBackColor = false;
            // 
            // Btn_Guardar
            // 
            this.Btn_Guardar.BackColor = System.Drawing.Color.Khaki;
            this.Btn_Guardar.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Btn_Guardar.Location = new System.Drawing.Point(115, 216);
            this.Btn_Guardar.Name = "Btn_Guardar";
            this.Btn_Guardar.Size = new System.Drawing.Size(95, 23);
            this.Btn_Guardar.TabIndex = 152;
            this.Btn_Guardar.Text = "Guardar";
            this.Btn_Guardar.UseVisualStyleBackColor = false;
            // 
            // txtcodigocupon
            // 
            this.txtcodigocupon.Location = new System.Drawing.Point(127, 56);
            this.txtcodigocupon.MaxLength = 255;
            this.txtcodigocupon.Name = "txtcodigocupon";
            this.txtcodigocupon.Size = new System.Drawing.Size(205, 21);
            this.txtcodigocupon.TabIndex = 151;
            this.txtcodigocupon.Tag = "nombre";
            // 
            // textBox2
            // 
            this.textBox2.BackColor = System.Drawing.Color.AliceBlue;
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Font = new System.Drawing.Font("Tahoma", 8.25F);
            this.textBox2.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.textBox2.Location = new System.Drawing.Point(12, 56);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.Size = new System.Drawing.Size(109, 21);
            this.textBox2.TabIndex = 150;
            this.textBox2.Text = "Codigo Cupon:";
            // 
            // Frm_EditMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 261);
            this.ControlBox = false;
            this.Controls.Add(this.Grp_Datos);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_EditMenu";
            this.Text = "Edicion de Menu";
            this.Load += new System.EventHandler(this.Frm_EditMenu_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Grp_Datos)).EndInit();
            this.Grp_Datos.ResumeLayout(false);
            this.Grp_Datos.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl Grp_Datos;
        private System.Windows.Forms.Button Btn_Cancelar;
        private System.Windows.Forms.Button Btn_Guardar;
        private System.Windows.Forms.TextBox txtcodigocupon;
        private System.Windows.Forms.TextBox textBox2;
    }
}