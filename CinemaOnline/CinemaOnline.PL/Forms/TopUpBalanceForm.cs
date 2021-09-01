using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class TopUpBalanceForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserSession _user;
        private IUserService _userService;
        private ITopUpService _topUpService;

        public TopUpBalanceForm(IFormOpener formOpener, IUserSession user, IUserService userService, ITopUpService topUpService)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _user = user;
            _userService = userService;
            _topUpService = topUpService;
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            var amount = _topUpService.TopUpCard(_topUpTextBox.Text);

            if (amount > 0)
            {
                TopUpBalance(amount);
                Hide();
                _formOpener.ShowModelessForm<AccountForm>();
            }
            else
            {
                MessageBox.Show(Constant.InvalidCard, Constant.Card, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void TopUpBalance(float amount)
        {
            _user.User.Balance += amount;
            _userService.Update(_user.User);
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<AccountForm>();
        }

        private void TopUpBalanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
