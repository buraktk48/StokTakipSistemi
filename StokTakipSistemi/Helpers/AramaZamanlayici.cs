using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StokTakipSistemi.Helpers
{
    public static class AramaZamanlayici
    {
        public static void AramaSinirlayici(TextBox textbox, Action<string> AramaFonksiyonu, int interval = 300)
        {
            var zamanlayici = new System.Windows.Forms.Timer {  Interval = interval };



            zamanlayici.Tick += (sender, e) =>
            {
                zamanlayici.Stop();
                AramaFonksiyonu(textbox.Text.Trim());
            };

            textbox.TextChanged += (sender, e) =>
            {
                zamanlayici.Stop();
                zamanlayici.Start();


            };





        }


    }
}
