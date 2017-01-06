using System;
using System.Web;
using System.Web.UI;
using csharp_assmnt_mono.models;

namespace csharp_assmnt_mono.views
{
	
	public partial class register : System.Web.UI.Page
	{
		protected void Register(object sender, EventArgs e)
		{
			bool isRegistered = models.User.register(txtName.Text,TxtEmail.Text,txtPWD.Text);
			if (isRegistered)
				Response.Redirect("login.aspx");
			else
				ClientScript.RegisterStartupScript(Page.GetType(), "validation", "<script language='javascript'>alert('There was an error in the registration request')</script>");

		}
	}
}

