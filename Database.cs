using System.Data;
using System.Data.SqlClient;

namespace Sql_project
{
    /// <summary>
    /// The database.
    /// </summary>
    public class Database
    {
        //Create Connection and Command,and an Adapter.

        private SqlConnection Connection = new SqlConnection();

        private SqlCommand Command = new SqlCommand();
        private SqlDataAdapter da = new SqlDataAdapter();

        // private Database myDatabase = new Database();
        private string connectionString = @"Data Source=DESKTOP-4F5AHK1\SQLEXPRESS01;Initial Catalog=Movies.MDF;Integrated Security=True";

        /// <summary>
        /// The .ctor.
        /// </summary>
        public Database()
        {
            //change the connection string to run from your own music db

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
                //create a datatable as we only have one table, the Owner
                DataTable dt = new DataTable();
                using (da = new SqlDataAdapter("select * from Movies ", Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
                    da.Fill(dt);
                }

                //fill the datatable from the SQL
                Connection.Close(); //close the connection

                return dt; //pass the datatable data to the DataGridView
            }
        }

        /// <summary>
        /// The fill d g v customers with customer.
        /// </summary>
        /// <returns>The result.</returns>
        public DataTable FillDGVCustomersWithCustomer()
        {
            // Define DB connection
            // using (SqlConnection Connection = new SqlConnection(connectionString))
            {
                //create a datatable as we only have one table, the Owner
                DataTable dt = new DataTable();
                using (da = new SqlDataAdapter("select * from Customer ", Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
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
                //create a datatable as we only have one table, the Owner
                DataTable dt = new DataTable();
                using (da = new SqlDataAdapter("select * from RentedMovies ", Connection))
                {
                    //connect in to the DB and get the SQL
                    Connection.Open();
                    //open a connection to the DB
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
                update.Parameters.AddWithValue("@Genre", updateArr[4]);

                // Open DB Connection
                Connection.Open();

                // Run SQL Command - Will return how many rows were effected
                update.ExecuteNonQuery();

                // Close DB Connection
                Connection.Close();
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
            }
        }
    }
}