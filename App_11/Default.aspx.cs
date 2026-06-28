using System;
using System.Web.UI.WebControls;

namespace App_11
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {

                PopulateItems(DropDownList1);
                PopulateItems(CheckBoxList1);
                PopulateItems(RadioButtonList1);
                PopulateItems(ListBox1);
                PopulateItems(BulletedList1);

            }

        }
        private void RetrieveMultipleSelections(ListControl listControl)
        {

            foreach (ListItem li in listControl.Items)
            {

                if (li.Selected)
                {

                    Response.Write("Text = " + li.Text + ", Value = " + li.Value +
                    ", Index = " + listControl.Items.IndexOf(li).ToString() + "<br/>");

                }

            }

        }

        private void PopulateItems(ListControl listControl)
        {

            ListItem li1 = new ListItem("Item1", "1");
            ListItem li2 = new ListItem("Item1", "1");
            ListItem li3 = new ListItem("Item1", "1");

            listControl.Items.Add(li1);
            listControl.Items.Add(li2);
            listControl.Items.Add(li3);

        }
    }
}