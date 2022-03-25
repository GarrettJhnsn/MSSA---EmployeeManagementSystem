using System.Data.SqlClient;
using static AccountManagement.DeleteEmployee;

namespace AccountManagement
{
    public partial class Verify : Form
    {
        int textID;
        //Connection String To Connect To Database
        string connectionString = @"Data Source = localhost\SQLEXPRESS; Initial Catalog = EmployeeDB; Integrated Security = True;";

        //Taking In Int ID From DeleteEmployee.cs For Employee To Be Deleted
        public Verify(int ID)
        {
            textID = ID;
            InitializeComponent();
        }

        //If No Is Selected Windows Form Closes And You Are Brought Back To Home
        private void No_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //If Yes Is Selected Sql Query Is Excecuted To Delete Employee Row Based On EmployeeID
        private void Yes_Click(object sender, EventArgs e)
        {
            using (SqlConnection sqlCon = new SqlConnection(connectionString))
            {
                //Opening SQL Connection
                sqlCon.Open();

                string query = "DELETE FROM [Employee] WHERE EmployeeID = @EmployeeID";

                using (SqlCommand command = new SqlCommand(query, sqlCon))
                {
                    command.Parameters.AddWithValue("@EmployeeID", textID);

                    int result = command.ExecuteNonQuery();

                    if (result < 0)
                    {
                        MessageBox.Show("Error Deleting Data");
                    }
                    //Closing SQL Connection
                    sqlCon.Close();

                    this.Close();
                }
            }
        }
    }
}
