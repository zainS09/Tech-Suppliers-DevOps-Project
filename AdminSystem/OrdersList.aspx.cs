using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1_List : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        if (IsPostBack == false)
        {
            DisplayOrders();
        }
    }
    void DisplayOrders()
    {
        clsOrderCollection Orders = new clsOrderCollection();
        lstOrderList.DataSource = Orders.OrderList;
        lstOrderList.DataValueField = "OrderID";
        lstOrderList.DataTextField = "ShippingAdress";
        lstOrderList.DataBind();
    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["OrderId"] = -1;
        Response.Redirect("OrdersDataEntry.aspx");
    }




    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 OrderID;
        if (lstOrderList.SelectedIndex != -1)
        {
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            Session["OrderId"] = OrderID;
            Response.Redirect("OrdersDataEntry.aspx");
        }
        else
        {
            lblError.Text = "Please select a record from list to edit";
        }
    }

    protected void lstCustomerList_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void Button1_Click(object sender, EventArgs e)
    {

    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        // variable to store the primary key value of the record to be deleted
        Int32 OrderID;
        // if a record has been selected from the list
        if (lstOrderList.SelectedIndex != -1)
        {
            // get the primary key value of the record to delete
            OrderID = Convert.ToInt32(lstOrderList.SelectedValue);
            // store the data in the session object
            Session["OrderId"] = OrderID;
            // redirect to the delete confirmation page
            Response.Redirect("OrderConfirmDelete.aspx");
        }
        else
        {
            // if no record has been selected
            lblError.Text = "Please select a record from the list to delete";
        }
    }

    protected void Button1_Click1(object sender, EventArgs e)
    {

    }

    protected void BtnClear_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff collection object
        clsOrderCollection OrderCollection = new clsOrderCollection();
        // Set an empty string to clear the filter
        OrderCollection.ReportByAdress("");
        // Clear any existing filter to tidy up the interface
        txtFilter.Text = "";
        // Set the data source to the list of staff in the collection
        lstOrderList.DataSource = OrderCollection.OrderList;
        // Set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // Set the name of the field to display
        lstOrderList.DataTextField = "ShippingAdress";
        // Bind the data to the list
        lstOrderList.DataBind();

    }

    protected void TextBox1_TextChanged(object sender, EventArgs e)
    {

    }

    protected void BtnApply_Click(object sender, EventArgs e)
    {
        // Create an instance of the staff collection object
        clsOrderCollection OrderCollection = new clsOrderCollection();
        // Retrieve the value of the role from the presentation layer
        OrderCollection.ReportByAdress(txtFilter.Text);
        // Set the data source to the list of staff in the collection
        lstOrderList.DataSource = OrderCollection.OrderList;
        // Set the name of the primary key
        lstOrderList.DataValueField = "OrderId";
        // Set the name of the field to display
        lstOrderList.DataTextField = "ShippingAdress";
        // Bind the data to the list
        lstOrderList.DataBind();
    }

    protected void Button1_Click2(object sender, EventArgs e)
    {
        Response.Redirect("TeamMainMenu.aspx");
    }
}
