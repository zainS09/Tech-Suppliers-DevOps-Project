using ClassLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _1Viewer : System.Web.UI.Page
{
    protected void Page_Load(object sender, EventArgs e)
    {
        clsCustomer ACustomer = new clsCustomer();
        ACustomer = (clsCustomer)Session["ACustomer"];
        Response.Write(ACustomer.Email);
        Response.Write(ACustomer.Address);
        Response.Write(ACustomer.FullName);
        Response.Write(ACustomer.Password);
        Response.Write(ACustomer.CustomerId);
        Response.Write(ACustomer.DateOfBirth);
        Response.Write(ACustomer.Active);
    }
}