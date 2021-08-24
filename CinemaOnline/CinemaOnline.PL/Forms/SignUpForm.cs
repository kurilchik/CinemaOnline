using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.BLL.Services;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignUpForm : Form
    {
        private const int GIFT = 30;
        private SignInForm _signInForm;
        private IUserService _userService;

        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(SignInForm signInForm) : this()
        {
            _userService = new UserService();
            _signInForm = signInForm;
        }

        private void _singUpButton_Click(object sender, EventArgs e)
        {
            var space = string.IsNullOrEmpty(_passwordTextBox.Text);

            if (space)
                MessageBox.Show("Invalid password!", "Pasword", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Email() && Password() && !space)
            {
                var user = new UserViewModel()
                {
                    Email = _emailAddressTextBox.Text,
                    Password = _passwordTextBox.Text,
                    Name = _nameTextBox.Text
                };

                if (_userService.GetByEmail(_emailAddressTextBox.Text) == null)
                {
                    user.Balance = GIFT;

                    _userService.Add(user);

                    MessageBox.Show($"Registration successful!\nGift for registration {user.Balance} BYN.", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    _signInForm.Show();
                }
                else
                    MessageBox.Show($"{_emailAddressTextBox.Text} already registered!", "Email", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void _emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (_emailAddressTextBox.Text.Trim() != string.Empty)
            {
                Email();
            }
        }

        private bool Email()
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(_emailAddressTextBox.Text);
                return true;
            }
            catch
            {
                MessageBox.Show("E-mail address format is not correct.", "Email Address", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

        }

        private void _passwordTextBox_Leave(object sender, EventArgs e)
        {
            Password();
        }

        private bool Password()
        {
            if (_passwordTextBox.Text.Contains(' '))
            {
                MessageBox.Show("Invalid password!", "Pasword", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }

        private void _signInLabel_Click(object sender, EventArgs e)
        {
            Hide();
            _signInForm.Show();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }       
    }
}
