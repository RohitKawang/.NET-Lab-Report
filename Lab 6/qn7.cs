using System;
using System.Web.UI;

namespace ValidationDemo
{
    // FIX: Changed System.Web.Style to Page
    public partial class Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            // Optional: Prevents runtime JavaScript errors with modern ASP.NET validation
            ValidationSettings.UnobtrusiveValidationMode = UnobtrusiveValidationMode.None;

            // Clears message on fresh load
            lblMessage.Text = "";
        }

        protected void btnSubmit_Click(object sender, EventArgs e)
        {
            // CRITICAL STEP: Always check if the page passed all validation rules
            if (Page.IsValid)
            {
                // If everything is valid, proceed with your logic (e.g., saving to database)
                lblMessage.Text = "Registration successful! Welcome, " + txtUsername.Text + ".";
            }
            else
            {
                // Fallback message (though ValidationSummary usually handles this visually)
                lblMessage.Text = "";
            }
        }
    }
}
