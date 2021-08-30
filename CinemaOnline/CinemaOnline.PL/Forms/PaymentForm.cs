using CinemaOnline.BLL.Services;
using CinemaOnline.BLL.Services.Interfaces;
using CinemaOnline.BLL.ViewModels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CinemaOnline.PL.Forms
{
    public partial class PaymentForm : Form
    {
        private FilmViewModel _film;
        private UserViewModel _user;
        private PreviewForm _previewForm;
        private IFilmService _filmService;
        private IUserService _userService;
        private ITicketService _ticketService;

        public PaymentForm(FilmViewModel film, UserViewModel user, PreviewForm previewForm)
        {
            InitializeComponent();

            _user = user;
            _previewForm = previewForm;
            _filmService = new FilmService();
            _film = _filmService.GetSessions(film);
            _userService = new UserService();
            _ticketService = new TicketService();

            FilmView();
        }

        //public PaymentForm(FilmViewModel film, UserViewModel user, PreviewForm previewForm) : this()
        //{
        //    _user = user;
        //    _previewForm = previewForm;
        //    _filmService = new FilmService();
        //    _film = _filmService.GetSessions(film);
        //    _userService = new UserService();
        //    _ticketService = new TicketService();

        //    FilmView();
        //}

        private void FilmView()
        {
            _filmPictureBox.ImageLocation = _film.ImgUrl;
            Text = _film.Name;
            _nameTextLabel.Text = _film.Name;
            _descriptionTextLabel.Text = _film.Description;
            _genreTextLabel.Text = string.Join(", ", _film.Genres);
        }

        private void _payButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(_priceTextLabel.Text))
            {
                var price = float.Parse(_priceTextLabel.Text);

                if (price <= _user.Balance)
                {
                    _user.Balance -= price;
                    _userService.Update(_user);

                    var session = _film.Sessions.Where(s => s.CinemaName == _cinemaComboBox.Text && s.Time.ToString() == _timeComboBox.Text).FirstOrDefault();
                    _ticketService.Add(_user.Id, session.Id);
                    MessageBox.Show(Constant.TicketPurchased, Constant.Ticket, MessageBoxButtons.OK, MessageBoxIcon.Information);

                    Hide();
                    _previewForm.Show();
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
            _previewForm.Show();
        }

        private void PaymentForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void _cinemaComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _timeComboBox.Items.AddRange(_film.Sessions.Where(c => c.CinemaName == _cinemaComboBox.Text).Select(t => t.Time.ToString()).ToArray());
        }

        private void _cinemaComboBox_Click(object sender, EventArgs e)
        {
            _cinemaComboBox.Items.Clear();
            _timeComboBox.Items.Clear();
            _timeComboBox.Text = string.Empty;
            _priceTextLabel.Text = string.Empty;
            _cinemaComboBox.Items.AddRange(_film.Sessions.Select(s => s.CinemaName).Distinct().ToArray());
            
        }

        private void _timeComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            _priceTextLabel.Text = _film.Sessions.Where(t => t.Time.ToString() == _timeComboBox.Text).Select(p => p.Price).First().ToString();
        }
    }
}
