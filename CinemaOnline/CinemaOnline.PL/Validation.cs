using System.Windows.Forms;

namespace CinemaOnline.PL
{
    public static class Validation
    {
        public static bool EmailValidation(string email)
        {
            try
            {
                var mailAddress = new System.Net.Mail.MailAddress(email);
                return true;
            }
            catch
            {
                MessageBox.Show(Constant.InvalidEmail, Constant.Email, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        public static bool PasswordValidation(string password)
        {
            if (password.Contains(' '))
            {
                MessageBox.Show(Constant.InvalidPassword, Constant.Password, MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            else
                return true;
        }
    }
}
