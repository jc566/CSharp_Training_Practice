using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace addNewCustomer
{
    public partial class _Default : Page
    {
        public string fName,lName,Address,City,zip,annualIncome;

        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //set the variables to the Textbox equivalent values
            fName = firstName.Text;
            lName = LastName.Text;
            Address = address.Text;
            City = city.Text;
            zip = zipcode.Text;
            annualIncome = income.Text;
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    
    }
}