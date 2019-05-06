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
                conexion.Open();
                OracleCommand comando = new OracleCommand("INSERTAR_USUARIO_EMPRESA", conexion);
                comando.CommandType = CommandType.StoredProcedure;
                comando.Parameters.Add("nom", OracleDbType.Varchar2).Value = txtNombre.Text;
                comando.Parameters.Add("perfil", OracleDbType.Int32).Value = 2;
                comando.Parameters.Add("rut", OracleDbType.Varchar2).Value = txtRut.Text;
                comando.Parameters.Add("emp", OracleDbType.Varchar2).Value = txtEmpresa.Text;
                comando.Parameters.Add("correo", OracleDbType.Varchar2).Value = txtCorreo.Text;
                //System.Diagnostics.Debug.WriteLine(drop.SelectedValue);
                comando.ExecuteNonQuery();
                conexion.Close();
                Response.Redirect("~/RegistrarEmpresa.aspx");
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