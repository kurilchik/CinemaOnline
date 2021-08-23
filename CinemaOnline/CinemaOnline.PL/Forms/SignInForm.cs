using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class SignInForm : Form
    {
        private SignUpForm _signUpForm;

        public SignInForm()
        {
            InitializeComponent();
            _signUpForm = new SignUpForm(this);
        }

        private void _singInButton_Click(object sender, EventArgs e)
        {
            var whiteSpace = string.IsNullOrEmpty(_passwordTextBox.Text);

            if (whiteSpace)
                MessageBox.Show("Invalid password!", "Pasword", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Email() && Password() && !whiteSpace)
            {
                MessageBox.Show("Login completed successfully!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Hide();
                PreviewForm previewForm = new PreviewForm();              
                previewForm.Show();
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
