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

        public AccountForm()
        {
            InitializeComponent();
            _topUpBalanceForm = new TopUpBalanceForm(this);
        }

        public AccountForm(PreviewForm previewForm) : this()
        {
            _previewForm = previewForm;
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
