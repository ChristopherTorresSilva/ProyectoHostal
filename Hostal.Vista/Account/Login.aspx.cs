using System;
using System.Web;
using System.Web.UI;
using Microsoft.AspNet.Identity;
using Microsoft.AspNet.Identity.Owin;
using Owin;
using Hostal.Vista.Models;
using Oracle.DataAccess.Client;
using Hostal.Negocio;
using System.Data;

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
                Perfiles perfil = new Perfiles();
                DataTable perfiles = perfil.ListaPerfiles();
                DataTable usuarioLog = usuario.login(txtUsuario.Text, txtPass.Text);

                if (usuarioLog.Rows.Count > 0) 
                {
                    foreach (DataRow row in usuarioLog.Rows)
                    {
                        foreach (DataColumn column in usuarioLog.Columns)
                        {
                            //System.Diagnostics.Debug.WriteLine(column);
                            if (column.ToString() == "PERFIL_ID")
                            {
                                foreach (DataRow _perfil in perfiles.Rows)
                                {
                                    foreach (DataColumn _perfilColumn in perfiles.Columns)
                                    {
                                        if (_perfilColumn.ToString() == "ID")
                                        {
                                            if (_perfil[_perfilColumn].ToString() == row[column].ToString())
                                            {
                                                Session["perfil"] = _perfil["NOMBRE"].ToString();
                                                //System.Diagnostics.Debug.WriteLine(row[column].ToString());
                                            }
                                        }
                                            
                                    }
                                }
                                    
                                //System.Diagnostics.Debug.WriteLine(row[column].ToString());
                            }else if (column.ToString() == "USERNAME")
                            {
                                Session["username"] = txtUsuario.Text.Trim();
                            } else if (column.ToString() == "ID")
                            {
                                Session["ID"] = row["ID"].ToString();
                            }

                        }
                    }
                    //Session["username"] = txtUsuario.Text.Trim();
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