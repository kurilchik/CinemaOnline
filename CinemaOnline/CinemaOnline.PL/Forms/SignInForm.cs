using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignInForm : Form
    {
        private SignUpForm _signUpForm;
        private IUserService _userService;

        public SignInForm(IUserService userService)
        {
            InitializeComponent();

            _signUpForm = new SignUpForm(this);
            _userService = userService;
        }

        private void _singInButton_Click(object sender, EventArgs e)
        {
            var whiteSpace = string.IsNullOrEmpty(_passwordTextBox.Text);

            if (whiteSpace)
            {
                MessageBox.Show(Constant.InvalidPassword, Constant.Password, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            var emailValid = Validation.EmailValidation(_emailAddressTextBox.Text);
            var passwordValid = Validation.PasswordValidation(_passwordTextBox.Text);


            if (emailValid && passwordValid && !whiteSpace)
            {
                var user = _userService.GetByEmail(_emailAddressTextBox.Text);
                if (user != null && user.Email == _emailAddressTextBox.Text && user.Password == _passwordTextBox.Text)
                {
                    MessageBox.Show(Constant.SuccessfulLogin, Constant.SignIn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    PreviewForm previewForm = new PreviewForm(user);
                    previewForm.Show();
                }
                else
                    MessageBox.Show(Constant.SignInFailed, Constant.SignIn, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        private void _signUpLabel_Click(object sender, EventArgs e)
        {
            Hide();
            _signUpForm.Show();
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
