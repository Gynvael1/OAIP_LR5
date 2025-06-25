using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ОАИП_ЛР5
{
    public partial class AuthForm : Form
    {
        public AuthForm()
        {
            InitializeComponent();
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider();
            byte[] byteHash = CSP.ComputeHash(bytes);
            string hash = "";
            foreach (byte b in byteHash)
            {
                hash += string.Format("{0:x2}", b);
            }
            return hash;
        }


        private void buttonAuth_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(AuthLogin.Text) )
            {
                MessageBox.Show("Введите логин");
                return;
            }

            if (string.IsNullOrEmpty(AuthLogin.Text))
            {
                MessageBox.Show("Введите логин");
                return;
            }
            if (string.IsNullOrEmpty(AuthPassword.Text))
            {
                MessageBox.Show("Введите пароль");
                return;
            }
            string login = AuthLogin.Text;
            string password = GetHashString(AuthPassword.Text);

            using (UserContext db = new UserContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Login == login && u.Password == password);
                if (user != null)
                {
                    InfoForm form = new InfoForm();
                    form.InfoLogin.Text = user.Login;
                    form.InfoName.Text = user.Name;
                    form.InfoSurname.Text = user.Surname;
                    form.InfoPhone.Text = user.Phone;
                    form.InfoBirth.Text = user.BirthDate.ToShortDateString();
                    form.InfoFaculty.Text = user.Faculty.ToString();
                    form.InfoCourse.Text = user.Course.ToString();
                    form.InfoGroup.Text = user.Group;
                    form.InfoEntrance.Text = user.EntranceDate.ToShortDateString();
                    form.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Неверный логин или пароль");
                }
            }
        }

        private void labelLostPass_Click(object sender, EventArgs e)
        {
            PasswordForm passForm = new PasswordForm();
            passForm.Show();
            Hide();
        }

        private void labelDontReg_Click(object sender, EventArgs e)
        {
            RegForm regForm = new RegForm();
            regForm.Show();
            Hide();
        }
    }
}
