using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class AccountForm : Form
    {
        private PreviewForm _previewForm;
        private TopUpBalanceForm _topUpBalanceForm;
        private UserViewModel _user;
        private IUserService _userService;
        private ITicketService _ticketService;

        public AccountForm()
        {
            InitializeComponent();
            _topUpBalanceForm = new TopUpBalanceForm(this);
            _userService = new UserService();
            _ticketService = new TicketService();
        }

        public AccountForm(PreviewForm previewForm, UserViewModel user) : this()
        {
            _previewForm = previewForm;
            _user = user;

            _nameTextBox.Text = _user.Name;
            _emailAddressTextBox.Text = _user.Email;
            _passwordTextBox.Text = _user.Password;
            _balanceTextBox.Text = _user.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.Id).ToString();
        }

        public void TopUpBalance(float amount)
        {
            _user.Balance += amount;
            _userService.Update(_user);
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

        private void AccountForm_VisibleChanged(object sender, EventArgs e)
        {
            _balanceTextBox.Text = _user.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.Id).ToString();
        }
    }
}
