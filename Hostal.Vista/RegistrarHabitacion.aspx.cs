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

                if (Session["perfil"] != null && Session["perfil"].ToString() == "Administrador")
                {
                    if (!IsPostBack)
                    {
                        init();
                    }
                }
                if (Session["perfil"] != null && Session["perfil"].ToString() == "Usuario Empresa")
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
            //enumeracion
            /*dropHuesped.Items.Clear();
            foreach (enumeracion tipo in Enum.GetValues(typeof(enumeracion)))
            {
                dropHuesped.Items.Add(new ListItem()
                {
                    Text = tipo.ToString(),
                    Value = ((int)tipo).ToString()
                });
            }*/

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

            txtPrecio.Text = "0";



            comando = new OracleCommand("SELECT * FROM EMPRESA", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            dt = new DataSet();
            da.Fill(dt);
            dropEmpresa.DataTextField = "NOMBRE";
            dropEmpresa.DataValueField = "ID";
            dropEmpresa.DataSource = dt;
            dropEmpresa.DataBind();
            emptyItem = new ListItem("", "");
            dropEmpresa.Items.Insert(0, emptyItem);



            comando = new OracleCommand("SELECT * FROM TIPO_SERVICIO", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            dt = new DataSet();
            da.Fill(dt);
            dropServicio.DataTextField = "NOMBRE";
            dropServicio.DataValueField = "ID";
            dropServicio.DataSource = dt;
            dropServicio.DataBind();
            emptyItem = new ListItem("", "");
            dropServicio.Items.Insert(0, emptyItem);

            comando = new OracleCommand("SELECT * FROM HUESPED", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            dt = new DataSet();
            da.Fill(dt);
            huespedAntiguo.DataTextField = "NOMBRE";
            huespedAntiguo.DataValueField = "ID";
            huespedAntiguo.DataSource = dt;
            huespedAntiguo.DataBind();
            emptyItem = new ListItem("", "");
            huespedAntiguo.Items.Insert(0, emptyItem);
            conexion.Close();

        }

        protected void btnReservar_Click(object sender, EventArgs e)
        {
            /*System.Diagnostics.Debug.WriteLine(int.Parse(dropHuesped.SelectedItem.Value));*/
            try
            {
                int tipoCama = int.Parse(dropCama.SelectedValue);
                int habitacion = int.Parse(dropHabitacion.SelectedValue);
                if (int.Parse(dropHuesped.SelectedValue) == 1)
                {
                    OrdenCompra compra = new OrdenCompra();
                    if (compra.CreateReserva(int.Parse(huespedAntiguo.SelectedValue), int.Parse(dropServicio.SelectedValue),
                        int.Parse(dropHabitacion.SelectedValue), int.Parse(dropServicio.SelectedValue)))
                    {
                        lblErrorMsg.Text = "Reserva realizada. ";
                    }
                    else
                    {
                        lblErrorMsg.Text = "Error, no se ha podido reservar.";
                    }
                }else
                {
                    if(int.Parse(dropHuesped.SelectedValue) == 2)
                    {
                        OrdenCompra compra = new OrdenCompra();
                        if (compra.CreateReservaHuesped(txtNombre.Text, txtApellido.Text, txtRut.Text, int.Parse(dropEmpresa.SelectedValue),
                            int.Parse(dropHabitacion.SelectedValue), int.Parse(dropServicio.SelectedValue), "Test", int.Parse(txtPrecio.Text),
                            int.Parse(dropServicio.SelectedValue)))
                        {
                            lblErrorMsg.Text = "Reserva realizada. ";
                        }
                        else
                        {
                            lblErrorMsg.Text = "Error, no se ha podido reservar.";
                        }
                    }
                }
     
                //lblErrorMsg.Text = "Reserva realizada. ";
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Error: " + ex.Message.ToString();


            }

           

        }

        //Opcion para mostrar el precio segun el tipo de cama 
        /*protected void dropCama_SelectedIndexChanged(object sender, EventArgs e)
        {
            var valor = dropCama.SelectedItem.Text;
            int eje = 0;

            switch (valor)
            {
                case "Simple":
                    eje = 40000;
                    break;
                case "Doble":
                    eje = 60000;
                    break;
            }
            txtPrecio.Text = eje.ToString();
        }*/

        public void Clear()
        {
            txtPrecio.Text = string.Empty;
        }

        public enum enumeracion
        {
            Seleccionar, Antiguo, Nuevo
        }
        protected void dropHuesped_SelectedIndexChanged1(object sender, EventArgs e)
        {
            if (dropHuesped.SelectedItem.ToString() == "Antiguo")
            {
                huespedAntiguo.Enabled = true;
                dropHabitacion.Enabled = true;
                dropServicio.Enabled = true;
                dropCama.Enabled = true;
               
            }
            else
            {
                huespedAntiguo.Enabled = false;
            }

            if (dropHuesped.SelectedItem.ToString() == "Nuevo")
            {
                txtNombre.Enabled = true;
                txtApellido.Enabled = true;
                txtRut.Enabled = true;
                dropEmpresa.Enabled = true;
                dropHabitacion.Enabled = true;
                dropServicio.Enabled = true;
                dropCama.Enabled = true;
            }
            else
            {
                txtNombre.Enabled = false;
                txtApellido.Enabled = false;
                txtRut.Enabled = false;
                dropEmpresa.Enabled = false;
            }
        }
    }
}