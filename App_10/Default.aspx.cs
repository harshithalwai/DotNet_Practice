using App_10.Models;
using App_10.Services;
using System;
using System.Drawing;
using System.IO;
using System.Web.UI;

namespace App_10
{
    public partial class Default : Page
    {

        // ==========================================================
        // Page_Load
        //
        // Runs every time page loads.
        //
        // First Request
        // IsPostBack = false
        //
        // Button Click
        // IsPostBack = true
        // ==========================================================

        protected void Page_Load(object sender, EventArgs e)
        {

            if (!IsPostBack)
            {
                lblStatus.Text = "";
                lblProgress.Text = "";
            }

        }



        // ==========================================================
        // Upload Button Click
        //
        // This is the starting point of our Import Engine.
        // ==========================================================

        protected void btnUpload_Click(object sender, EventArgs e)
        {

            try
            {

                //------------------------------------------------------
                // STEP 1
                //
                // Check whether user selected a file.
                //------------------------------------------------------

                if (!FileUpload1.HasFile)
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = "Please Select Excel File.";
                    return;
                }



                //------------------------------------------------------
                // STEP 2
                //
                // Validate Extension
                //------------------------------------------------------

                string extension =
                    Path.GetExtension(FileUpload1.FileName)
                    .ToLower();

                if (extension != ".xlsx" &&
                    extension != ".xls")
                {

                    lblStatus.ForeColor = Color.Red;

                    lblStatus.Text =
                        "Only Excel Files are Allowed.";

                    return;

                }



                //------------------------------------------------------
                // STEP 3
                //
                // Upload Folder
                //------------------------------------------------------

                string uploadFolder =
                    Server.MapPath("~/Uploads/");



                //------------------------------------------------------
                // STEP 4
                //
                // Create Upload Folder
                //------------------------------------------------------

                if (!Directory.Exists(uploadFolder))
                {
                    Directory.CreateDirectory(uploadFolder);
                }



                //------------------------------------------------------
                // STEP 5
                //
                // Generate Unique File Name
                //------------------------------------------------------

                string uniqueFileName =

                    Guid.NewGuid().ToString()

                    +

                    extension;



                //------------------------------------------------------
                // STEP 6
                //
                // Final Physical Path
                //------------------------------------------------------

                string filePath =
                    Path.Combine(uploadFolder,
                                 uniqueFileName);



                //------------------------------------------------------
                // STEP 7
                //
                // Save File
                //------------------------------------------------------

                FileUpload1.SaveAs(filePath);



                //------------------------------------------------------
                // STEP 8
                //
                // Update UI
                //------------------------------------------------------

                lblProgress.Text =
                    "Starting Import...";



                //------------------------------------------------------
                // STEP 9
                //
                // Call Business Layer
                //------------------------------------------------------

                ImportService service =
                    new ImportService();



                //------------------------------------------------------
                // STEP 10
                //
                // Start Import
                //------------------------------------------------------
                ImportResult result = service.StartImport(filePath);

                if (result.IsSuccess)
                {
                    lblStatus.ForeColor = Color.Green;
                    lblStatus.Text = result.Message;

                    lblProgress.Text =
                        "Table Name : " + result.TableName;
                }
                else
                {
                    lblStatus.ForeColor = Color.Red;
                    lblStatus.Text = result.Message;
                }

                lblProgress.Text =
                    "Phase 1 Completed.";

            }

            catch (Exception ex)
            {

                //------------------------------------------------------
                // Show Exception
                //
                // Later we will Log this.
                //------------------------------------------------------

                lblStatus.ForeColor =
                    Color.Red;

                lblStatus.Text =
                    ex.Message;

            }

        }

    }

}