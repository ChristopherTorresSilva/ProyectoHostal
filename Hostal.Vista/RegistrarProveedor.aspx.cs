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
                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_PROVEEDOR", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("userN", OracleDbType.Varchar2).Value = txtUsuario.Text;
                comando.Parameters.Add("perfil", OracleDbType.Int32).Value = 3;
                comando.Parameters.Add("rut", OracleDbType.Varchar2).Value = txtRut.Text;
                comando.Parameters.Add("nom", OracleDbType.Varchar2).Value = txtProveedor.Text;
                comando.Parameters.Add("tel", OracleDbType.Varchar2).Value = txtTel.Text;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = txtCorreo.Text;
                comando.Parameters.Add("rubro", OracleDbType.Int32).Value = dropRubro.SelectedValue;


                //System.Diagnostics.Debug.WriteLine(drop.SelectedValue);
                comando.ExecuteNonQuery();
                conexion.Close();
                Response.Redirect("~/RegistrarProveedor.aspx");
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