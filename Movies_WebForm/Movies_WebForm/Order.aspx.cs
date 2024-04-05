using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movies_WebForm
{
    public partial class Order : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cart"] == null)
                {
                    Response.Redirect("ShoppingCart.aspx");
                }
                if (Session["username"] != null)
                {
                    username.Text = Session["username"].ToString();
                }
            }
        }
    }
}