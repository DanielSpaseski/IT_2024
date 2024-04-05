using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Movies_WebForm
{
    public partial class ShoppingCart : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                if (Session["cart"] == null)
                {
                    isEmptyCart.Text = "Your Shopping cart is empty";
                }
                else
                {
                    int sum = 0;
                    ArrayList list = (ArrayList)Session["cart"];
                    lbItems.DataSource = list;
                    lbItems.DataBind();
                    foreach (ListItem item in list)
                    {
                        sum += Convert.ToInt32(item.Value);
                    }
                    totalSum.Text = sum.ToString();
                }
            }
        }

        protected void btnBuy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Order.aspx");
        }

        protected void backCat_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categories.aspx");
        }

        protected void removeItem_Click(object sender, EventArgs e)
        {
                if (lbItems.SelectedIndex != -1)
                {
                    int sum = 0;
                    ArrayList list = (ArrayList)Session["cart"];
                    list.RemoveAt(lbItems.SelectedIndex);
                    Session["cart"] = list;
                    lbItems.DataSource = list;
                    lbItems.DataBind();
                    foreach (ListItem item in list)
                    {
                        sum += Convert.ToInt32(item.Value);
                    }
                    if(sum == 0)
                {
                    isEmptyCart.Text = "Your Shopping cart is empty";
                }
                    totalSum.Text = sum.ToString();
                }
           
        }

    
    }
}