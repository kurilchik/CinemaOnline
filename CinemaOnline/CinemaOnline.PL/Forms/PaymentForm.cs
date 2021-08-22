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
    public partial class PaymentForm : Form
    {
        private string _url;

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(string url)
        {
            InitializeComponent();
            _url = url;
            _filmPictureBox.ImageLocation = _url;
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
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

        private void _payButton_Click(object sender, EventArgs e)
        {

        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
