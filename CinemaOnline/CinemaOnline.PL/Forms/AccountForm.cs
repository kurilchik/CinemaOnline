using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class AccountForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserSession _user;
        private ITicketService _ticketService;

        public AccountForm(IFormOpener formOpener, IUserSession user, ITicketService ticketService)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _user = user;
            _ticketService = ticketService;

            ShowUser();
        }

        private void ShowUser()
        {
            _nameTextBox.Text = _user.User.Name;
            _emailAddressTextBox.Text = _user.User.Email;
            _passwordTextBox.Text = _user.User.Password;
            _balanceTextBox.Text = _user.User.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.User.Id).ToString();
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<PreviewForm>();
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<TopUpBalanceForm>();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void AccountForm_VisibleChanged(object sender, EventArgs e)
        {
            _balanceTextBox.Text = _user.User.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.User.Id).ToString();
        }
    }
}
