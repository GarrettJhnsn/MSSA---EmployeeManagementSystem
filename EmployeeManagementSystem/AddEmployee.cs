using System.Data.SqlClient;

namespace AccountManagement
{
    public partial class AddEmployee : Form
    {
        //Connection String To Connect To Database
        string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True;";
        public AddEmployee()
        {
            InitializeComponent();
        }

        //Closes Add Employee Form. **Does Not Close Applicaton**
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Takes Data Inputed Into TextFields And Submits Query To Be Excecuted With Insert Into Command
        private void button1_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Opening Sql Connection
                sqlCon.Open();
                string query = "INSERT INTO [Employee](FirstName, LastName, Email, PhoneNumber, City, State) VALUES (@FirstName,@LastName,@Email,@PhoneNumber,@City,@State)";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@FirstName", textFName.Text);
                    command.Parameters.AddWithValue("@LastName", textLName.Text);
                    command.Parameters.AddWithValue("@Email", textEmail.Text);
                    command.Parameters.AddWithValue("@PhoneNumber", textPhoneNumber.Text);
                    command.Parameters.AddWithValue("@City", textCity.Text);
                    command.Parameters.AddWithValue("@State", textState1.Text);

                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error Inserting Data");
                    }
                    //Closing Sql Connection
                    sqlCon.Close();
                    //Closing Add Employee Form
                    this.Close();
                }
            }

        }

        //Clears All Text Entry Fields In Add Employee
        private void label6_Click(object sender, EventArgs e)
        {
            textCity.Clear();
            textState1.Clear();
            textFName.Clear();
            textLName.Clear();
            textEmail.Clear();
            textPhoneNumber.Clear();

        }
    }
}
