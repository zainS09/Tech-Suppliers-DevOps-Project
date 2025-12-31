using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class StockLogin : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnLogin_Click(object sender, EventArgs e)
    {
        //create instance
        clsStockUser User = new clsStockUser();
        //vars to store un and pw
        string UserName = txtUserName.Text;
        string Password = txtPassword.Text;
        //create var to store the result of the find user operation
        Boolean Found = false;
        //get the user name entered
        UserName = Convert.ToString(txtUserName.Text);
        // get the pw
        Password = Convert.ToString(txtPassword.Text);  
        //find the record
        Found = User.FindUser(UserName, Password);
        //Add a session to capture user name
        Session["User"] = User;
        //if user name and/or pw is empty
        if(txtUserName.Text == "")
        {
            lblError.Text = "Enter a username ";
        }
        else if(txtPassword.Text == "")
        {
            lblError.Text = "Enter a password";
        }
        //if found
        else if (Found == true)
        {
            Response.Redirect("StockList.aspx");
        }
        else if (Found == false)
        {
            lblError.Text = "Login failed. Try again ";
        }
    }



    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //when cancel clicked, redirect to main menu
        Response.Redirect("TeamMainMenu.aspx");
    }
}