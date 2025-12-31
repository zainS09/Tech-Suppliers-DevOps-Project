using System;
using System.Collections.Generic;
using System.Web.UI;
using ClassLibrary;

public partial class _1_List : Page
{
    // variable to store the primary key with page level scope
    int StaffID;


    protected void Page_Load(object sender, EventArgs e)
    {
        // create a new instance of clsStaffUser
        clsStaffUser AnUser = new clsStaffUser();
        // get data from the session object
        AnUser = (clsStaffUser)Session["AUser"];
        // display the user name
        Response.Write("Logged in as: " + AnUser.UserName);
        // if this is the first time the page is displayed
        if (!IsPostBack)
        {
            // update the list box
            DisplayStaff();
        }
        
    }


    void DisplayStaff()
    {
        // create an instance of the Staff collection
        clsStaffCollection StaffCollection = new clsStaffCollection();
        // set the data source to the list of staff in the collection
        lstStaffList.DataSource = StaffCollection.StaffList;
        // set the name of the primary key
        lstStaffList.DataValueField = "StaffId";
        // set the data field to display
        lstStaffList.DataTextField = "Name"; 
        // bind the data to the list
        lstStaffList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        // store -1 into the session object to indicate this is a new record
        Session["StaffId"] = -1;
        // redirect to the data entry page
        Response.Redirect("StaffDataEntry.aspx");
    }


    protected void btnEdit_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be edited
        int StaffID;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to edit
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffID;
            // redirect to the edit page
            Response.Redirect("StaffDataEntry.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to edit.";
        }
    }


    protected void lstStaffList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 StaffID;
        // if a record has been selected from the list
        if (lstStaffList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            StaffID = Convert.ToInt32(lstStaffList.SelectedValue);
            // store the data in the session object
            Session["StaffId"] = StaffID;
            // redirect to the delete confirmation page
            Response.Redirect("StaffConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        
            // Create an instance of the staff collection object
            clsStaffCollection StaffCollection = new clsStaffCollection();
            // Retrieve the value of the role from the presentation layer
            StaffCollection.ReportByRole(txtFilter.Text);
            // Set the data source to the list of staff in the collection
            lstStaffList.DataSource = StaffCollection.StaffList;
            // Set the name of the primary key
            lstStaffList.DataValueField = "StaffId";
            // Set the name of the field to display
            lstStaffList.DataTextField = "Name";
            // Bind the data to the list
            lstStaffList.DataBind();
        

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        
            // Create an instance of the staff collection object
            clsStaffCollection StaffCollection = new clsStaffCollection();
            // Set an empty string to clear the filter
            StaffCollection.ReportByRole("");
            // Clear any existing filter to tidy up the interface
            txtFilter.Text = "";
            // Set the data source to the list of staff in the collection
            lstStaffList.DataSource = StaffCollection.StaffList;
            // Set the name of the primary key
            lstStaffList.DataValueField = "StaffId";
            // Set the name of the field to display
            lstStaffList.DataTextField = "Name";
            // Bind the data to the list
            lstStaffList.DataBind();
        

    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
