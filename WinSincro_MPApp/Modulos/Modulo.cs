using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//using PCGUtility;
using System.Drawing;
using System.Drawing.Imaging;
using System.Drawing.Drawing2D;
using System.IO;
using Microsoft.VisualBasic;
using System.Net;
using WinSincro_MPApp;
using System.Windows.Forms;

namespace WinSincro_App.Modulos
{

   
    public class Modulo{

        string WsqlE = "";
 


   public bool InsertaLog(string Modulo,string Usuario)
    {

            bool respuesta = false;
    

            try
            {



                WsqlE = " Exec App_Pcg_LogSincro_Modulos 'C','" + Modulo + "','" + Usuario + "'";

                //respuesta = Utilities.Execute(VGlobales.ConectaT, WsqlE, true);



            }
            catch (Exception)
            {

                respuesta = false;
            }

            return respuesta;
        }




        public string ExtraeLog(string Modulo, string Usuario)
        {

            string respuesta = "";
            DataTable dt = new DataTable();

            try
            {


                WsqlE = " Exec App_Pcg_LogSincro_Modulos 'R','" + Modulo + "','" + Usuario + "'";
                //Utilities.ObtenerDatos(VGlobales.ConectaT, dt, WsqlE, true);

                if (dt.Rows.Count>0)
                {
                    respuesta = dt.Rows[0]["FechaRegistro"].ToString();
                }

                   return respuesta;

            }
            catch (Exception)
            {

                respuesta = "";
            }

            return respuesta;
        }


        public Image Redimensionar(Image imagen, int ancho, int alto)
        {
            if (imagen.Width > imagen.Height)
            {
                alto = imagen.Height * ancho / imagen.Width;
            }
            else
            {
                ancho = imagen.Width * alto / imagen.Height;
            }

            var imagenPhoto = imagen;
            var bmPhoto = new Bitmap(ancho, alto, PixelFormat.Format24bppRgb);
            //bmPhoto.SetResolution(72, 72);
            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.SmoothingMode = SmoothingMode.AntiAlias;
            grPhoto.InterpolationMode = InterpolationMode.HighQualityBicubic;
            grPhoto.PixelOffsetMode = PixelOffsetMode.HighQuality;
            grPhoto.DrawImage(imagenPhoto, new Rectangle(0, 0, ancho, alto), 0, 0, imagen.Width, imagen.Height, GraphicsUnit.Pixel);
            var mm = new MemoryStream();
            bmPhoto.Save(mm, System.Drawing.Imaging.ImageFormat.Png);
            imagen.Dispose();
            imagenPhoto.Dispose();
            bmPhoto.Dispose();
            grPhoto.Dispose();
            //mm.Dispose();
            return ByteArrayToImage(mm.GetBuffer());
        }

        public Image ByteArrayToImage(byte[] arregloDeBytes)
        {
            var ms = new MemoryStream(arregloDeBytes);
            Image imagen = Image.FromStream(ms);
            return imagen;
        }


        public string ConvertImageToBase64(Image file)
        {
            using (MemoryStream memoryStream = new MemoryStream())
            {
                file.Save(memoryStream, file.RawFormat);
                byte[] imageBytes = memoryStream.ToArray();
                return Convert.ToBase64String(imageBytes);
            }
        }


        public void Render_Grillas(string Tipo, FarPoint.Win.Spread.FpSpread vaspri, DataTable dtn_render, int Canres)
        {

            // --Renderizado
            vaspri.ActiveSheet.ColumnHeader.Rows.Get(0).Height = 30;
            var celltext = new FarPoint.Win.Spread.CellType.TextCellType();
            celltext.ReadOnly = true;
            var cellnumber = new FarPoint.Win.Spread.CellType.NumberCellType();
            cellnumber.ReadOnly = true;
            cellnumber.Separator = ",";
            cellnumber.ShowSeparator = true;
            cellnumber.DecimalPlaces = 2;
            cellnumber.NegativeRed = true;
            var cellfecha = new FarPoint.Win.Spread.CellType.DateTimeCellType();
            cellfecha.ReadOnly = true;
            cellfecha.DateTimeFormat = FarPoint.Win.Spread.CellType.DateTimeFormat.ShortDate;
            cellnumber.MaximumValue = 99999999999999.00;
            for (int c = 0; c <= vaspri.ActiveSheet.ColumnCount - Canres; c++)
            {

                if (Strings.Left(dtn_render.Rows[0][c].ToString().Trim(), 1) == "S")
                {


                    vaspri.ActiveSheet.ColumnHeader.Columns.Get(c).BackColor = Color.Khaki;
                    vaspri.ActiveSheet.Columns[c].CellType = celltext;
                    vaspri.ActiveSheet.Columns[c].Width = float.Parse(Strings.Right(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().Length - 9));
                }
                else if (Strings.Left(dtn_render.Rows[0][c].ToString().Trim(), 1) == "N")
                {
                    vaspri.ActiveSheet.ColumnHeader.Columns.Get(c).BackColor = Color.AliceBlue;
                    vaspri.ActiveSheet.Columns[c].CellType = cellnumber;
                    vaspri.ActiveSheet.Columns[c].Width = float.Parse(Strings.Right(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().Length - 9));
                }
                else
                {
                    vaspri.ActiveSheet.ColumnHeader.Columns.Get(c).BackColor = Color.Khaki;
                    vaspri.ActiveSheet.Columns[c].CellType = cellfecha;
                    vaspri.ActiveSheet.Columns[c].Width = float.Parse(Strings.Right(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().Length - 9));
                }


                if (Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("-") + 2, 1) == "1")
                {
                    vaspri.ActiveSheet.Columns[c].AllowAutoFilter = true;
                }
                else
                {
                    vaspri.ActiveSheet.Columns[c].AllowAutoFilter = false;
                }
                //vaspri.ActiveSheet.Columns[c].AllowAutoFilter = Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("-") + 2, 1);

                if (Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("%") + 2, 1) == "1")
                {
                    vaspri.ActiveSheet.Columns[c].AllowAutoSort = true;
                }
                else
                {
                    vaspri.ActiveSheet.Columns[c].AllowAutoSort = false;
                }

                //vaspri.ActiveSheet.Columns[c].AllowAutoSort = Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("%") + 2, 1);


                if (Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("/") + 2, 1) == "1")
                {
                    vaspri.ActiveSheet.Columns[c].MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.Always;
                }
                else
                {
                    vaspri.ActiveSheet.Columns[c].MergePolicy = FarPoint.Win.Spread.Model.MergePolicy.None;
                }

                if (Strings.Mid(dtn_render.Rows[0][c].ToString().Trim(), dtn_render.Rows[0][c].ToString().Trim().IndexOf("@") + 2, 1) == "1")
                {
                    vaspri.ActiveSheet.Columns[c].Visible = true;
                }
                else
                {
                    vaspri.ActiveSheet.Columns[c].Visible = false;
                }
            }

            for (int cc = 0, loopTo1 = vaspri.ActiveSheet.ColumnCount - 1; cc <= loopTo1; cc++)
            {
                for (int f = 0, loopTo2 = vaspri.ActiveSheet.RowCount - 1; f <= loopTo2; f++)
                {
                    if (vaspri.ActiveSheet.Cells[f, cc].Text.ToString().Trim() == "Total:")
                    {
                        vaspri.ActiveSheet.Rows[f].BackColor = Color.Khaki;
                    }
                }
            }

            if (dtn_render.Rows.Count > 0)
            {
                if (dtn_render.Rows[0][dtn_render.Columns.Count - 1].ToString().Trim() != "")
                {
                    vaspri.ActiveSheet.RowCount = vaspri.ActiveSheet.RowCount + 1;
                    vaspri.ActiveSheet.Cells[vaspri.ActiveSheet.RowCount - 1, 0].CellType = celltext;
                    vaspri.ActiveSheet.AddSpanCell(vaspri.ActiveSheet.RowCount - 1, 0, 1, vaspri.ActiveSheet.Columns.Count);
                    vaspri.ActiveSheet.Cells[vaspri.ActiveSheet.RowCount - 1, 0].Text = dtn_render.Rows[0][dtn_render.Columns.Count - 1].ToString().Trim();
                    // vsp_general_ventas.ActiveSheet.Rows(vsp_general_ventas.ActiveSheet.RowCount - 1).BackColor = Color.LightGreen

                    vaspri.ActiveSheet.Rows[vaspri.ActiveSheet.Rows.Count - 1].Font = new Font("Tahoma", 12, FontStyle.Bold);
                    vaspri.ActiveSheet.Rows[vaspri.ActiveSheet.Rows.Count - 1].HorizontalAlignment = FarPoint.Win.Spread.CellHorizontalAlignment.Center;
                    vaspri.ActiveSheet.MoveRow(vaspri.ActiveSheet.RowCount - 1, 0, true);
                    vaspri.ActiveSheet.FrozenRowCount = 1;
                    if (Strings.Left(dtn_render.Rows[0][dtn_render.Columns.Count - 1].ToString().Trim(), 1) == "*")
                    {
                        vaspri.ActiveSheet.FrozenTrailingRowCount = 1;
                    }
                }
            }
        }

        public bool Tamaño_ValidoImg(string tipo, string filepath, int indiceImg, ref int anchoimg, ref int altoimg)
        {
            bool valido = false;
            Image imageFile;
            imageFile = Image.FromFile(filepath);

            anchoimg = imageFile.Width;
            altoimg = imageFile.Height;

            if (tipo == "C")
            {
                if (imageFile.Width == VGlobales.ancho_c && imageFile.Height == VGlobales.alto_c)
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


            if (tipo == "P" && indiceImg == 1)
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
        public string HexConverter(System.Drawing.Color c)
        {
            string rtn = "";
            rtn = "";
            rtn = "#" + c.R.ToString("X2") + c.G.ToString("X2") + c.B.ToString("X2");
            return rtn;
        }
        public Color Hexa_a_Color(String Hexa)
        {
            Color color;
            string colornombre = "White";
            int ARB = 0;

            color = Color.White;
            color = System.Drawing.ColorTranslator.FromHtml(Hexa);
            colornombre = System.Drawing.ColorTranslator.FromHtml(Hexa).Name;
            //ARB = System.Drawing.ColorTranslator.FromHtml(Hexa).ToArgb();


            return color;
        }
        public string Hexa_a_ColorNombre(String Hexa)
        {
         
            string colornombre = "White";
            Color color;
            int ARB = 0;


            color = System.Drawing.ColorTranslator.FromHtml(Hexa);
            colornombre = color.Name;
                //System.Drawing.ColorTranslator.FromHtml(Hexa).Name;
            //ARB = System.Drawing.ColorTranslator.FromHtml(Hexa).ToArgb();


            return colornombre;
        }

        public Color Html_a_Color(string Html)
        {
            Color Html_a_ColorRet = Color.White;
      
            Html_a_ColorRet = System.Drawing.ColorTranslator.FromHtml(Html);
            return Html_a_ColorRet;
        }

        public string Html_a_ColorNombre(string Html)
        {
            Color Html_a_ColorRet = Color.White;

            Html_a_ColorRet = System.Drawing.ColorTranslator.FromHtml(Html);
            
            return Html_a_ColorRet.Name.ToString();
        }

        public string GetColourName(string htmlString)
        {
            Color color = (Color)new ColorConverter().ConvertFromString(htmlString);
            KnownColor knownColor = color.ToKnownColor();

            string name = knownColor.ToString();
            return name.Equals("0") ? "Unknown" : name;
        }

        public bool Crear_Carpeta(string ftpAddress, string pathToCreate, string login, string password, byte[] fileContents, string ftpProxy = null)
        {
            bool resp = false;
            FtpWebRequest reqFTP = null;
            Stream ftpStream = null;
            FtpWebResponse response;

            string[] subDirs = pathToCreate.Split('/');

            string currentDir = string.Format("ftp://{0}", ftpAddress);
            currentDir = currentDir + "/" + VGlobales.SubDirectorio_FTP;
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



        public bool Envio_ArchivoFTP_ImgB64(string carpeta, string nombre_archivo, string ImgB64)
        {

            bool resp = false;
            try
            {

                Stream stimg = null;
                //Console.WriteLine("ftp://" + Server_FTP + "/" + SubDirectorio_FTP + "/" + carpeta + "/" + nombre_archivo.Trim() + ".png");
                FtpWebRequest request =
                (FtpWebRequest)WebRequest.Create("ftp://" + VGlobales.Server_FTP + "/" + VGlobales.SubDirectorio_FTP + "/" + carpeta.ToLower() + "/" + nombre_archivo.Trim() + ".png");
                request.Credentials = new NetworkCredential(VGlobales.Usuario_FTP, VGlobales.Contraseña_FTP);
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


    }
}
