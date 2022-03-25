namespace AccountManagement
{
    public partial class DeleteEmployee : Form
    {
        int employeeID;
        public DeleteEmployee()
        {
            InitializeComponent();
        }

        //Closes Delete Employee Form
        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        //Opens Verify Form With Employee ID Being Sent In
        //Closes Form
        private void Delete_Click(object sender, EventArgs e)
        {
            new Verify(employeeID).Show();
            this.Close();
        }

        //Takes EmployeeID Input And Checks To Make Sure It Is A Int
        private void textID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                employeeID = Convert.ToInt32(textID.Text);
            }
            catch (Exception)
            {
                textID.Clear();
                MessageBox.Show("Please enter Employee ID only. Ex 101");

            }
        }
    }
}
