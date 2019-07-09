using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Web.UI.WebControls;
using Hostal.Negocio;

namespace Hostal.Vista
{
    public partial class RegistroOrdenPedido : System.Web.UI.Page
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");
        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(IsPostBack);
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Administrador" || Session["perfil"] != null && Session["perfil"].ToString() == "Empleado" || Session["perfil"] != null && Session["perfil"].ToString() == "Proveedor")
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
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();

                OracleCommand comando = new OracleCommand("SELECT * FROM PROVEEDOR", conexion);
                OracleDataAdapter da = new OracleDataAdapter(comando);
                DataSet dt = new DataSet();
                da.Fill(dt);

                dropProveedor.DataTextField = "NOMBRE";
                dropProveedor.DataValueField = "ID";
                dropProveedor.DataSource = dt;
                dropProveedor.DataBind();
                ListItem emptyItem = new ListItem("", "");
                dropProveedor.Items.Insert(0, emptyItem);


                comando = new OracleCommand("SELECT * FROM EMPLEADO", conexion);
                da = new OracleDataAdapter(comando);
                dt = new DataSet();
                da.Fill(dt);

                dropEmpleado.DataTextField = "NOMBRE";
                dropEmpleado.DataValueField = "ID";
                dropEmpleado.DataSource = dt;
                dropEmpleado.DataBind();
                emptyItem = new ListItem("", "");
                dropEmpleado.Items.Insert(0, emptyItem);
                
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                conexion.Close();
            }


        }

        public void Clear()
        {
            //txtNombre.Text = string.Empty;
            //txtApellido.Text = string.Empty;
            //txtRut.Text = string.Empty;
        }

        protected void dropProveedor_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dropEmpleado_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dropProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void inCantidad_SelectedIndexChanged(object sender, EventArgs e)
        {
            //OracleCommand comando = new OracleCommand("SELECT PRECIO FROM PRODUCTO WHERE ID =" + precioId, conexion);
            //comando.Parameters.Add(precioId, txtTotal.Text);
            //conexion.Open();
            //OracleDataReader registro = comando.ExecuteReader();
            //if (registro.Read())
            //{
            //    string op = registro["PRECIO"].ToString();
            //    int tot = int.Parse(op) * int.Parse(inCantidad.Text);
            //    txtTotal.Text = tot.ToString();
            //}
            //conexion.Close();
        }

        protected void btnCrearOrden_Click(object sender, EventArgs e)
        {
            int cantidad = int.Parse(inCantidad.Text);
            int empleado = int.Parse(dropEmpleado.SelectedValue);
            int proveedor = int.Parse(dropProveedor.SelectedValue);
            string producto = txtProducto.Text;
            try
            {
                OrdenPedido ordenPedido = new OrdenPedido();
                if (ordenPedido.CreateOrdenPedido(cantidad, empleado, proveedor, producto))
                {
                    lblErrorMsg.Text = "Se ha registrado su orden de pedido";
                }
                else
                {
                    lblErrorMsg.Text = "No se pudo registrar su orden de pedido";
                }

            }
            catch (Exception ex)
            {

                lblErrorMsg.Text = "Error: " + ex.Message.ToString();
            }

        }

        protected void txtTotal_TextChanged(object sender, EventArgs e)
        {

        }
    }
}