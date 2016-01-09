using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Training
{
    public partial class MasterPage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
            if (Session["user"] != null)
            {
                Button1.Text = Session["user"] + " click to logout";
                Button1.Visible = true;
                HyperLink1.Visible = true;
                HyperLink2.Visible = false;
                HyperLink3.Visible = false;
            }
            else
            {
                HyperLink2.Visible = true;
                HyperLink3.Visible = true;
                HyperLink1.Visible = false;

                Button1.Visible = false;
            }
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("index.aspx");
        }
    }
}