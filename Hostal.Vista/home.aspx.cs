﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Hostal.Vista
{
    public partial class home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            lblUSerDetails.Text = "Hola! " + Session["username"];
        }

        protected void btnLogOut_Click(object sender, EventArgs e)
        {

        }
    }
}