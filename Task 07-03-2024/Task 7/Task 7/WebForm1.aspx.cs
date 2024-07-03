using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Xml.Linq;

namespace Task_7
{
    public partial class WebForm1 : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
        }

        protected void SubmitButton_Click(object sender, EventArgs e)
        {
            // Set the labels with the submitted data
            LabelName.Text = inputName.Text;
            LabelEmail.Text = inputEmail.Text;
            LabelId.Text = inputId.Text;

            // Determine the selected gender
            if (genderMale.Checked)
            {
                LabelGender.Text = "Male";
            }
            else if (genderFemale.Checked)
            {
                LabelGender.Text = "Female";
            }
            else
            {
                LabelGender.Text = "Not specified";
            }

            // Collect selected skills
            string selectedSkills = "";

            if (skillCpp.Checked)
            {
                selectedSkills += "C++ ";
            }

            if (skillCsharp.Checked)
            {
                selectedSkills += "C# ";
            }

            if (skillJs.Checked)
            {
                selectedSkills += "JavaScript ";
            }

            if (string.IsNullOrEmpty(selectedSkills))
            {
                LabelSkills.Text = "No skills selected";
            }
            else
            {
                LabelSkills.Text = selectedSkills.Trim();
            }


            // Set the comments
            LabelComments.Text = comment.Text;

        }
    }
}