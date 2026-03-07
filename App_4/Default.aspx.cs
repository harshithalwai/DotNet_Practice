using System;

namespace App_4
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                label1.Text = "";
                label1.Style["display"] = "none";
                Page.SetFocus(txtTask);
            }
        }

        private void ShowMessage(string message)
        {
            label1.Text = message;
            label1.Style["display"] = "inline-block";

            ClientScript.RegisterStartupScript(
                this.GetType(),
                "fadeMessage",
                "setTimeout(function(){document.getElementById('" + label1.ClientID + "').style.display='none';},2000);",
                true
            );
            Page.SetFocus(txtTask);
        }

        protected void BtnAdd_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(txtTask.Text))
            {
                lstTasks.Items.Add(txtTask.Text);
                ShowMessage("Task added successfully!");
                txtTask.Text = "";
            }
        }

        protected void BtnClear_Click(object sender, EventArgs e)
        {
            lstTasks.Items.Clear();
            txtTask.Text = "";
            ShowMessage("List cleared successfully!");
        }

        protected void BtnEdit_Click(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem != null)
            {
                //label1.Text = lstTasks.SelectedIndex.ToString();
                txtTask.Text = lstTasks.SelectedItem?.Text ?? "";
                lstTasks.Items.Remove(lstTasks.SelectedItem);
                ShowMessage("Task ready for editing!");
            }
        }

        protected void BtnDelete_Click(object sender, EventArgs e)
        {
            lstTasks.Items.Remove(lstTasks.SelectedItem);
            ShowMessage("Task has been deleted !");
        }

        protected void BtnShow_Click(object sender, EventArgs e)
        {
            ShowMessage("The value of task is : " + lstTasks.SelectedItem);
        }
    }
}