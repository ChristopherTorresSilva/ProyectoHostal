﻿using System;
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
    public partial class RegistrarPlatos : System.Web.UI.Page
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

            comando = new OracleCommand("SELECT * FROM PLATOS", conexion);
            da = new OracleDataAdapter(comando);
            //System.Diagnostics.Debug.WriteLine(topTitle + " " + subTitle);

            dt = new DataSet();
            da.Fill(dt);
            dropPrecioServicio.DataTextField = "PRECIO";
            dropPrecioServicio.DataValueField = "ID";
            dropPrecioServicio.DataSource = dt;
            dropPrecioServicio.DataBind();
            emptyItem = new ListItem("", "");
            dropPrecioServicio.Items.Insert(0, emptyItem);
            conexion.Close();
        }

        protected void btnCrearPlato_Click(object sender, EventArgs e)
        {

            int tipoPre = int.Parse(dropPrecioServicio.SelectedValue);
            int tipoServ = int.Parse(dropTipoServicio.SelectedValue);
            try
            {
                Platos platos = new Platos();
                if (platos.CreatePlatos(tipoServ, tipoPre))
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

        public void Clear()
        {
            //txtNombre.Text = string.Empty;
            //txtApellido.Text = string.Empty;
            //txtRut.Text = string.Empty;
        }





    }
}