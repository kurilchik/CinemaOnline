using System.Windows.Forms;

namespace CinemaOnline.PL.NavigationServices.Interfaces
{
    public interface IFormOpener
    {
        void ShowModelessForm<TForm>() where TForm : Form;
        DialogResult ShowModalForm<TForm>() where TForm : Form;
    }
}
