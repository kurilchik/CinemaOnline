using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignInForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserSession _user;
        private IUserService _userService;

        public SignInForm(IFormOpener formOpener, IUserService userService, IUserSession user)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _user = user;
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
                _user.User = _userService.GetByEmail(_emailAddressTextBox.Text);
                if (_user.User != null && _user.User.Email == _emailAddressTextBox.Text && _user.User.Password == _passwordTextBox.Text)
                {
                    MessageBox.Show(Constant.SuccessfulLogin, Constant.SignIn, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    _formOpener.ShowModelessForm<PreviewForm>();
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
            _formOpener.ShowModelessForm<SignUpForm>();
        }

        private void SignInForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
