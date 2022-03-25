namespace AccountManagement
{
    public partial class Login : Form
    {
        //Creates Window Form
        public Login()
        {
            InitializeComponent();
        }

        //Clears Text Entry Fields Of Username and Password
        private void Clear_Click(object sender, EventArgs e)
        {
            textPassword.Clear();
            textUsername.Clear();
        }

        //Exits Out Of Application
        private void label1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        //Checks Username And Password If Correct Closes Login Form, Opens Home Form. 
        //If Incorrect Clears Text From Entry Fields
        private void Login_Click(object sender, EventArgs e)
        {
            if (textUsername.Text == "admin" && textPassword.Text == "admin")
            {
                new Home().Show();
                this.Hide();
            }
            else
            {
                MessageBox.Show("Incorrect Username or Password");
                textUsername.Clear();
                textPassword.Clear();
            }
        }

        //Hides Each Char In Password Entry Field With *
        private void textPassword_TextChanged(object sender, EventArgs e)
        {
            textPassword.PasswordChar = '*';
        }

    }
}