﻿using System;
using System.Web.UI.WebControls;
using Oracle.DataAccess.Client;
using System.Data;
using Hostal.Negocio;

namespace Hostal.Vista
{
    public partial class RegistrarPlatos : System.Web.UI.Page
    {
        OracleConnection conexion = new OracleConnection("DATA SOURCE = XE ; PASSWORD = 123 ; USER ID = hostal");

        protected void Page_Load(object sender, EventArgs e)
        {
            System.Diagnostics.Debug.WriteLine(IsPostBack);
            
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Administrador" || Session["perfil"] != null && Session["perfil"].ToString() == "Empleado")
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
                if(conexion.State==ConnectionState.Closed)
                conexion.Open();

                OracleCommand comando = new OracleCommand("SELECT * FROM TIPO_SERVICIO", conexion);
                OracleDataAdapter da = new OracleDataAdapter(comando);
                //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

                DataSet dt = new DataSet();
                da.Fill(dt);
                dropTipoServicio.DataTextField = "NOMBRE";
                dropTipoServicio.DataValueField = "ID";
                dropTipoServicio.DataSource = dt;
                dropTipoServicio.DataBind();
                ListItem emptyItem = new ListItem("", "");
                dropTipoServicio.Items.Insert(0, emptyItem);


                comando = new OracleCommand("SELECT * FROM TIPO_SERVICIO", conexion);
                da = new OracleDataAdapter(comando);
                //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

                dt = new DataSet();
                da.Fill(dt);
                //dropPrecioServicio.DataTextField = "PRECIO";
                //dropPrecioServicio.DataValueField = "ID";
                //dropPrecioServicio.DataSource = dt;
                //dropPrecioServicio.DataBind();
                //emptyItem = new ListItem("", "");
                //dropPrecioServicio.Items.Insert(0, emptyItem);
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
        
        protected void dropTipoServicio_SelectedIndexChanged(object sender, EventArgs e)
        {
            //var serv = dropTipoServicio.SelectedItem.Text;
            ////int eje = 0;
            //var eje = "";
            //var pre = "";
            //switch (serv)
            //{
            //    case "Ejecutivo":
            //        eje = "Arroz con Pollito";
            //        pre = "7000";
            //        break;
            //    case "Especial":
            //        eje = "Puré Con Filete de Res";
            //        pre = "10000";
            //        break;
            //    case "General":
            //        eje = "Puré con vienesa";
            //        pre = "5000";
            //        break;
            //}
            //txtPrecio.Text = eje.ToString();
            //txtPrecioFin.Text = pre.ToString();
        }

        protected void btnCrearPlato_Click(object sender, EventArgs e)
        {
            int tipoServ = int.Parse(dropTipoServicio.SelectedValue);
            string plato = inPlato.Value;
            try
            {
                Platos platos = new Platos();
                if (platos.CreatePlatos(plato, tipoServ))
                {
                    lblErrorMsg.Text = "Se ha registrado su plato, que lo disfrute";
                }
                else
                {
                    lblErrorMsg.Text = "No se ha podido registrar el plato";
                }
            }
            catch (Exception ex)
            {
                lblErrorMsg.Text = "Error: " + ex.Message.ToString();
            }

        }









    }
}