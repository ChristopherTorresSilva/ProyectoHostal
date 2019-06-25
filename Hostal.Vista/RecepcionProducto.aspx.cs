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

                OracleCommand comando = new OracleCommand("SELECT * FROM PRODUCTO", conexion);
                OracleDataAdapter da = new OracleDataAdapter(comando);
                //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

                DataSet dt = new DataSet();
                da.Fill(dt);
                dropProducto.DataTextField = "NOMBRE";
                dropProducto.DataValueField = "ID";
                dropProducto.DataSource = dt;
                dropProducto.DataBind();
                ListItem emptyItem = new ListItem("", "");
                dropProducto.Items.Insert(0, emptyItem);


                comando = new OracleCommand("SELECT * FROM TIPO_PRODUCTO", conexion);
                da = new OracleDataAdapter(comando);
                dt = new DataSet();
                da.Fill(dt);

                dropTipoProducto.DataTextField = "NOMBRE";
                dropTipoProducto.DataValueField = "ID";
                dropTipoProducto.DataSource = dt;
                dropTipoProducto.DataBind();
                emptyItem = new ListItem("", "");
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

        protected void dropProducto_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idPrecio = dropProducto.SelectedItem.Value;
            OracleCommand comando = new OracleCommand("SELECT PRECIO FROM PRODUCTO WHERE ID =" + idPrecio, conexion);
            comando.Parameters.Add(idPrecio, txtPrecio.Text);
            conexion.Open();
            OracleDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtPrecio.Text = registro["PRECIO"].ToString();
            }
            conexion.Close();
        }

        protected void dropTipoProducto_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        protected void dropFamilia_SelectedIndexChanged(object sender, EventArgs e)
        {
            var idDescripcion = dropProducto.SelectedItem.Value;
            OracleCommand comando = new OracleCommand("SELECT DESCRIPCION FROM PRODUCTO WHERE ID =" + idDescripcion, conexion);
            comando.Parameters.Add(idDescripcion, txtDescripcion.Text);
            conexion.Open();
            OracleDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                txtDescripcion.Text = registro["DESCRIPCION"].ToString();
            }
            conexion.Close();
        }

        protected void txtCantidad_TextChanged(object sender, EventArgs e)
        {
            var idStock = dropProducto.SelectedItem.Value;
            OracleCommand comando = new OracleCommand("SELECT STOCK_CRITICO FROM PRODUCTO WHERE ID =" + idStock, conexion);
            comando.Parameters.Add(idStock, txtStock.Text);
            conexion.Open();
            OracleDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                int va = int.Parse(registro["STOCK_CRITICO"].ToString());
                int va2 = int.Parse(txtCantidad.Text) + va;
                txtStock.Text = va2.ToString();
                txtStockCritico.Text = registro["STOCK_CRITICO"].ToString();
            }
            conexion.Close();
        }

        protected void txtFecha_TextChanged(object sender, EventArgs e)
        {
            
            string provId = "";
            string tProdId = "";
            string fam = "";
            string fech = "";
            string exp = "";
            var prov = dropProducto.SelectedItem.Value;
            OracleCommand comando = new OracleCommand("SELECT PROVEEDOR_ID FROM ORDEN_PEDIDO WHERE PRODUCTO_ID =" + prov, conexion);
            comando.Parameters.Add(prov, provId);
            conexion.Open();
            OracleDataReader registro = comando.ExecuteReader();
            if (registro.Read())
            {
                provId = (registro["PROVEEDOR_ID"].ToString()).Substring(0,1);
                tProdId = dropTipoProducto.SelectedValue.Substring(0, 1);
                fam = dropFamilia.SelectedValue.Substring(0, 1);
                fech = txtFecha.Text.Replace("-", "").Substring(0, 8);
                exp = provId + fam + fech + tProdId;
                txtCodigo.Text = exp;
            }
            conexion.Close();
        }

        protected void btnCrearRecepcionProducto_Click(object sender, EventArgs e)
        {
            long codigo = long.Parse(txtCodigo.Text);
            string nombre = dropProducto.Text;
            int precio = int.Parse(txtPrecio.Text);
            int tipoProductoId = int.Parse(dropTipoProducto.SelectedValue);
            int familiaId = int.Parse(dropFamilia.SelectedValue);
            string descripcion = txtDescripcion.Text;
            int stock = int.Parse(txtStock.Text);
            int stockCritico = int.Parse(txtStockCritico.Text);

            try
            {
                Recepcion recepcion = new Recepcion();
                if (recepcion.CreateRecepcionProducto(codigo, nombre, precio, tipoProductoId, familiaId, descripcion, stock, stockCritico))
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