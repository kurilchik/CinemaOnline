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
        public TopUpBalanceForm()
        {
            InitializeComponent();
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            PreviewForm previewForm = new PreviewForm();
            previewForm.Show();
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
        {
            this.Dispose();
            this.Hide();
            AccountForm accountForm = new AccountForm();
            accountForm.Show();
        }

        private void TopUpBalanceForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
