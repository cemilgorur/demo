using System;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace Proje.Master
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyDetail : ContentPage
    {
        public MyDetail()
        {
            InitializeComponent();
        }

        private async void Button_Clicked(object sender, EventArgs e)
        {

            if (EntryText.Text == null)
            {
                DisplayAlert("Hata", "Lütfen birşeyler yazın", "Tamam");
            }
            else
            
                await TextToSpeech.SpeakAsync(EntryText.Text);
            
               
          
            
            
        }
    }
}