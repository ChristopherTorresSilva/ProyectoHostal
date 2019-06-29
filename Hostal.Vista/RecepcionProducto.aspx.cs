using Oracle.DataAccess.Client;
using System;
using System.Data;
using System.Web.UI.WebControls;
using Hostal.Negocio;

namespace Hostal.Vista
{
    public partial class RecepcionProducto : System.Web.UI.Page
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
            try
            {
                if (conexion.State == ConnectionState.Closed)
                    conexion.Open();
                
                //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

                DataSet dt = new DataSet();

                OracleCommand comando = new OracleCommand("SELECT * FROM TIPO_PRODUCTO", conexion);
                OracleDataAdapter da = new OracleDataAdapter(comando);
                dt = new DataSet();
                da.Fill(dt);

                dropTipoProducto.DataTextField = "NOMBRE";
                dropTipoProducto.DataValueField = "ID";
                dropTipoProducto.DataSource = dt;
                dropTipoProducto.DataBind();
                ListItem emptyItem = new ListItem("", "");
                dropTipoProducto.Items.Insert(0, emptyItem);


                comando = new OracleCommand("SELECT * FROM FAMILIA", conexion);
                da = new OracleDataAdapter(comando);
                dt = new DataSet();
                da.Fill(dt);

                dropFamilia.DataTextField = "NOMBRE";
                dropFamilia.DataValueField = "ID";
                dropFamilia.DataSource = dt;
                dropFamilia.DataBind();
                emptyItem = new ListItem("", "");
                dropFamilia.Items.Insert(0, emptyItem);

                comando = new OracleCommand("SELECT * FROM ORDEN_PEDIDO", conexion);
                da = new OracleDataAdapter(comando);
                dt = new DataSet();
                da.Fill(dt);

                dropOrden.DataTextField = "ID";
                dropOrden.DataValueField = "PROVEEDOR_ID";
                dropOrden.DataSource = dt;
                dropOrden.DataBind();
                emptyItem = new ListItem("", "");
                dropOrden.Items.Insert(0, emptyItem);
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


        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
            string provId = "";
            string tProdId = "";
            string fam = "";
            string fech = "";
            string exp = "";
            
            conexion.Close();
        }

        protected void btnCrearRecepcionProducto_Click(object sender, EventArgs e)
        {
            
            string nombre = txtProducto.Text;
            int precio = int.Parse(txtPrecio.Text);
            int tipoProductoId = int.Parse(dropTipoProducto.SelectedValue);
            int familiaId = int.Parse(dropFamilia.SelectedValue);
            string descripcion = txtDescripcion.Text;
            int stock = int.Parse(txtStock.Text);
            int stockCritico = int.Parse(txtStockCritico.Text);
            string fecha = txtFecha.Text;
            int proveedorId = int.Parse(dropOrden.SelectedValue);

            try
            {
                Recepcion recepcion = new Recepcion();
                if (recepcion.CreateRecepcionProducto(nombre, precio, tipoProductoId, familiaId, descripcion, stock, stockCritico, fecha, proveedorId))
                {
                    lblErrorMsg.Text = "Se han registrado los productos";
                }
                else
                {
                    lblErrorMsg.Text = "No se pudo registrar los productos";
                }

            }
            catch (Exception ex)
            {

                lblErrorMsg.Text = "Error: " + ex.Message.ToString();
            }
        }
    }
}