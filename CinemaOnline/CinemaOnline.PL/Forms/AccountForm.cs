﻿using System;
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
        public AccountForm()
        {
            InitializeComponent();
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            this.Hide();
            PreviewForm previewForm = new PreviewForm();
            previewForm.Show();
        }

        private void _topUpButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            TopUpBalanceForm topUpBalanceForm = new TopUpBalanceForm();
            topUpBalanceForm.Show();
        }

        private void AccountForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}