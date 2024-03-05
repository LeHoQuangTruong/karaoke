using KaraokeManagement.Model;
using System.Linq;


namespace KaraokeManagement
{
    public partial class FormDangNhap : Form
    {
        public FormDangNhap()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            var password = txtPassword.Text;
            var db = new KaraDB();
            var user = db.Employees.SingleOrDefault(staff => staff.Username == username && staff.Password == password);
            if (user == null)
            {
                MessageBox.Show("Incorrect username or password!");
            }
            else
            {   
               Console.WriteLine(user.FirstName + " " + user.LastName);
               FormManHinhChinh FrmMCH =  new FormManHinhChinh(user);
                FrmMCH.Show();
                

            }
        }
    }
}
