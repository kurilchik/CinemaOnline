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
    public partial class TopUpBalanceForm : Form
    {
        private AccountForm _accountForm;

        public TopUpBalanceForm()
        {
            InitializeComponent();
        }

        public TopUpBalanceForm(AccountForm accountForm) : this()
        {
            _accountForm = accountForm;
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            Hide();
            _accountForm.Show();
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
