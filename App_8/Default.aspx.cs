using System;
using System.IO;
using System.Web;

namespace App_8
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        // Simple Upload
        protected void Button1_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                string path = Server.MapPath("~/Uploads/");

                if (!Directory.Exists(path))
                {
                    Directory.CreateDirectory(path);
                }

                HttpPostedFile sfile = FileUpload1.PostedFile;
                sfile.SaveAs(path + sfile.FileName);

                Label1.Text = "File uploaded successfully!";
            }
            else
            {
                Label1.Text = "Please select a file.";
            }
        }

        // Upload with Conditions
        protected void Button2_Click(object sender, EventArgs e)
        {
            if (FileUpload1.HasFile)
            {
                HttpPostedFile selectedFile = FileUpload1.PostedFile;

                string contenttype = selectedFile.ContentType;

                if (contenttype == "image/jpeg" ||
                    contenttype == "image/png" ||
                    contenttype == "image/bmp")
                {
                    if (selectedFile.ContentLength <= 524288) // 512 KB
                    {
                        string physicalPath = Server.MapPath("~/Uploads/");

                        if (!Directory.Exists(physicalPath))
                        {
                            Directory.CreateDirectory(physicalPath);
                        }

                        selectedFile.SaveAs(physicalPath + selectedFile.FileName);

                        lblStatus.Text = selectedFile.FileName + " Uploaded to the server";
                    }
                    else
                    {
                        lblStatus.Text = "Size of the file should be <= 512KB";
                    }
                }
                else
                {
                    lblStatus.Text = "Please upload only JPEG, PNG, or BMP image files";
                }
            }
            else
            {
                lblStatus.Text = "Please select a file first.";
            }
        }

        // Multiple File Upload
        protected void btnUpload_Click(object sender, EventArgs e)
        {
            string physicalPath = Server.MapPath("~/Uploads/");

            if (!Directory.Exists(physicalPath))
            {
                Directory.CreateDirectory(physicalPath);
            }

            if (FileUpload1.HasFiles)
            {
                int count = 0;

                foreach (HttpPostedFile selectedFile in FileUpload1.PostedFiles)
                {
                    selectedFile.SaveAs(physicalPath + selectedFile.FileName);
                    count++;
                }

                lblStatus.Text = count + " file(s) uploaded successfully.";
            }
            else
            {
                lblStatus.Text = "Please select file(s) before clicking Upload.";
            }
        }
    }
}