using dovidnyk_numizmata.Forms;

namespace dovidnyk_numizmata
{
    internal static class Program
    {
        [STAThread]
        static void Main()
        {
            ApplicationConfiguration.Initialize();
            Application.Run(new CoinsForm());
        }
    }
}