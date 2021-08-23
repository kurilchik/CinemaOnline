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
    public partial class SignUpForm : Form
    {
        private SignInForm _signInForm;

        public SignUpForm()
        {
            InitializeComponent();
        }

        public SignUpForm(SignInForm signInForm) : this()
        {
            _signInForm = signInForm;
        }

        private void _singUpButton_Click(object sender, EventArgs e)
        {
            var space = string.IsNullOrEmpty(_passwordTextBox.Text);

            if (space)
                MessageBox.Show("Invalid password!", "Pasword", MessageBoxButtons.OK, MessageBoxIcon.Error);

            if (Email() && Password() && !space)
            {
                MessageBox.Show("Registration successful!", "Successfully", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                _signInForm.Show();
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

        private void SignUpForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
