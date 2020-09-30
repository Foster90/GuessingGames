using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Web.UI.HtmlControls;

namespace GuessingGames
{
    public partial class Game : Page

    {
        Random random = new Random();
        static int randomNum = 0;
        static int guess = 0;
        static int attempts = 0;        
        string diffcult;
        


        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                setDiffcult();
               
            }
            HtmlGenericControl Body = (HtmlGenericControl)Master.FindControl("Body");
            Body.Attributes.Add("style", "background-color: #0d1b2a");

        }

            
        protected void Guess_Click(object sender, EventArgs e)
        {
            attempts++;
            int userGuess = 0;
            int guessleft = guess - attempts;
                      
            if(guess > attempts)

            {

                try { Int32.TryParse(TextBox1.Text, out userGuess); }
                catch { ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Please enter a number');", true); }



                if (userGuess > randomNum)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('To High ');", true);
                    Label1.Text = "To High";
                    Label1.ForeColor = System.Drawing.Color.DarkRed;
                    Label2.Visible = bool.Parse("true");
                    Label2.Text = Label2.Text + " " + TextBox1.Text;
                    Label3.Text = "Number of Guess left: " + guessleft.ToString();

                }
                else if (userGuess == randomNum)
                {

                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('Correct');", true);
                    Label1.Text = "Correct";
                    Label1.ForeColor = System.Drawing.Color.DarkGreen;
                    Label2.Visible = bool.Parse("true");
                    Label2.Text = Label2.Text + " " + TextBox1.Text;
                    Label3.Text = "Number of Guess left: " + guessleft.ToString();

                }
                else if (userGuess < randomNum)
                {
                    //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('To Low ');", true);
                    Label1.Text = "To Low";
                    Label1.ForeColor = System.Drawing.Color.DarkRed;
                    Label2.Visible = bool.Parse("true");
                    Label2.Text = Label2.Text + " " + TextBox1.Text;
                    Label3.Text = "Number of Guess left: " + guessleft.ToString();

                }

            }

            else

            {

                //ClientScript.RegisterStartupScript(this.GetType(), "myalert", "alert('You are out of guess');", true);
                Label1.Text = "You are out of guess";
                Label2.Text = "Numbers Guessed:";
                Label2.Visible = bool.Parse("false");                
                Label1.ForeColor = System.Drawing.Color.DarkRed;
                Label3.Text = "Number of Guess left: 0 ";

            }

          

        }

        protected void Reset_Click(object sender, EventArgs e)
        {
            setDiffcult();
            attempts = 0;
            Label1.Text = "Game Reset";
            Label1.ForeColor = System.Drawing.Color.DarkGreen;
            Label2.Text = "Numbers Guessed:";
      


        }

        private void setDiffcult()
        {
            
            diffcult = null;
            try
            {
                diffcult = Server.UrlDecode(Request.QueryString["Parameter"].ToString());
            }
            catch (NullReferenceException)
            {
                diffcult = "Easy";
            }


            switch (diffcult)
            {
                case "Easy":
                    randomNum = random.Next(1, 10);
                    guess = 5;
                    Label3.Text = "Number of Guess left: " + guess.ToString();
                    Label4.Text = "Range: 1 - 10";
                    break;

                case "Medium":
                    randomNum = random.Next(1, 100);
                    guess = 10;
                    Label3.Text = "Number of Guess left: " + guess.ToString();
                    Label4.Text = "Range: 1 - 100";
                    break;

                case "Hard":
                    randomNum = random.Next(1, 1000);
                    guess = 15;
                    Label3.Text = "Number of Guess left: " + guess.ToString();
                    Label4.Text = "Range: 1 - 1000";
                    break;
            }


        }
    }
}