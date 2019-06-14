using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace XamarinPsi
{
    public partial class MainPage : ContentPage
    { 

        ObservableCollection<Slika> vsiPsi;
        public MainPage()
        {
           
                InitializeComponent();
        }
        protected override async void OnAppearing()
        {
            base.OnAppearing();
            vsiPsi = new ObservableCollection<Slika>();
            await Klic.NapolniPsi(vsiPsi);
            psiView.ItemsSource = vsiPsi;
        }
    }
}
