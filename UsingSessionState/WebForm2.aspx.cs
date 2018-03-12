using System;
namespace UsingSessionState
{
    public partial class WebForm2
    : System.Web.UI.Page
    {
        protected void Page_Load(
        object sender, EventArgs e)
        {
            if (Session["Name"] != null)
                Label1.Text = String.Format(
                "Welcome, {0}", Session["Name"]);
            else
                Response.Redirect("WebForm1.aspx");
        }
        protected void Button1_Click(
        object sender, EventArgs e)
        {
            Session.Remove("Name");
            Response.Redirect("WebForm1.aspx");
        }
    }
}