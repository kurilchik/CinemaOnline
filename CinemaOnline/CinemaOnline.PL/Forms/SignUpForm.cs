using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignUpForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserService _userService;

        public SignUpForm(IFormOpener formOpener, IUserService userService)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _userService = userService;
        }

        private void _singUpButton_Click(object sender, EventArgs e)
        {
            var space = string.IsNullOrEmpty(_passwordTextBox.Text);

            if (space)
            {
                MessageBox.Show(Constant.InvalidPassword, Constant.Password, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var emailValid = Validation.EmailValidation(_emailAddressTextBox.Text);
            var passwordValid = Validation.PasswordValidation(_passwordTextBox.Text);

            if (emailValid && passwordValid && !space)
            {
                var user = new UserViewModel()
                {
                    Email = _emailAddressTextBox.Text,
                    Password = _passwordTextBox.Text,
                    Name = _nameTextBox.Text
                };

                if (_userService.GetByEmail(_emailAddressTextBox.Text) == null)
                {
                    user.Balance = Constant.Gift;

                    _userService.Add(user);

                    MessageBox.Show($"Registration successful!\nGift for registration {Constant.Gift} BYN.", Constant.SignUp, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    _formOpener.ShowModelessForm<SignInForm>();
                }
                else
                {
                    MessageBox.Show($"{_emailAddressTextBox.Text} already registered!", Constant.SignUp, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void _emailAddressTextBox_Leave(object sender, EventArgs e)
        {
            if (_emailAddressTextBox.Text.Trim() != string.Empty)
            {
                Validation.EmailValidation(_emailAddressTextBox.Text);
            }
        }

        private void _passwordTextBox_Leave(object sender, EventArgs e)
        {
            Validation.PasswordValidation(_passwordTextBox.Text);
        }

        private void _signInLabel_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<SignInForm>();
        }

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }       
    }
}
