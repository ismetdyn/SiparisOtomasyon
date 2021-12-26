using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tulpep.NotificationWindow;

namespace Siparis_Otomasyon
{
    internal static class Program
    {
        /// <summary>
        /// Uygulamanın ana girdi noktası.
        /// </summary>

        public static Musteri musteri;

        [STAThread]
        static void Main()
        {           
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Login login = new Login();
            Application.Run(login);

            PopupNotifier popup;
            if (login.KullaniciGirisDenetimi)
            {
                popup = new PopupNotifier
                {
                    TitleText = "Başarılı Giriş",
                    ContentText = "Hoşgeldiniz.",
                    IsRightToLeft = false
                };
                musteri = login.musteri;
                popup.Popup();
                login.Dispose();
                popup.Dispose();
                Application.Run(new MusteriMenu());
            }
            else if (login.YoneticiGirisDenetimi)
                {
                popup = new PopupNotifier
                {
                    TitleText = "Başarılı Yönetici Girişi",
                    ContentText = "Hoşgeldiniz.",
                    IsRightToLeft = false
                };
                popup.Popup();
                login.Dispose();
                popup.Dispose();
                Application.Run(new Firma());
                }
        }
    }
}
