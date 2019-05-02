using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Hostal.Vista.Models;
using Oracle.DataAccess.Client;

namespace Hostal.Vista.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");
        protected void LogIn(object sender, EventArgs e)
        {
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM USUARIO WHERE USERNAME = :usuario and PASSWORD = :password", conexion);

            comando.Parameters.Add(":usuario", txtUsuario.Text);
            comando.Parameters.Add(":password", txtPass.Text);

            OracleDataReader lector = comando.ExecuteReader();
            var login = lector.Read();
            //System.Diagnostics.Debug.WriteLine(lector.Read());

            if (login == true)
            {
                Session["username"] = txtUsuario.Text.Trim();
                Response.Redirect("~/Default.aspx");
                conexion.Close();

            }else
            {
                lblErrorLogin.Text = "Nombre de Usuario o Contraseña incorrectos";
            }
        }
    }
}