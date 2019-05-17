using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using Hostal.Negocio;

namespace Hostal.Vista
{
    public partial class ListadoUsuarios : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                MtInicio();
            }
        }

        private void MtInicio()
        {
            try
            {
                ListaUsuarios();
            }
            catch (Exception)
            {

                throw;
            }
        }


        public void ListaUsuarios()
        {
            try
            {
                //String _rut_pac = (txtRutPaciente.Text != "") ? txtRutPaciente.Text : "-1";
                //String _buscador_nombre = (txtBuscadorNombre.Text != "") ? txtBuscadorNombre.Text : "-1";
                USUARIO usuario = new USUARIO();
                DataTable dt = new DataTable();

                dt = usuario.ListaUsuarios();
                
             
                gridUser.DataSource = dt;
                gridUser.DataBind();
                usuario = null;
                dt.Dispose();
                //DataTable dt = new DataTable();
                //OracleCommand comando = new OracleCommand("SELECT * FROM CARGO");

            }
            catch (Exception ex)
            {
            }
        }

        protected void gridUser_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}