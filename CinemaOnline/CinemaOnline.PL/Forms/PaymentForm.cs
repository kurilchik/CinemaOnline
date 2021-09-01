using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.PL.ModelServices.Interfaces;
using CinemaOnline.PL.NavigationServices.Interfaces;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class PaymentForm : Form
    {
        private readonly IFormOpener _formOpener;
        private IUserSession _user;
        private IFilmSelected _film;
        private IFilmService _filmService;
        private IUserService _userService;
        private ITicketService _ticketService;

        public PaymentForm(IFormOpener formOpener, IUserSession user, IFilmSelected film, IFilmService filmService, IUserService userService, ITicketService ticketService)
        {
            InitializeComponent();

            _formOpener = formOpener;
            _user = user;
            _film.Film = _filmService.GetSessions(film.Film);
            _filmService = filmService;
            _userService = userService;
            _ticketService = ticketService;

            FilmView();
        }

        private void FilmView()
        {
            _filmPictureBox.ImageLocation = _film.Film.ImgUrl;
            Text = _film.Film.Name;
            _nameTextLabel.Text = _film.Film.Name;
            _descriptionTextLabel.Text = _film.Film.Description;
            _genreTextLabel.Text = string.Join(", ", _film.Film.Genres);
        }

        private void _payButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_priceTextLabel.Text))
            {
                var price = float.Parse(_priceTextLabel.Text);

                if (price <= _user.User.Balance)
                {
                    _user.User.Balance -= price;
                    _userService.Update(_user.User);

                    var session = _film.Film.Sessions.Where(s => s.CinemaName == _cinemaComboBox.Text && s.Time.ToString() == _timeComboBox.Text).FirstOrDefault();
                    _ticketService.Add(_user.User.Id, session.Id);
                    MessageBox.Show(Constant.TicketPurchased, Constant.Ticket, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    _formOpener.ShowModelessForm<PreviewForm>();
                }
                else
                {
                    MessageBox.Show(Constant.InvalidBalance, Constant.Balance, MessageBoxButtons.OK, MessageBoxIcon.Error);
                }                    
            }            
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _formOpener.ShowModelessForm<PreviewForm>();
        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void _cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _timeComboBox.Items.AddRange(_film.Film.Sessions.Where(c => c.CinemaName == _cinemaComboBox.Text).Select(t => t.Time.ToString()).ToArray());
        }

        private void _cinemaComboBox_Click(object sender, EventArgs e)
        {
            _cinemaComboBox.Items.Clear();
            _timeComboBox.Items.Clear();
            _timeComboBox.Text = string.Empty;
            _priceTextLabel.Text = string.Empty;
            _cinemaComboBox.Items.AddRange(_film.Film.Sessions.Select(s => s.CinemaName).Distinct().ToArray());
            
        }

        private void _timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priceTextLabel.Text = _film.Film.Sessions.Where(t => t.Time.ToString() == _timeComboBox.Text).Select(p => p.Price).First().ToString();
        }
    }
}
