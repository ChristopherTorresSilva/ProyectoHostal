using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;
using Hostal.Negocio;

namespace Hostal.Vista
{
    public partial class CrearUsuario : System.Web.UI.Page
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(IsPostBack);
            if (!IsPostBack)
            {
                init();
            }
        }
        public void init()
        {
            Clear();
            
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                int perfil = 2;
                try
                {


                    EMPRESA empresa = new EMPRESA();
                    if (empresa.CreateEmpresa(txtNombre.Text, perfil,txtRut.Text,txtEmpresa.Text,txtCorreo.Text))
                    {


                        lblErrorMsg.Text = "Se ha creado con éxito el usuario. ";
                        


                    }
                    else
                    {

                        lblErrorMsg.Text = "No se ha podido crear el usuario.";
                        

                    }

                }
                catch (Exception ex)
                {
                    lblErrorMsg.Text = "Error: " + ex.Message.ToString();
                    
                }

                
            }
            catch (Exception)
            {
                lblErrorMsg.Text = "Error al crear el usuario";
            }




        }

        public void Clear()
        {
            txtCorreo.Text = string.Empty;
            txtEmpresa.Text = string.Empty;
            txtNombre.Text = string.Empty;
            txtRut.Text = string.Empty;
        }
       
    }
}