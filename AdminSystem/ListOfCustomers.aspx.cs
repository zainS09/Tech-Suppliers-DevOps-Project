using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{
    Int32 CustomerId;
    protected void Page_Load(object sender, EventArgs e)
    {
       if(IsPostBack == false)
        {
            DisplayCustomers();
        }
    clsCustomerUser AUser = new clsCustomerUser();
        AUser = (clsCustomerUser)Session["AUser"];
        Response.Write("Logged in as: " + AUser.UserName);
    }
    void DisplayCustomers()
    {
        clsCustomerCollection Customers = new clsCustomerCollection();  
        lstCustomerList.DataSource = Customers.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind(); 
    }

   
    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerId"] = -1;
        Response.Redirect("CustomerDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerId;
        if(lstCustomerList.SelectedIndex != -1)
        {
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            Session["CustomerId"] = CustomerId;
            Response.Redirect("CustomerDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from list to edit";
        }

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //var to store the primary key value of the record to be edited
        Int32 CustomerId;
        //if a record has been selected from the list
        if (lstCustomerList.SelectedIndex != -1)
        {
            //het the primary key value of the record to edit
            CustomerId = Convert.ToInt32(lstCustomerList.SelectedValue);
            //stroe the data in the session object
            Session["CustomerId"] = CustomerId;
            //redirect to delete page
            Response.Redirect("CustomerConfirmDelete.aspx");
        }
        else//if no records has benn select.
        {

            lblError.Text = "Please select a record to delete from the list";
            lblError.Visible = true;
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByFullName(txtFilter.Text);
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind(); 
    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection ACustomer = new clsCustomerCollection();
        ACustomer.ReportByFullName("");
        txtFilter.Text = "";
        ACustomer.ReportByFullName(txtFilter.Text);
        lstCustomerList.DataSource = ACustomer.CustomerList;
        lstCustomerList.DataValueField = "CustomerId";
        lstCustomerList.DataTextField = "FullName";
        lstCustomerList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}