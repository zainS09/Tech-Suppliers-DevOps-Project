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
            DisplayAllStock();
        }

        //create a new instance of clsStockUser
        clsStockUser User = new clsStockUser();
        //get data from session object
        User = (clsStockUser)Session["User"];
        //display the user name
        Response.Write("Logged in as: " + User.UserName);
    }

    protected void lstStockList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    void DisplayAllStock()
    {
        //create an instance of the stock collection
        clsStockCollection StockItems = new clsStockCollection();
        //set the data source to list of addresses in collection
        lstStockList.DataSource = StockItems.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the data field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();
    }




    protected void btnAdd_Click(object sender, EventArgs e)
    {
        //store -1 into the session object to indicate this is a new record
        Session["StockId"] = -1;
        //redirect to the data entry page
        Response.Redirect("StockDataEntry.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        //variable to store the primary key value of the record to be edited
        Int32 StockId;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to edit
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the edit page
            Response.Redirect("StockDataEntry.aspx");
        }
        else
        {
            //if no record is selected
            lblError.Text = "Please select a record from the list to edit";
        }
    }




    protected void btnDelete_Click(object sender, EventArgs e)
    {
        //variable to store primary key value of the record to be deleted
        Int32 StockId;
        //if a record has been selected from the list
        if(lstStockList.SelectedIndex != -1)
        {
            //get the primary key value of the record to delete
            StockId = Convert.ToInt32(lstStockList.SelectedValue);
            //store the data in the session object
            Session["StockId"] = StockId;
            //redirect to the delete page
            Response.Redirect("StockConfirmDelete.aspx");
        }
        else
        {
            //if no record selected, display error message
            lblError.Text = "Please select a record from the list to delete";
        }
    }



    protected void btnFilterApply_Click(object sender, EventArgs e)
    {
        //create instance of stock object 
        clsStockCollection StockItem = new clsStockCollection();
        //retrieve the value of the name from presentation layer
        StockItem.ReportByItemName(txtItemNameFilter.Text);
        //set the data source to the list of stock items in collection
        lstStockList.DataSource = StockItem.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the name of the field to display
        lstStockList.DataTextField = "ItemName";
        //bind the data to the list
        lstStockList.DataBind();

    }

    protected void btnFilterClear_Click(object sender, EventArgs e)
    {
        //crete an instance
        clsStockCollection StockItem = new clsStockCollection();
        //set an empty string
        StockItem.ReportByItemName("");
        //clear any existing filter to clear interface
        txtItemNameFilter.Text = "";
        //set the data source to the list of addresses in the collection
        lstStockList.DataSource = StockItem.StockList;
        //set the name of the primary key
        lstStockList.DataValueField = "StockId";
        //set the name of the field to display
        lstStockList.DataTextField = "ItemName";
        //bind data to list
        lstStockList.DataBind();
    }


    protected void btnReturnToMenu_Click(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }

  
}