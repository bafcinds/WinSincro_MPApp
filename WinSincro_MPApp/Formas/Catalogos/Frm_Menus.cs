using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinSincro_MPApp.Formas.Catalogos
{
    public partial class Frm_Menus : Form
    {
        public Frm_Menus()
        {
            InitializeComponent();
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_EditMenu edm = new Frm_EditMenu();
            edm.ShowDialog();
        }

        private void Frm_Menus_Load(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Frm_Menus_AutoSizeChanged(object sender, EventArgs e)
        {

        }

        private void Frm_Menus_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }
    }
}
