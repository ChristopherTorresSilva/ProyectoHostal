using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Hostal.Vista.Models;
using Oracle.DataAccess.Client;
using Hostal.Negocio;

namespace Hostal.Vista.Account
{
    public partial class Login : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void LogIn(object sender, EventArgs e)
        {
            try
            {
                USUARIO usuario = new USUARIO();
                if (usuario.login(txtUsuario.Text, txtPass.Text))
                {
                    Session["username"] = txtUsuario.Text.Trim();
                    Response.Redirect("~/Default.aspx");
                }
                else
                {
                    lblErrorLogin.Text = "Usuario o contraseña incorrectos";
                }

            }
            catch (Exception ex)
            {
                lblErrorLogin.Text = "Error: " + ex.Message.ToString();
            }

        }
    }
}