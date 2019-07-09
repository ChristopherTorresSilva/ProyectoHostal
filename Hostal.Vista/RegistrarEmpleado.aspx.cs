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
    public partial class RegistrarEmpleado : System.Web.UI.Page
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(IsPostBack);
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Administrador")
            {
                if (!IsPostBack)
                {
                    init();
                }
            }
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Empleado")
            {
                if (!IsPostBack)
                {
                    init();
                }
            }
            else
            {
                Response.Redirect("~/Default.aspx");
            }
        }
        public void init()
        {
            Clear();
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM CARGO", conexion);
            OracleDataAdapter da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            DataSet dt = new DataSet();
            da.Fill(dt);
            dropCargo.DataTextField = "NOMBRE";
            dropCargo.DataValueField = "ID";
            dropCargo.DataSource = dt;
            dropCargo.DataBind();
            ListItem emptyItem = new ListItem("", "");
            dropCargo.Items.Insert(0, emptyItem);

            comando = new OracleCommand("SELECT * FROM PERFIL", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);
            dt = new DataSet();
            da.Fill(dt);

            dropPerfil.DataTextField = "NOMBRE";
            dropPerfil.DataValueField = "ID";
            dropPerfil.DataSource = dt;
            dropPerfil.DataBind();
            emptyItem = new ListItem("", "");
            dropPerfil.Items.Insert(0, emptyItem);
            conexion.Close();
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            
            int perfil = int.Parse(dropPerfil.SelectedValue);
            int cargo = int.Parse(dropCargo.SelectedValue);
            try
            {

                
                EMPLEADO empleado = new EMPLEADO();
                if (empleado.CreateEmpleados(txtUsuario.Text, perfil, txtRut.Text, txtNombre.Text, txtApellido.Text, cargo))
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

        public void Clear()
        {
            txtNombre.Text = string.Empty;
            txtApellido.Text = string.Empty;
            txtRut.Text = string.Empty;
        }

    }
}