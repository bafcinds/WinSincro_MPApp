using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PCGUtility;
using WinSincro_App.Modulos;
using System.IO;

namespace WinSincro_MPApp.Formas.Catalogos
{
    public partial class Frm_EditCategoria : Form
    {
        public string Flag = "A";
        public string Codigo = "", Categoria = "", Referencia = "", Marca = "", CodMarca = "",ColorHex="",Url_Img="";
        public Color color;
        Modulo md = new Modulo();


        private void Btn_Guardar_Click(object sender, EventArgs e)
        {

            try
            {

         
            Guid g;
            string nombre_carpeta = "categorias", nombre_archivo = "", path_archivo = "", url_img = "", result = "", colorHex = "";

            DataTable dtnresp = new DataTable();
            if (txtDescripcion.Text.ToString().Trim() == "")
            {
                MessageBox.Show("El nombre de la categoria no puede ser vacio, Revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


            if (txtMarca.Tag.ToString().Trim() == "")
            {
                MessageBox.Show("Se requiere una marca valida, Revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                return;
            }


                Btn_Guardar.Enabled = false;
            nombre_archivo = txtCodigo.Text;
            path_archivo = pb_categorias.Tag.ToString();

                if (path_archivo!="")
                {
                    g = Guid.NewGuid();

                    url_img = VGlobales.Dominio_FTP + VGlobales.SubDirectorio_FTP + "/" + nombre_carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png" + "?time=" + g.ToString().Replace("-", "").Trim() + "";
                }
    

            VGlobales.WsqlE_My = " Call App_Crud_Categorias('" + VGlobales.PEmpresa_Cod + "','" + txtMarca.Tag.ToString() + "','" + txtCodigo.Text.ToString().Trim() + "','" + txtDescripcion.Text.ToString().Trim().Replace("'", "") + "','"+lblColor.Text.ToString()+"','"+url_img+ "',0,'" + txtReferencia.Text.ToString().Trim().Replace("'", "") + "','S','C');";

            Conexion_Mysql.LlenarTabla_Mysql(ref dtnresp, VGlobales.WsqlE_My);

          



            if (dtnresp.Rows[0]["Resp"].ToString().Trim() == "N")
            {

                MessageBox.Show(dtnresp.Rows[0]["Mensaje"].ToString().Trim(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                  Btn_Guardar.Enabled = true;
                    return;
            }
            else
            {
              

                if (path_archivo != "")
                {

                     md.Crear_Carpeta(VGlobales.Server_FTP, nombre_carpeta.ToLower(), VGlobales.Usuario_FTP, VGlobales.Contraseña_FTP, null, null);
                     md.Envio_ArchivoFTP_ImgB64(nombre_carpeta, nombre_archivo, path_archivo);
               
                }
                MessageBox.Show(dtnresp.Rows[0]["Mensaje"].ToString().Trim(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (Flag == "A")
                {
                    Limpiar();

                }
                else
                {
                    this.Dispose();
                }
            }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                Btn_Guardar.Enabled = true;
            }
        }

        private void Btn_Marca_Click(object sender, EventArgs e)
        {

            DataTable dtncat = new DataTable();
            DataTable dtncatc = new DataTable();
            VGlobales.WsqlE_My = " SELECT CODMARCA as CODIGO,NOMBRE AS DESCRIPCION FROM CAT_DATOMARCA WHERE ACTIVO='S' AND CODMARCA IN (SELECT CODMARCA FROM REL_SEGMENTO_EMPRESA_MARCA WHERE CODEMPRESA='"+VGlobales.PEmpresa_Cod.ToString()+"');";

            Conexion_Mysql.LlenarTabla_Mysql(ref dtncat, VGlobales.WsqlE_My);

            PCGUtility.FrmBusqueda frm = new PCGUtility.FrmBusqueda(dtncat, "Codigo", "Marca", "Listado de Marcas");

            frm.ShowDialog();

            if (frm.RCodigo.ToString().Trim()!="")
            {
                txtMarca.Text = frm.RDesc.ToString().Trim();
                txtMarca.Tag = frm.RCodigo.ToString().Trim();
               Conexion_Mysql.LlenarTabla_Mysql(ref dtncatc, "select APLICA_ERP from CAT_DATOMARCA where CODMARCA=" + txtMarca.Tag.ToString() + "");

                Btn_Marca.Tag =  dtncatc.Rows[0]["APLICA_ERP"].ToString().Trim();
            }

        }

        private void Btn_Cancelar_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void Btn_BCat_Click(object sender, EventArgs e)
        {
            string hayImagen = "N";
            string urlImagen = "";
            int ancho = 0, alto = 0;
            string tempo = "";
            Image imageFile;
            //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
            string base64ImageRepresentation = "";
       

                var openDlg = new OpenFileDialog();
                // openDlg.Filter = "Imágenes JPG(*.jpg)|*.jpg|Imágenes PNG(*.png)|*.png|Todos los formatos (*.*)|*.*";
                openDlg.Filter = "All png files|*.png";

                openDlg.InitialDirectory = Environment.CurrentDirectory;
                string filter = openDlg.Filter;
                openDlg.Title = "Open a Bitmap File";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    urlImagen = openDlg.FileName;


                    if (VGlobales.ancho_c > 0 && VGlobales.alto_c > 0)
                    {

                        if (VGlobales.ACategoria)
                        {
                            imageFile = Image.FromFile(urlImagen);
                            base64ImageRepresentation = md.ConvertImageToBase64(md.Redimensionar(imageFile, VGlobales.ancho_c, VGlobales.alto_c));
                        }
                        else
                        {
                            if (md.Tamaño_ValidoImg("C", urlImagen, 1, ref ancho, ref alto) == false)
                            {
                                MessageBox.Show("Imagen no posee las dimensiones aceptadas (Ancho: " + VGlobales.ancho_c.ToString() + " ; Alto: " + VGlobales.alto_c.ToString() + ")  , Imagen seleccionada (Ancho:" + ancho.ToString() + " ; Alto:" + alto.ToString() + ") ,  Favor revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                return;
                            }
                            else
                            {
                                byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                                base64ImageRepresentation = Convert.ToBase64String(imageArray);
                            }
                        }



                    }
                    else
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                        base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    }

                    pb_categorias.ImageLocation = urlImagen;
                   pb_categorias.Tag = base64ImageRepresentation;


                var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64ImageRepresentation)));

                lblancho.Text = "Ancho: " + img.Width.ToString();
                lblalto.Text = "Alto: " + img.Height.ToString();
                lblpixel.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);

                hayImagen = "S";
                }
                else
                {
                    hayImagen = "N";
                    //Environment.Exit(0);
                } /* TODO ERROR: Skipped SkippedTokensTrivia */

                //if (urlImagen != "")
                //{

                //    //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                //    //string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                //    //txtpath.Text = urlImagen;


                //    if (MessageBox.Show("Esta seguro de Hacer el cambio de Imagen?", "Opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                //    {
                //        WsqlE = " Update Grupos_Img set ImgB64='" + base64ImageRepresentation + "' where CodGrupo='" + vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Text.ToString().Trim() + "'";

                //        WsqlE += "  Update Grupos set Img_Path='" + urlImagen + "' where CodGrupo='" + vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Text.ToString().Trim() + "'";

                //        //Conecta = VGlobales.ConectaT;
                //        if (Utilities.Execute(Conecta, WsqlE, true))
                //        {
                //            vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Tag = base64ImageRepresentation;
                //            vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 2].Value = true;
                //            MessageBox.Show("Imagen Actualizada , Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //        }

                //    }

                //}

            


        }

        private void Color_Edit_EditValueChanged(object sender, EventArgs e)
        {
            lblColor.Text = md.HexConverter(Color_Edit.Color);
        }

        public Frm_EditCategoria()
        {
            InitializeComponent();
        }

        private void Frm_EditCategoria_Load(object sender, EventArgs e)
        {

            if (Flag=="A")
            {
                this.Text = "Agregar Categoria.";
                Limpiar();

            }
            else
            {
                this.Text = "Modificar Categoria.";
                txtCodigo.Text = Codigo;
                txtDescripcion.Text = Categoria;
                txtReferencia.Text = Referencia;
                txtMarca.Tag = CodMarca;
                txtMarca.Text = Marca;
                Color_Edit.Color = color;

                if (Url_Img!="")
                {
                    pb_categorias.Load(Url_Img);
                    pb_categorias.Tag = md.ConvertImageToBase64(pb_categorias.Image);
                    Image img = pb_categorias.Image;
                    lblancho.Text = "Ancho: " + img.Width.ToString();
                    lblalto.Text = "Alto: " + img.Height.ToString();
                    lblpixel.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                }
            }
        }

        public void Limpiar()
        {
            txtCodigo.Text = Consecutivo();
            txtDescripcion.Text = "";
            txtMarca.Text = "";
            txtMarca.Tag = "";
            txtReferencia.Text = "";
            Btn_Marca.Tag = "N";
            pb_categorias.Image = null;
            pb_categorias.Tag = "";

            lblancho.Text = "Ancho: 0" ;
            lblalto.Text = "Alto: 0" ;
            lblpixel.Text = "Pixeles: 0";

        }

        public string Consecutivo()
        {
            string Conse = "";
            DataTable dtconse = new DataTable();
            VGlobales.WsqlE_My = " SELECT IFNULL(MAX(CODCATEGORIA),0)+1 AS CODIGO FROM TCATEGORIA; ";
            Conexion_Mysql.LlenarTabla_Mysql(ref dtconse, VGlobales.WsqlE_My);

            if (dtconse.Rows.Count>0)
            {
                Conse = Utilities.ZtrCero(dtconse.Rows[0]["CODIGO"].ToString().Trim(), 8);
            }
            else
            {
                Conse = "1";
            }

            return Conse;
        }

    }
}
