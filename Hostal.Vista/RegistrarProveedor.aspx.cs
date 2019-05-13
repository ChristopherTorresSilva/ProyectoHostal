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
    public partial class RegistrarProveedor : System.Web.UI.Page
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
            conexion.Open();
           
            OracleCommand comando = new OracleCommand("SELECT * FROM RUBRO", conexion);
            OracleDataAdapter da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            DataSet dt = new DataSet();
            da.Fill(dt);
            dropRubro.DataTextField = "NOMBRE";
            dropRubro.DataValueField = "ID";
            dropRubro.DataSource = dt;
            dropRubro.DataBind();
            ListItem emptyItem = new ListItem("", "");
            dropRubro.Items.Insert(0, emptyItem);
            conexion.Close();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {

                int perfil = 3;
                int rubro = int.Parse(dropRubro.SelectedValue);
                try
                {


                    PROVEEDOR empresa = new PROVEEDOR();
                    if (empresa.CreateProveedor(txtUsuario.Text, perfil,txtRut.Text,txtProveedor.Text,txtTel.Text,txtCorreo.Text, rubro))
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
            txtUsuario.Text = string.Empty;
            txtProveedor.Text = string.Empty;
            txtRut.Text = string.Empty;
            txtCorreo.Text = string.Empty;
            txtTel.Text = string.Empty;
        }

    }
}