using System;
using System.Windows.Forms;

namespace Sql_project
{
    public partial class Form1 : Form
    {
       
        //create an instance of the Database class
        public Database myDatabase = new Database();

        private DateTime thisDay = DateTime.Now;

        /// <summary>
        /// The .ctor.
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            //loads database
            loadDB();
            
          
        }

        public string Message()
        {
            return "hello";

        }

       

        /// <summary>
        /// Gets the today.
        /// </summary>
        public static DateTime Today { get; }

        /// <summary>
        /// The load d b.
        /// </summary>
        public void loadDB()
        {
            //DGVCustomer.DataSource = dt;
            //dt.Rows.Clear();
            // dgvMain.DataSource = myDatabase.ReadCust();
            // load the customer dgv
            // DisplayListBox();
            // InsertCust();
            
            DisplayDataGridViewCustomers();
            DisplayDataGridViewRentals();  
            DisplayDataGridViewMovie();
        }

        /// <summary>
        /// The display data grid view movie.
        /// </summary>
        private void DisplayDataGridViewMovie()
        {
            DGVMovie.DataSource = "";
            DGVMovie.DataSource = myDatabase.FillDGVMovieWithMovies();
            //pass the datatable data to the DataGridView
         //   DGVMovie.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// The display data grid view customers.
        /// </summary>
        private void DisplayDataGridViewCustomers()
        {
            DGVMovie.DataSource = "";
            DGVCustomers.DataSource = myDatabase.FillDGVCustomersWithCustomer();
            //pass the datatable data to the DataGridView
         //   DGVCustomers.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
        }

        /// <summary>
        /// The display data grid view rentals.
        /// </summary>
        private void DisplayDataGridViewRentals()
        {
            DGVMovie.DataSource = "";
            DGVRentals.DataSource = myDatabase.FillDGVRentalsWithRentedMovies();
            //pass the datatable data to the DataGridView
         //   DGVRentals.AutoResizeColumns(DataGridViewAutoSizeColumnsMode.AllCells);
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
            lblDate.Text = InserDate();
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

        /// <summary>
        /// The btn insert movie_ click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        public void btnInsertMovie_Click(object sender, EventArgs e)
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

        public void btnRemoveMovie_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] DelArr = { txtMovieID.Text, };
            //calls my database
            myDatabase.DelMovie(DelArr);
           
            //loads database / refresh dgv
            loadDB();
           
        }
        public void MessageBoxPopUp()
        {
            btnRemoveMovie.Click += btnRemoveMovie_Click;
            MessageBox.Show("Message here");
            this.Close();
        }

        public string InserDate()
        {
            return DateTime.Now.ToString("dddd , MMM dd yyyy,hh:mm:ss");
        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            lblDate.Text = InserDate();
            // creates array from string input from text box
            string[] RentArr = { txtMovieID.Text, txtCustomerID.Text, };
            //calls my database
            myDatabase.RentMovie(RentArr);

            //loads database / refresh dgv
            loadDB();
        }

        private void DGVCustomer(object sender, DataGridViewCellEventArgs e)
        {
        }

        private void tbxPhone_TextChanged(object sender, EventArgs e)
        {
        }

        private void DGVCustomers_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
        }

        /// <summary>
        /// The d g v customers_ cell click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void DGVCustomers_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            txtCustomerID.Text = DGVCustomers.Rows[e.RowIndex].Cells[0].Value.ToString();
            tbxFirstName.Text = DGVCustomers.Rows[e.RowIndex].Cells[1].Value.ToString();
            tbxLastName.Text = DGVCustomers.Rows[e.RowIndex].Cells[2].Value.ToString();
            tbxAddress.Text = DGVCustomers.Rows[e.RowIndex].Cells[3].Value.ToString();
            tbxPhone.Text = DGVCustomers.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
            catch (Exception)
            {

                Console.WriteLine("{0} Clicked Invalid cell", e);
            }
            
        }

        /// <summary>
        /// The d g v movie_ cell click.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        /// [num] = row number
        private void DGVMovie_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
            txtMovieID.Text = DGVMovie.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtRateing.Text = DGVMovie.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtTitle.Text = DGVMovie.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtYear.Text = DGVMovie.Rows[e.RowIndex].Cells[3].Value.ToString();
            txtRentalCost.Text = DGVMovie.Rows[e.RowIndex].Cells[4].Value.ToString();
            //genre is the 7th cell
            txtGenre.Text = DGVMovie.Rows[e.RowIndex].Cells[7].Value.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("{0} Clicked Invalid cell", e);
            }
          
        }

        /// <summary>
        /// The txt date_ text changed.
        /// </summary>
        /// <param name="sender">The sender.</param>
        /// <param name="e">The e.</param>
        private void txtDate_TextChanged(object sender, EventArgs e)
        {
            lblDate.Text = InserDate();
        }

        private void btnReturn_Click(object sender, EventArgs e)
        {
            // creates array from string input from text box
            string[] updateArr = { txtRMID.Text, };
            //calls my database
            myDatabase.Return(updateArr);
            //loads database / refresh dgv
            loadDB();
            
        }

        private void DGVRentals_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtRMID.Text = DGVRentals.Rows[e.RowIndex].Cells[0].Value.ToString();
            }
            catch (Exception)
            {
                Console.WriteLine("{0} Clicked Invalid cell", e);
            }
            
        }

        
    }
}