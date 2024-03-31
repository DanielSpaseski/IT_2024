using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Strucna_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=1&name=Стручна литература");
        }

        protected void Bele_Click(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=2&name=Белетристика");
        }

        protected void Mag_Link(object sender, EventArgs e)
        {
            Response.Redirect("Proizvodi.aspx?id=3&name=Магазини");
        }
    }
}