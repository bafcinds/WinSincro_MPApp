using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;
using Microsoft.VisualBasic;
using System.Data.SqlClient;
using MySql.Data.MySqlClient;
using System.Data;
//using PCGUtility;
using WinSincro_App.Modulos;
using System.Windows.Forms;
using WinSincro_App;

static class Conexion_Mysql
{
    public static SqlConnection Conecta;
    public static MySqlConnection Conecta_My;
    public static MySqlDataAdapter Adaptador_My = new MySqlDataAdapter();
    public static System.Data.DataSet DSTGlobal_My;
    public static MySql.Data.MySqlClient.MySqlCommand CmdAux_My;
    public static string WsqlE_My;
    public static string WSQLAux_My;
    public static string My_Usuario = "";
    public static string My_Contraseña = "";
    public static string My_BD = "";
    public static string My_Server = "";
    public static string My_Puerto = "";
    public static string WsqlE ="";
    public static string Cadena_Sql = "";
    // Public myConnectionString As String = "Database=" + My_BD + ";Data Source=" + My_Server + ";User Id=" + My_Usuario + ";Password=" + My_Contraseña

    // Public myConnectionString As String = "Data Source=" + My_Server + ";User ID=" + My_Usuario + ";Password=" + My_Contraseña + ";Initial Catalog=" + My_BD

    public static MySqlConnection Conexion_My(string mycn, string Tipo)
    {
    
        //Sql_Conexion sqlc =new Sql_Conexion();

        //Conecta = VGlobales.ConectaT;
        DataTable DTNCONFG = new DataTable();
        //WsqlE = " SELECT * FROM TAB_CONFIG_WEBG ";
        MySqlConnection myConnection = new MySqlConnection();

        //if ( Utilities.ObtenerDatos(Conecta, DTNCONFG, WsqlE, true))
        //{

        //if (DTNCONFG.Rows.Count > 0)
        //{
        //My_Usuario = DTNCONFG.Rows[0]["USUARIO_WEB"].ToString().Trim();
        //My_Contraseña = DTNCONFG.Rows[0]["CONTRASEÑA_WEB"].ToString().Trim();
        //My_BD = DTNCONFG.Rows[0]["BD_WEB"].ToString().Trim();
        //My_Server = DTNCONFG.Rows[0]["SERVER_WEB"].ToString().Trim();
        //My_Puerto= DTNCONFG.Rows[0]["PUERTO_WEB"].ToString().Trim();

        My_Usuario = "pcgroups_PCG";
        My_Contraseña = "PCG1992";
        My_BD = "pcgroups_atentodb_deli";
        My_Server = "162.241.26.9";
        My_Puerto = "3306";

        //string MyConecc = "Server=" + My_Server + "; Uid=" + My_Usuario + ";Pwd=" + My_Contraseña + ";Database=" + My_BD;
        string MyConecc = "Server=" + My_Server + "; Port="+ My_Puerto + "; ;Database=" + My_BD+"; Uid =" + My_Usuario + ";Pwd=" + My_Contraseña ;
                // If myConnectionString = "" Then
                // myConnectionString = "Database=" + My_BD + ";Data Source=" + My_Server + ";User Id=" + My_Usuario + ";Password=" + My_Contraseña + ""
                // End If

                // Dim myInsertQuery As String = "INSERT INTO Orders (id, customerId, amount) Values(1001, 23, 30.66)"
                // Dim myCommand As New MySqlCommand(myInsertQuery)
                // myCommand.Connection = myConnection
                // myConnection.Open()
                // myCommand.ExecuteNonQuery()
                // myCommand.Connection.Close()
                try
                {
                    myConnection = new MySqlConnection(MyConecc);

                    if (Tipo == "T")
                    {
                        myConnection.Open();

                        MessageBox.Show("Conexion Sastifactoria", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);


                        myConnection.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Opcion", "No hay Conexion al Servidor:" + ex.Message, MessageBoxButtons.OK, MessageBoxIcon.Exclamation);

                }

            //}
            //else
            //{
            //    MessageBox.Show( "No hay Conexion al Servidor", "Opcion", MessageBoxButtons.OK, MessageBoxIcon.Information);

              
            // }

      
        //}
        return myConnection;
    }

    public static System.Data.DataSet ExtraeDatos_Mysql(string Consulta)
    {
        try
        {

            Conecta_My = Conexion_My("", "");

            if (Conecta_My.State == ConnectionState.Closed)
                Conecta_My.Open();

            // Dim a As String = Conecta_My.WorkstationId
            DSTGlobal_My = new System.Data.DataSet();
            Adaptador_My = new MySqlDataAdapter("" + Consulta + "", Conecta_My);
            Adaptador_My.SelectCommand.CommandTimeout = 0;
            if (DSTGlobal_My.Tables["DATOS"] != null)
                DSTGlobal_My.Tables["DATOS"].Clear();
            Adaptador_My.Fill(DSTGlobal_My, "DATOS");
            Conecta_My.Close();
            return DSTGlobal_My;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
        }
        return DSTGlobal_My;
    }
    public static bool LlenarTabla_Mysql(ref System.Data.DataTable Tabla, string Consulta)
    {
        bool LlenarTabla_Mysql = false;

        WSQLAux_My = "";
        WSQLAux_My = Consulta;

        Conecta_My = Conexion_My("","");
        Adaptador_My = new MySqlDataAdapter(WSQLAux_My, Conecta_My);
        Adaptador_My.SelectCommand.CommandTimeout = 0;
        try
        {
            Tabla.Clear();
            if (Conecta_My.State == ConnectionState.Closed)
                Conecta_My.Open();
            Adaptador_My.Fill(Tabla);
            Conecta_My.Close();

            Adaptador_My.Dispose();

            LlenarTabla_Mysql = true;
        }
        catch (Exception ex)
        {
            if (Conecta_My.State == ConnectionState.Open)
                Conecta_My.Close();
            MessageBox.Show("Error en la Consulta: " + WSQLAux_My + " / " + ex.Message, "", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return LlenarTabla_Mysql;
    }


    public static bool Ejecutar2_Mysql(string Consulta, ref string Resultado)
    {
       bool Ejecutar2_Mysql = false;
        WSQLAux_My = "";
        Conecta_My = Conexion_My("", "");
        WSQLAux_My = Consulta;
        try
        {
            CmdAux_My = new MySql.Data.MySqlClient.MySqlCommand();
            CmdAux_My.Connection = Conecta_My;
            CmdAux_My.CommandTimeout = 0;
            CmdAux_My.CommandType = CommandType.Text;
            CmdAux_My.CommandText = WSQLAux_My;

            Conecta_My.Open();
            try
            {
                Resultado = CmdAux_My.ExecuteScalar().ToString();
            }
            catch (Exception ex)
            {
                Resultado = "XXXXX";
            }
            if (Resultado == "XXXXX")
            {
                Resultado = "";
                Ejecutar2_Mysql = false;
            }
            else
                Ejecutar2_Mysql = true;
            Conecta_My.Close();
            CmdAux_My.Dispose();
        }
        catch (Exception ex)
        {
            if (Conecta_My.State == ConnectionState.Open)
                Conecta_My.Close();
            MessageBox.Show("Error en la Cosulta: " + WSQLAux_My + " / " + ex.Message, "SISTEMA V 2.0", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
        return Ejecutar2_Mysql;


    }

    public static void CargaCombo(string Consulta, System.Windows.Forms.ComboBox ComboBox, string Texto, string Codigo, bool Abrir, bool Seleccionar)
    {
        string fp = "";
        DataTable dtcombo = new DataTable();
        LlenarTabla_Mysql(ref dtcombo, Consulta);

   
        ComboBox.DataSource = dtcombo;
        ComboBox.DisplayMember = Texto;
        ComboBox.ValueMember = Codigo;
        if (Abrir == true)
            ComboBox.DroppedDown = true;
        if (Seleccionar == true)
        {
            ComboBox.SelectAll();
            ComboBox.Focus();
        }
    }



}


