using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ASP_Training
{
    public partial class login : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                System.Data.OleDb.OleDbConnection conn = new
                       System.Data.OleDb.OleDbConnection();
                conn.ConnectionString = @"Provider=Microsoft Office 12.0 Access Database Engine OLE DB Provider;" +
                                        @"Data source= C:\Users\Ahmed Kamel Taha\Documents\Visual Studio 2015\Projects\ASP Training\bns.accdb";
                conn.Open();
                string q = "select count(*) from users where name='" + TextBox1.Text + "' And password='"+ TextBox2.Text+"';";
                OleDbCommand comm = new OleDbCommand(q, conn);

                if (Convert.ToInt32(comm.ExecuteScalar().ToString()) == 1)
                {
                    Session["user"] = TextBox1.Text;


                    Response.Redirect("index.aspx");
   
                }
                else
                {
                    Response.Write("<script> alert(\"wrong pass or user\"); </script>");

                }
                conn.Close();

            }catch(Exception ex)
            {
                Response.Write(ex.ToString());
            }
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}