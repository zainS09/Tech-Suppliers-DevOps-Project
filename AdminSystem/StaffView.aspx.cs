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
        // Create a new instance of TblStaff
        clsStaff staff = new clsStaff();

        // Get the data from the session object
        staff = (clsStaff)Session["Staff"];

        if (staff != null)

        {

            // Display all details about the staff

            Response.Write("Staff ID: " + staff.StaffId + "<br>");

            Response.Write("Staff Name: " + staff.Name + "<br>");

            Response.Write("Staff Email: " + staff.StaffEmail + "<br>");

            Response.Write("Staff Role: " + staff.Role + "<br>");

            Response.Write("Date Hired: " + staff.DateHired.ToShortDateString() + "<br>");

            Response.Write("Is Active: " + (staff.Active ? "Yes" : "No") + "<br>");

            Response.Write("Hourly Rate: " + staff.HourlyRate.ToString("C") + "<br>");  // Assuming currency format

        }

        else

        {

            // Display a message if no staff data is available

            Response.Write("No staff data available.");

        }
    }

}