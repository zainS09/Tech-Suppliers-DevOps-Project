using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    protected void Page_Load(object sender, EventArgs e)
    {
        //if this is the first time the page is displayed
        if (IsPostBack == false)
        {
            //update the list box
            DisplaySupplies();
        }

        //create a new instance of clsSupplyUser
        clsSupplyUser AUser = new clsSupplyUser();
        //get data from the session object
        AUser = (clsSupplyUser)Session["AUser"];
        //display the user name
        Response.Write("Logged in as: " + AUser.UserName);
    }
    protected void lstSupplyList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }
    void DisplaySupplies()
    {
        //create an instance of the Supply collection 
        clsSupplyCollection Supplies = new clsSupplyCollection();  
        //set the data source to list of supplies in the collection 
        lstSupplyList.DataSource = Supplies.SupplyList;
        //set the name of the primary key
        lstSupplyList.DataValueField = "SupplyID";
        //set the data field to display
        lstSupplyList.DataTextField = "SupplierContact";
        //bind the data to the list
        lstSupplyList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["SupplyID"] = -1;
        //redirect to the data entry page
        Response.Redirect("SupplyDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 SupplyID;
        //if a record has been selected from the list
        if (lstSupplyList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            SupplyID = Convert.ToInt32(lstSupplyList.SelectedValue);
            //store the data in the session object
            Session["SupplyID"] = SupplyID;
            //redirect to the edit page
            Response.Redirect("SupplyDataEntry.aspx");
        }
        else    //if no record has been selected
        {
            lblError.Text = "At least a record must be selected";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be deleted
        Int32 SupplyID;
        //if a record has been selected from the list
        if (lstSupplyList.SelectedIndex != -1)
        {
            //get the primary key value of the record delete
            SupplyID = Convert.ToInt32(lstSupplyList.SelectedValue);
            //store the data in the session object
            Session["SupplyID"] = SupplyID;
            //redirect to the delete page
            Response.Redirect("SupplyConfirmDelete.aspx");
        }
        else   //if no record has been selected
        {
            //display an error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApplyFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Supply object
        clsSupplyCollection ASupply = new clsSupplyCollection();
        //retrieve the value of Supply Contact from the presentation layer
        ASupply.ReportBySupplierContact(txtSupplierContactFilter.Text);
        //set the data source to the list of Suppliers in the collection
        lstSupplyList.DataSource = ASupply.SupplyList;
        //set the name of the primary key
        lstSupplyList.DataValueField = "SupplyID";
        //bind the data to the list
        lstSupplyList.DataBind();
    }

    protected void btnClearFilter_Click(object sender, EventArgs e)
    {
        //create an instance of the Supply object
        clsSupplyCollection ASupply = new clsSupplyCollection();
        //set an empty string
        ASupply.ReportBySupplierContact("");
        //clear any existing filter to tidy up the interface
        txtSupplierContactFilter.Text = "";
        //set the data source to the list of Suppliers in the collection
        lstSupplyList.DataSource = ASupply.SupplyList;
        //set the name of the primary key
        lstSupplyList.DataValueField = "SupplyID";
        //set the name of the field to display
        lstSupplyList.DataTextField = "SupplierContact";
        //bind the data to the list
        lstSupplyList.DataBind();
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu 
        Response.Redirect("TeamMainMenu.aspx");
    }
}