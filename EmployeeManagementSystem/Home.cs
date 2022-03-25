using System.Data;
using System.Data.SqlClient;
namespace AccountManagement
{
    public partial class Home : Form
    {
        //Connectiong String For Database Entry
        string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True;";
        int employeeID;
        public Home()
        {
            InitializeComponent();
        }
        
        //Exits Application
        private void Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Searches Database For Employee Based On EmployeeID
        private void Search_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Opening Sql Connection
                sqlCon.Open();
                //Pulls Data From Databse Table [Employee] Based On EmployeeID
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT* FROM [Employee] WHERE[EmployeeID] = " + employeeID, sqlCon);
                DataTable dt = new DataTable();
                //Inputs Data To DataTable
                adapter.Fill(dt);

                //Formats DataTable To Fit
                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

                //Closing Sql Connection
                sqlCon.Close();
            }

        }

        //Entry Box For Employee ID Search Box. If Entry Is Not A Number Fails And Clears Entry Field
        private void textEmployeeID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employeeID = Convert.ToInt32(textEmployeeID.Text);
            }catch (Exception)
            {
                textEmployeeID.Clear();
                MessageBox.Show("Please enter Employee ID only. Ex 101");
                
            }
            
        }

        //Searches Database For All Employees In Database Table Employee
        private void ShowAll_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Opening Sql Connection
                sqlCon.Open();
                //Pulls All Data From Databse Table [Employee] 
                SqlDataAdapter adapter = new SqlDataAdapter("SELECT* FROM [Employee]", sqlCon);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                dataGridView1.DataSource = dt;
                dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                dataGridView1.Columns[dataGridView1.ColumnCount - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                //Closing Sql Connection
                sqlCon.Close();
            }
        }

        //Opens Add Employee Form
        private void Add_Click(object sender, EventArgs e)
        {
            new AddEmployee().Show();
        }

        //Opens Delete Employee Form
        private void textDelete_Click(object sender, EventArgs e)
        {
            new DeleteEmployee().Show();
        }

        //Close Home Form And Re Opens Login Form
        private void Logout_Click(object sender, EventArgs e)
        {
            this.Close();
            new Login().Show();
        }
    }
}
