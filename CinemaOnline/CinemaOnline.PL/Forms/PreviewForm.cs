using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class PreviewForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserSession _user;
        private IFilmSelected _film;
        private IFilmService _filmService;

        public PreviewForm(IFormOpener formOpener, IUserSession user, IFilmSelected film, IFilmService filmService)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _user = user;
            _film = film;
            _filmService = filmService;

            ViewFilms();
        }

        private void ViewFilms()
        {
            _welcomLabel.Text = $"{_user.User.Name} Welcome to \"Cinema Online\"";

            List<FilmViewModel> films = _filmService.GetAllFilms();


            foreach (var item in films)
            {
                var filmView = new PictureBox()
                {
                    Size = new Size(300, 430),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    ImageLocation = item.ImgUrl
                };

                filmView.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    _film.Film = item;
                    _formOpener.ShowModelessForm<PaymentForm>();
                };

                _filmsFlowLayoutPanel.Controls.Add(filmView);
            }
        }

        private void filmView_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<AccountForm>();
        }

        private void _accountTictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<AccountForm>();
        }

        private void PreviewForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
    }
}
