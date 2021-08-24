using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
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
    public partial class AccountForm : Form
    {
        private PreviewForm _previewForm;
        private TopUpBalanceForm _topUpBalanceForm;
        private UserViewModel _user;
        private IUserService _userService;

        public AccountForm()
        {
            InitializeComponent();
            _topUpBalanceForm = new TopUpBalanceForm(this);
            _userService = new UserService();
        }

        public AccountForm(PreviewForm previewForm, UserViewModel user) : this()
        {
            _previewForm = previewForm;
            _user = user;

            _nameTextBox.Text = _user.Name;
            _emailAddressTextBox.Text = _user.Email;
            _passwordTextBox.Text = _user.Password;
            _balanceTextBox.Text = _user.Balance.ToString();
        }

        public void TopUpBalance(float amount)
        {
            _user.Balance += amount;
            _userService.Update(_user);
            _balanceTextBox.Text = _user.Balance.ToString();
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _previewForm.Show();
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            _topUpBalanceForm.Show();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
