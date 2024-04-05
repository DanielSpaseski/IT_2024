using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movies_WebForm
{
    public partial class Categories : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["username"] != null)
                {
                    show_username.Text = Session["username"].ToString();
                }
            }
        }

        protected void linkDrama_Click(object sender, EventArgs e)
        {
            Response.Redirect("Movies.aspx?id=1&name=Drama");
        }

        protected void linkAction_Click(object sender, EventArgs e)
        {
            Response.Redirect("Movies.aspx?id=2&name=Action");
        }

        protected void linkComedy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Movies.aspx?id=3&name=Comedy");
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }
    }
}