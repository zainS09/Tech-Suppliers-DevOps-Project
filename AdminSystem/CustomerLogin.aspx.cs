using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class CustomerLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        clsCustomerUser AUser = new clsCustomerUser();
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        Boolean Found = false;
        UserName = Convert.ToString(txtUserName.Text);
        Password = Convert.ToString(txtPassword.Text);
        Found = AUser.FindUser(UserName, Password);
        Session["AUser"] = AUser;
        if (txtUserName.Text == "")
        {
            lblError.Text = "Enter a Username ";
        }
        else if (txtPassword.Text == "")
        {
            lblError.Text = "Enter a Password ";
        }
        else if (Found == true)
        {
            Response.Redirect("ListOfCustomers.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login details are incorrect. Please try again ";
        }
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}