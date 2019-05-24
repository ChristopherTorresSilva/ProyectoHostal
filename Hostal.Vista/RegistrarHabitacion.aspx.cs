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
    public partial class RegistrarHabitacion : System.Web.UI.Page
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
            /*-----------------------------------------------------------*/
            conexion.Open();
            OracleCommand comando = new OracleCommand("SELECT * FROM TIPO_CAMA", conexion);
            OracleDataAdapter da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            DataSet dt = new DataSet();
            da.Fill(dt);
            dropCama.DataTextField = "NOMBRE";
            dropCama.DataValueField = "ID";
            dropCama.DataSource = dt;
            dropCama.DataBind();
            ListItem emptyItem = new ListItem("", "");
            dropCama.Items.Insert(0, emptyItem);

            /*-------------------------------------------------------------------*/
            comando = new OracleCommand("SELECT * FROM HABITACION", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            dt = new DataSet();
            da.Fill(dt);
            dropHabitacion.DataTextField = "NUMERO_HABITACION";
            dropHabitacion.DataValueField = "ID";
            dropHabitacion.DataSource = dt;
            dropHabitacion.DataBind();
            emptyItem = new ListItem("", "");
            dropHabitacion.Items.Insert(0, emptyItem);

            txtPrecio.Text = "111";

            conexion.Close();

        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            int tipoCama = int.Parse(dropCama.SelectedValue);
            int habitacion = int.Parse(dropHabitacion.SelectedValue);
            try
            {


                 OrdenCompra compra = new OrdenCompra();
                 if (compra.CreateReserva(habitacion, int.Parse(txtPrecio.Text), tipoCama))
                 {


                     lblErrorMsg.Text = "Reserva realizada. ";



                 }
                 else
                 {

                     lblErrorMsg.Text = "Error, no se ha podido reservar.";


                 }
                 
                //lblErrorMsg.Text = "Reserva realizada. ";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Error: " + ex.Message.ToString();


            }

        }

        public void Clear()
        {
            txtPrecio.Text = string.Empty;
        }

        
    }
}