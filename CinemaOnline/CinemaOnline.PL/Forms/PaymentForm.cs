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
    public partial class PaymentForm : Form
    {
        private PreviewForm _previewForm;

        public PaymentForm()
        {
            InitializeComponent();
        }

        public PaymentForm(FilmViewModel film, PreviewForm previewForm) : this()
        {
            _filmPictureBox.ImageLocation = film.ImgUrl;
            _previewForm = previewForm;
            Text = film.Name;
            _nameTextLabel.Text = film.Name;
            _descriptionTextLabel.Text = film.Description;
            _genreTextLabel.Text = string.Join(", ", film.Genres);
        }

        private void _homePictureBox_Click(object sender, EventArgs e)
        {
            Hide();
            _previewForm.Show();
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
