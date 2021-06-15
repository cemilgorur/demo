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
    public partial class Pazar : ContentPage
    {
        public Pazar()
        {
            InitializeComponent();
        }
            private async void Button_Clicked(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Elma ne kadar");

            }

            private async void Button_Clicked_1(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Portakal ne kadar");
            }

            private async void Button_Clicked_2(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("İndirim yapabilir misin");
            }

            private async void Button_Clicked_3(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Şeftali ne kadar");
            }

            private async void Button_Clicked_4(object sender, EventArgs e)
            {
                await TextToSpeech.SpeakAsync("Kolay gelsin");
            }
        private async void Button_Clicked_5(object sender, EventArgs e)
        {
            await TextToSpeech.SpeakAsync("Marul ne kadar");
        }
    }
    }
