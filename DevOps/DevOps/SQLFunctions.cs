using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Data;
using System.Data.OleDb;
using System.Xml.Serialization;
using System.Data.SqlClient;
using System.Diagnostics;

/// <summary>
/// Summary description for SQL_Functions
/// </summary>
public class SQL_Functions
{
    //reference to the OleDbConnection we will use throughout page.
    SqlConnection connection = null;

    //reference to the dataset / table that we will display/manipulate.
    DataSet myDataSet = new DataSet();

    //change this variables value to make a new database based on this name
    string databaseName = "DevOpsTraining";

#region makeDBConnection
    /***********************************************************************************************
     * Make a connection to Database                                                               *
     * Creates a new Database with the value of databaseName variable.                             *
     * If it already exists, ignore. If it does not exists, then it will create it so dont wory :) *
     **********************************************************************************************/
    public void makeDBConnection()
    {
        Debug.WriteLine("Attempting Connection to Database\n");

        //Quickly change the Database you are trying to connect to
        string ServerPath = "VMINOB076;";


        //Make the connection to the Excel Sheet
        try
        {
            connection = new SqlConnection("Server=" + ServerPath + ";Integrated security=SSPI;");
            connection.Open();
            

            //Confirm that DB connection is made.
            if (connection.State == System.Data.ConnectionState.Open)
            {
                Debug.WriteLine("Successfully Connected to Database!\n");
            }
            else
            {
                Debug.WriteLine("Failed to connect to Database!\n");
            }

            Debug.WriteLine("You are connected to database called : " + connection.Database);
        }
        //if Connection has failed Print the Error Message
        catch (Exception ex)
        {
            Debug.WriteLine("Error: Failed to create a database connection.\n" + ex.Message + "...\n");
            return;
        }
        //Create the Database in case it doesnt exist
        createANewDB();
    }
#endregion

#region createANewDB
    /********************************************************************************************
     * Switches to Master in SQL Connection.                                                    *
     * It then checks if the value for databaseName variable is in the SQL                      *
     * If there is no database with the desired value for databaseName variable, it makes one   *
     *******************************************************************************************/
    public void createANewDB()
    {
        //ensure that you change to the Master to be able to make proper counts of pre-existing databases
        connection.ChangeDatabase("Master");
        //variable that will determine whether or not the database name is inside SQL Server
        string iReturn;
        // If the database does not exist then create it.
        string strCommand = string.Format("SET NOCOUNT OFF; SELECT COUNT(*) FROM master.dbo.sysdatabases where name=\'{0}\'", databaseName);
        using (SqlCommand sqlCmd = new SqlCommand(strCommand, connection))
        {
            iReturn = sqlCmd.ExecuteScalar().ToString();
            if(iReturn == 0.ToString())
            {
                Debug.WriteLine("\nCreating a new Database\n");
                //Query that will create the new database based on the name you gave to the above variable
                string query = "CREATE DATABASE " + databaseName;
                try
                {
                    //run the query
                    SqlCommand command = new SqlCommand(query, connection);
                    command.ExecuteNonQuery();
                    Debug.WriteLine("New Database created with name" + databaseName);
                }
                catch (Exception ex)
                {
                    Debug.WriteLine("Failed to create new Database : \n" + ex);
                }
            }
            else
            {
                Debug.WriteLine("This Database already Exists : " + iReturn);
            }
        }
    }
#endregion

#region checkIfTableExists
    /************************************************************************************************
     * Changes the Database to the value of the databaseName variable                               *
     * Checks to see if the value of tableName variable already exists inside the current Database  *
     * Returns 0 is it doesnt exist and anything else for if it does exist                          *
     ***********************************************************************************************/
    public int checkIfTableExists(string tableName)
    {
        //open a connection to the Database
        makeDBConnection();
        //Swtich to the database you want to tweak with
        connection.ChangeDatabase(databaseName);

        //string tableName = "Customers";  //Name of the table to be created. Now uses a passing of a parameter

        //Set up the SQL query to be executed
        string query = "SELECT * FROM INFORMATION_SCHEMA.TABLES WHERE TABLE_NAME = '" + tableName + "'";
        //Run the Query
        SqlCommand command = new SqlCommand(query, connection);
        SqlDataReader myReader = null;
        //variable that will hold the number of Tables existing with the value of the tableName variable
        int count = 0;
        //Run the logic
        try
        {
            myReader = command.ExecuteReader();
            while (myReader.Read())
            {
                count++;
                Debug.WriteLine("MY COUNTER IS : " + count);
            }
            myReader.Close();
            //connection.Close();
        }
        catch (Exception ex)
        {
            Debug.WriteLine("\nError!!!! :\n" + ex);
        }
        //This is for debugging messages.
        if (count == 0)
        {
            Debug.WriteLine("Table doesn't exists");
        }
        else
        {
            Debug.WriteLine("Table exists");
        }
        //if it returns a 0, table doesnt exist, otherwise, it does exist
        return count;
    }
#endregion

#region createCustomerTable
    /********************************************************************************************************************
     * First checks to see if the table exists by sending a table name value and running checkIfTableExists function    *
     * If the table exists, do nothing                                                                                  *
     * If the table does NOT exist, then create it                                                                      *
     *******************************************************************************************************************/
    public void createCustomerTable()
    {
        //name of the table you want to check if it already exists and if not, then create
        string tableName = "Customers";
        //Send a table name and see if it exists. A value of 0 means it does not exist
        int tableExists = checkIfTableExists(tableName);
        //For debugging purposes, confirm the Database and whether or not the Table exists before moving forward
        Debug.WriteLine("current database is : " + connection.Database + "and the value is " + tableExists);
        //If the table doesnt exist, create it
        if(tableExists == 0)
        {
            string query = "CREATE TABLE Customers " +
                "(FirstName varchar(50), LastName varchar(50), Address varchar(100), City varchar(100), Zipcode int, Income float, Email varchar(100))";

            SqlCommand command = new SqlCommand(query, connection);
            command.ExecuteNonQuery();
        }
    }
    #endregion

#region insertIntoCustomers
    /****************************************************************************************************************
     * Makes a connection to the Database & inserts the values passed through its parameters to the customers table *
     ***************************************************************************************************************/
    public void insertIntoCustomers(string firstname, string lastname, string address, string city, int zipcode, float salary, string email)
    {
        //connect to the Database
        makeDBConnection();
        //Checks to see if the Customers table already Exists
        checkIfTableExists("Customers");
        //If Customers table DOESNT exist, Create it. If it DOES exist, do nothing.
        createCustomerTable();

        //create the INSERT query string
        string query = "INSERT INTO " + databaseName + ".dbo.Customers VALUES(@firstName, @lastName, @address, @city, @zipcode, @income, @email)";
        //run the Query logics
        SqlCommand command = new SqlCommand(query, connection);
        //fill in the data for the parameters
        command.Parameters.AddWithValue("@firstName",firstname);
        command.Parameters.AddWithValue("@lastName",lastname);
        command.Parameters.AddWithValue("@address",address);
        command.Parameters.AddWithValue("@city",city);
        command.Parameters.AddWithValue("@zipcode",zipcode);
        command.Parameters.AddWithValue("@income",salary);
        command.Parameters.AddWithValue("@email",email);
        //run te Query
        command.ExecuteNonQuery();
        Debug.WriteLine("Successfully INSERTED the data in to the Customers table in the " + databaseName + "Database");
    }
#endregion



    // /*****************************************************************************************
    //* 
    //****************************************************************************************/
    // public DataSet displayRecords()
    // {
    //     try
    //     {
    //         Create the DB query string
    //         string query = "SELECT * FROM [data$]";
    //         Execute the DB query
    //         OleDbCommand cmd = new OleDbCommand(query, connection);
    //         OleDbDataAdapter myDataAdapter = new OleDbDataAdapter(cmd);
    //         Transfer the retrieved data into a dataset
    //         myDataAdapter.Fill(myDataSet);

    //         return (myDataSet);

    //         System.Diagnostics.Debug.WriteLine("Successfully copied the table from DB and displayed the FULL table.\n");

    //         ConsoleMessageBox.Text += "Successfully copied the table from DB and displayed the FULL table.\n";
    //     }
    //     catch (Exception ex)
    //     {
    //         ConsoleMessageBox.Text += "Error: Failed to copy/retrieve data from Database.\n" + ex.Message + "...\n";
    //         System.Diagnostics.Debug.WriteLine("Error: Failed to copy/retrieve data from Database.\n" + ex.Message + "...\n");
    //         return null;
    //     }
    // }
    // /****************************************************************************************
    //  * This function will take values entered in the Textboxes from 'addRecords.aspx' page. *
    //  * It will make a new connection to the DB.                                             *
    //  * Makes a INSERT query string and executes it.                                         *
    //  ***************************************************************************************/
    // public string addRecords(int id, string firstName, string lastName, string email, string gender, string ipAddress, int age, int salary)
    // {
    //     try
    //     {
    //         //make connection to DB
    //         makeDBConnection();

    //         //create the query string
    //         string query = "INSERT INTO [data$] VALUES(@id, @firstName, @lastName, @email, @gender, @ipAddress, @age, @salary)";

    //         OleDbCommand command = new OleDbCommand(query, connection);

    //         //give values to the parameters
    //         command.Parameters.AddWithValue("@id", id);
    //         command.Parameters.AddWithValue("@firstName", firstName);
    //         command.Parameters.AddWithValue("@lastName", lastName);
    //         command.Parameters.AddWithValue("@email", email);
    //         command.Parameters.AddWithValue("@gender", gender);
    //         command.Parameters.AddWithValue("@ipAddress", ipAddress);
    //         command.Parameters.AddWithValue("age", age);
    //         command.Parameters.AddWithValue("@salary", salary);


    //         //Execute the DB query 
    //         command.ExecuteNonQuery();

    //         System.Diagnostics.Debug.WriteLine("Successfully inserted row(s) into Database\n");

    //         //send success return string
    //         return ("\nSuccessfully added the row(s) for ID : " + id + " and Name : " + firstName + " " + lastName + ".\n");
    //     }
    //     catch (Exception ex)
    //     {
    //         System.Diagnostics.Debug.WriteLine("Failed to insert row(s) into Database" + ex + ".\n");

    //         //send failure return string
    //         return ("Failure to add the row(s) for ID : " + id + " and Name : " + firstName + " " + lastName + ".\n");

    //     }

    // }
    // /************************************************************************************************
    //  * This function will ask the user which ID to modify.                                          *
    //  * It will then take the textbox values from 'updateRecords.aspx' and create a query string.    *
    //  * Finally, it will exeute the query string.                                                    *
    //  ***********************************************************************************************/
    // public string updateRecord(int id, string firstName, string lastName, string email, string gender, string ipAddress, int age, int salary)
    // {
    //     try
    //     {
    //         //make connection to DB
    //         makeDBConnection();

    //         //create the query string
    //         string query = "UPDATE [data$] SET first_name=@firstName, last_name=@lastName, email=@email, gender=@gender, ip_address=@ipAddress, age=@age, salary=@salary WHERE [id]=@id";

    //         OleDbCommand command = new OleDbCommand(query, connection);

    //         //give values to the parameters. Important to note that the order the parameters are added do matter. Match the same order of appearance.
    //         command.Parameters.AddWithValue("@firstName", firstName);
    //         command.Parameters.AddWithValue("@lastName", lastName);
    //         command.Parameters.AddWithValue("@email", email);
    //         command.Parameters.AddWithValue("@gender", gender);
    //         command.Parameters.AddWithValue("@ipAddress", ipAddress);
    //         command.Parameters.AddWithValue("age", age);
    //         command.Parameters.AddWithValue("@salary", salary);
    //         command.Parameters.AddWithValue("@id", id);

    //         //Execute the DB query 
    //         command.ExecuteNonQuery();

    //         System.Diagnostics.Debug.WriteLine("Successfully updated the row(s) for ID : " + id + ".\n");

    //         //send success return string
    //         return ("\nSuccessfully updated the row(s) for ID : " + id + " and Name : " + firstName + " " + lastName + ".\n");
    //     }
    //     catch (Exception ex)
    //     {
    //         System.Diagnostics.Debug.WriteLine("Failed to update row(s) in the Database" + ex + ".\n");

    //         //send failure return string
    //         return ("\nFailure to update the row(s) for ID : " + id + " and Name : " + firstName + " " + lastName + ".\n");
    //     }
    // }

    // /*
    //  * get the excel row number
    //  **/
    // public void modifyDataset(int id)
    // {
    //     try
    //     {
    //         //make connection to DB
    //         makeDBConnection();

    //         //make a temporary data table
    //         DataTable tempDataTable = new DataTable();
    //         //set the temporary dataset equal to the most recent info pulled from the Excel table
    //         tempDataTable = displayRecords().Tables[0];

    //         DataRow[] curRow;

    //         //make data table query string
    //         string getRowQuery = "id = " + id;

    //         curRow = tempDataTable.Select(getRowQuery);

    //         tempDataTable.Rows.Remove(curRow[0]);

    //         System.Diagnostics.Debug.WriteLine(curRow[0][0]);

    //         //System.Diagnostics.Debug.WriteLine("Successfully updated the row(s) for ID : " + id + ".\n");
    //     }
    //     catch (Exception ex)
    //     {
    //         System.Diagnostics.Debug.WriteLine("Failed to update row(s) in the Database" + ex + ".\n");
    //     }
    // }

    // /*
    //  * Remove a record
    //  ***/
    // public void deleteRecord(int id)
    // {
    //     try
    //     {
    //         //make connection to DB
    //         makeDBConnection();

    //         //create the query string
    //         string query = "DELETE * FROM [data$] WHERE id=@id";

    //         OleDbCommand command = new OleDbCommand(query, connection);

    //         //give values to the parameters. Important to note that the order the parameters are added do matter. Match the same order of appearance.
    //         command.Parameters.AddWithValue("@id", id);

    //         //Execute the DB query 
    //         command.ExecuteNonQuery();

    //         System.Diagnostics.Debug.WriteLine("Successfully deleted the row(s) for ID : " + id + ".\n");
    //     }
    //     catch (Exception ex)
    //     {
    //         System.Diagnostics.Debug.WriteLine("Failed to remove row(s) in the Database" + ex + ".\n");
    //     }
    // }
}