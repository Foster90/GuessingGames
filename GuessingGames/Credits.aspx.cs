using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GuessingGames
{
    public partial class Contact : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            HtmlGenericControl Body = (HtmlGenericControl)Master.FindControl("Body");
            Body.Attributes.Add("style", "background-color: #0d1b2a");
        }
    }
}