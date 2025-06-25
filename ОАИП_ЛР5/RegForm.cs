using System;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Security.Cryptography;
using System.Windows.Forms;


namespace ОАИП_ЛР5
{
    public partial class RegForm : Form
    {
        public RegForm()
        {
            InitializeComponent();

            RegFaculty.Items.AddRange(new string[] { "Гриффиндор", "Слизерин", "Пуффендуй", "Когтевран" });
            RegCourse.Items.AddRange(new string[] { "1", "2", "3", "4" });
     
            RegEntrance.ValueChanged += (s, e) =>
            {
                RegEntrance.Value = new DateTime(RegEntrance.Value.Year, 9, 1);
            };

            RegBirth.MaxDate = DateTime.Today.AddYears(-18);
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


        private void RegFaculty_SelectedIndexChanged(object sender, EventArgs e) => GenerateGroups();
        private void RegCourse_SelectedIndexChanged(object sender, EventArgs e) => GenerateGroups();

        private void GenerateGroups()
        {
            RegGroup.Items.Clear();
            if (RegFaculty.SelectedIndex != -1 && RegCourse.SelectedIndex != -1)
            {
                int faculty = RegFaculty.SelectedIndex + 1;
                int course = RegCourse.SelectedIndex + 1;
                for (int i = 1; i <= 3; i++)
                    RegGroup.Items.Add($"{faculty}{course}{i}");
            }
        }

        private void buttonReg_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(RegName.Text))
                MessageBox.Show("Введите имя");
            else if (string.IsNullOrWhiteSpace(RegSurname.Text))
                MessageBox.Show("Введите фамилию");
            else if (string.IsNullOrWhiteSpace(RegPhone.Text))
                MessageBox.Show("Введите номер телефона");
            else if (string.IsNullOrWhiteSpace(RegEmail.Text))
                MessageBox.Show("Введите почту");
            else if (string.IsNullOrWhiteSpace(RegLogin.Text))
                MessageBox.Show("Введите логин");
            else if (string.IsNullOrWhiteSpace(RegPassword.Text))
                MessageBox.Show("Введите пароль");
            else if (RegFaculty.SelectedIndex == -1)
                MessageBox.Show("Выберите факультет");
            else if (RegCourse.SelectedIndex == -1)
                MessageBox.Show("Выберите курс");
            else if (RegGroup.SelectedIndex == -1)
                MessageBox.Show("Выберите группу");
            else if (RegPassword.Text.Length < 8)
                MessageBox.Show("Пароль должен содержать минимум 8 символов");
            else if (!System.Text.RegularExpressions.Regex.IsMatch(RegName.Text, @"^[А-Яа-яA-Za-z\-]+$"))
                MessageBox.Show("Имя должно содержать только буквы и дефис");
            else if (!System.Text.RegularExpressions.Regex.IsMatch(RegSurname.Text, @"^[А-Яа-яA-Za-z\-]+$"))
                MessageBox.Show("Фамилия должна содержать только буквы и дефис");
            else if (!System.Text.RegularExpressions.Regex.IsMatch(RegPhone.Text, @"^\+7\d{10}$"))
                MessageBox.Show("Введите номер в формате +7XXXXXXXXXX");
            else if ((RegEntrance.Value.Year - RegBirth.Value.Year) < 16)
                MessageBox.Show("Разница между рождением и поступлением должна быть минимум 16 лет");
            else
            {
                try
                {
                    var addr = new System.Net.Mail.MailAddress(RegEmail.Text);
                }
                catch (FormatException)
                {
                    MessageBox.Show("E-mail указан в недопустимом формате");
                    return;
                }

                try
                {
                    string domain = RegEmail.Text.Split('@')[1];
                    var entry = System.Net.Dns.GetHostEntry(domain);
                }
                catch
                {
                    MessageBox.Show("Домен почты не существует или не отвечает");
                    return;
                }

                using (UserContext db = new UserContext())
                {
                    if (db.Users.Any(u => u.Login == RegLogin.Text || u.Email == RegEmail.Text || u.Phone == RegPhone.Text))
                    {
                        MessageBox.Show("Такой логин, email или телефон уже зарегистрированы");
                        return;
                    }

                    User user = new User
                    {
                        Name = RegName.Text,
                        Surname = RegSurname.Text,
                        BirthDate = RegBirth.Value,
                        Email = RegEmail.Text,
                        Phone = RegPhone.Text,
                        Faculty = RegFaculty.SelectedIndex + 1,
                        Course = RegCourse.SelectedIndex + 1,
                        Group = RegGroup.Text,
                        EntranceDate = RegEntrance.Value,
                        Login = RegLogin.Text,
                        Password = GetHashString(RegPassword.Text)
                    };

                    db.Users.Add(user);
                    db.SaveChanges();
                    MessageBox.Show("Регистрация успешна!");
                    AuthForm authForm = new AuthForm();
                    authForm.Show();
                    Hide();
                }
            }

        }

        private void AlreadyReg_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }
    }
}
