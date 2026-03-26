using Hotel.BLL.Managers;
using Hotel.DAL.Identity;
namespace Login
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        

        private void LoginBtn_Click(object sender, EventArgs e)
        {
            var user = new User() { Username = UsernameTxtBox.Text, Password = PasswordTxtBox.Text };

            bool exists = UserManager.CheckUser(user);


            if (exists)
            {
                MainForm mainForm = new MainForm();
                mainForm.Show();
                //this.Close();
            }
            else MessageBox.Show("Wrong username or password");

        }
    }

}
