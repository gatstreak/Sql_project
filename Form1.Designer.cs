namespace Sql_project
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.DGVCustomers = new System.Windows.Forms.DataGridView();
            this.DGVMovie = new System.Windows.Forms.DataGridView();
            this.TAC1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.DGVRentals = new System.Windows.Forms.DataGridView();
            this.BtnAddCustomer = new System.Windows.Forms.Button();
            this.BtnRemoveCustomer = new System.Windows.Forms.Button();
            this.BtnUpdateCustomer = new System.Windows.Forms.Button();
            this.tbxFirstName = new System.Windows.Forms.TextBox();
            this.tbxPhone = new System.Windows.Forms.TextBox();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.tbxLastName = new System.Windows.Forms.TextBox();
            this.txtCustomerID = new System.Windows.Forms.TextBox();
            this.btnAddMovie = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnRemoveMovie = new System.Windows.Forms.Button();
            this.txtTitle = new System.Windows.Forms.TextBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.txtGenre = new System.Windows.Forms.TextBox();
            this.txtRentalCost = new System.Windows.Forms.TextBox();
            this.txtMovieID = new System.Windows.Forms.TextBox();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.tbxTitle = new System.Windows.Forms.Label();
            this.tbxYear = new System.Windows.Forms.Label();
            this.tbxCost = new System.Windows.Forms.Label();
            this.tbxGenre = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtRateing = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovie)).BeginInit();
            this.TAC1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // DGVCustomers
            // 
            this.DGVCustomers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVCustomers.Location = new System.Drawing.Point(0, -4);
            this.DGVCustomers.Margin = new System.Windows.Forms.Padding(4);
            this.DGVCustomers.Name = "DGVCustomers";
            this.DGVCustomers.RowHeadersWidth = 51;
            this.DGVCustomers.Size = new System.Drawing.Size(1238, 319);
            this.DGVCustomers.TabIndex = 1;
            this.DGVCustomers.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVCustomers_CellContentClick);
            // 
            // DGVMovie
            // 
            this.DGVMovie.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVMovie.Location = new System.Drawing.Point(0, 0);
            this.DGVMovie.Margin = new System.Windows.Forms.Padding(4);
            this.DGVMovie.Name = "DGVMovie";
            this.DGVMovie.RowHeadersWidth = 51;
            this.DGVMovie.Size = new System.Drawing.Size(1238, 319);
            this.DGVMovie.TabIndex = 4;
            // 
            // TAC1
            // 
            this.TAC1.Controls.Add(this.tabPage1);
            this.TAC1.Controls.Add(this.tabPage2);
            this.TAC1.Controls.Add(this.tabPage3);
            this.TAC1.Location = new System.Drawing.Point(12, 12);
            this.TAC1.Name = "TAC1";
            this.TAC1.SelectedIndex = 0;
            this.TAC1.Size = new System.Drawing.Size(1246, 348);
            this.TAC1.TabIndex = 5;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.DGVCustomers);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1238, 319);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Customers";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.DGVMovie);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1238, 319);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Movies";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.DGVRentals);
            this.tabPage3.Location = new System.Drawing.Point(4, 25);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(1238, 319);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Rentals";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // DGVRentals
            // 
            this.DGVRentals.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DGVRentals.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DGVRentals.Location = new System.Drawing.Point(3, 3);
            this.DGVRentals.Name = "DGVRentals";
            this.DGVRentals.RowHeadersWidth = 51;
            this.DGVRentals.RowTemplate.Height = 24;
            this.DGVRentals.Size = new System.Drawing.Size(1232, 313);
            this.DGVRentals.TabIndex = 0;
            this.DGVRentals.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DGVRentals_CellContentClick);
            // 
            // BtnAddCustomer
            // 
            this.BtnAddCustomer.BackColor = System.Drawing.Color.Lime;
            this.BtnAddCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAddCustomer.Location = new System.Drawing.Point(48, 373);
            this.BtnAddCustomer.Name = "BtnAddCustomer";
            this.BtnAddCustomer.Size = new System.Drawing.Size(107, 69);
            this.BtnAddCustomer.TabIndex = 6;
            this.BtnAddCustomer.Text = "Add Customer";
            this.BtnAddCustomer.UseVisualStyleBackColor = false;
            this.BtnAddCustomer.Click += new System.EventHandler(this.BtnAddCustomer_Click);
            // 
            // BtnRemoveCustomer
            // 
            this.BtnRemoveCustomer.BackColor = System.Drawing.Color.Red;
            this.BtnRemoveCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnRemoveCustomer.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BtnRemoveCustomer.Location = new System.Drawing.Point(973, 448);
            this.BtnRemoveCustomer.Name = "BtnRemoveCustomer";
            this.BtnRemoveCustomer.Size = new System.Drawing.Size(144, 60);
            this.BtnRemoveCustomer.TabIndex = 7;
            this.BtnRemoveCustomer.Text = "Remove Customer";
            this.BtnRemoveCustomer.UseVisualStyleBackColor = false;
            this.BtnRemoveCustomer.Click += new System.EventHandler(this.BtnRemoveCustomer_Click);
            // 
            // BtnUpdateCustomer
            // 
            this.BtnUpdateCustomer.BackColor = System.Drawing.Color.Lime;
            this.BtnUpdateCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnUpdateCustomer.Location = new System.Drawing.Point(973, 377);
            this.BtnUpdateCustomer.Name = "BtnUpdateCustomer";
            this.BtnUpdateCustomer.Size = new System.Drawing.Size(144, 65);
            this.BtnUpdateCustomer.TabIndex = 8;
            this.BtnUpdateCustomer.Text = "Update Customer";
            this.BtnUpdateCustomer.UseVisualStyleBackColor = false;
            this.BtnUpdateCustomer.Click += new System.EventHandler(this.BtnUpdateCustomer_Click);
            // 
            // tbxFirstName
            // 
            this.tbxFirstName.Location = new System.Drawing.Point(310, 373);
            this.tbxFirstName.Name = "tbxFirstName";
            this.tbxFirstName.Size = new System.Drawing.Size(100, 22);
            this.tbxFirstName.TabIndex = 9;
            // 
            // tbxPhone
            // 
            this.tbxPhone.Location = new System.Drawing.Point(534, 399);
            this.tbxPhone.Name = "tbxPhone";
            this.tbxPhone.Size = new System.Drawing.Size(100, 22);
            this.tbxPhone.TabIndex = 10;
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(310, 401);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.Size = new System.Drawing.Size(100, 22);
            this.tbxAddress.TabIndex = 11;
            // 
            // tbxLastName
            // 
            this.tbxLastName.Location = new System.Drawing.Point(534, 373);
            this.tbxLastName.Name = "tbxLastName";
            this.tbxLastName.Size = new System.Drawing.Size(100, 22);
            this.tbxLastName.TabIndex = 12;
            // 
            // txtCustomerID
            // 
            this.txtCustomerID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtCustomerID.Location = new System.Drawing.Point(756, 394);
            this.txtCustomerID.Name = "txtCustomerID";
            this.txtCustomerID.Size = new System.Drawing.Size(49, 22);
            this.txtCustomerID.TabIndex = 13;
            // 
            // btnAddMovie
            // 
            this.btnAddMovie.BackColor = System.Drawing.Color.Lime;
            this.btnAddMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAddMovie.Location = new System.Drawing.Point(48, 448);
            this.btnAddMovie.Name = "btnAddMovie";
            this.btnAddMovie.Size = new System.Drawing.Size(107, 60);
            this.btnAddMovie.TabIndex = 14;
            this.btnAddMovie.Text = "Add Movie";
            this.btnAddMovie.UseVisualStyleBackColor = false;
            this.btnAddMovie.Click += new System.EventHandler(this.btnInsertMovie_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Lime;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Location = new System.Drawing.Point(823, 377);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 65);
            this.button2.TabIndex = 15;
            this.button2.Text = "Update Movie";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btnRemoveMovie
            // 
            this.btnRemoveMovie.BackColor = System.Drawing.Color.Red;
            this.btnRemoveMovie.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemoveMovie.ForeColor = System.Drawing.SystemColors.Control;
            this.btnRemoveMovie.Location = new System.Drawing.Point(823, 448);
            this.btnRemoveMovie.Name = "btnRemoveMovie";
            this.btnRemoveMovie.Size = new System.Drawing.Size(144, 60);
            this.btnRemoveMovie.TabIndex = 16;
            this.btnRemoveMovie.Text = "Remove Movie";
            this.btnRemoveMovie.UseVisualStyleBackColor = false;
            this.btnRemoveMovie.Click += new System.EventHandler(this.btnRemoveMovie_Click);
            // 
            // txtTitle
            // 
            this.txtTitle.Location = new System.Drawing.Point(310, 458);
            this.txtTitle.Name = "txtTitle";
            this.txtTitle.Size = new System.Drawing.Size(100, 22);
            this.txtTitle.TabIndex = 17;
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(310, 486);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(100, 22);
            this.txtYear.TabIndex = 18;
            // 
            // txtGenre
            // 
            this.txtGenre.Location = new System.Drawing.Point(534, 455);
            this.txtGenre.Name = "txtGenre";
            this.txtGenre.Size = new System.Drawing.Size(100, 22);
            this.txtGenre.TabIndex = 19;
            // 
            // txtRentalCost
            // 
            this.txtRentalCost.Location = new System.Drawing.Point(534, 483);
            this.txtRentalCost.Name = "txtRentalCost";
            this.txtRentalCost.Size = new System.Drawing.Size(100, 22);
            this.txtRentalCost.TabIndex = 20;
            // 
            // txtMovieID
            // 
            this.txtMovieID.Cursor = System.Windows.Forms.Cursors.No;
            this.txtMovieID.Location = new System.Drawing.Point(756, 428);
            this.txtMovieID.Name = "txtMovieID";
            this.txtMovieID.Size = new System.Drawing.Size(49, 22);
            this.txtMovieID.TabIndex = 21;
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button4.ForeColor = System.Drawing.Color.Red;
            this.button4.Location = new System.Drawing.Point(1292, 37);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(154, 54);
            this.button4.TabIndex = 22;
            this.button4.Text = "Return Movie";
            this.button4.UseVisualStyleBackColor = true;
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.button5.ForeColor = System.Drawing.Color.Lime;
            this.button5.Location = new System.Drawing.Point(1292, 125);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(154, 53);
            this.button5.TabIndex = 23;
            this.button5.Text = "Return Movie";
            this.button5.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton2);
            this.groupBox1.Controls.Add(this.radioButton1);
            this.groupBox1.Location = new System.Drawing.Point(1275, 214);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 100);
            this.groupBox1.TabIndex = 24;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Rented Movies";
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(7, 59);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(102, 21);
            this.radioButton2.TabIndex = 1;
            this.radioButton2.Text = "Out Rented";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.Location = new System.Drawing.Point(7, 31);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(89, 21);
            this.radioButton1.TabIndex = 0;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "All rented";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(228, 375);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(76, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "First Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(443, 375);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "Last Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(657, 394);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(93, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "Customer ID#";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(228, 404);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "Address";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(425, 404);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "Phone Number";
            // 
            // tbxTitle
            // 
            this.tbxTitle.AutoSize = true;
            this.tbxTitle.Location = new System.Drawing.Point(228, 460);
            this.tbxTitle.Name = "tbxTitle";
            this.tbxTitle.Size = new System.Drawing.Size(35, 17);
            this.tbxTitle.TabIndex = 31;
            this.tbxTitle.Text = "Title";
            // 
            // tbxYear
            // 
            this.tbxYear.AutoSize = true;
            this.tbxYear.Location = new System.Drawing.Point(228, 491);
            this.tbxYear.Name = "tbxYear";
            this.tbxYear.Size = new System.Drawing.Size(38, 17);
            this.tbxYear.TabIndex = 32;
            this.tbxYear.Text = "Year";
            // 
            // tbxCost
            // 
            this.tbxCost.AutoSize = true;
            this.tbxCost.Location = new System.Drawing.Point(438, 483);
            this.tbxCost.Name = "tbxCost";
            this.tbxCost.Size = new System.Drawing.Size(81, 17);
            this.tbxCost.TabIndex = 33;
            this.tbxCost.Text = "Rental Cost";
            // 
            // tbxGenre
            // 
            this.tbxGenre.AutoSize = true;
            this.tbxGenre.Location = new System.Drawing.Point(471, 455);
            this.tbxGenre.Name = "tbxGenre";
            this.tbxGenre.Size = new System.Drawing.Size(48, 17);
            this.tbxGenre.TabIndex = 34;
            this.tbxGenre.Text = "Genre";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(680, 428);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(70, 17);
            this.label6.TabIndex = 35;
            this.label6.Text = "Movie ID#";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // txtRateing
            // 
            this.txtRateing.Location = new System.Drawing.Point(756, 467);
            this.txtRateing.Name = "txtRateing";
            this.txtRateing.Size = new System.Drawing.Size(49, 22);
            this.txtRateing.TabIndex = 36;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(693, 463);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(57, 17);
            this.label7.TabIndex = 37;
            this.label7.Text = "Rateing";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1487, 543);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtRateing);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.tbxGenre);
            this.Controls.Add(this.tbxCost);
            this.Controls.Add(this.tbxYear);
            this.Controls.Add(this.tbxTitle);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.txtMovieID);
            this.Controls.Add(this.txtRentalCost);
            this.Controls.Add(this.txtGenre);
            this.Controls.Add(this.txtYear);
            this.Controls.Add(this.txtTitle);
            this.Controls.Add(this.btnRemoveMovie);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.btnAddMovie);
            this.Controls.Add(this.txtCustomerID);
            this.Controls.Add(this.tbxLastName);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.tbxPhone);
            this.Controls.Add(this.tbxFirstName);
            this.Controls.Add(this.BtnUpdateCustomer);
            this.Controls.Add(this.BtnRemoveCustomer);
            this.Controls.Add(this.BtnAddCustomer);
            this.Controls.Add(this.TAC1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "Form1";
            this.Text = "Movies Database Application";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DGVCustomers)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DGVMovie)).EndInit();
            this.TAC1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DGVRentals)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView DGVCustomers;
        private System.Windows.Forms.DataGridView DGVMovie;
        private System.Windows.Forms.TabControl TAC1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.DataGridView DGVRentals;
        private System.Windows.Forms.Button BtnAddCustomer;
        private System.Windows.Forms.Button BtnRemoveCustomer;
        private System.Windows.Forms.Button BtnUpdateCustomer;
        private System.Windows.Forms.TextBox tbxFirstName;
        private System.Windows.Forms.TextBox tbxPhone;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.TextBox tbxLastName;
        private System.Windows.Forms.TextBox txtCustomerID;
        private System.Windows.Forms.Button btnAddMovie;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnRemoveMovie;
        private System.Windows.Forms.TextBox txtTitle;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.TextBox txtGenre;
        private System.Windows.Forms.TextBox txtRentalCost;
        private System.Windows.Forms.TextBox txtMovieID;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label tbxTitle;
        private System.Windows.Forms.Label tbxYear;
        private System.Windows.Forms.Label tbxCost;
        private System.Windows.Forms.Label tbxGenre;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtRateing;
        private System.Windows.Forms.Label label7;
    }
}

