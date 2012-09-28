using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.Routing;

namespace UrlRouting
{
    public partial class customer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            string id = Page.RouteData.Values["Id"].ToString();
            //string id = "1";
            Response.Write("<h1>Customer Details page</h1>");
            Response.Write(string.Format("Displaying information for customer : {0}", id));
        }
    }
}