using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignInForm : Form
    {
        private IUserSession _user;
        private IUserService _userService;
        private SignUpForm _signUpForm;
        private PreviewForm _previewForm;

        public SignInForm(Container container, IUserService userService, IUserSession user)
        {
            InitializeComponent();

            _user = user;
            _userService = userService;
            _signUpForm = container.GetInstance<SignUpForm>();
            _previewForm = container.GetInstance<PreviewForm>(); ;
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
                    _previewForm.Show();
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
