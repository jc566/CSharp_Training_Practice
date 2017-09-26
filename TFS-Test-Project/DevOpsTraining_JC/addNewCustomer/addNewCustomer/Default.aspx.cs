using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;

namespace addNewCustomer
{
    public partial class _Default : Page
    {
        //references to the user inputs
        public string fName,lName,Address,City,zip,annualIncome;

        //connection string
        public SQLConnection myConn = new SQLConnection("Server=VMINOB076;database=master");



        protected void Unnamed1_Click(object sender, EventArgs e)
        {
            //set the variables to the Textbox equivalent values
            fName = firstName.Text;
            lName = LastName.Text;
            Address = address.Text;
            City = city.Text;
            zip = zipcode.Text;
            annualIncome = income.Text;

            try
            {
                myConn.Open();
                alert("Successfully opened");
            }
            catch(Exception e)
            {
                alert("failed due to" + e);
            }
        }

        protected void Page_Load(object sender, EventArgs e)
        {

        }

    
    }
}