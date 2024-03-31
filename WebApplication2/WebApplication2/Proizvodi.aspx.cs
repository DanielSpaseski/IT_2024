using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication2
{
    public partial class Proizvodi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            ArrayList list;
            if (Session["cart"] != null)
            {
                list = (ArrayList)Session["cart"];
                lbShoppingCart.DataSource = list;
                lbShoppingCart.DataBind();
            }

            if (!IsPostBack)
            {

                // База на податоци
                string[] sl = {
                    "Modern Operating Systems by Andrew S. Tanenbaum",
                    "Advanced Programming in the UNIX Environment by W. Richard Stevens",
                    "The Mythical Man-month by Frederick Phillips Brooks",
                    "Introduction to the Theory of Computation by Michael Sipser",
                    "Thinking in Systems: A Primer by Donella H. Meadows"
                };

                string[] sl_c = {
                    "45", "60", "20", "55", "30"
                };

                string[] be = {
                    "Origin by Dan Brown",
                    "The Hobbit by J. R. R. Tolkien",
                    "Harry Potter and the Philosopher's Stone by J. K. Rowling",
                    "Sherlock Holmes Series by Arthur Conan Doyle",
                    "Hercule Poirot Mysteries Series by Agatha Christie"
                };

                string[] be_c = {
                    "10", "9", "9", "50", "40"
                };

                string[] mg = {
                    "WIRED",
                    "PC Magazine",
                    "MIT Technology Review",
                    "Linux Magazine",
                    "Fast Company"
                };

                string[] mg_c = {
                    "2", "3", "1", "3", "2"
                };

                var categoryId = Convert.ToInt32(Request.QueryString["id"]);
                var categoryName = Request.QueryString["name"];
                category.Text = categoryName;
                switch (categoryId)
                {
                    case 1:
                        lbTitles.DataSource = sl;
                        lbPrices.DataSource = sl_c;
                        break;
                    case 2:
                        lbTitles.DataSource = be;
                        lbPrices.DataSource = be_c;
                        break;
                    case 3:
                        lbTitles.DataSource = mg;
                        lbPrices.DataSource = mg_c;
                        break;
                }
                lbTitles.DataBind();
                lbPrices.DataBind();
            }
        }

        protected void lbTitles_SelectedIndexChanged(object sender, EventArgs e)
        {
            lbPrices.SelectedIndex = lbTitles.SelectedIndex;
            total.Text = "Тотал:";
            if (ViewState["totalChanges"] == null)
            {
                ViewState["totalChanges"] = 1;
            }
            else
            {
                ViewState["totalChanges"] = (int)ViewState["totalChanges"] + 1;
            }
            total.Text = "Тотал:" + ((int)ViewState["totalChanges"]).ToString();
        }

        protected void Back_Click(object sender, EventArgs e)
        {
            Response.Redirect("Katalog.aspx");
        }

        protected void AddItem_Click(object sender, EventArgs e)
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
            list.Add(new ListItem(lbTitles.SelectedItem.Text, lbPrices.SelectedItem.Text));
            lbShoppingCart.DataSource = list;
            lbShoppingCart.DataBind();
            Session["cart"] = list; 
        }

        protected void Buy_Click(object sender, EventArgs e)
        {
            Response.Redirect("Plakanje.aspx");
        }
    }
}