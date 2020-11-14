using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSincro_MPApp.Formas.Catalogos;

namespace WinSincro_MPApp.Formas
{
    public partial class MDI : Form
    {

         
        public MDI()
        {
            InitializeComponent();
        }

        private void marcasToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void menusToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Frm_Menus))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new Frm_Menus();
            newForm.MdiParent = this;
            newForm.Show();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            //VGlobales.WslqE_My = " Call App_GetEmpresas('','N'); ";
            Cbo_Empresas.DropDownStyle = ComboBoxStyle.DropDownList;

            Conexion_Mysql.CargaCombo(" Call App_GetEmpresas('','N'); ", Cbo_Empresas, "EMPRESA", "CODEMPRESA", false, false);

            VGlobales.PEmpresa_Cod = Cbo_Empresas.SelectedValue.ToString().Trim();
            VGlobales.NOMBRE_EMPRESA = Cbo_Empresas.Text.ToString().Trim();
            VGlobales.FTPSettings();
            VGlobales.SizesImg();

            Cbo_Empresas.Enabled = false;


            this.Text = Cbo_Empresas.Text.ToString().Trim();

        }

        private void Btn_CambiaE_Click(object sender, EventArgs e)
        {

            if (this.MdiChildren.Length > 0)
            {
                MessageBox.Show("No es posible cambiar de Empresa, se requiere cerrar todas las Pantallas, Revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                return;
            }

            MenuStrip_MDI.Visible = false;
            Cbo_Empresas.Enabled = true;
        }

        private void Cbo_Empresas_SelectedIndexChanged(object sender, EventArgs e)
        {

         
            MenuStrip_MDI.Visible = true;
            Cbo_Empresas.Enabled = false;
            VGlobales.PEmpresa_Cod = Cbo_Empresas.SelectedValue.ToString();
            VGlobales.NOMBRE_EMPRESA = Cbo_Empresas.Text.ToString().Trim();

            this.Text = VGlobales.NOMBRE_EMPRESA;

        }

        private void categoriasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            foreach (Form form in Application.OpenForms)
            {
                if (form.GetType() == typeof(Frm_Categorias))
                {
                    form.Activate();
                    return;
                }
            }

            Form newForm = new Frm_Categorias();
            newForm.MdiParent = this;
            newForm.Show();
        }
    }
}
