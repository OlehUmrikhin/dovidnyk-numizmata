using dovidnyk_numizmata.Forms;
using dovidnyk_numizmata.Models;

namespace dovidnyk_numizmata
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            AppState.Initialize();
            Application.Run(AppState.coinsForm = new CoinsForm());
        }
    }
}