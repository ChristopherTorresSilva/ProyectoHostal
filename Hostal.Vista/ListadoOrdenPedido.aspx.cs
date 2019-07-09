﻿using Hostal.Negocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hostal.Vista
{
    public partial class ListadoOrdenPedido : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Administrador")
            {
                if (!IsPostBack)
                {
                    init();
                }
            }
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Empleado")
            {
                if (!IsPostBack)
                {
                    init();
                }
            }
            if (Session["perfil"] != null && Session["perfil"].ToString() == "Proveedor")
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

        private void init()
        {
            try
            {
                ListaOrdenPedido();
            }
            catch (Exception)
            {

                throw;
            }
        }

        public void ListaOrdenPedido()
        {
            try
            {
                OrdenPedido ordenPedido = new OrdenPedido();
                DataTable dt = new DataTable();

                dt = ordenPedido.ListaOrdenPedido();

                gridUser.DataSource = dt;
                gridUser.DataBind();
                ordenPedido = null;
                dt.Dispose();
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