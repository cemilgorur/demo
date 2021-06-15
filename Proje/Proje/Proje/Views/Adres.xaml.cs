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
    public partial class Adres : ContentPage
    {
        public Adres()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Merhaba ben işitme engelliyim yardımcı olabilir misiniz");
       
        }

        private async void Button_Clicked_1(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Hava alanına nasıl gidebilirim");
        }

        private async void Button_Clicked_2(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Gitmek istediğim adresi göstersem tarif edebilirmisiniz");
        }

        private async void Button_Clicked_3(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Otobüs terminaline nasıl gidebilirim");
        }

        private async void Button_Clicked_4(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Teşekkkür ederim");
        }
    }
}