using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movies_WebForm
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (Session["username"] == null)
            {
                Session["username"] = username.Text;
            }
            Response.Redirect("Categories.aspx");
        }
    }
}