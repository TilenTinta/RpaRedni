using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Psi
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        ObservableCollection<Slika> vsiPsi;
        public MainPage()
        {
            this.InitializeComponent();
            vsiPsi = new ObservableCollection<Slika>();
        }

        private async void Page_Loaded(object sender, RoutedEventArgs e)
        {
            mojPR.IsActive = true;
            mojPR.Visibility = Visibility.Visible;
            await Klic.NapolniPsi(vsiPsi);
            mojPR.IsActive = false;
            mojPR.Visibility = Visibility.Collapsed;
        }
    }
}
