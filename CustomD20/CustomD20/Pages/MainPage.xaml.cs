using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace CustomD20.Pages
{
    public partial class MainPage : ContentPage
    {
        public MainPage()
        {
            InitializeComponent();
            PopulatePicker();
        }

        private void PopulatePicker()
        {
            List<int> itemSource = new List<int>();
            for(int x = 1; x <= 20; x++)
            {
                itemSource.Add(x);
            }
            PkrValue.ItemsSource = itemSource;
        }

        private async void BtnLucky(object sender, EventArgs e)
        {
            if(PkrValue.SelectedIndex < 0)
            {
                await DisplayAlert("ERROR", "Por favor, escolha sua pontuação atual!", "OK");
                return;
            }

            int Value = PkrValue.SelectedIndex + 1;

            await Navigation.PushAsync(new Results(Value));
        }
    }
}
