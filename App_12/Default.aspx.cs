using System;
using System.IO;
using System.Linq;

namespace App_12
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                // ==========================================================
                // 1. Check if a file is selected
                // ==========================================================
                if (!FileUpload1.HasFile)
                {
                    Response.Write("Please select a file.");
                    return;
                }

                // ==========================================================
                // 2. Get Safe File Name
                // ==========================================================
                string fileName = Path.GetFileName(FileUpload1.FileName);

                if (string.IsNullOrWhiteSpace(fileName))
                {
                    Response.Write("Invalid file name.");
                    return;
                }

                // ==========================================================
                // 3. Remove Invalid Characters
                // ==========================================================
                foreach (char c in Path.GetInvalidFileNameChars())
                {
                    fileName = fileName.Replace(c.ToString(), "");
                }

                // ==========================================================
                // 4. Check File Name Length
                // ==========================================================
                if (fileName.Length > 255)
                {
                    Response.Write("File name is too long.");
                    return;
                }

                // ==========================================================
                // 5. Validate Extension
                // ==========================================================
                string extension = Path.GetExtension(fileName).ToLower();

                string[] allowedExtensions =
                {
                    ".jpg",
                    ".jpeg",
                    ".png",
                    ".gif",
                    ".pdf",
                    ".doc",
                    ".docx",
                    ".xls",
                    ".xlsx",
                    ".txt"
                };

                if (!allowedExtensions.Contains(extension))
                {
                    Response.Write("This file type is not allowed.");
                    return;
                }

                // ==========================================================
                // 6. Block Dangerous Extensions
                // ==========================================================
                string[] blockedExtensions =
                {
                    ".exe",
                    ".dll",
                    ".bat",
                    ".cmd",
                    ".js",
                    ".vbs",
                    ".ps1",
                    ".msi"
                };

                if (blockedExtensions.Contains(extension))
                {
                    Response.Write("Dangerous file type blocked.");
                    return;
                }

                // ==========================================================
                // 7. Validate File Size (Max 5 MB)
                // ==========================================================
                int maxFileSize = 5 * 1024 * 1024;

                if (FileUpload1.PostedFile.ContentLength == 0)
                {
                    Response.Write("File is empty.");
                    return;
                }

                if (FileUpload1.PostedFile.ContentLength > maxFileSize)
                {
                    Response.Write("Maximum file size is 5 MB.");
                    return;
                }

                // ==========================================================
                // 8. Validate MIME Type (Optional)
                // ==========================================================
                string contentType = FileUpload1.PostedFile.ContentType;

                string[] allowedContentTypes =
                {
                    "image/jpeg",
                    "image/png",
                    "image/gif",
                    "application/pdf",
                    "text/plain",
                    "application/msword",
                    "application/vnd.openxmlformats-officedocument.wordprocessingml.document",
                    "application/vnd.ms-excel",
                    "application/vnd.openxmlformats-officedocument.spreadsheetml.sheet"
                };

                if (!allowedContentTypes.Contains(contentType))
                {
                    Response.Write("Invalid Content Type.");
                    return;
                }

                // ==========================================================
                // 9. Create Upload Folder
                // ==========================================================
                string folderPath = Server.MapPath("~/Uploads");

                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                }

                // ==========================================================
                // 10. Rename File Using GUID
                // ==========================================================
                string newFileName = Guid.NewGuid().ToString() + extension;

                string fullPath = Path.Combine(folderPath, newFileName);

                // ==========================================================
                // 11. Check Duplicate (Optional)
                // ==========================================================
                if (File.Exists(fullPath))
                {
                    Response.Write("File already exists.");
                    return;
                }

                // ==========================================================
                // 12. Save File
                // ==========================================================
                FileUpload1.SaveAs(fullPath);

                // ==========================================================
                // Success Message
                // ==========================================================
                Response.Write("File uploaded successfully.<br/>");
                Response.Write("Original Name : " + fileName + "<br/>");
                Response.Write("Saved Name : " + newFileName + "<br/>");
                Response.Write("Size : " + FileUpload1.PostedFile.ContentLength + " Bytes<br/>");
                Response.Write("Content Type : " + contentType);
            }
            catch (Exception ex)
            {
                Response.Write("Error : " + ex.Message);
            }
        }
    }
}