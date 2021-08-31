using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using CinemaOnline.PL.ModelServices.Interfaces;
using SimpleInjector;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class PreviewForm : Form
    {
        private IUserSession _user;
        private IFilmService _filmService;
        private AccountForm _accountForm;
        private List<FilmViewModel> _films = new List<FilmViewModel>();

        public PreviewForm(Container container, IUserSession user, IFilmService filmService)
        {
            InitializeComponent();

            _user = user;
            _accountForm = container.GetInstance<AccountForm>();
            _filmService = filmService;

            _welcomLabel.Text = $"{_user.User.Name} Welcome to \"Cinema Online\"";

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

                filmView.Click += (object sender, EventArgs e) =>
                {
                    Hide();
                    PaymentForm paymentForm = new PaymentForm(item, _user.User, this);
                    paymentForm.Show();
                };

                _filmsFlowLayoutPanel.Controls.Add(filmView);
            }
        }

        private void filmView_Click(object sender, EventArgs e)
        {
            Hide();
            _accountForm.Show();
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
