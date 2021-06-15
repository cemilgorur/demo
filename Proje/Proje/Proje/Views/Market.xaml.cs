using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proje.Views
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Market : ContentPage
    {
        public Market()
        {
            InitializeComponent();
        }
        private async void Button_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Ne kadar ödemeliyim");

        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Kredi kartı geçerli mi");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("İçecekler ne tarafta");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("İndirimde hangi ürünler var");
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Teşekkkür ederim");
        }
    }
}