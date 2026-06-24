using System;
using System.Web.UI.WebControls;

namespace App_8
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            //Button1.Click += new EventHandler(Button1_Click);
            //Button1.Command += new CommandEventHandler(Button1_Command);

        }
        //protected void Button1_Click(object sender, EventArgs e)
        //{

        //    Response.Write("Button Click Event <br/>");
        //}

        //protected void Button1_Command(object sender, CommandEventArgs e)
        //{

        //    Response.Write("Button Command Event <br/>");
        //}


        protected void CommandButton_Click(object sender, CommandEventArgs e)
        {
            switch (e.CommandName)
            {
                case "Print":
                    OutputLabel.Text = "You clicked Print Button";
                    break;

                case "Delete":
                    OutputLabel.Text = "You clicked Delete Button";
                    break;

                case "Show":
                    if (e.CommandArgument.ToString() == "Top10")
                    {
                        OutputLabel.Text = "You clicked Show Top 10 Employees Button";
                    }
                    else
                    {
                        OutputLabel.Text = "You clicked Show Bottom 10 Employees Button";
                    }
                    break;
            }
        }
    }
}