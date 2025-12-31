using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{
    //variable to store the primary key with page level scope
    Int32 SupplyID;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the supply to be processed
        SupplyID = Convert.ToInt32(Session["SupplyID"]);
        if (IsPostBack == false)
        {
            //if this is not a new record 
            if (SupplyID != -1)
            {
                //display the current data for the record
                DisplaySupply();
            }
        }    
    }
    void DisplaySupply()
    {
        //create an instance of the supply book
        clsSupplyCollection Supply = new clsSupplyCollection();
        //find the record to update
        Supply.ThisSupply.Find(SupplyID);
        //display the data for the record
        txtSupplierID.Text = Supply.ThisSupply.SupplyID.ToString();
        txtSupplierContact.Text = Supply.ThisSupply.SupplierContact.ToString();
        txtPriceOfResource.Text = Supply.ThisSupply.PriceOfResource.ToString();
        txtDateRequested.Text = Supply.ThisSupply.DateRequested.ToString();
        txtToBeDeliveredBy.Text = Supply.ThisSupply.ToBeDeliveredBy.ToString();
        chkAvailabilityOfSupplier.Checked = Supply.ThisSupply.AvailabilityOfSupplier;
    }

    protected void btnOK_Click(object sender, EventArgs e)
    {
        //create a new instance of clsSupply
        clsSupply ASupply = new clsSupply();


        //capture the supplier contact
        string SupplierContact = txtSupplierContact.Text;
        //capture the price of resource
        string PriceOfResource = txtPriceOfResource.Text;
        //capture the date requested
        string DateRequested = txtDateRequested.Text;
        //capture the to be delivered by
        string ToBeDeliveredBy = txtToBeDeliveredBy.Text;
        //capture Active check box
        string AvailabilityOfSupplier = chkAvailabilityOfSupplier.Text;

        //variable to store any error messages
        string Error = "";
        //validate the data
        Error = ASupply.Valid(SupplierContact, PriceOfResource, DateRequested, ToBeDeliveredBy);
        if (Error == "")
        {
            //capture the Supply ID
            ASupply.SupplyID = SupplyID;
            //capture the supplier contact
            ASupply.SupplierContact = SupplierContact;
            //capture the price of resource
            ASupply.PriceOfResource = Convert.ToDouble(PriceOfResource);
            //capture the date requested
            ASupply.DateRequested = Convert.ToDateTime(DateRequested);
            //capture the to be delivered by  
            ASupply.ToBeDeliveredBy = Convert.ToDateTime(ToBeDeliveredBy);

            //capture AvailabilityOfSupplier
            ASupply.AvailabilityOfSupplier = chkAvailabilityOfSupplier.Checked;

            //create a new instance of the supply collection
            clsSupplyCollection SupplyList = new clsSupplyCollection();

            //if this is a new record i.e. SupplyID = -1 then add the data
            if (SupplyID == -1)
            {
                //set the ThisSupply property
                SupplyList.ThisSupply = ASupply;
                //add the new record
                SupplyList.Add();
            }
            //otherwise it must be an update
            else
            {
                //find the record to update
                SupplyList.ThisSupply.Find(SupplyID);
                //set the ThisSupply property
                SupplyList.ThisSupply = ASupply;
                //update the record
                SupplyList.Update();
            }
            //redirect back to the list page
            Response.Redirect("SupplyList.aspx");
        }
        else
        {
            //display the error message
            lblError.Text = Error;
        }
    }
        

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsSupply ASupply = new clsSupply();
        //create a variable to store the primary key
        Int32 SupplyID;
        //create a variable to store the result of the find operation
        Boolean Found = false;
        //get the primary key entered by the user
        SupplyID = Convert.ToInt32(txtSupplierID.Text);
        //find the record
        Found = ASupply.Find(SupplyID);
        //if found
        if (Found == true)
        {
            //display the values of the properties in the form
            txtSupplierContact.Text = ASupply.SupplierContact.ToString();
            txtPriceOfResource.Text = ASupply.PriceOfResource.ToString();
            txtDateRequested.Text = ASupply.DateRequested.ToString();
            txtToBeDeliveredBy.Text = ASupply.ToBeDeliveredBy.ToString();
            chkAvailabilityOfSupplier.Checked = ASupply.AvailabilityOfSupplier;
            lblError.Text = "";
        }
        else
        {
            txtSupplierContact.Text = "";
            txtPriceOfResource.Text = "";
            txtDateRequested.Text = "";
            txtToBeDeliveredBy.Text = "";
            chkAvailabilityOfSupplier.Checked = false;
            lblError.Text = "ERROR: THE ID YOU ENTERED NOT FOUND!";
            lblError.Visible = true;
        }
    }

    protected void btnReturn_Click(object sender, EventArgs e)
    {
        //redirect to the main menu 
        Response.Redirect("TeamMainMenu.aspx");
    }

    protected void btnCancel_Click(object sender, EventArgs e)
    {
        //navigate to the Supply List Page
        Response.Redirect("SupplyList.aspx");
    }
}