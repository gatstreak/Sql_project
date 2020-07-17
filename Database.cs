using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Sql_project
{
    /// <summary>
    /// The database.
    /// </summary>
    public class Database
    {
        // declares new connection to database
        private SqlConnection Connection = new SqlConnection();

        // declares command
        private SqlCommand Command = new SqlCommand();

        // declares data adapter
        private SqlDataAdapter da = new SqlDataAdapter();

        // connection string
        private string connectionString = @"Data Source=DESKTOP-4F5AHK1\SQLEXPRESS01;Initial Catalog=Movies.MDF;Integrated Security=True";

        /// <summary>
        /// The .ctor.
        /// </summary>
        public Database()
        {
            //Connection
            Connection = new SqlConnection(connectionString);
        }

        /// <summary>
        /// The fill d g v movie with movies.
        /// </summary>
        /// <returns>The result.</returns>
        public DataTable FillDGVMovieWithMovies()
        {
            // Define DB connection
            // using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                //New data table
                DataTable dt = new DataTable();
                // Finds Movies table
                using (da = new SqlDataAdapter("select * from Movies ", Connection))
                {
                    //opens connection
                    Connection.Open();
                    //fills data-table
                    da.Fill(dt);
                }

                //fill the data-table from the SQL
                Connection.Close(); //close the connection

                return dt; //pass the data-table data to the DataGridView
            }
        }

        //public void loadDB()
        //{
        //    GolTable.Clear();

        //    // dgvMain.DataSource = myDatabase.ReadCust();
        //    // load the customer dgv
        //    // DisplayListBox();
        //    // InsertCust();
        //}

        /// <summary>
        /// The fill d g v customers with customer.
        /// </summary>
        /// <returns>The result.</returns>
        public DataTable FillDGVCustomersWithCustomer()
        {
            // Define DB connection
            // using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                using (da = new SqlDataAdapter("select * from Customer ", Connection))

                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //fills data-table
                    da.Fill(dt);
                }

                //fill the datatable from the SQL
                Connection.Close(); //close the connection

                return dt; //pass the datatable data to the DataGridView
            }
        }

        /// <summary>
        /// The fill d g v rentals with rented movies.
        /// </summary>
        /// <returns>The result.</returns>
        public DataTable FillDGVRentalsWithRentedMovies()
        {
            // Define DB connection
            // using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                DataTable dt = new DataTable();
                using (da = new SqlDataAdapter("select * from RentedMovies ", Connection))
                {
                    //open conection to db
                    Connection.Open();

                    da.Fill(dt);
                }

                //fill the datatable from the SQL
                Connection.Close(); //close the connection

                return dt; //pass the datatable data to the DataGridView
            }
        }
      
        /// <summary>
        /// The insert cust.
        /// </summary>
        /// <param name="insertArr">The insert arr.</param>
        public void InsertCust(string[] insertArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string entryStatement = "INSERT INTO Customer(FirstName, LastName, Address, Phone) VALUES(@FirstName, @LastName, @Address, @Phone)";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand entryData = new SqlCommand(entryStatement, Connection))
            {
                // Assigns Parameters
                entryData.Parameters.AddWithValue("@FirstName", insertArr[0]);
                entryData.Parameters.AddWithValue("@LastName", insertArr[1]);
                entryData.Parameters.AddWithValue("@Address", insertArr[2]);
                entryData.Parameters.AddWithValue("@Phone", insertArr[3]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                int returnValue = entryData.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                var InsertCustcounter = 0;

                InsertCustcounter ++;
                if (InsertCustcounter == 1)
                {
                    MessageBox.Show("Customer Inserted!");
                }
            }
        }

        /// <summary>
        /// The insert movie.
        /// </summary>
        /// <param name="insertArr">The insert arr.</param>
        public void InsertMovie(string[] insertArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string entryStatement = "INSERT INTO Movies(Title, Year, Genre, Rental_Cost, rating) VALUES(@Title, @Year, @Genre, @RentalCost, @Rateing)";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand entryData = new SqlCommand(entryStatement, Connection))
            {
                entryData.Parameters.AddWithValue("@Title", insertArr[0]);
                entryData.Parameters.AddWithValue("@Year", insertArr[1]);
                entryData.Parameters.AddWithValue("@Genre", insertArr[2]);
                entryData.Parameters.AddWithValue("@RentalCost", insertArr[3]);
                entryData.Parameters.AddWithValue("@Rateing", insertArr[4]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                int returnValue = entryData.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                var InsertMoviecounter = 0;

                InsertMoviecounter++;
                if (InsertMoviecounter == 1)
                {
                    MessageBox.Show("Movie Inserted!");
                }
            }
        }

        /// <summary>
        /// The update movie.
        /// </summary>
        /// <param name="updateArr">The update arr.</param>
        public void UpdateMovie(string[] updateArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE Movies set rating=@Rateing, Title=@Title, Year=@Year, Rental_Cost=@RentalCost, Genre=@Genre where MovieID = @MovieID";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand update = new SqlCommand(updatestatement, Connection))
            {
                update.Parameters.AddWithValue("@MovieID", updateArr[0]);
                update.Parameters.AddWithValue("@Rateing", updateArr[1]);
                update.Parameters.AddWithValue("@Title", updateArr[2]);
                update.Parameters.AddWithValue("@Year", updateArr[3]);
                update.Parameters.AddWithValue("@RentalCost", updateArr[4]);
                update.Parameters.AddWithValue("@Genre", updateArr[5]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                update.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                var UpdateMoviecounter = 0;

                UpdateMoviecounter++;
                if (UpdateMoviecounter == 1)
                {
                    MessageBox.Show("Movie Updated!");
                }
            }
        }

        /// <summary>
        /// The update customer.
        /// </summary>
        /// <param name="updateArr">The update arr.</param>
        public void UpdateCustomer(string[] updateArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string updatestatement = "UPDATE  Customer set FirstName=@FirstName, LastName=@LastName, Address=@Address, Phone=@Phone where CustID = @CustomerID";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand update = new SqlCommand(updatestatement, Connection))
            {
                update.Parameters.AddWithValue("@CustomerID", updateArr[0]);
                update.Parameters.AddWithValue("@FirstName", updateArr[1]);
                update.Parameters.AddWithValue("@LastName", updateArr[2]);
                update.Parameters.AddWithValue("@Address", updateArr[3]);
                update.Parameters.AddWithValue("@Phone", updateArr[4]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                update.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                var UpdateCustcounter = 0;

                UpdateCustcounter++;
                if (UpdateCustcounter == 1)
                {
                    MessageBox.Show("Customer Updated!");
                }
            }
        }

        /// <summary>
        /// The del customers.
        /// </summary>
        /// <param name="DelArr">The del arr.</param>
        public void DelCustomers(string[] DelArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string DeleteCommand = "Delete Customer where CustID = @CustomerID";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand DeleteData = new SqlCommand(DeleteCommand, Connection))
            {
                DeleteData.Parameters.AddWithValue("@CustomerID", DelArr[0]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                int returnValue = DeleteData.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();
               
            }
        }

        /// <summary>
        /// The del movie.
        /// </summary>
        /// <param name="DelArr">The del arr.</param>
        public void DelMovie(string[] DelArr)
        {
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string DeleteCommand = "Delete Movies where MovieID = @MovieID";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand DeleteData = new SqlCommand(DeleteCommand, Connection))
            {
                DeleteData.Parameters.AddWithValue("@MovieID", DelArr[0]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                int returnValue = DeleteData.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                //var DelMoviecounter = 0;

                //DelMoviecounter++;
                //if (DelMoviecounter == 1)
                //{
                //    MessageBox.Show("Movie Deleted!");
                //}
            }
        }

        /// <summary>
        /// The rent movie.
        /// </summary>
        /// <param name="RentArr">The rent arr.</param>
        public string RentMovie(string[] RentArr)
        {
            try
            {

            
            // this puts the parameters into the code so that the data in the text boxes is added to the database
            string entryStatement = "INSERT INTO RentedMovies (MovieIDFK, CustIDFK, DateRented) VALUES(@MovieID, @CustomerID, @DateRented)";
            // gets system date & time
            DateTime today = System.DateTime.Now;
            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);

            using (SqlCommand entryData = new SqlCommand(entryStatement, Connection))
            {
                // Assigns Parameters
                entryData.Parameters.AddWithValue("@MovieID", RentArr[0]);
                entryData.Parameters.AddWithValue("@CustomerID", RentArr[1]);
                entryData.Parameters.AddWithValue("@DateRented", today);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                int returnValue = entryData.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                //var RentMoviecounter = 0;
                
                return "Success";
            }
            }
            catch (Exception)
            {

                return "Fail";
            }
        }

        /// <summary>
        /// The return.
        /// </summary>
        /// <param name="updateArr">The update arr.</param>
        public void Return(string[] updateArr)
        {
            // SQL Query
            string updatestatement = "UPDATE  RentedMovies set DateReturned = @DateReturned where RMID = @RMID";

            // Define DB Connection
            SqlConnection Connection = new SqlConnection(connectionString);
            // gets system date & time
            DateTime today = System.DateTime.Now;
            using (SqlCommand update = new SqlCommand(updatestatement, Connection))
            {
                //@RMID = txtRMID
                update.Parameters.AddWithValue("@RMID", updateArr[0]);
                update.Parameters.AddWithValue("@DateReturned", today);
                // Open DB Connection
                Connection.Open();

                // Execute SQL Command
                update.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();

                var ReturnMoviecounter = 0;

                ReturnMoviecounter++;
                if (ReturnMoviecounter == 1)
                {
                    MessageBox.Show("Movie Returned!");
                }
            }
        }
    }
}