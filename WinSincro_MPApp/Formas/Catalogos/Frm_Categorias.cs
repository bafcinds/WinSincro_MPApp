using Microsoft.VisualBasic;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSincro_App.Modulos;

namespace WinSincro_MPApp.Formas.Catalogos
{
    public partial class Frm_Categorias : Form
    {

        Modulo md = new Modulo();
        public string XActivo = "S";
        public Frm_Categorias()
        {
            InitializeComponent();
        }

        private void Frm_Categorias_Load(object sender, EventArgs e)
        {

            vsp_categorias.ActiveSheet.RowCount = 0;
            vsp_categorias.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            vsp_categorias.ActiveSheet.GrayAreaBackColor = Color.White;
            vsp_categorias.BackColor = Color.White;

            ExtraerMov();

            this.WindowState = FormWindowState.Maximized;
        }

        private void Btn_Salir_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        public void ExtraerMov()
        {

            var Loading = new PCGUtility.Preload();
            object[] param = null;
            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "CargarTodos", CallType.Method, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Cargando Categorias ");
        }
        public void CargarTodos()
        {

            try
            {

                Grp_Datos.Visible = false;
            DataTable dtnt = new DataTable();
            VGlobales.WsqlE_My = " Call App_Crud_Categorias('"+VGlobales.PEmpresa_Cod+"','','','','','',0,'','"+XActivo+"','R');";
            Conexion_Mysql.LlenarTabla_Mysql(ref dtnt, VGlobales.WsqlE_My);

            if (dtnt.Rows.Count>0)
            {
                vsp_categorias.ActiveSheet.Rows.Count = dtnt.Rows.Count;

                for (int i = 0; i <= vsp_categorias.ActiveSheet.Rows.Count-1; i++)
                {
                    vsp_categorias.ActiveSheet.Cells[i, 0].Text = dtnt.Rows[i]["Marca"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 0].Tag = dtnt.Rows[i]["CodigoMarca"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 1].Text = dtnt.Rows[i]["Codigo"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 2].Text = dtnt.Rows[i]["Categoria"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 2].BackColor = md.Hexa_a_Color(dtnt.Rows[i]["Color"].ToString());
                    vsp_categorias.ActiveSheet.Cells[i, 3].Tag = dtnt.Rows[i]["Color"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 3].Text =md.GetColourName( dtnt.Rows[i]["Color"].ToString().Trim());
                    vsp_categorias.ActiveSheet.Cells[i, 4].Text = dtnt.Rows[i]["Url"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 5].Text = dtnt.Rows[i]["Referencia"].ToString().Trim();
                    vsp_categorias.ActiveSheet.Cells[i, 6].Text = dtnt.Rows[i]["Activo"].ToString().Trim();
                }
                }
                else
                {
                    vsp_categorias.ActiveSheet.Rows.Count = 0;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

            Grp_Datos.Visible = true;
        }

        private void Btn_Nuevo_Click(object sender, EventArgs e)
        {
            Frm_EditCategoria edt = new Frm_EditCategoria();
            edt.Flag = "A";
            edt.ShowDialog();

            ExtraerMov();
        }

        private void Btn_Modificar_Click(object sender, EventArgs e)
        {

            if (vsp_categorias.ActiveSheet.RowCount>0)
            {
                int fila = vsp_categorias.ActiveSheet.ActiveRowIndex;
                Frm_EditCategoria edt = new Frm_EditCategoria();
                edt.Flag = "M";
                edt.CodMarca = vsp_categorias.ActiveSheet.Cells[fila, 0].Tag.ToString().Trim();
                edt.Marca = vsp_categorias.ActiveSheet.Cells[fila, 0].Text.ToString().Trim();
                edt.Codigo = vsp_categorias.ActiveSheet.Cells[fila, 1].Text.ToString().Trim();
                edt.Categoria = vsp_categorias.ActiveSheet.Cells[fila, 2].Text.ToString().Trim();
                edt.ColorHex = vsp_categorias.ActiveSheet.Cells[fila, 3].Text.ToString().Trim();
                edt.Url_Img= vsp_categorias.ActiveSheet.Cells[fila, 4].Text.ToString().Trim();
                edt.Referencia = vsp_categorias.ActiveSheet.Cells[fila, 5].Text.ToString().Trim();
                edt.color = md.Html_a_Color(vsp_categorias.ActiveSheet.Cells[fila, 3].Tag.ToString());
                edt.ShowDialog();

                ExtraerMov();
            }
          
        }

        private void Btn_Desactivar_Click(object sender, EventArgs e)
        {

            try
            {

          
            string reff = "";
            int fila = vsp_categorias.ActiveSheet.ActiveRowIndex;
            if (vsp_categorias.ActiveSheet.RowCount>0)
            {

                    if (vsp_categorias.ActiveSheet.Cells[fila, 6].Text.ToString().Trim()=="N")
                    {
                        MessageBox.Show("Unicamente Categorias Activas puede Desactivarse, Revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                if (MessageBox.Show("Esta Seguro de Desactivar la Categoria: "+vsp_categorias.ActiveSheet.Cells[fila,2].Text.ToString() +"","Opcion",MessageBoxButtons.YesNo,MessageBoxIcon.Question)==DialogResult.Yes)
                {
                    VGlobales.WsqlE_My = " Call App_Crud_Categorias('" + VGlobales.PEmpresa_Cod + "','','" + vsp_categorias.ActiveSheet.Cells[fila, 1].Text.ToString() + "','','','',0,'','','D');";
                    Conexion_Mysql.Ejecutar2_Mysql(VGlobales.WsqlE_My, ref reff);

                        MessageBox.Show("Categoria Desactivada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        ExtraerMov();

                    }
            }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }

        }

        private void Btn_Reactivar_Click(object sender, EventArgs e)
        {
            try
            {


                string reff = "";
                int fila = vsp_categorias.ActiveSheet.ActiveRowIndex;
                if (vsp_categorias.ActiveSheet.RowCount > 0)
                {

                    if (vsp_categorias.ActiveSheet.Cells[fila, 6].Text.ToString().Trim() == "S")
                    {
                        MessageBox.Show("Unicamente Categorias Inactivas pueden Reactivarse, Revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        return;
                    }

                    if (MessageBox.Show("Esta Seguro de Desactivar la Categoria: " + vsp_categorias.ActiveSheet.Cells[fila, 2].Text.ToString() + "", "Opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        VGlobales.WsqlE_My = " Call App_Crud_Categorias('" + VGlobales.PEmpresa_Cod + "','','" + vsp_categorias.ActiveSheet.Cells[fila, 1].Text.ToString() + "','','','',0,'','','N');";
                        Conexion_Mysql.Ejecutar2_Mysql(VGlobales.WsqlE_My, ref reff);
                        MessageBox.Show("Categoria Reactivada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ExtraerMov();

                    }
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
        }

        private void chk_inactivos_CheckedChanged(object sender, EventArgs e)
        {
            if (chk_inactivos.Checked)
            {
                XActivo = "N";
            }
            else
            {
                XActivo = "S";
            }

            ExtraerMov();
        }

        private void vsp_categorias_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            if (vsp_categorias.ActiveSheet.RowCount > 0)
            {
                string UrlImagen = "";
                int fila = vsp_categorias.ActiveSheet.ActiveRowIndex;
                UrlImagen = vsp_categorias.ActiveSheet.Cells[fila, 4].Text;

                //string UrlImagen = "";
                //UrlImagen = vsp_categoria_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (UrlImagen != "")
                {
                    Image img = null;
                    pb_categorias.Load(UrlImagen);
                    img = pb_categorias.Image;
                    lblancho.Text = "Ancho: " + img.Width.ToString();
                    lblalto.Text = "Alto: " + img.Height.ToString();
                    lblpixel.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);

                    //    pb_categorias.ImageLocation = UrlImagen;
                    //    txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_categorias.Image = null;
                    lblancho.Text = "Ancho: ";
                    lblalto.Text = "Alto: ";
                    lblpixel.Text = "Pixeles: ";
                }

            }

        }

        private void vsp_categorias_RowDragMoveCompleted(object sender, FarPoint.Win.Spread.DragMoveCompletedEventArgs e)
        {

            var Loading = new PCGUtility.Preload();
            object[] param = null;
            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "SincronizaOrden", CallType.Method, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Orden de Categorias ");

        }

        public void SincronizaOrden()
        {

            VGlobales.WsqlE_My = "";
            try
            {

                string reff = "";
            for (int i = 0; i <= vsp_categorias.ActiveSheet.RowCount-1; i++)
            {
                VGlobales.WsqlE_My += "\n\r"; ;
                VGlobales.WsqlE_My += " Call App_Crud_Categorias('" + VGlobales.PEmpresa_Cod + "','','" + vsp_categorias.ActiveSheet.Cells[i, 1].Text.ToString() + "','','','',"+i.ToString()+",'','','S');";
                }


            if (VGlobales.WsqlE_My.ToString().Trim()!="")
            {
                Conexion_Mysql.Ejecutar2_Mysql(VGlobales.WsqlE_My, ref reff);

                 
                }


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                VGlobales.WsqlE_My = "";
            }
            VGlobales.WsqlE_My = "";
        }
    }
}
