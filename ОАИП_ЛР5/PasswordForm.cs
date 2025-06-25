using System;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace ОАИП_ЛР5
{
    public partial class PasswordForm : Form
    {
        public PasswordForm()
        {
            InitializeComponent();
            Load += PasswordForm_Load;
            FormClosed += PasswordForm_FormClosed;
        }

        private void PasswordForm_Load(object sender, EventArgs e)
        {
            UpdateButtonState();

            PasswordRecoveryTimer.OnTick += UpdateButtonFromTimer;
            PasswordRecoveryTimer.OnComplete += UpdateButtonFromTimer;
        }

        private void PasswordForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            PasswordRecoveryTimer.OnTick -= UpdateButtonFromTimer;
            PasswordRecoveryTimer.OnComplete -= UpdateButtonFromTimer;
        }

        private string GetHashString(string s)
        {
            byte[] bytes = Encoding.Unicode.GetBytes(s);
            using (MD5CryptoServiceProvider CSP = new MD5CryptoServiceProvider())
            {
                byte[] byteHash = CSP.ComputeHash(bytes);
                StringBuilder hash = new StringBuilder();
                foreach (byte b in byteHash)
                {
                    hash.AppendFormat("{0:x2}", b);
                }
                return hash.ToString();
            }
        }

        private void UpdateButtonState()
        {
            if (PasswordRecoveryTimer.IsRunning)
            {
                buttonNewPass.Enabled = false;
                buttonNewPass.Text = $"{PasswordRecoveryTimer.SecondsRemaining} сек)";
            }
            else
            {
                buttonNewPass.Enabled = true;
                buttonNewPass.Text = "Отправить новый пароль";
            }
        }

        private void UpdateButtonFromTimer()
        {
            this.Invoke((MethodInvoker)delegate
            {
                if (PasswordRecoveryTimer.IsRunning)
                {
                    buttonNewPass.Enabled = false;
                    buttonNewPass.Text = $"{PasswordRecoveryTimer.SecondsRemaining} сек)";
                }
                else
                {
                    buttonNewPass.Enabled = true;
                    buttonNewPass.Text = "Отправить новый пароль";
                }
            });
        }

        private async void buttonNewPass_Click(object sender, EventArgs e)
        {
            string email = PassEmail.Text;
            if (string.IsNullOrWhiteSpace(email))
            {
                MessageBox.Show("Введите адрес электронной почты.");
                return;
            }

            using (UserContext db = new UserContext())
            {
                var user = db.Users.FirstOrDefault(u => u.Email == email);
                if (user == null)
                {
                    MessageBox.Show("Почта не найдена.");
                    return;
                }

                string newPass = Guid.NewGuid().ToString().Substring(0, 10);
                user.Password = GetHashString(newPass);
                db.SaveChanges();

                try
                {
                    MailAddress from = new MailAddress("savmal1357@gmail.com", "Hogwarts_Admin");
                    MailAddress to = new MailAddress(email);
                    MailMessage msg = new MailMessage(from, to)
                    {
                        Subject = "Восстановление пароля",
                        Body = $"<h2>Ваш новый пароль для логина {user.Login}: {newPass}</h2>",
                        IsBodyHtml = true
                    };

                    using (SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587))
                    {
                        smtp.Credentials = new System.Net.NetworkCredential("savmal1357@gmail.com", "oxzs kyha gvaj xwyk");
                        smtp.EnableSsl = true;
                        await smtp.SendMailAsync(msg);
                    }

                    MessageBox.Show("Новый пароль отправлен на почту.");

                    PasswordRecoveryTimer.Start(30,
                        () => this.Invoke((MethodInvoker)delegate
                        {
                            buttonNewPass.Text = $"{PasswordRecoveryTimer.SecondsRemaining} сек)";
                        }),
                        () => this.Invoke((MethodInvoker)delegate
                        {
                            buttonNewPass.Enabled = true;
                            buttonNewPass.Text = "Отправить новый пароль";
                        }));

                    buttonNewPass.Enabled = false;

                }
                catch (SmtpException smtpEx)
                {
                    MessageBox.Show($"Ошибка SMTP: {smtpEx.Message}\n\nКод ошибки: {smtpEx.StatusCode}");
                }
                catch (FormatException formatEx)
                {
                    MessageBox.Show("Неверный формат e-mail: " + formatEx.Message);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Не удалось отправить письмо: " + ex.Message);
                }
            }
        }

        private void PassRemember_Click(object sender, EventArgs e)
        {
            AuthForm authForm = new AuthForm();
            authForm.Show();
            Hide();
        }
    }
}