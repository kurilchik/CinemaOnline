using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class AccountForm : Form
    {
        private IUserSession _user;
        private IUserService _userService;
        private ITicketService _ticketService;
        private PreviewForm _previewForm;
        private TopUpBalanceForm _topUpBalanceForm;

        public AccountForm(Container container, IUserSession user, IUserService userService, ITicketService ticketService)
        {
            InitializeComponent();

            _user = user;
            _userService = userService;
            _ticketService = ticketService;
            _previewForm = container.GetInstance<PreviewForm>();
            _topUpBalanceForm = container.GetInstance<TopUpBalanceForm>();

            _nameTextBox.Text = _user.User.Name;
            _emailAddressTextBox.Text = _user.User.Email;
            _passwordTextBox.Text = _user.User.Password;
            _balanceTextBox.Text = _user.User.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.User.Id).ToString();
        }

        public void TopUpBalance(float amount)
        {
            _user.User.Balance += amount;
            _userService.Update(_user.User);
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
            _balanceTextBox.Text = _user.User.Balance.ToString();
            _ticketTExtLabel.Text = _ticketService.CountUserTickets(_user.User.Id).ToString();
        }
    }
}
