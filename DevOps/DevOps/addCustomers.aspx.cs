using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data.SqlClient;
using System.Diagnostics;

namespace DevOps
{
    public partial class addCustomers : System.Web.UI.Page
    {
        //variables that will store the data given by the user
        public string fName, lName, AddressString, CityName, customerEmail;

        int zipNumber;
        float annualIncome;

        public SqlConnection sqlconn = new SqlConnection("Server=VMINOB076;Integrated security=SSPI;");

        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void addANewRecord_Click(object sender, EventArgs e)
        {
            //set the variables to the Textbox equivalent values
            fName = firstName.Text;
            lName = LastName.Text;
            AddressString = address.Text;
            CityName = city.Text;
            zipNumber = int.Parse(zipcode.Text);
            annualIncome = float.Parse(income.Text);
            customerEmail = email.Text;
            SQL_Functions func = new SQL_Functions();

            //func.createCustomerTable();
            func.insertIntoCustomers(fName, lName, AddressString, CityName, zipNumber, annualIncome, customerEmail);

            //func.create_check_table(8,"woo","hoo","hoot",9,7.0f,"yo","lo","hoe",92);

            ////Make a connection to the Database and notify if there was an error.
            //try
            //{
            //    sqlconn.Open();
            //    if (sqlconn.State == System.Data.ConnectionState.Open)
            //    {
            //        Debug.WriteLine("Success");
            //    }  
            //    else
            //    {
            //        Debug.WriteLine("FAIL");
            //    }
            //}
            //catch(Exception ex)
            //{
            //    Debug.WriteLine("There was an Error : \n" + ex);
            //}

            ////
            //string sqlQuery = string.Format("SELECT database_id FROM sys.databases WHERE Name = '{0}'", "Employee_DB");


        }
    }
}