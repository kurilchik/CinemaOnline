using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
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
        private List<FilmViewModel> _films;
        private IFilmService _filmService;

        public PreviewForm()
        {
            InitializeComponent();     
        }

        public PreviewForm(UserViewModel user) : this()
        {
            _user = user;
            _accountForm = new AccountForm(this, _user);
            _filmService = new FilmService();
            _films = new List<FilmViewModel>();

            ViewFilms();
        }

        private void ViewFilms()
        {
            _films = _filmService.GetAllFilms();


            foreach (var item in _films)
            {
                var filmView = new PictureBox()
                {
                    Size = new Size(300, 430),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = item.ImgUrl
                };

                _filmsFlowLayoutPanel.Controls.Add(filmView);

                filmView.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    PaymentForm paymentForm = new PaymentForm(item, _user, this);
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
