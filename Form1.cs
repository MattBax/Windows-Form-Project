using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace OrderSummary
{
    public partial class OrderForm : Form
    {
        // creates sqlconnection variable
       protected readonly SqlConnection conn = new SqlConnection("Data Source = lugh4.it.nuigalway.ie; Initial Catalog = msdb2752;" +
                              " Persist Security Info = True; User ID = msdb2752; Password = ");
        int _id = 0;
        // initial state set-up
        public OrderForm()
        {
            InitializeComponent(); //Adds buttons, labels etc.
            Display(); //Displays data from Orders table
        }
        // add input to Orders table in DB
        private void btn_Add(object sender, EventArgs e)
        {
            if (oidBox.Text != "" && cBox.Text != "" && priceBox.Text != "" && Tbox.Text != "")
            {
                //Insert SQL command
                SqlCommand cmd = new SqlCommand("INSERT INTO Orders(Order_No, Order_Desc, Price, Cust_ID) VALUES(@OrdNo,@OrdDesc, @Price, @CustID)", conn);
                conn.Open(); //Open connection
                cmd.Parameters.AddWithValue("@OrdNo", oidBox.Text);
                cmd.Parameters.AddWithValue("@CustID", cBox.Text);
                cmd.Parameters.AddWithValue("@Price", priceBox.Text);
                cmd.Parameters.AddWithValue("@OrdDesc", Tbox.Text);
                cmd.ExecuteNonQuery(); //Execute SQL command
                conn.Close(); //Close connection
                MessageBox.Show(@"Details of the order have been added succesfully.");
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"ERROR - Please check the entry and try again.");
            }
        }
        // view data on table in form
        private void btn_View(object sender, EventArgs e)
        {
            conn.Open();
            var dt = new DataTable();
            var ad = new SqlDataAdapter("SELECT * FROM Orders;", conn); //SQL command to view data
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }
        // edit data in DB table
        private void btn_Edit(object sender, EventArgs e)
        {
            if (oidBox.Text != "" && cBox.Text != "" && priceBox.Text != "" && Tbox.Text != "")
            {
                //SQL command to update Orders table from input
                SqlCommand cmd = new SqlCommand("UPDATE Orders set Order_No=@OrderNo, Order_Desc=@OrderDesc, Price=@Price, Cust_ID=@CustID where Order_No=@OrderNo", conn);
                conn.Open();
                cmd.Parameters.AddWithValue("@OrderNo", oidBox.Text);
                cmd.Parameters.AddWithValue("@CustID", cBox.Text);
                cmd.Parameters.AddWithValue("@Price", priceBox.Text);
                cmd.Parameters.AddWithValue("@OrderDesc", Tbox.Text);
                cmd.ExecuteNonQuery();
                // outputs message if successful
                MessageBox.Show(@"Orders table has been succesfully updated.");
                conn.Close();
                Display();
                Clear();
            }
            else
            {
                MessageBox.Show(@"ERROR - Update not processed. Try again.");
            }
        }
        // delete data from DB table
        private void btn_Delete(object sender, EventArgs e)
        {
                //SQL command to delete data from Orders table
                SqlCommand cmd = new SqlCommand("DELETE FROM Orders WHERE Order_No= '" + this.oidBox.Text + "'", conn);
                conn.Open();
                cmd.ExecuteNonQuery();
                conn.Close();
                MessageBox.Show(@"Entry has been deleted from the Orders table.");
                Display();
                Clear();
          
        }
        // average order test
        private void btn_Average(object sender, EventArgs e)
        {
                conn.Open();
                SqlCommand cmd = new SqlCommand("SELECT AVG(Price) FROM Orders;", conn); //SQL command to select avg price
                
               // var avg = cmd.ExecuteScalar();
                decimal avg = (decimal)cmd.ExecuteScalar();

                //Printing average price to screen
                MessageBox.Show(@"Average Order Price: " + (decimal)avg);
                conn.Close();
                Display();
                Clear();
            
        }
        //method to show total
        private void btn_Total(object sender, EventArgs e)
        {
            conn.Open();
            SqlCommand cmd = new SqlCommand("SELECT SUM(Price) FROM Orders", conn); //SQL command to find total

            decimal sum = (decimal) cmd.ExecuteScalar();

            MessageBox.Show(@"The total value of all Orders: " + (decimal) sum);
            conn.Close();
            Display();
            Clear();
        }

        // Clears typed data to return state to 0.  
        private void Clear()
        {
            _id = 0;
            oidBox.Text = "";
            cBox.Text = "";
            priceBox.Text = "";
            Tbox.Text = "";
        }
        // outputs data in DataGrid form field
        private void Display()
        {
            conn.Open();
            var dt = new DataTable();
            var ad = new SqlDataAdapter("SELECT * FROM Orders;", conn);
            ad.Fill(dt);
            dataGridView1.DataSource = dt;
            conn.Close();
        }

        //method to view data from Orders table
        private void view_Data(object sender, DataGridViewCellMouseEventArgs e)
        {
            oidBox.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
            Tbox.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            priceBox.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            cBox.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
        }

        private void oidBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void OrderForm_Load(object sender, EventArgs e)
        {

        }

        private void cid_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }
    }
}
