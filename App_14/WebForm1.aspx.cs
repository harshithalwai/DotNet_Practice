using System;
using System.Text;
using System.Web.UI.WebControls;

namespace App_14
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }
        protected void Calendar1_VisibleMonthChanged(object sender, MonthChangedEventArgs e)
        {

            string NewMonth = GetMonthName(e.NewDate.Month);
            string OldMonth = GetMonthName(e.PreviousDate.Month);

            Response.Write("Month cahnged from " + OldMonth + " to " + NewMonth);

        }

        private string GetMonthName(int MonthNumber)
        {

            switch (MonthNumber)
            {

                case 1:
                    return "Jan";
                case 2:
                    return "Feb";
                case 3:
                    return "Mar";
                case 4:
                    return "Apr";
                case 5:
                    return "May";
                default:
                    return "else";

            }
        }
        protected void Calendar1_DayRender(object sender, DayRenderEventArgs e)
        {
            if (!e.Day.IsOtherMonth && e.Day.Date.Day % 2 == 0)
            {
                e.Cell.BackColor = System.Drawing.Color.Red;
                e.Cell.ForeColor = System.Drawing.Color.White;
                e.Cell.Font.Bold = true;
                e.Cell.Text = "X";
                e.Cell.ToolTip = "Booked";
            }
            else
            {
                e.Cell.ToolTip = "Available";
            }
        }


        //===========================
        // Show / Hide Calendar
        //===========================

        protected void ImageButton1_Click(object sender, System.Web.UI.ImageClickEventArgs e)
        {
            Calendar1.Visible = !Calendar1.Visible;
        }

        //===========================
        // Date Selected
        //===========================

        protected void Calendar1_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DateTime selectedDateTime in Calendar1.SelectedDates)
            {
                Response.Write(selectedDateTime.ToShortDateString() + "<br/>");
            }

            // Show selected date in textbox

            TextBox1.Text = Calendar1.SelectedDate.ToString("dd/MM/yyyy");

            // Hide Calendar

            Calendar1.Visible = false;

            // Show Calendar Properties

            StringBuilder sb = new StringBuilder();

            sb.Append("<h3>Calendar Properties</h3>");

            sb.Append("Selected Date : " + Calendar1.SelectedDate + "<br/>");

            sb.Append("Short Date : " + Calendar1.SelectedDate.ToShortDateString() + "<br/>");

            sb.Append("Long Date : " + Calendar1.SelectedDate.ToLongDateString() + "<br/>");

            sb.Append("Day : " + Calendar1.SelectedDate.Day + "<br/>");

            sb.Append("Month : " + Calendar1.SelectedDate.Month + "<br/>");

            sb.Append("Year : " + Calendar1.SelectedDate.Year + "<br/>");

            sb.Append("Day Of Week : " + Calendar1.SelectedDate.DayOfWeek + "<br/>");

            sb.Append("Day Of Year : " + Calendar1.SelectedDate.DayOfYear + "<br/>");

            sb.Append("Visible Date : " + Calendar1.VisibleDate.ToShortDateString() + "<br/>");

            sb.Append("Today's Date : " + Calendar1.TodaysDate.ToShortDateString() + "<br/>");

            sb.Append("First Day Of Week : " + Calendar1.FirstDayOfWeek + "<br/>");

            sb.Append("Selection Mode : " + Calendar1.SelectionMode + "<br/>");

            sb.Append("Is Weekend : " +
                (Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Saturday ||
                 Calendar1.SelectedDate.DayOfWeek == DayOfWeek.Sunday));

            Label1.Text = sb.ToString();
        }
    }
}