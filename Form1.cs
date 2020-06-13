using System;
using System.Windows.Forms;

namespace Sql_project
{
    public partial class Form1 : Form
    {
        //create an instance of the Database class
        public Database myDatabase = new Database();

        /// <summary>
        /// The .ctor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //loads database
            loadDB();
            DisplayDataGridViewMovie();
            DisplayDataGridViewCustomers();
            DisplayDataGridViewRentals();
        }

        public void loadDB()
        {
            //  dgvMain.DataSource = myDatabase.ReadCust();
            //load the customer dgv
            // DisplayListBox();
            // InsertCust();
        }

        /// <summary>
        /// The display data grid view movie.
        /// </summary>
        private void DisplayDataGridViewMovie()
        {
            DGVMovie.DataSource = myDatabase.FillDGVMovieWithMovies();
            //pass the datatable data to the DataGridView
            DGVMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// The display data grid view customers.
        /// </summary>
        private void DisplayDataGridViewCustomers()
        {
            DGVCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomer();
            //pass the datatable data to the DataGridView
            DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// The display data grid view rentals.
        /// </summary>
        private void DisplayDataGridViewRentals()
        {
            DGVRentals.DataSource = myDatabase.FillDGVRentalsWithRentedMovies();
            //pass the datatable data to the DataGridView
            DGVRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        //private void DisplayListBox()
        //{
        //    lbgenre.DataSource = null;
        //    try
        //    {
        //        lbgenre.DataSource = myDatabase.FillListBoxWithGenre();
        //    }
        //    catch (Exception ex)
        //    {
        //        MessageBox.Show(ex.Message);
        //    }
        //}

        private void lbxNames_SelectedIndexChanged(object sender, EventArgs e)
        {
            //lbgenre.Text = lbgenre.SelectedItem.ToString();
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
        }

        private void lblMovies_Click(object sender, EventArgs e)
        {
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        }

        private void label6_Click(object sender, EventArgs e)
        {
        }

        private void BtnAddCustomer_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] insertArr = { tbxFirstName.Text, tbxLastName.Text, tbxAddress.Text, tbxPhone.Text };
            //calls my database
            myDatabase.InsertCust(insertArr);
            //loads database / refresh dgv
            loadDB();
        }

        private void DGVCustomers_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        // button to update customer
        private void BtnUpdateCustomer_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] updateArr = { txtCustomerID.Text, tbxFirstName.Text, tbxLastName.Text, tbxAddress.Text, tbxPhone.Text };
            //calls my database
            myDatabase.UpdateCustomer(updateArr);
            //loads database / refresh dgv
            loadDB();
        }

        //button to insert movie
        private void btnInsertMovie_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] insertArr = { txtTitle.Text, txtYear.Text, txtGenre.Text, txtRentalCost.Text, txtRateing.Text, };
            //calls my database
            myDatabase.InsertMovie(insertArr);
            //loads database / refresh dgv
            loadDB();
        }

        private void DGVRentals_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void button2_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] updateArr = { txtMovieID.Text, txtRateing.Text, txtTitle.Text, txtYear.Text, txtRentalCost.Text, txtGenre.Text, };
            //calls my database
            myDatabase.UpdateMovie(updateArr);
            //loads database / refresh dgv
            loadDB();
        }

        private void BtnRemoveCustomer_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] DelArr = { txtCustomerID.Text, };
            //calls my database
            myDatabase.DelCustomers(DelArr);
            //loads database / refresh dgv
            loadDB();
        }

        private void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] DelArr = { txtMovieID.Text, };
            //calls my database
            myDatabase.DelMovie(DelArr);
            //loads database / refresh dgv
            loadDB();
        }
    }
}