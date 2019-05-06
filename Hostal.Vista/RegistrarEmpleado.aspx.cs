using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;

namespace Hostal.Vista
{
    public partial class RegistrarTrabajador : System.Web.UI.Page
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
            try
            {
                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_EMPLEADO", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("userN", OracleDbType.Varchar2).Value = txtUsuario.Text;
                comando.Parameters.Add("perfil", OracleDbType.Int32).Value = dropPerfil.SelectedValue;
                comando.Parameters.Add("rut", OracleDbType.Varchar2).Value = txtRut.Text;
                comando.Parameters.Add("nom", OracleDbType.Varchar2).Value = txtNombre.Text;
                comando.Parameters.Add("ape", OracleDbType.Varchar2).Value = txtApellido.Text;
                comando.Parameters.Add("cargo", OracleDbType.Int32).Value = dropCargo.SelectedValue;
                
                
                //System.Diagnostics.Debug.WriteLine(drop.SelectedValue);
                comando.ExecuteNonQuery();
                conexion.Close();
                Response.Redirect("~/RegistrarEmpleado.aspx");
            }
            catch (Exception)
            {
                lblErrorMsg.Text = "Error al crear el usuario";
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