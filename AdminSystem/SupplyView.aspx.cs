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
        //create a new instance of clsSupply
        clsSupply ASupply = new clsSupply();

        //get the data from the session object
        ASupply = (clsSupply)Session["ASupply"];

        //display the Supply Contact for this entry
        Response.Write(ASupply.SupplierContact);
        Response.Write(ASupply.PriceOfResource);
        Response.Write(ASupply.DateRequested);
        Response.Write(ASupply.ToBeDeliveredBy);
        Response.Write(ASupply.AvailabilityOfSupplier);

    }
}