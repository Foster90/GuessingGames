using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GuessingGames
{
    public partial class Start : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                DropDownList1.Items.Add("Easy");
                DropDownList1.Items.Add("Medium");
                DropDownList1.Items.Add("Hard");
            }
            HtmlGenericControl Body = (HtmlGenericControl)Master.FindControl("Body");
            Body.Attributes.Add("style", "background-color: #0d1b2a");

        }
         
        protected void Start_Button_Click(object sender, EventArgs e)
        {
            Response.Redirect("Game.aspx?Parameter=" + DropDownList1.Text);
        }
    }
}