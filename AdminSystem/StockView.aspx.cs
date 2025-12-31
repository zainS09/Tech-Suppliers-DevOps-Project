using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        //create a new instance of class
        clsStock StockItem = new clsStock();

        //get the data from the session object
        StockItem = (clsStock)Session["StockItem"];

        //display the data from this entry
        Response.Write(StockItem.ItemName + " ");
        Response.Write(StockItem.Quantity + " ");
        Response.Write(StockItem.Price + " ");
        Response.Write(StockItem.ArrivedOn + " ");
        Response.Write(StockItem.SupplierId + " ");
        Response.Write(StockItem.Available + " ");
    }
}