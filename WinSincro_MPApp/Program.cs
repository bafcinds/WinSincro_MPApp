using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinSincro_MPApp;
using WinSincro_MPApp.Formas;

namespace WinSincro_MPApp
{


    static class VGlobales
    {

        public static string WsqlE_My = "", MiArchivo = "", P_NombreServidor = "", P_NomBaseDato = "", P_RolUsuario = "", P_UsuarioNombreRol = "", P_Usuario = "", P_NomUsuario = "", P_PassUsuario = "", CadenaC = "";
        public static string  PEmpresa_Cod="",NOMBRE_EMPRESA = "", P_Sucursal = "", P_SucursalCod = "", P_NombreServidor_PcgP = "", P_NomBaseDato_PcgP = "", VersionSistema = "";

        public static string Server_FTP = "", Usuario_FTP = "", Contraseña_FTP = "", SubDirectorio_FTP = "", Dominio_FTP = "";
        public static int Puerto_FTP = 0;

        public static int ancho_c = 0, alto_c = 0, ancho_s = 0, alto_s = 0, ancho_p1 = 0, alto_p1 = 0, ancho_p2 = 0, alto_p2 = 0, ancho_logo = 0, alto_logo = 0, ancho_bienve = 0,
        alto_bienve = 0, ancho_onboar = 0, alto_onboard = 0, ancho_banner = 0, alto_banner = 0;

        public static bool ACategoria = false, ASubcategoria = false, AProductos1 = false, AProductos2 = false;



        public static void FTPSettings()
        {

            DataTable dnt_ftp = new DataTable();

            WsqlE_My = "select * from TAB_CONFIG_FTP; ";
            Conexion_Mysql.LlenarTabla_Mysql(ref dnt_ftp, WsqlE_My);

            if (dnt_ftp.Rows.Count>0)
            {

             Server_FTP = dnt_ftp.Rows[0]["Servidor"].ToString().Trim();
            Usuario_FTP = dnt_ftp.Rows[0]["Usuario"].ToString().Trim();
            Contraseña_FTP = dnt_ftp.Rows[0]["Contraseña"].ToString().Trim();
            SubDirectorio_FTP = dnt_ftp.Rows[0]["SubDirectorio"].ToString().Trim();

            Dominio_FTP = dnt_ftp.Rows[0]["Dominio"].ToString().Trim();


        }
    }


        public static void SizesImg()
        {

            WsqlE_My = "select * from TAB_IMG_SIZES";
            DataTable dnt_img = new DataTable();
            Conexion_Mysql.LlenarTabla_Mysql(ref dnt_img, WsqlE_My);

            if (dnt_img.Rows.Count>0)
            {
                for (int k = 0; k <= dnt_img.Rows.Count - 1; k++)
                {
                    switch (dnt_img.Rows[k]["Nombre"].ToString().Trim())
                    {
                        case "Categorias":
                            ancho_c = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_c = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            ACategoria = (dnt_img.Rows[k]["AjustarTamano"].ToString() == "0" ? false : true);
                            break;
                        case "SubCategorias":
                            ancho_s = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_s = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            ASubcategoria = (dnt_img.Rows[k]["AjustarTamano"].ToString() == "0" ? false : true);
                            break;
                        case "Productos 1":
                            ancho_p1 = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_p1 = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            AProductos1 = (dnt_img.Rows[k]["AjustarTamano"].ToString() == "0" ? false : true);
                            break;

                        case "Productos 2":
                            ancho_p2 = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_p2 = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            AProductos2 = (dnt_img.Rows[k]["AjustarTamano"].ToString() == "0" ? false : true);
                            break;

                        case "Logo":
                            ancho_logo = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_logo = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            break;

                        case "Imagen Bienvenida":
                            ancho_bienve = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_bienve = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            break;

                        case "Onboarding":
                            ancho_onboar = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_onboard = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            break;

                        case "Banner":
                            ancho_banner = int.Parse(dnt_img.Rows[k]["ancho"].ToString());
                            alto_banner = int.Parse(dnt_img.Rows[k]["alto"].ToString());
                            break;
                    }
                }

            }
        }



        //public static void ExtraerC()
        //{
        //    DataSet dset = new DataSet();
        //    MiArchivo = FileSystem.Dir(Application.StartupPath + @"\\Tele.dat");
        //    if (Strings.UCase(MiArchivo) == Strings.UCase("Tele.dat"))
        //    {
        //        try
        //        {
        //            dset.ReadXml(Application.StartupPath + @"\\Tele.dat");
        //            try
        //            {
        //                P_NomBaseDato = dset.Tables["TU"].Rows[0]["BD"].ToString();
        //                P_NombreServidor = dset.Tables["TU"].Rows[0]["S"].ToString();
        //                P_NomUsuario = dset.Tables["TU"].Rows[0]["US"].ToString();
        //                P_PassUsuario = dset.Tables["TU"].Rows[0]["CS"].ToString();



        //                CadenaC = "Data Source=" + P_NombreServidor.ToString() + ";User ID=" + P_Usuario.ToString() + " ;Password=" + P_PassUsuario.ToString() + ";Persist Security Info=True;Initial Catalog=" + P_NomBaseDato.ToString() + "";

        //                //Sql_Conexion sqlc = new Sql_Conexion();
        //                //ConectaT = sqlc.Conexion();
        //                //DataTable DTNCONFG = new DataTable();


        //                //if (Utilities.ObtenerDatos(ConectaT, DTNCONFG, "SELECT * FROM [Config.Servidores] where Principal='S' ", true))
        //                //{

        //                //    if (DTNCONFG.Rows.Count > 0)
        //                //    {
        //                //        P_NombreServidor_PcgP = DTNCONFG.Rows[0]["Servidor"].ToString().Trim();
        //                //        P_NomBaseDato_PcgP = DTNCONFG.Rows[0]["BD"].ToString().Trim();



        //                //    }
        //                //  }
        //            }
        //            catch (Exception ex)
        //            {

        //            }
        //        }
        //        catch (Exception ex)
        //        {

        //        }
        //    }
        //}


    }


    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MDI());
        }
    }
}
