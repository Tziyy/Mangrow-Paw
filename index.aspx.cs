using System;
using System.Web.UI; // Make sure this is here

namespace MangrowPaw
{
    // Ensure "public partial class Default" matches the "Inherits" attribute in your .aspx
    // And MUST include ": System.Web.UI.Page"
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Your logic here
        }
    }
}