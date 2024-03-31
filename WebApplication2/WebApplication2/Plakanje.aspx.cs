using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Plakanje : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                int sum = 0;
                ArrayList list;
                list = (ArrayList)Session["cart"];
                lbPay.DataSource = list;
                lbPay.DataBind();
                foreach (ListItem listItem in list) 
                {
                    sum += Convert.ToInt32(listItem.Value);
                }
                totalSum.Text = sum.ToString();
            }
        }
    }
}