using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using SimpleInjector;
using System;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class TopUpBalanceForm : Form
    {
        private AccountForm _accountForm;
        private ITopUpService _topUpService;

        public TopUpBalanceForm(Container container, ITopUpService topUpService)
        {
            InitializeComponent();

            _accountForm = container.GetInstance<AccountForm>(); 
            _topUpService = topUpService;
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            var amount = _topUpService.TopUpCard(_topUpTextBox.Text);

            if (amount > 0)
            {
                _accountForm.TopUpBalance(amount);
                Hide();
                _accountForm.Show();
            }
            else
            {
                MessageBox.Show(Constant.InvalidCard, Constant.Card, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }                
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _accountForm.Show();
        }

        private void TopUpBalanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
