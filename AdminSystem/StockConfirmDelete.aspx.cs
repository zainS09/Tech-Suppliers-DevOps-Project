using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.WebSockets;
using ClassLibrary;

public partial class _1_ConfirmDelete : System.Web.UI.Page
{

    //variable to store primary key value of the record to be deleted
    Int32 StockId;
    protected void Page_Load(object sender, EventArgs e)
    {
        //get the number of the stock to be deleted from the session object
        StockId = Convert.ToInt32(Session["StockId"]);
    }

    protected void btnYes_Click(object sender, EventArgs e)
    {
        //create new instance of the stock collection
        clsStockCollection StockList = new clsStockCollection();
        //find the record to delete
        StockList.ThisStock.Find(StockId);
        //delete the record
        StockList.Delete();
        //redirect back to the main page
        Response.Redirect("StockList.aspx");
    }

    protected void btnNo_Click(object sender, EventArgs e)
    {
        //redirect back to main list page
        Response.Redirect("StockList.aspx");
    }
}