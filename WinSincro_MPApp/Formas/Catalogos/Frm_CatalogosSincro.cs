using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using PCGUtility;
using WinSincro_App.Modulos;
using Microsoft.VisualBasic;
using System.IO;
using System.Net;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using WinSincro_MPApp;

namespace WinSincro_App
{
   

    public partial class Frm_SincroCatalogos:Form
    {
         
         //Sql_Conexion sqlc = new Sql_Conexion();
         public string WsqlE = "";
         public string WsqlE_My = "";
         public DataSet DTG= new DataSet();
        public DataSet DTG_IMG = new DataSet();
        Modulo md = new Modulo();
         //public string cadena= "Data Source=DEVBRYAN\\DEVBRYAN;User ID=SUPER_PCG ;Password=pcg270282;Persist Security Info=True;Initial Catalog=PCG_WEB";
         public SqlConnection Conecta;

        //Variables FTP
        string Server_FTP = "", Usuario_FTP = "", Contraseña_FTP = "", SubDirectorio_FTP = "",Dominio_FTP="";

        public Frm_SincroCatalogos()
        {
            InitializeComponent();
        }

        private void Tab_Catalogos_SelectedIndexChanged(object sender, EventArgs e)
        {
            //Btn_Sincroniza.Text = "Sincronizar " + Tab_Catalogos.TabPages[Tab_Catalogos.SelectedIndex].Text.ToString();

            Chk_Marcar.Checked = false;
         
        }

        private void Btn_Extrae_Click(object sender, EventArgs e)
        {
            var Loading = new PCGUtility.Preload();
            object[] param = null;
            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Extraer_Datos", CallType.Method, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Extayendo Datos");

            //Extraer_Datos();
        }

        public void Extraer_Datos()
        {


            //Conecta = VGlobales.ConectaT;
            Tab_Catalogos.Visible = false;
            //DTG = new DataSet();
            DTG_IMG = new DataSet();
            //DTG.Dispose();
            //DTG_IMG.Dispose();
            //WsqlE = "Exec App_Pcg_ExtraeCatalogos 0,'','','' ";
            // if ( Utilities.ObtenerDatos(Conecta, DTG, WsqlE, true))
            //{ 
            //    if(DTG.Tables[0].Rows.Count > 0)
            //    {

            //        vsp_umedida.ActiveSheet.DataSource = DTG.Tables[0];
            //        vsp_categorias.ActiveSheet.DataSource = DTG.Tables[1];
            //        vsp_subcategorias.ActiveSheet.DataSource = DTG.Tables[2];
            //        vsp_productos.ActiveSheet.DataSource = DTG.Tables[3];
            //        vsp_listaprecio.ActiveSheet.DataSource = DTG.Tables[4];
            //        vsp_precios.ActiveSheet.DataSource = DTG.Tables[5];
            //        vsp_estados.ActiveSheet.DataSource = DTG.Tables[6];
            //        vsp_departamentos.ActiveSheet.DataSource = DTG.Tables[7];
            //        vsp_fpagos.ActiveSheet.DataSource = DTG.Tables[8];

                   

            //        FarPoint.Win.Spread.CellType.CheckBoxCellType chk = new FarPoint.Win.Spread.CellType.CheckBoxCellType();
            //        FarPoint.Win.Spread.CellType.DateTimeCellType dt = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            //        FarPoint.Win.Spread.CellType.TextCellType tx = new FarPoint.Win.Spread.CellType.TextCellType();

            //        vsp_umedida.ActiveSheet.ColumnCount = vsp_umedida.ActiveSheet.ColumnCount + 1;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;


            //        vsp_umedida.ActiveSheet.ColumnCount = vsp_umedida.ActiveSheet.ColumnCount + 1;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_umedida.ActiveSheet.ColumnCount = vsp_umedida.ActiveSheet.ColumnCount + 1;
            //        vsp_umedida.ActiveSheet.Columns[vsp_umedida.ActiveSheet.Columns.Count - 1].CellType = chk;




            //        vsp_categorias.ActiveSheet.ColumnCount = vsp_categorias.ActiveSheet.ColumnCount + 1;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;

            //        vsp_categorias.ActiveSheet.ColumnCount = vsp_categorias.ActiveSheet.ColumnCount + 1;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_categorias.ActiveSheet.ColumnCount = vsp_categorias.ActiveSheet.ColumnCount + 1;
            //        vsp_categorias.ActiveSheet.Columns[vsp_categorias.ActiveSheet.Columns.Count - 1].CellType = chk;



            //        vsp_subcategorias.ActiveSheet.ColumnCount = vsp_subcategorias.ActiveSheet.ColumnCount + 1;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;


            //        vsp_subcategorias.ActiveSheet.ColumnCount = vsp_subcategorias.ActiveSheet.ColumnCount + 1;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_subcategorias.ActiveSheet.ColumnCount = vsp_subcategorias.ActiveSheet.ColumnCount + 1;
            //        vsp_subcategorias.ActiveSheet.Columns[vsp_subcategorias.ActiveSheet.Columns.Count - 1].CellType = chk;



            //        vsp_productos.ActiveSheet.ColumnCount = vsp_productos.ActiveSheet.ColumnCount + 1;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;

            //        vsp_productos.ActiveSheet.ColumnCount = vsp_productos.ActiveSheet.ColumnCount + 1;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_productos.ActiveSheet.ColumnCount = vsp_productos.ActiveSheet.ColumnCount + 1;
            //        vsp_productos.ActiveSheet.Columns[vsp_productos.ActiveSheet.Columns.Count - 1].CellType = chk;



            //        vsp_listaprecio.ActiveSheet.ColumnCount = vsp_listaprecio.ActiveSheet.ColumnCount + 1;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;

            //        vsp_listaprecio.ActiveSheet.ColumnCount = vsp_listaprecio.ActiveSheet.ColumnCount + 1;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_listaprecio.ActiveSheet.ColumnCount = vsp_listaprecio.ActiveSheet.ColumnCount + 1;
            //        vsp_listaprecio.ActiveSheet.Columns[vsp_listaprecio.ActiveSheet.Columns.Count - 1].CellType = chk;



            //        vsp_precios.ActiveSheet.ColumnCount = vsp_precios.ActiveSheet.ColumnCount + 1;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;



            //        vsp_precios.ActiveSheet.ColumnCount = vsp_precios.ActiveSheet.ColumnCount + 1;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_precios.ActiveSheet.ColumnCount = vsp_precios.ActiveSheet.ColumnCount + 1;
            //        vsp_precios.ActiveSheet.Columns[vsp_precios.ActiveSheet.Columns.Count - 1].CellType = chk;


            //        vsp_estados.ActiveSheet.ColumnCount = vsp_estados.ActiveSheet.ColumnCount + 1;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;



            //        vsp_estados.ActiveSheet.ColumnCount = vsp_estados.ActiveSheet.ColumnCount + 1;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_estados.ActiveSheet.ColumnCount = vsp_estados.ActiveSheet.ColumnCount + 1;
            //        vsp_estados.ActiveSheet.Columns[vsp_estados.ActiveSheet.Columns.Count - 1].CellType = chk;



            //        vsp_departamentos.ActiveSheet.ColumnCount = vsp_departamentos.ActiveSheet.ColumnCount + 1;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;

            //        vsp_departamentos.ActiveSheet.ColumnCount = vsp_departamentos.ActiveSheet.ColumnCount + 1;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_departamentos.ActiveSheet.ColumnCount = vsp_departamentos.ActiveSheet.ColumnCount + 1;
            //        vsp_departamentos.ActiveSheet.Columns[vsp_departamentos.ActiveSheet.Columns.Count - 1].CellType = chk;




            //        vsp_fpagos.ActiveSheet.ColumnCount = vsp_fpagos.ActiveSheet.ColumnCount + 1;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].CellType = dt;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].Label = "Fecha Hora";
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].AllowAutoFilter = true;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].AllowAutoSort = true;


            //        vsp_fpagos.ActiveSheet.ColumnCount = vsp_fpagos.ActiveSheet.ColumnCount + 1;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].CellType = tx;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].Label = "Usuario";

            //        vsp_fpagos.ActiveSheet.ColumnCount = vsp_fpagos.ActiveSheet.ColumnCount + 1;
            //        vsp_fpagos.ActiveSheet.Columns[vsp_fpagos.ActiveSheet.Columns.Count - 1].CellType = chk;


              

            //    }

            //}

            WsqlE = "Exec App_Pcg_ExtraeCatalogos 1,'','','' ";
            if (Utilities.ObtenerDatos(Conecta, DTG_IMG, WsqlE, true))
            {
                if (DTG_IMG.Tables[0].Rows.Count > 0)
                {

                    vsp_categoria_img.ActiveSheet.Rows.Count = 0;



                    if (DTG_IMG.Tables[0].Rows.Count > 0)
                    {
                        vsp_categoria_img.ActiveSheet.Rows.Count = DTG_IMG.Tables[0].Rows.Count;

                        for (int k = 0; k <= DTG_IMG.Tables[0].Rows.Count - 1; k++)
                        {

                            vsp_categoria_img.ActiveSheet.Cells[k, 0].Text = DTG_IMG.Tables[0].Rows[k]["CodGrupo"].ToString().Trim();
                            vsp_categoria_img.ActiveSheet.Cells[k, 0].Tag = DTG_IMG.Tables[0].Rows[k]["ImgB64"].ToString();
                            vsp_categoria_img.ActiveSheet.Cells[k, 1].Tag = DTG_IMG.Tables[0].Rows[k]["Color"].ToString().Trim();
                            vsp_categoria_img.ActiveSheet.Cells[k, 1].Text = DTG_IMG.Tables[0].Rows[k]["Grupo"].ToString().Trim();
                            vsp_categoria_img.ActiveSheet.Cells[k, 2].Value = DTG_IMG.Tables[0].Rows[k]["Imagen"];
                            vsp_categoria_img.ActiveSheet.Cells[k, 2].Locked = true;

                            //vsp_categorias.ActiveSheet.Cells[k, 1].BackColor =Color.FromArgb( Hexa_a_Color( DTG.Tables[9].Rows[k]["Color"].ToString()));
                            vsp_categoria_img.ActiveSheet.Cells[k, 1].BackColor = Hexa_a_Color(DTG_IMG.Tables[0].Rows[k]["Color"].ToString());
                        }


                    }



                    vsp_subcategoria_img.ActiveSheet.Rows.Count = 0;
                    if (DTG_IMG.Tables[1].Rows.Count > 0)
                    {
                        vsp_subcategoria_img.ActiveSheet.Rows.Count = DTG_IMG.Tables[1].Rows.Count;



                        for (int k = 0; k <= DTG_IMG.Tables[1].Rows.Count - 1; k++)
                        {

                            vsp_subcategoria_img.ActiveSheet.Cells[k, 0].Text = DTG_IMG.Tables[1].Rows[k]["Categoria"].ToString().Trim();
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 0].Tag = DTG_IMG.Tables[1].Rows[k]["ImgB64"].ToString();
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 1].Tag = DTG_IMG.Tables[1].Rows[k]["Color"].ToString();
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 1].Text = DTG_IMG.Tables[1].Rows[k]["CodSubGrupo"].ToString().Trim();
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 2].Text = DTG_IMG.Tables[1].Rows[k]["SubCategoria"].ToString().Trim();
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 3].Value = DTG_IMG.Tables[1].Rows[k]["Imagen"];
                            vsp_subcategoria_img.ActiveSheet.Cells[k, 3].Locked = true;

                            vsp_subcategoria_img.ActiveSheet.Cells[k, 2].BackColor = Hexa_a_Color(DTG_IMG.Tables[1].Rows[k]["Color"].ToString());
                            //vsp_subcategoria_img.ActiveSheet.Cells[k, 2].BackColor =Color.FromArgb( Hexa_a_Color(DTG.Tables[10].Rows[k]["Color"].ToString()));
                        }


                    }

                    vsp_productos_img.ActiveSheet.Rows.Count = 0;
                    if (DTG_IMG.Tables[2].Rows.Count > 0)
                    {
                        vsp_productos_img.ActiveSheet.Rows.Count = DTG_IMG.Tables[2].Rows.Count;

                        for (int k = 0; k <= DTG_IMG.Tables[2].Rows.Count - 1; k++)
                        {

                            vsp_productos_img.ActiveSheet.Cells[k, 0].Text = DTG_IMG.Tables[2].Rows[k]["Categoria"].ToString().Trim();
                            vsp_productos_img.ActiveSheet.Cells[k, 0].Tag = DTG_IMG.Tables[2].Rows[k]["ImgB64"].ToString();
                            vsp_productos_img.ActiveSheet.Cells[k, 1].Text = DTG_IMG.Tables[2].Rows[k]["SubCategoria"].ToString().Trim();
                            vsp_productos_img.ActiveSheet.Cells[k, 1].Tag = DTG_IMG.Tables[2].Rows[k]["ImgB64_2"].ToString();
                            vsp_productos_img.ActiveSheet.Cells[k, 2].Text = DTG_IMG.Tables[2].Rows[k]["CodProducto"].ToString().Trim();
                            vsp_productos_img.ActiveSheet.Cells[k, 3].Text = DTG_IMG.Tables[2].Rows[k]["Descripcion"].ToString().Trim();
                            vsp_productos_img.ActiveSheet.Cells[k, 4].Value = DTG_IMG.Tables[2].Rows[k]["Imagen"];
                            vsp_productos_img.ActiveSheet.Cells[k, 4].Locked = true;
                            vsp_productos_img.ActiveSheet.Cells[k, 5].Value = DTG_IMG.Tables[2].Rows[k]["Imagen2"];
                            vsp_productos_img.ActiveSheet.Cells[k, 5].Locked = true;

                        }


                    }


                }

            }

            Tab_Catalogos.Visible =true;
             //DTG.Dispose();
            DTG_IMG.Dispose();
            //FreeMemory.FlushMemory();
            GC.Collect();
        }

        public Color Hexa_a_Color(String Hexa)
        {
            Color color;
            string colornombre = "White";
            int ARB = 0;

            color = Color.White;
            color = System.Drawing.ColorTranslator.FromHtml(Hexa);
            colornombre= System.Drawing.ColorTranslator.FromHtml(Hexa).Name;
            //ARB = System.Drawing.ColorTranslator.FromHtml(Hexa).ToArgb();


            return color;
        }

     
 

        private void Frm_SincroCatalogos_Load(object sender, EventArgs e)
        {

            //vsp_umedida.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_umedida.BackColor = Color.White;
            //vsp_umedida.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_umedida.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_umedida.ActiveSheet.ColumnCount = 0;
            //vsp_umedida.ActiveSheet.RowCount = 0;

            lblpaleta.Visible = true;
            lblColor.Visible = true;
            Color_Edit.Visible = true;

            Image imgd = null;

            try
            {
                imgd = Image.FromFile(Application.StartupPath + "\\" + "LogoAgua.png");
            }
            catch (Exception ex) {
            }
          
            vsp_umedida.BackgroundImage = imgd;

            vsp_umedida.BackgroundImageLayout = ImageLayout.Stretch;
            //vsp_umedida.SetInsertSheetImage(imgd);




            //vsp_categorias.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_categorias.BackColor = Color.White;
            //vsp_categorias.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_categorias.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_categorias.ActiveSheet.ColumnCount = 0;
            //vsp_categorias.ActiveSheet.RowCount = 0;

            //vsp_categorias.BackgroundImage = imgd;
            //vsp_categorias.BackgroundImageLayout = ImageLayout.Stretch;


            //vsp_subcategorias.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_subcategorias.BackColor = Color.White;
            //vsp_subcategorias.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_subcategorias.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_subcategorias.ActiveSheet.ColumnCount = 0;
            //vsp_subcategorias.ActiveSheet.RowCount = 0;


            //vsp_subcategorias.BackgroundImage = imgd;
            //vsp_subcategorias.BackgroundImageLayout = ImageLayout.Stretch;


            //vsp_productos.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_productos.BackColor = Color.White;
            //vsp_productos.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_productos.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_productos.ActiveSheet.ColumnCount = 0;
            //vsp_productos.ActiveSheet.RowCount = 0;

            //vsp_productos.BackgroundImage = imgd;
            //vsp_productos.BackgroundImageLayout = ImageLayout.Stretch;

            //vsp_listaprecio.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_listaprecio.BackColor = Color.White;
            //vsp_listaprecio.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_listaprecio.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_listaprecio.ActiveSheet.ColumnCount = 0;
            //vsp_listaprecio.ActiveSheet.RowCount = 0;

            //vsp_listaprecio.BackgroundImage = imgd;
            //vsp_listaprecio.BackgroundImageLayout = ImageLayout.Stretch;


            //vsp_precios.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_precios.BackColor = Color.White;
            //vsp_precios.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_precios.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_precios.ActiveSheet.ColumnCount = 0;
            //vsp_precios.ActiveSheet.RowCount = 0;

            //vsp_precios.BackgroundImage = imgd;
            //vsp_precios.BackgroundImageLayout = ImageLayout.Stretch;

            //vsp_estados.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_estados.BackColor = Color.White;
            //vsp_estados.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_estados.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_estados.ActiveSheet.ColumnCount = 0;
            //vsp_estados.ActiveSheet.RowCount = 0;

            //vsp_estados.BackgroundImage = imgd;
            //vsp_estados.BackgroundImageLayout = ImageLayout.Stretch;

            //vsp_departamentos.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_departamentos.BackColor = Color.White;
            //vsp_departamentos.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_departamentos.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_departamentos.ActiveSheet.ColumnCount = 0;
            //vsp_departamentos.ActiveSheet.RowCount = 0;

            //vsp_departamentos.BackgroundImage = imgd;
            //vsp_departamentos.BackgroundImageLayout = ImageLayout.Stretch;


            //vsp_fpagos.ActiveSheet.GrayAreaBackColor = Color.White;
            //vsp_fpagos.BackColor = Color.White;
            //vsp_fpagos.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            //vsp_fpagos.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_fpagos.ActiveSheet.ColumnCount = 0;
            //vsp_fpagos.ActiveSheet.RowCount = 0;

            //vsp_fpagos.BackgroundImage = imgd;
            //vsp_fpagos.BackgroundImageLayout = ImageLayout.Stretch;


            vsp_categoria_img.ActiveSheet.GrayAreaBackColor = Color.White;
            vsp_categoria_img.BackColor = Color.White;
            vsp_categoria_img.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            vsp_categoria_img.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_categoria_img.ActiveSheet.ColumnCount = 0;
            vsp_categoria_img.ActiveSheet.RowCount = 0;

            vsp_categoria_img.BackgroundImage = imgd;
            vsp_categoria_img.BackgroundImageLayout = ImageLayout.Stretch;


            vsp_subcategoria_img.ActiveSheet.GrayAreaBackColor = Color.White;
            vsp_subcategoria_img.BackColor = Color.White;
            vsp_subcategoria_img.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            vsp_subcategoria_img.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_subcategoria_img.ActiveSheet.ColumnCount = 0;
            vsp_subcategoria_img.ActiveSheet.RowCount = 0;

            vsp_subcategoria_img.BackgroundImage = imgd;
            vsp_subcategoria_img.BackgroundImageLayout = ImageLayout.Stretch;


            vsp_productos_img.ActiveSheet.GrayAreaBackColor = Color.White;
            vsp_productos_img.BackColor = Color.White;
            vsp_productos_img.ActiveSheet.DefaultStyle.BackColor = Color.Transparent;
            vsp_productos_img.ActiveSheet.OperationMode = FarPoint.Win.Spread.OperationMode.RowMode;
            //vsp_productos_img.ActiveSheet.ColumnCount = 0;
            vsp_productos_img.ActiveSheet.RowCount = 0;

            vsp_productos_img.BackgroundImage = imgd;
            vsp_productos_img.BackgroundImageLayout = ImageLayout.Stretch;


            vsp_productos_img.ActiveSheet.FrozenTrailingColumnCount = 3;

            //cadena = "Data Source=DEVBRYAN\\DEVBRYAN;User ID=SUPER_PCG ;Password=pcg270282;Persist Security Info=True;Initial Catalog=PCG_WEB";
            //DataSet dset = new DataSet();

            string MiArchivo = "", P_NombreServidor="", P_NomBaseDato="",P_Usuario="",P_Contraseña="";
            //MiArchivo = FileSystem.Dir(Application.StartupPath + @"\\Tele.dat");
            //if (Strings.UCase(MiArchivo) == Strings.UCase("Tele.dat"))
            //{
            //    try
            //    {
            //        dset.ReadXml(Application.StartupPath + @"\\Tele.dat");
            //        try
            //        {
            //            P_NomBaseDato = dset.Tables["TU"].Rows[0]["BD"].ToString();
            //            P_NombreServidor = dset.Tables["TU"].Rows[0]["S"].ToString();
            //            P_Usuario = dset.Tables["TU"].Rows[0]["US"].ToString();
            //            P_Contraseña = dset.Tables["TU"].Rows[0]["CS"].ToString();
            //        }
            //        catch (Exception ex)
            //        {

            //        }
            //    }
            //    catch (Exception ex)
            //    {

            //    }
            //}


            Tab_Umedida.Parent = null;
            Tab_Categorias.Parent = null;
            Tab_SubCategorias.Parent = null;
            Tab_Productos.Parent = null;
            Tab_ListaP.Parent = null;
            Tab_Precios.Parent = null;
            Tab_Estados.Parent = null;
            Tab_Departamentos.Parent = null;
            Tab_FPagos.Parent = null;
            Tab_Img.Parent = Tab_Catalogos;



            //cadena= "Data Source="+ VGlobales.P_NombreServidor.ToString() +";User ID="+ VGlobales.P_Usuario.ToString() + " ;Password="+ VGlobales.P_Contraseña.ToString() + ";Persist Security Info=True;Initial Catalog="+ VGlobales.P_NomBaseDato.ToString() + "";


            DataTable dnt_ftp = new DataTable();

            //Conecta = VGlobales.ConectaT;

            //try
            //{

            //    Conecta.Open();
            //    Conecta.Close();
            //}
            //catch (Exception ex)
            //{

            //    MessageBox.Show("Revise los parametros de Conexion 'Tele.dat'", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //    Conecta.Close();
            //    Environment.Exit(0);


            //}


            WsqlE = "select * from Tab_Config_FTP ";

           if( Utilities.ObtenerDatos(Conecta, dnt_ftp, WsqlE, true)){

                VGlobales.Server_FTP = dnt_ftp.Rows[0]["Servidor"].ToString().Trim();
                VGlobales.Usuario_FTP = dnt_ftp.Rows[0]["Usuario"].ToString().Trim();
                VGlobales.Contraseña_FTP = dnt_ftp.Rows[0]["Contraseña"].ToString().Trim();
                VGlobales.SubDirectorio_FTP = dnt_ftp.Rows[0]["SubDirectorio"].ToString().Trim();

                VGlobales.Dominio_FTP = dnt_ftp.Rows[0]["Dominio"].ToString().Trim();

                lbl_server.Text = "Server FTP: " + VGlobales.Server_FTP;
                lbl_directorio.Text = "Directorio FTP: " + VGlobales.SubDirectorio_FTP + "/Categorias";


                Server_FTP = dnt_ftp.Rows[0]["Servidor"].ToString().Trim();
               Usuario_FTP = dnt_ftp.Rows[0]["Usuario"].ToString().Trim();
               Contraseña_FTP = dnt_ftp.Rows[0]["Contraseña"].ToString().Trim();
              SubDirectorio_FTP = dnt_ftp.Rows[0]["SubDirectorio"].ToString().Trim();

              Dominio_FTP = dnt_ftp.Rows[0]["Dominio"].ToString().Trim();
            }

            GC.Collect();


            lblUltimaA.Text = md.ExtraeLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), "");


            this.WindowState = FormWindowState.Maximized;

        }

        private void Btn_Test_Click(object sender, EventArgs e)
        {
            Conexion_Mysql.Conexion_My("", "T");
        }

        private void Btn_Sincroniza_Click(object sender, EventArgs e)
        {


            var Loading = new PCGUtility.Preload();
            object[] param = null;
            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Sincroniza_Datos", CallType.Method, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Datos");


         

        }

        //public Image Redimensionar(Image imagen, int ancho, int alto)
        //{
        //    if (imagen.Width > imagen.Height)
        //    {
        //        alto = imagen.Height * ancho / imagen.Width;
        //    }
        //    else
        //    {
        //        ancho = imagen.Width * alto / imagen.Height;
        //    }

        //    var imagenPhoto = imagen;
        //    var bmPhoto = new Bitmap(ancho, alto, PixelFormat.Format24bppRgb);
        //    //bmPhoto.SetResolution(72, 72);
        //    Graphics grPhoto = Graphics.FromImage(bmPhoto);
        //    grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
        //    grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
        //    grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
        //    grPhoto.DrawImage(imagenPhoto, new Rectangle(0, 0, ancho, alto), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel);
        //    var mm = new MemoryStream();
        //    bmPhoto.Save(mm, System.Drawing.Imaging.ImageFormat.Png);
        //    imagen.Dispose();
        //    imagenPhoto.Dispose();
        //    bmPhoto.Dispose();
        //    grPhoto.Dispose();
        //    //mm.Dispose();
        //    return ByteArrayToImage(mm.GetBuffer());
        //}

        //public Image ByteArrayToImage(byte[] arregloDeBytes)
        //{
        //    var ms = new MemoryStream(arregloDeBytes);
        //    Image imagen = Image.FromStream(ms);
        //    return imagen;
        //}


      


        public void Sincroniza_Datos()
        {
            string banderax = "C";
            if (Rbtn_Insertar.Checked)
            {
                banderax = "C";
            }
            else if (Rbtn_Actualizar.Checked)
            {
                banderax = "U";
            }
            else
            {
                banderax = "D";
            }


            Conexion_Mysql.Conexion_My("", "");

            if (Tab_Catalogos.SelectedIndex == 0)
            {

                //--Unidades de Medida.
                if (HayMarcados(vsp_umedida))
                {
                    DataTable dtn_umedida = new DataTable();

                    for (int j = 0; j <= vsp_umedida.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Umedida('" + vsp_umedida.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_umedida.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_umedida.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_umedida.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_umedida.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + vsp_umedida.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_umedida, WsqlE_My);

                            if (dtn_umedida.Rows.Count > 0)
                            {
                                //MessageBox.Show( "Unidad de Medida ("+ vsp_umedida.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_umedida.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_umedida.ActiveSheet.SetActiveCell(j, vsp_umedida.ActiveSheet.Columns.Count - 2);
                            }
                            else
                            {
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_umedida.ActiveSheet.Cells[j, vsp_umedida.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                vsp_umedida.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_umedida.ActiveSheet.SetActiveCell(j, vsp_umedida.ActiveSheet.Columns.Count - 2);
                                //MessageBox.Show("La Unidad de Medida ("+ vsp_umedida.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }


            }

            if (Tab_Catalogos.SelectedIndex == 1)
            {

                //--Categorias.
                if (HayMarcados(vsp_categorias))
                {
                    DataTable dtn_categorias = new DataTable();

                    for (int j = 0; j <= vsp_categorias.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Categorias('" + vsp_categorias.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_categorias.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_categorias.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_categorias.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "','" + vsp_categorias.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_categorias.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_categorias, WsqlE_My);

                            if (dtn_categorias.Rows.Count > 0)
                            {

                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_categorias.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_categorias.ActiveSheet.SetActiveCell(j, vsp_categorias.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                vsp_categorias.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_categorias.ActiveSheet.SetActiveCell(j, vsp_categorias.ActiveSheet.Columns.Count - 2);

                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_categorias.ActiveSheet.Cells[j, vsp_categorias.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }


            if (Tab_Catalogos.SelectedIndex == 2)
            {

                //--SubCategorias.
                if (HayMarcados(vsp_subcategorias))
                {
                    DataTable dtn_subcategorias = new DataTable();

                    for (int j = 0; j <= vsp_subcategorias.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_SubCategorias('" + vsp_subcategorias.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_subcategorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_subcategorias.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_subcategorias.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_subcategorias.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "','" + vsp_subcategorias.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_subcategorias.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_subcategorias, WsqlE_My);

                            if (dtn_subcategorias.Rows.Count > 0)
                            {
                                //MessageBox.Show("SubCategoria (" + vsp_subcategorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_subcategorias.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_subcategorias.ActiveSheet.SetActiveCell(j, vsp_subcategorias.ActiveSheet.Columns.Count - 2);
                            }
                            else
                            {
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_subcategorias.ActiveSheet.Cells[j, vsp_subcategorias.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                vsp_subcategorias.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_subcategorias.ActiveSheet.SetActiveCell(j, vsp_subcategorias.ActiveSheet.Columns.Count - 2);

                            }

                        }
                    }

                }

            }


            if (Tab_Catalogos.SelectedIndex == 3)
            {

                //--Productos.
                if (HayMarcados(vsp_productos))
                {
                    DataTable dtn_productos = new DataTable();

                    for (int j = 0; j <= vsp_productos.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Productos('" + vsp_productos.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_productos.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_productos.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 7].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 8].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 9].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 11].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 12].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 13].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 14].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 15].Text.ToString().Trim() + "','" + vsp_productos.ActiveSheet.Cells[j, 16].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_productos, WsqlE_My);

                            if (dtn_productos.Rows.Count > 0)
                            {
                                //MessageBox.Show("Producto (" + vsp_productos.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_productos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_productos.ActiveSheet.SetActiveCell(j, vsp_productos.ActiveSheet.Columns.Count - 2);
                            }
                            else
                            {
                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_productos.ActiveSheet.Cells[j, vsp_productos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;


                                vsp_productos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_productos.ActiveSheet.SetActiveCell(j, vsp_productos.ActiveSheet.Columns.Count - 2);
                            }

                        }
                    }

                }

            }

            if (Tab_Catalogos.SelectedIndex == 4)
            {

                //--ListaPrecios.
                if (HayMarcados(vsp_listaprecio))
                {
                    DataTable dtn_listaprecios = new DataTable();

                    for (int j = 0; j <= vsp_listaprecio.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_ListaPrecios('" + vsp_listaprecio.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_listaprecio.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_listaprecio.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_listaprecio.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_listaprecio.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "','" + vsp_listaprecio.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_listaprecios, WsqlE_My);

                            if (dtn_listaprecios.Rows.Count > 0)
                            {

                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_listaprecio.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_listaprecio.ActiveSheet.SetActiveCell(j, vsp_listaprecio.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                vsp_listaprecio.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_listaprecio.ActiveSheet.SetActiveCell(j, vsp_listaprecio.ActiveSheet.Columns.Count - 2);

                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_listaprecio.ActiveSheet.Cells[j, vsp_listaprecio.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }

            if (Tab_Catalogos.SelectedIndex == 5)
            {

                //--Precios.
                if (HayMarcados(vsp_precios))
                {
                    DataTable dtn_precios = new DataTable();

                    for (int j = 0; j <= vsp_precios.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Det_ListaPrecio('" + vsp_precios.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_precios.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "'," + Double.Parse(vsp_precios.ActiveSheet.Cells[j, 2].Text).ToString("######0.00") + ", '" + vsp_precios.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_precios.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_precios.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "'," + vsp_precios.ActiveSheet.Cells[j, 7].Text.ToString().Trim() + ",'" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_precios, WsqlE_My);

                            if (dtn_precios.Rows.Count > 0)
                            {

                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;


                                vsp_precios.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_precios.ActiveSheet.SetActiveCell(j, vsp_precios.ActiveSheet.Columns.Count - 2);
                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_precios.ActiveSheet.Cells[j, vsp_precios.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                vsp_precios.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_precios.ActiveSheet.SetActiveCell(j, vsp_precios.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }


            if (Tab_Catalogos.SelectedIndex == 6)
            {

                //--Estados.
                if (HayMarcados(vsp_estados))
                {
                    DataTable dtn_estados = new DataTable();

                    for (int j = 0; j <= vsp_estados.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Estados(" + vsp_estados.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + ", '" + vsp_estados.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_estados.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_estados.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_estados.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "'," + vsp_estados.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + ",'" + vsp_estados.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + vsp_estados.ActiveSheet.Cells[j, 7].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_estados, WsqlE_My);

                            if (dtn_estados.Rows.Count > 0)
                            {

                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;


                                vsp_estados.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_estados.ActiveSheet.SetActiveCell(j, vsp_estados.ActiveSheet.Columns.Count - 2);
                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {
                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_estados.ActiveSheet.Cells[j, vsp_estados.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;


                                vsp_estados.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_estados.ActiveSheet.SetActiveCell(j, vsp_estados.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }


            if (Tab_Catalogos.SelectedIndex == 7)
            {

                //--Departamentos.
                if (HayMarcados(vsp_departamentos))
                {
                    DataTable dtn_departamentos = new DataTable();

                    for (int j = 0; j <= vsp_departamentos.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Cat_Departamento('" + vsp_departamentos.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_departamentos.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_departamentos.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_departamentos.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_departamentos.ActiveSheet.Cells[j, 5].Text.ToString().Trim() + "','" + vsp_departamentos.ActiveSheet.Cells[j, 6].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_departamentos, WsqlE_My);

                            if (dtn_departamentos.Rows.Count > 0)
                            {

                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_departamentos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_departamentos.ActiveSheet.SetActiveCell(j, vsp_departamentos.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                vsp_departamentos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_departamentos.ActiveSheet.SetActiveCell(j, vsp_departamentos.ActiveSheet.Columns.Count - 2);

                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_departamentos.ActiveSheet.Cells[j, vsp_departamentos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }


            if (Tab_Catalogos.SelectedIndex == 8)
            {

                //--Departamentos.
                if (HayMarcados(vsp_fpagos))
                {
                    DataTable dtn_fpagos = new DataTable();

                    for (int j = 0; j <= vsp_fpagos.ActiveSheet.RowCount - 1; j++)
                    {


                        if (vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 1].Text == "True")
                        {
                            WsqlE_My = " call App_Pcg_CRUD_Divisas_Pagos('" + vsp_fpagos.ActiveSheet.Cells[j, 0].Text.ToString().Trim() + "', '" + vsp_fpagos.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + "','" + vsp_fpagos.ActiveSheet.Cells[j, 2].Text.ToString().Trim() + "', '" + vsp_fpagos.ActiveSheet.Cells[j, 3].Text.ToString().Trim() + "','" + vsp_fpagos.ActiveSheet.Cells[j, 4].Text.ToString().Trim() + "','" + banderax + "');";

                            Conexion_Mysql.LlenarTabla_Mysql(ref dtn_fpagos, WsqlE_My);

                            if (dtn_fpagos.Rows.Count > 0)
                            {

                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 3].Text = DateTime.Now.ToString();
                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 2].Text = "Usuario";
                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightGreen;
                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightGreen;

                                vsp_fpagos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_fpagos.ActiveSheet.SetActiveCell(j, vsp_fpagos.ActiveSheet.Columns.Count - 2);

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") Sincronzada Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }
                            else
                            {

                                vsp_fpagos.ShowCell(0, 0, j, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp_fpagos.ActiveSheet.SetActiveCell(j, vsp_fpagos.ActiveSheet.Columns.Count - 2);

                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 3].BackColor = Color.LightPink;
                                vsp_fpagos.ActiveSheet.Cells[j, vsp_fpagos.ActiveSheet.Columns.Count - 2].BackColor = Color.LightPink;

                                //MessageBox.Show("Categoria (" + vsp_categorias.ActiveSheet.Cells[j, 1].Text.ToString().Trim() + ") No fue Sincronizada", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            }

                        }
                    }

                }

            }
        }

        public bool HayMarcados(FarPoint.Win.Spread.FpSpread vsp)
        {
            int can = 0;
            bool marcados = false;

            for (int k = 0; k <= vsp.ActiveSheet.RowCount - 1; k++)
            {
                if (vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - 1].Text=="True")
                {
                    marcados = true;
                    break;
                }
            }

            return marcados;
        }

        private void Chk_Marcar_CheckedChanged(object sender, EventArgs e)
        {
            bool val = false;
            if (Chk_Marcar.Checked)
            {
                val = true;
                Chk_Marcar.Text = "Desmarcar Todos";
            }else
            {
                Chk_Marcar.Text = "Marcar Todos";
            }

            if (Tab_Catalogos.SelectedIndex == 0)
            {
                switch (Tab_Imagenes.SelectedIndex)
                {
                    case 0:
                        MarcarChecks(vsp_categoria_img, val);
                        break;
                    case 1:
                        MarcarChecks(vsp_subcategoria_img, val);
                        break;
                    case 2:
                        MarcarChecks(vsp_productos_img, val);
                        break;

                }
            }
            else
            {

                switch (Tab_Catalogos.SelectedIndex)
                {
                    case 0:
                        MarcarChecks(vsp_umedida, val);
                        break;
                    case 1:
                        MarcarChecks(vsp_categorias, val);
                        break;
                    case 2:
                        MarcarChecks(vsp_subcategorias, val);
                        break;
                    case 3:
                        MarcarChecks(vsp_productos, val);
                        break;
                    case 4:
                        MarcarChecks(vsp_listaprecio, val);
                        break;
                    case 5:
                        MarcarChecks(vsp_precios, val);
                        break;
                    case 6:
                        MarcarChecks(vsp_estados, val);
                        break;
                    case 7:
                        MarcarChecks(vsp_departamentos, val);
                        break;
                    case 8:
                        MarcarChecks(vsp_fpagos, val);
                        break;

                }

            }



        }

        public void MarcarChecks(FarPoint.Win.Spread.FpSpread vsp,bool value)
        {

            for(int h=0;h <= vsp.ActiveSheet.RowCount - 1; h++)
            {
                if (vsp.ActiveSheet.Rows[h].Visible)
                {
                    vsp.ActiveSheet.Cells[h, vsp.ActiveSheet.ColumnCount - 1].Value = value;
                }
              
            }

        }

        private void tabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            btn_testftp.Text = "Sincronizar Img. " + Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString();

            Chk_Marcar.Checked = false;

            lbl_directorio.Text = "Directorio FTP: " + SubDirectorio_FTP + "/"+ Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(); 

            if( Tab_Imagenes.SelectedIndex==0 || Tab_Imagenes.SelectedIndex == 1){

                lblpaleta.Visible = true;
                lblColor.Visible = true;
                Color_Edit.Visible = true;
            }
            else
            {

                lblpaleta.Visible = false;
                lblColor.Visible = false;
                Color_Edit.Visible = false;
            }

            lblUltimaA.Text = md.ExtraeLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), "");
                
        }

        private void button1_Click(object sender, EventArgs e)
        {
            vsp_categoria_img.SearchWithDialog("");
        }

        private void vsp_categoria_img_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {

            string hayImagen = "N";
            string urlImagen = "";
            int ancho=0, alto=0;
            string tempo = "";
            Image imageFile;
            //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
            string base64ImageRepresentation = "";
            if (e.Column == 5)
            {
                
                var openDlg = new OpenFileDialog();
               // openDlg.Filter = "Imágenes JPG(*.jpg)|*.jpg|Imágenes PNG(*.png)|*.png|Todos los formatos (*.*)|*.*";
                openDlg.Filter = "All png files|*.png";
            
                openDlg.InitialDirectory = Environment.CurrentDirectory;
                string filter = openDlg.Filter;
                openDlg.Title = "Open a Bitmap File";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    urlImagen = openDlg.FileName;


                    if(VGlobales.ancho_c > 0 && VGlobales.alto_c > 0)
                    {

                        if (VGlobales.ACategoria)
                        {
                            imageFile = Image.FromFile(urlImagen);
                            base64ImageRepresentation = md.ConvertImageToBase64(md.Redimensionar(imageFile, VGlobales.ancho_c, VGlobales.alto_c));
                        }
                        else
                        {
                            if (Tamaño_ValidoImg("C", urlImagen, 1, ref ancho, ref alto) == false)
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



                    }else
                    {
                        byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                        base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    }

                    pb_categorias.ImageLocation = urlImagen;
                    hayImagen = "S";
                }
                else
                {
                    hayImagen = "N";
                    //Environment.Exit(0);
                } /* TODO ERROR: Skipped SkippedTokensTrivia */

                if (urlImagen != "")
                {
                    
                    //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                    //string base64ImageRepresentation = Convert.ToBase64String(imageArray);
                    txtpath.Text = urlImagen;


                    if(MessageBox.Show("Esta seguro de Hacer el cambio de Imagen?", "Opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WsqlE = " Update Grupos_Img set ImgB64='" + base64ImageRepresentation + "' where CodGrupo='" + vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Text.ToString().Trim() + "'";

                        WsqlE += "  Update Grupos set Img_Path='" + urlImagen + "' where CodGrupo='" + vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Text.ToString().Trim() + "'";

                        //Conecta = VGlobales.ConectaT;
                        if (Utilities.Execute(Conecta, WsqlE, true))
                        {
                            vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Tag= base64ImageRepresentation;
                            vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 2].Value = true;
                            MessageBox.Show("Imagen Actualizada , Sastifactoriamente" ,"Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            
                        }

                    }

                }
               
            }






            }

        public bool Tamaño_ValidoImg(string tipo,string filepath,int indiceImg,ref  int anchoimg, ref int altoimg)
        {
            bool valido = false;
            Image imageFile;
            imageFile = Image.FromFile(filepath);

            anchoimg = imageFile.Width;
            altoimg = imageFile.Height;

            if (tipo=="C")
            {
                if(imageFile.Width==VGlobales.ancho_c && imageFile.Height == VGlobales.alto_c)
                {
                    valido = true;
                }
            }

            if (tipo == "S")
            {
                if (imageFile.Width == VGlobales.ancho_s && imageFile.Height == VGlobales.alto_s)
                {
                    valido = true;
                }

            }
                

                //object op = "==";


                if (tipo ==  "P" && indiceImg == 1)
            {
                if (imageFile.Width == VGlobales.ancho_p1 && imageFile.Height == VGlobales.alto_p1)
                {
                    valido = true;
                }

            }
            else if (tipo == "P" && indiceImg == 2)
            {
                if (imageFile.Width == VGlobales.ancho_p2 && imageFile.Height == VGlobales.alto_p2)
                {
                    valido = true;
                }
            }
            

            return valido;
        }

        //public  bool Operador(string logica, int x, int y)
        //{
        //    switch (logica)
        //    {
        //        case ">": return x > y;
        //        case "<": return x < y;
        //        case "==": return x == y;
        //        case ">=": return x >= y;
        //        case "<=": return x <= y;
        //        //default: throw new Exception("Operador Invalido");
        //    }
        //}

        private void vsp_categoria_img_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {

        }

        private void vsp_categoria_img_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {

            if (vsp_categoria_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Tag.ToString();


                //string UrlImagen = "";
                //UrlImagen = vsp_categoria_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_categorias.Image = img;
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

        private void button2_Click(object sender, EventArgs e)
        {
            vsp_subcategoria_img.SearchWithDialog("");
        }

        private void vsp_subcategoria_img_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {


            string hayImagen = "N";
            string urlImagen = "";
            int ancho=0, alto=0;
            string tempo = "";
            Image imageFile;
            string base64ImageRepresentation = "";
                
            if (e.Column == 6)
            {

                var openDlg = new OpenFileDialog();
                // openDlg.Filter = "Imágenes JPG(*.jpg)|*.jpg|Imágenes PNG(*.png)|*.png|Todos los formatos (*.*)|*.*";
                openDlg.Filter = "All png files|*.png";
                openDlg.InitialDirectory = Environment.CurrentDirectory;
                string filter = openDlg.Filter;
                openDlg.Title = "Open a Bitmap File";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    urlImagen = openDlg.FileName;


                    if (VGlobales.ancho_s > 0 && VGlobales.alto_s > 0)
                    {
                        if (VGlobales.ASubcategoria)
                        {
                            imageFile = Image.FromFile(urlImagen);
                            base64ImageRepresentation = md.ConvertImageToBase64(md.Redimensionar(imageFile, VGlobales.ancho_s, VGlobales.alto_s));
                        }
                        else
                        {
                            if (Tamaño_ValidoImg("S", urlImagen, 1, ref ancho, ref alto) == false)
                            {
                                MessageBox.Show("Imagen no posee las dimensiones aceptadas (Ancho: " + VGlobales.ancho_s.ToString() + " ; Alto: " + VGlobales.alto_s.ToString() + ")  , Imagen seleccionada (Ancho:" + ancho.ToString() + " ; Alto:" + alto.ToString() + ") ,  Favor revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    

                   
                    pb_subcategoria.ImageLocation = urlImagen;
                    hayImagen = "S";
                }
                else
                {
                    hayImagen = "N";
                    //Environment.Exit(0);
                } /* TODO ERROR: Skipped SkippedTokensTrivia */

                if (urlImagen != "")
                {
                    //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                    //string base64ImageRepresentation = Convert.ToBase64String(imageArray);


                    if (MessageBox.Show("Esta seguro de Hacer el cambio de Imagen?", "Opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        WsqlE = " Update Cat_Grupo_Img set ImgB64='" + base64ImageRepresentation + "' where CodSubGrupo='" + vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 1].Text.ToString().Trim() + "'";

                        WsqlE += "  Update Cat_Grupo set Img_Path='" + urlImagen + "' where Codigo='" + vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 1].Text.ToString().Trim() + "'";

                        //Conecta = sqlc.Conexion();
                        if (Utilities.Execute(Conecta, WsqlE, true))
                        {
                            vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 0].Tag = base64ImageRepresentation;
                            vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 3].Value = true;
                            MessageBox.Show("Imagen Actualizada , Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }

                }

            }





        }

        private void vsp_subcategoria_img_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (vsp_subcategoria_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_subcategoria_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                //string UrlImagen = "";
                //UrlImagen = vsp_subcategoria_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_subcategoria.Image = img;

                    lblancho2.Text = "Ancho: " + img.Width.ToString();
                    lblalto2.Text = "Alto: " + img.Height.ToString();
                    lblpixel2.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                    //    pb_subcategoria.ImageLocation = UrlImagen;
                    //txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_subcategoria.Image = null;
                    lblancho2.Text = "Ancho: ";
                    lblalto2.Text = "Alto: ";
                    lblpixel2.Text = "Pixeles: ";
                }
        }
    }
        

    

        private void vsp_subcategoria_img_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            if (vsp_subcategoria_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 0].Tag.ToString();

                //string UrlImagen = "";
                //UrlImagen = vsp_subcategoria_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_subcategoria.Image = img;

                    lblancho2.Text = "Ancho: " + img.Width.ToString();
                    lblalto2.Text = "Alto: " + img.Height.ToString();
                    lblpixel2.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                    //    pb_subcategoria.ImageLocation = UrlImagen;
                    //txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_subcategoria.Image = null;
                    lblancho2.Text = "Ancho: ";
                    lblalto2.Text = "Alto: ";
                    lblpixel2.Text = "Pixeles: ";
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            vsp_productos_img.SearchWithDialog("");
        }

        private void vsp_productos_img_ButtonClicked(object sender, FarPoint.Win.Spread.EditorNotifyEventArgs e)
        {
            string hayImagen = "N";
            string urlImagen = "";
       
            if (e.Column == 8 || e.Column==9 )
            {

                int col = 0;
                int ancho = 0, alto = 0;
                col = e.Column;
                var openDlg = new OpenFileDialog();
                // openDlg.Filter = "Imágenes JPG(*.jpg)|*.jpg|Imágenes PNG(*.png)|*.png|Todos los formatos (*.*)|*.*";
                openDlg.Filter = "All png files|*.png";
                openDlg.InitialDirectory = Environment.CurrentDirectory;
                string filter = openDlg.Filter;
                openDlg.Title = "Open a Bitmap File";
                string tempo = "";
                Image imageFile;
                //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                string base64ImageRepresentation = "";
                if (openDlg.ShowDialog() == DialogResult.OK)
                {
                    urlImagen = openDlg.FileName;

                    if (col == 8)
                    {
                        if (VGlobales.ancho_p1 > 0 && VGlobales.alto_p1 > 0)
                        {

                            if (VGlobales.AProductos1)
                            {
                                //-- Resize
                                imageFile = Image.FromFile(urlImagen);
                                base64ImageRepresentation = md.ConvertImageToBase64(md.Redimensionar(imageFile, VGlobales.ancho_p1, VGlobales.alto_p1));
                            }
                            else
                            {
                                if (Tamaño_ValidoImg("P", urlImagen, 1, ref ancho, ref alto) == false)
                                {
                                    MessageBox.Show("Imagen no posee las dimensiones aceptadas (Ancho: " + VGlobales.ancho_p1.ToString() + " ; Alto: " + VGlobales.alto_p1.ToString() + ")  , Imagen seleccionada (Ancho:" + ancho.ToString() + " ; Alto:" + alto.ToString() + ") ,  Favor revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                    return;


                                }else
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


                    }

                    if (col == 9)
                    {
                        if (VGlobales.ancho_p2 > 0 && VGlobales.alto_p2 > 0)
                        {

                            if (VGlobales.AProductos2)
                            {
                                //-- Resize
                                imageFile = Image.FromFile(urlImagen);
                                base64ImageRepresentation = md.ConvertImageToBase64(md.Redimensionar(imageFile, VGlobales.ancho_p2, VGlobales.alto_p2));
                            }
                            else
                            {
                                if (Tamaño_ValidoImg("P", urlImagen, 2, ref ancho, ref alto) == false)
                                {
                                    MessageBox.Show("Imagen no posee las dimensiones aceptadas (Ancho: " + VGlobales.ancho_p2.ToString() + " ; Alto: " + VGlobales.alto_p2.ToString() + ")  , Imagen seleccionada (Ancho:" + ancho.ToString() + " ; Alto:" + alto.ToString() + ") ,  Favor revise", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                        
                    }



                    pb_productos.ImageLocation = urlImagen;
                    hayImagen = "S";
                }
                else
                {
                    hayImagen = "N";
                    //Environment.Exit(0);
                } /* TODO ERROR: Skipped SkippedTokensTrivia */

                if (urlImagen != "")
                {

                    
                  
                    //byte[] imageArray = System.IO.File.ReadAllBytes(urlImagen);
                    //string base64ImageRepresentation = Convert.ToBase64String(imageArray);


                    if (MessageBox.Show("Esta seguro de Hacer el cambio de Imagen?", "Opcion", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        //WsqlE = " Update Producto_Img set ImgB64='" + base64ImageRepresentation + "' where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString().Trim() + "'";

                        if (col == 8)
                        {
                            WsqlE = " Update Producto_Img set ImgB64='" + base64ImageRepresentation + "' where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString().Trim() + "'";

                            WsqlE += "  Update Productos set Img_Path='" + urlImagen + "' where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString().Trim() + "'";
                        }
                        else
                        {
                            WsqlE = " Update Producto_Img set ImgB64_2='" + base64ImageRepresentation + "' where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString().Trim() + "'";

                            WsqlE += "  Update Productos set Img_Path2='" + urlImagen + "' where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString().Trim() + "'";
                        }
                     

                        //Conecta = sqlc.Conexion();
                        if (Utilities.Execute(Conecta, WsqlE, true))
                        {
                            if (col == 8)
                            {
                                vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 0].Tag = base64ImageRepresentation;
                                vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 4].Value = true;
                            }
                            else
                            {
                                vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 1].Tag = base64ImageRepresentation;
                                vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 5].Value = true;
                            }
                           
                         
                            MessageBox.Show("Imagen Actualizada , Sastifactoriamente", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        }

                    }

                }

            }
        }

        private void vsp_productos_img_CellClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (vsp_productos_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_productos_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                //string UrlImagen = "";
                //UrlImagen = vsp_productos_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_productos.Image = img;

                    lblancho3.Text = "Ancho: " + img.Width.ToString();
                    lblalto3.Text = "Alto: " + img.Height.ToString();
                    lblpixel3.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                    //pb_productos.ImageLocation = UrlImagen;
                    //txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_productos.Image = null;
                    lblancho3.Text = "Ancho: ";
                    lblalto3.Text = "Alto: ";
                    lblpixel3.Text = "Pixeles: ";
                }

            }
        }

        private void vsp_productos_img_SelectionChanged(object sender, FarPoint.Win.Spread.SelectionChangedEventArgs e)
        {
            if (vsp_productos_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 0].Tag.ToString();

                //string UrlImagen = "";
                //UrlImagen = vsp_productos_img.ActiveSheet.Cells[e.Row, 0].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_productos.Image = img;

                    lblancho3.Text = "Ancho: " + img.Width.ToString();
                    lblalto3.Text = "Alto: " + img.Height.ToString();
                    lblpixel3.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                    //pb_productos.ImageLocation = UrlImagen;
                    //txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_productos.Image = null;
                    lblancho3.Text = "Ancho: ";
                    lblalto3.Text = "Alto: ";
                    lblpixel3.Text = "Pixeles: ";
                }

            }
        }

        private void btn_testftp_Click(object sender, EventArgs e)
        {



            var Loading = new PCGUtility.Preload();
            object[] param = null;
            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Sincroniza_Imagenes", CallType.Method, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Imagenes");


            FreeMemory.FlushMemory();

        }

        public void Sincroniza_Imagenes()
        {

            try
            {

          

            Guid g;
            string nombre_carpeta = "", nombre_archivo = "", path_archivo = "",url_img="",result="",colorHex="";
            int  col_fecha=0, col_user=0,col_cod=0;

            FarPoint.Win.Spread.FpSpread vsp=null;

            if (Tab_Imagenes.SelectedIndex == 0 && vsp_categoria_img.ActiveSheet.RowCount > 0)
            {
                nombre_carpeta = "Categorias";
                nombre_archivo = vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Text.ToString();
                path_archivo = vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Tag.ToString(); 
                vsp = vsp_categoria_img;
                col_fecha = 4;
                col_user = 3;
                col_cod = 0;
                grp_img_categorias.Visible = false;
            }
            if (Tab_Imagenes.SelectedIndex == 1 && vsp_subcategoria_img.ActiveSheet.RowCount > 0)
            {
                nombre_carpeta = "SubCategorias";
                nombre_archivo = vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 1].Text.ToString();
                path_archivo = vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 0].Tag.ToString();
                  
                    vsp = vsp_subcategoria_img;
                col_fecha = 4;
                col_user = 3;
                col_cod = 1;
                grp_img_subcategorias.Visible = false;
            }
            if (Tab_Imagenes.SelectedIndex == 2 && vsp_productos_img.ActiveSheet.RowCount > 0)
            {
                nombre_carpeta = "Productos";
                nombre_archivo = vsp_productos_img.ActiveSheet.Cells[vsp_productos_img.ActiveSheet.ActiveRowIndex, 2].Text.ToString();
                //path_archivo = txtpath.Text;
                vsp = vsp_productos_img;
                col_fecha = 5;
                col_user = 4;
                col_cod = 2;
                grp_img_productos.Visible = false;
            }


            Crear_Carpeta(Server_FTP, nombre_carpeta.ToLower(), Usuario_FTP, Contraseña_FTP, null, null);

            if (nombre_carpeta == "Productos")
            {

                 md.InsertaLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), VGlobales.P_NomUsuario);
                

                for (int k = 0; k <= vsp.ActiveSheet.RowCount - 1; k++)
                {

                    
                nombre_archivo = vsp.ActiveSheet.Cells[k, col_cod].Text.ToString();
                path_archivo = vsp.ActiveSheet.Cells[k, 0].Tag.ToString();


                    if (vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - 1].Text == "True")
                    {

                        nombre_archivo = vsp.ActiveSheet.Cells[k, col_cod].Text.ToString();
                        path_archivo = vsp.ActiveSheet.Cells[k, 0].Tag.ToString();

                        if (path_archivo != "")
                        {

                            if (Envio_ArchivoFTP_ImgB64(nombre_carpeta, nombre_archivo, path_archivo))
                            {

                                g = Guid.NewGuid();

                                url_img = Dominio_FTP + SubDirectorio_FTP + "/" + nombre_carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png" + "?time=" + g.ToString().Replace("-", "").Trim() + "";

                                Conexion_Mysql.Conexion_My("", "");

                              
                                    WsqlE_My = " Update Productos set Img_Path='" + url_img + "' where CodProducto='" + nombre_archivo + "';";
                                    Conexion_Mysql.Ejecutar2_Mysql(WsqlE_My, ref result);

                                    WsqlE = " Update Productos set Url_Img1='" + url_img + "' where CodProducto='" + nombre_archivo + "';";
                                    //Utilities.Execute(VGlobales.ConectaT, WsqlE, true);

                                    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].Text = DateTime.Now.ToShortDateString();
                                    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].Text = "Usuario";
                                    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightGreen;
                                    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightGreen;

                                    vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                    vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);



                                    nombre_archivo = vsp.ActiveSheet.Cells[k, col_cod].Text.ToString()+"_2";
                                path_archivo = vsp.ActiveSheet.Cells[k, 1].Tag.ToString();





                                if (path_archivo != "")
                                {
                                    if (Envio_ArchivoFTP_ImgB64(nombre_carpeta, nombre_archivo, path_archivo)) {


                                        g = Guid.NewGuid();

                                        url_img = Dominio_FTP + SubDirectorio_FTP + "/" + nombre_carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png" + "?time=" + g.ToString().Replace("-", "").Trim() + "";

                                        Conexion_Mysql.Conexion_My("", "");


                                        WsqlE_My = " Update Productos set Img_Path2='" + url_img + "' where CodProducto='" + nombre_archivo.Substring(0,nombre_archivo.Length-2) + "';";
                                        Conexion_Mysql.Ejecutar2_Mysql(WsqlE_My, ref result);


                                            WsqlE = " Update Productos set Url_Img2='" + url_img + "' where CodProducto='" + nombre_archivo + "';";
                                            //Utilities.Execute(VGlobales.ConectaT, WsqlE, true);

                                            //MessageBox.Show("Imagen Enviada Sastifactoriamente al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                            vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].Text = DateTime.Now.ToString();
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].Text = "Usuario";
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightGreen;
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightGreen;

                                vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);



                            }
                                }
                            }

                            

                        }
                        else
                            {

                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightPink;
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightPink;

                                vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - 2);
                                //MessageBox.Show("Imagen no enviada, Revise su Conexion al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                            }

                        }
                        //else
                        //{
                        //    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightPink;
                        //    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightPink;

                        //    vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                        //    vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);
                        //}

                    }


                grp_img_productos.Visible = true;
                lblUltimaA.Text= md.ExtraeLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), "");

                }

                else
            {

                    md.InsertaLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), VGlobales.P_NomUsuario);
                   
                    for (int k = 0; k <= vsp.ActiveSheet.RowCount - 1; k++)
                {

                    if (vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - 1].Text == "True")
                    {

                        nombre_archivo = vsp.ActiveSheet.Cells[k, col_cod].Text.ToString();
                    path_archivo = vsp.ActiveSheet.Cells[k, 0].Tag.ToString();
                            colorHex = vsp.ActiveSheet.Cells[vsp.ActiveSheet.ActiveRowIndex, 1].Tag.ToString();

                            if (path_archivo != "")
                    {

                            if (Envio_ArchivoFTP_ImgB64(nombre_carpeta, nombre_archivo, path_archivo))
                            {
                                //MessageBox.Show("Imagen Enviada Sastifactoriamente al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].Text = DateTime.Now.ToString();
                                    vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].Text = "Usuario";
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightGreen;
                                vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightGreen;

                                vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                                vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);

                                g = Guid.NewGuid();
                                
                                url_img = Dominio_FTP + SubDirectorio_FTP + "/" + nombre_carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png"+ "?time="+ g.ToString().Replace("-","").Trim() + "";

                            Conexion_Mysql.Conexion_My("", "");

                                if (nombre_carpeta.ToLower() == "categorias")
                                {
                                    WsqlE_My = " Update Grupos set Img_Path='" + url_img + "',Color='"+colorHex.ToString().Trim()+"' where CodGrupo='" + nombre_archivo + "';";
                                    Conexion_Mysql.Ejecutar2_Mysql(WsqlE_My,ref result);

                                      WsqlE = " Update Grupos set Url_Img1='" + url_img + "',Color='" + colorHex.ToString().Trim() + "'  where CodGrupo='" + nombre_archivo + "';";
                                        //Utilities.Execute(VGlobales.ConectaT, WsqlE, true);
                                    }


                                if (nombre_carpeta.ToLower() == "subcategorias")
                                {
                                    WsqlE_My = " Update Cat_Grupo set Img_Path='" + url_img + "',Color='" + colorHex.ToString().Trim() + "'  where Codigo='" + nombre_archivo + "';";
                                    Conexion_Mysql.Ejecutar2_Mysql(WsqlE_My, ref result);

                                        WsqlE = " Update Cat_Grupo set Url_Img1='" + url_img + "',Color='" + colorHex.ToString().Trim() + "'  where Codigo='" + nombre_archivo + "';";
                                        //Utilities.Execute(VGlobales.ConectaT, WsqlE, true);
                                    }
                            }
                        else
                        {

                            vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightPink;
                            vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightPink;

                            vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                            vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);
                            //MessageBox.Show("Imagen no enviada, Revise su Conexion al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                        }

                    }
                    else
                    {
                        vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_fecha].BackColor = Color.LightPink;
                        vsp.ActiveSheet.Cells[k, vsp.ActiveSheet.Columns.Count - col_user].BackColor = Color.LightPink;

                        vsp.ShowCell(0, 0, k, 0, FarPoint.Win.Spread.VerticalPosition.Top, FarPoint.Win.Spread.HorizontalPosition.Center);
                        vsp.ActiveSheet.SetActiveCell(k, vsp.ActiveSheet.Columns.Count - col_user);
                    }

                    }
               
                }
                grp_img_categorias.Visible = true;
                grp_img_subcategorias.Visible = true;

                lblUltimaA.Text = md.ExtraeLog(Tab_Imagenes.TabPages[Tab_Imagenes.SelectedIndex].Text.ToString(), "");


                }
            } catch(Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void button4_Click(object sender, EventArgs e)
        {

           if(Test_FTP())
            {
                MessageBox.Show("Conexion Sastifactoria al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Revise su Conexion al Servidor FTP", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

            }

        }

        private void vsp_productos_img_CellDoubleClick(object sender, FarPoint.Win.Spread.CellClickEventArgs e)
        {
            if (vsp_productos_img.ActiveSheet.RowCount > 0)
            {
                string base64String = "";
                base64String = vsp_productos_img.ActiveSheet.Cells[e.Row, 1].Tag.ToString();

                //string UrlImagen = "";
                //UrlImagen = vsp_productos_img.ActiveSheet.Cells[e.Row, 1].Tag.ToString();

                if (base64String != "")
                {
                    var img = Image.FromStream(new MemoryStream(Convert.FromBase64String(base64String)));
                    pb_productos.Image = img;

                    lblancho3.Text = "Ancho: " + img.Width.ToString();
                    lblalto3.Text = "Alto: " + img.Height.ToString();
                    lblpixel3.Text = "Pixeles: " + Image.GetPixelFormatSize(img.PixelFormat);
                    //pb_productos.ImageLocation = UrlImagen;
                    //txtpath.Text = UrlImagen;
                }
                else
                {
                    pb_productos.Image = null;
                    lblancho3.Text = "Ancho: " ;
                    lblalto3.Text = "Alto: "  ;
                    lblpixel3.Text = "Pixeles: ";
                }

            }
        }

        public bool Crear_Carpeta(string ftpAddress, string pathToCreate, string login, string password, byte[] fileContents, string ftpProxy = null)
        {
            bool resp = false;
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;
            FtpWebResponse response;

            string[] subDirs = pathToCreate.Split('/');

            string currentDir = string.Format("ftp://{0}", ftpAddress);
            currentDir = currentDir + "/" + SubDirectorio_FTP;
            foreach (string subDir in subDirs)
            {
                try
                {
                    currentDir = currentDir + "/" + subDir;
                    reqFTP = (FtpWebRequest)FtpWebRequest.Create(currentDir);
                    reqFTP.Method = WebRequestMethods.Ftp.MakeDirectory;
                    reqFTP.UseBinary = true;
                    reqFTP.Credentials = new NetworkCredential(login, password);
                     response = (FtpWebResponse)reqFTP.GetResponse();
                    ftpStream = response.GetResponseStream();
                    ftpStream.Close();
                    response.Close();

                }
                catch (Exception ex)
                {
                 
                   
                    resp = true;
                }
            }

            return resp;
        }

        private void vsp_categoria_img_RowDragMoveCompleted(object sender, FarPoint.Win.Spread.DragMoveCompletedEventArgs e)
        {
            //MessageBox.Show("Posicion Anterior : "+e.FromIndex.ToString() +" Posicion Actual:"+e.ToIndex.ToString() , "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

            var Loading = new PCGUtility.Preload();
            object[] param = new object[1];
            param[0] ="C";
       

            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Sincroniza_Orden", CallType.Method,param, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Reorden Categorias");


        }

        private void vsp_subcategoria_img_RowDragMoveCompleted(object sender, FarPoint.Win.Spread.DragMoveCompletedEventArgs e)
        {
            var Loading = new PCGUtility.Preload();
            object[] param = new object[1];
            param[0] = "S";


            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Sincroniza_Orden", CallType.Method, param, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Reorden SubCategorias");
        }

        private void vsp_productos_img_RowDragMoveCompleted(object sender, FarPoint.Win.Spread.DragMoveCompletedEventArgs e)
        {
            var Loading = new PCGUtility.Preload();
            object[] param = new object[1];
            param[0] = "P";


            Loading.ImgSizeDefault = false;
            Loading.WaitForIt(this, "Sincroniza_Orden", CallType.Method, param, _Etiqueta: "Espere Por Favor", _SubEtiqueta: "Sincronizando Reorden Productos");
        }

        private void Frm_SincroCatalogos_Activated(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            vsp_umedida.SearchWithDialog("");
        }

        private void button6_Click(object sender, EventArgs e)
        {
            vsp_categorias.SearchWithDialog("");
        }

        private void button7_Click(object sender, EventArgs e)
        {
            vsp_subcategorias.SearchWithDialog("");
        }

        private void button8_Click(object sender, EventArgs e)
        {
            vsp_productos.SearchWithDialog("");
        }

        private void button9_Click(object sender, EventArgs e)
        {
            vsp_listaprecio.SearchWithDialog("");
        }

        private void button10_Click(object sender, EventArgs e)
        {
            vsp_precios.SearchWithDialog("");
        }

        private void button11_Click(object sender, EventArgs e)
        {
            vsp_estados.SearchWithDialog("");
        }

        private void button12_Click(object sender, EventArgs e)
        {
            vsp_departamentos.SearchWithDialog("");
        }

        private void button13_Click(object sender, EventArgs e)
        {
            vsp_fpagos.SearchWithDialog("");
        }

        private void vsp_categoria_img_AutoSortingColumn(object sender, FarPoint.Win.Spread.AutoSortingColumnEventArgs e)
        {

        }

        private void Color_Edit_EditValueChanged(object sender, EventArgs e)
        {
            lblColor.Text = HexConverter(Color_Edit.Color);

            if (Tab_Imagenes.SelectedIndex==0)
            {
                if (vsp_categoria_img.ActiveSheet.RowCount > 0)
                {

                    vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 1].BackColor = Hexa_a_Color(lblColor.Text);
                    //vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 1].BackColor = Color.FromArgb(Hexa_a_Color(lblColor.Text));
                    vsp_categoria_img.ActiveSheet.Cells[vsp_categoria_img.ActiveSheet.ActiveRowIndex, 1].Tag = lblColor.Text;


                }
            }

            if (Tab_Imagenes.SelectedIndex == 1)
            {
                if (vsp_subcategoria_img.ActiveSheet.RowCount > 0)
                {
                    vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 2].BackColor =Hexa_a_Color(lblColor.Text);
                    //vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 2].BackColor = Color.FromArgb(Hexa_a_Color(lblColor.Text));
                    vsp_subcategoria_img.ActiveSheet.Cells[vsp_subcategoria_img.ActiveSheet.ActiveRowIndex, 1].Tag = lblColor.Text;
                }
            }


        }


        public string HexConverter(System.Drawing.Color c)
        {
            string rtn = "";
            rtn = "";
            rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            return rtn;
        }

        private void button14_Click(object sender, EventArgs e)
        {
            GC.Collect();
            this.Dispose();
        }

        public void Sincroniza_Orden(string tipo)
        {
            WsqlE = "";
            WsqlE_My = "";
            string refe="";
           
            if (tipo == "C")
            {
             

                //Conecta = sqlc.Conexion();


                for(int k=0;k <= vsp_categoria_img.ActiveSheet.RowCount-1; k++)
                {
                    WsqlE += "\n\r";
                    WsqlE += " Update Grupos set Orden=" + k.ToString() + " where CodGrupo='" + vsp_categoria_img.ActiveSheet.Cells[k,0].Text.ToString().Trim() + "';";

                 
                }

                WsqlE_My = WsqlE;

                Utilities.Execute(Conecta,WsqlE);



            }


            if (tipo == "S")
            {


                //Conecta = sqlc.Conexion();


                for (int k = 0; k <= vsp_subcategoria_img.ActiveSheet.RowCount - 1; k++)
                {
                    WsqlE += "\n\r";
                    WsqlE += " Update Cat_Grupo set Orden=" + k.ToString() + " where Codigo='" + vsp_subcategoria_img.ActiveSheet.Cells[k, 1].Text.ToString().Trim() + "';";


                }

                WsqlE_My = WsqlE;

                Utilities.Execute(Conecta, WsqlE);



            }


            if (tipo == "P")
            {


                //Conecta = sqlc.Conexion();


                for (int k = 0; k <= vsp_productos_img.ActiveSheet.RowCount - 1; k++)
                {
                    WsqlE += "\n\r";
                    WsqlE += " Update Productos set Orden=" + k.ToString() + " where CodProducto='" + vsp_productos_img.ActiveSheet.Cells[k, 2].Text.ToString().Trim() + "';";


                }

                WsqlE_My = WsqlE;

                Utilities.Execute(Conecta, WsqlE);



            }



            if (WsqlE_My.ToString().Trim() != "")
            {
                Conexion_Mysql.Conexion_My("", "");
                Conexion_Mysql.Ejecutar2_Mysql(WsqlE_My, ref refe);
            }
       
        }



        //Envio de Archivos dese una Ruta del Equipo
        public bool Envio_ArchivoFTP(string carpeta,string nombre_archivo,string path_archivo)
        {

            bool resp = false;
            try
            {


                Console.WriteLine("ftp://" + Server_FTP + "/" + SubDirectorio_FTP + "/" + carpeta + "/" + nombre_archivo.Trim() + ".png");
            FtpWebRequest request =
            (FtpWebRequest)WebRequest.Create("ftp://" + Server_FTP + "/"+SubDirectorio_FTP+"/"+carpeta.ToLower()+"/" + nombre_archivo.Trim() + ".png");
            request.Credentials = new NetworkCredential(Usuario_FTP, Contraseña_FTP);
            request.Method = WebRequestMethods.Ftp.UploadFile;

            using (Stream fileStream = File.OpenRead(txtpath.Text))
            using (Stream ftpStream = request.GetRequestStream())
            {
                byte[] buffer = new byte[10240];
                int read;
                while ((read = fileStream.Read(buffer, 0, buffer.Length)) > 0)
                {
                    ftpStream.Write(buffer, 0, read);
                    Console.WriteLine("Uploaded {0} bytes", fileStream.Position);
                }
                    resp = true;
            }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return resp;
        }


        //Envio de Archivos dese una Ruta del Equipo
        public bool Envio_ArchivoFTP_ImgB64(string carpeta, string nombre_archivo, string ImgB64)
        {

            bool resp = false;
            try
            {

                Stream stimg = null;
                //Console.WriteLine("ftp://" + Server_FTP + "/" + SubDirectorio_FTP + "/" + carpeta + "/" + nombre_archivo.Trim() + ".png");
                FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create("ftp://" + Server_FTP + "/" + SubDirectorio_FTP + "/" + carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png");
                request.Credentials = new NetworkCredential(Usuario_FTP, Contraseña_FTP);
                request.Method = WebRequestMethods.Ftp.UploadFile;

                stimg = new MemoryStream(Convert.FromBase64String(ImgB64));
                //using (Stream fileStream = File.OpenRead(txtpath.Text))
                using (Stream ftpStream = request.GetRequestStream())
                  

                {
                    byte[] buffer = new byte[10240];
                    int read;
                    while ((read = stimg.Read(buffer, 0, buffer.Length)) > 0)
                    {
                        ftpStream.Write(buffer, 0, read);
                        Console.WriteLine("Uploaded {0} bytes", stimg.Position);
                    }
                    resp = true;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString(), "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            }
            return resp;
        }


        public  bool Test_FTP()
        {
            bool resp = true;
            string archivo = "";

            string currentDir = string.Format("ftp://{0}", Server_FTP);
         
            try
            {
                FtpWebRequest request = (FtpWebRequest)WebRequest.Create(currentDir);
                request.Credentials = new NetworkCredential(Usuario_FTP, Contraseña_FTP);
                request.UseBinary = true;
                request.UsePassive = true;
                request.KeepAlive = false; 
                request.Method = WebRequestMethods.Ftp.ListDirectory;
                WebResponse response = request.GetResponse();
                return true;
            }
            catch (Exception)
            {
                return false;
            }

         

            return resp;

        }

    }
}