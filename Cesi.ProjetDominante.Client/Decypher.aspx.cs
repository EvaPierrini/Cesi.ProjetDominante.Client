using System;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Cesi.ProjetDominante.Client
{
    public partial class Decypher : System.Web.UI.Page
    {
        protected void UploadButton_Click(object sender, EventArgs e)
        {
            // Specify the path on the server to
            // save the uploaded file to.
            String savePath = @"c:\temp\uploads\";

            // Before attempting to perform operations
            // on the file, verify that the FileUpload 
            // control contains a file.

            var fileUploades = new FileUpload[]
            {
                FileUpload1,
                FileUpload2,
                FileUpload3,
                FileUpload4,
                FileUpload5
            };

            var uploadedFiles = "";

            foreach (var fileUpload in fileUploades)
            {

                if (fileUpload.HasFile)
                {
                    // Get the name of the file to upload.
                    String fileName = fileUpload.FileName;

                    // Append the name of the file to upload to the path.
                    savePath += fileName;

                    // Call the SaveAs method to save the 
                    // uploaded file to the specified path.
                    // This example does not perform all
                    // the necessary error checking.               
                    // If a file with the same name
                    // already exists in the specified path,  
                    // the uploaded file overwrites it.
                    fileUpload.SaveAs(savePath);

                    uploadedFiles = uploadedFiles + fileName + " ";

                }
            }

            if (uploadedFiles == "")
            {
                UploadStatusLabel.Text = "You did not specify a file to upload.";
            }
            else
            {
                // Notify the user of the name of the file
                // was saved under.
                UploadStatusLabel.Text = "Your file(s) was saved as " + uploadedFiles;
            }
                
        }

        protected void tempSave()
        {

        }
    }
}
