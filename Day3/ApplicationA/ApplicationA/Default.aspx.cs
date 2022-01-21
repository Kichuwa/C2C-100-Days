using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ApplicationA
{
    public partial class Default : System.Web.UI.Page
    {
        
        
        protected void Page_Load(object sender, EventArgs e)
        {
            lblResults.Text = "No results set!";
        }

        protected void btnShowResults_Click(object sender, EventArgs e)
        {
            String fName = txtFirstName.Text;
            String lName = txtLastName.Text;

            //I used a ternary operator to simplify the general outcome of this basic app.
            //If txtAge cannot be parsed it will be set to 0.
            int age = int.TryParse(txtAge.Text, out age) ? age : 0;    

                lblResults.Text = "Your Name is " + fName +" " +lName +" and you are " +age +" years old!";
        }
    }
}