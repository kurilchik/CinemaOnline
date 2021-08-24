using CinemaOnline.BLL.ViewModels;
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
    public partial class PreviewForm : Form
    {
        private AccountForm _accountForm;
        private UserViewModel _user;

        public PreviewForm()
        {
            InitializeComponent();     
        }

        public PreviewForm(UserViewModel user) : this()
        {
            _user = user;
            _accountForm = new AccountForm(this, _user);

            List<string> imgs = new List<string>()
            {
                "https://abws.bycard.by/uploads/events/thumbs/300x430/349Sl3h3g.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/9Pg1NEMup.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/5ZdyNlmVF.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/2hSk7hhNp.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/349Sl3h3g.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/9Pg1NEMup.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/5ZdyNlmVF.jpg",
                "https://abws.bycard.by/uploads/events/thumbs/300x430/2hSk7hhNp.jpg"
            };

            foreach (var item in imgs)
            {
                var film = new PictureBox()
                {
                    Size = new Size(300, 430),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = item
                };

                _filmsFlowLayoutPanel.Controls.Add(film);

                film.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    PaymentForm paymentForm = new PaymentForm(item, this);
                    paymentForm.Show();
                };
            }
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _accountForm.Show();
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
