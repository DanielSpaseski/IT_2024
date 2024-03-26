using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace WebApplication1
{
    public partial class Glasaj : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                ListItem predmet1 = new ListItem("Интернет Технологии", "Гоце Арменски");
                ListItem predmet2 = new ListItem("Интернет", "Магдалена Костоска");
                ListItem predmet3 = new ListItem("Дигитална Електроника", "Александар Стојменски");

                ListItem kredit1 = new ListItem("6", "6");
                ListItem kredit2 = new ListItem("5.5", "5.5");
                ListItem kredit3 = new ListItem("5.5", "5.5");

                lbPredmeti.Items.Add(predmet1);
                lbPredmeti.Items.Add(predmet2);
                lbPredmeti.Items.Add(predmet3);

                lbKrediti.Items.Add(kredit1);
                lbKrediti.Items.Add(kredit2);
                lbKrediti.Items.Add(kredit3);
            }
        }

        protected void lbPredmeti_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblProf.Text = lbPredmeti.SelectedValue;
            lbKrediti.SelectedIndex = lbPredmeti.SelectedIndex;
        }
        protected void lbKrediti_SelectedIndexChanged(Object sender, EventArgs e)
        {
            lblProf.Text = lbPredmeti.SelectedValue;
            lbPredmeti.SelectedIndex = lbKrediti.SelectedIndex;
        }


        protected void Glasajte_Click(object sender, EventArgs e)
        {
           if(lbPredmeti.SelectedIndex == -1)
            {
                Response.Write("Одберете професор");
            }
            else
            {
                Response.Redirect("UspeshnoGlasanje.aspx");
            }
        }

        protected void AddSubject_Click(object sender, EventArgs e)
        {
            ListItem newSubject = new ListItem(newPredmet.Text,newPredmet.Text);
            lbPredmeti.Items.Add((newSubject));
            ListItem newCredits = new ListItem(newKrediti.Text, newKrediti.Text);
            lbKrediti.Items.Add(newCredits);
        }

        protected void RemoveSubject_Click(Object sender, EventArgs e) 
        {
            var predmetToRemove = lbPredmeti.Items.FindByText(newPredmet.Text);
            var newIndex = lbPredmeti.Items.IndexOf(predmetToRemove);
            if(newIndex == -1)
            {
                Response.Write("Предметот не постои");
            }
            lbPredmeti.Items.RemoveAt(newIndex);
            lbKrediti.Items.RemoveAt(newIndex);
            lblProf.Text = "";
        }
    }
}