using System;
using System.Collections;
using System.Collections.Generic;
using System.EnterpriseServices;
using System.Linq;
using System.Security.Cryptography;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.WebControls.WebParts;

namespace Movies_WebForm
{
    public partial class Movies : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["cart"] != null)
            {
                ArrayList list = (ArrayList)Session["cart"];
            }

            if (!IsPostBack)
            {
                if (Session["username"] != null)
                {
                    show_username.Text = Session["username"].ToString();
                }

                string[] dramaMovies = {
                    "Toy Story",
                    "Jumanji",
                    "Grumpier Old Men",
                    "Waiting to Exhale",
                    "Father of the Bride Part II" };
                string[] dramaMoviesPrices = {
                    "45", "60", "20", "55", "30"
                };

                string[] actionMovies = {
                    "Heat",
                    "Sabrina",
                    "Tom and Huck",
                    "Sudden Death",
                    "GoldenEye", };
                string[] actionMoviesPrices = {
                    "10", "9", "9", "50", "40"
                };

                string[] comedyMovies = {
                    "Flintstones",
                    "Forrest Gump",
                    "Four Weddings and a Funeral",
                    "Higher Learning",
                    "I Like It Like That" };
                string[] comedyMoviesPrices = {
                    "20", "30", "10", "9", "25"
                };
                var categoryId = Convert.ToInt32(Request.QueryString["id"]);
                var categoryName = Request.QueryString["name"]; 
                switch (categoryId)
                {
                    case 1:
                        lbMovies.DataSource = dramaMovies;
                        lbPrices.DataSource = dramaMoviesPrices;
                        break; 
                    case 2:
                        lbMovies.DataSource = actionMovies;
                        lbPrices.DataSource= actionMoviesPrices;
                        break;
                     case 3:
                        lbMovies.DataSource = comedyMovies;
                        lbPrices.DataSource = comedyMoviesPrices;
                        break;
                }
                lbMovies.DataBind();
                lbPrices.DataBind();
            }
        }
        protected void lbMovies_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrices.SelectedIndex = lbMovies.SelectedIndex;
            totalSelected.Text = "0";
            if (ViewState["total"] == null)
            {
                ViewState["total"] = 1;
            }
            else
            {
                ViewState["total"] = Convert.ToInt32(ViewState["total"]) + 1;
            }
            totalSelected.Text = Convert.ToInt32(ViewState["total"]).ToString();
        }

        protected void linkCategories_Click(object sender, EventArgs e)
        {
            Response.Redirect("Categories.aspx");
        }

        protected void btnAdd_Click(object sender, EventArgs e)
        {
            ArrayList list;
            if (Session["cart"] == null)
            {
                list = new ArrayList();
            }
            else
            {
                list = (ArrayList)Session["cart"];
            }
            list.Add(new ListItem(lbMovies.SelectedItem.Text, lbPrices.SelectedItem.Text));
            Session["cart"] = list;
        }

        protected void btnCart_Click(object sender, EventArgs e)
        {
            Response.Redirect("ShoppingCart.aspx");
        }

        protected void lbPrices_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrices.SelectedIndex = lbMovies.SelectedIndex;
        }
    }
}