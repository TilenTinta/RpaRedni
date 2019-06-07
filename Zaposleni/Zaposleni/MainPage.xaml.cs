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

namespace Zaposleni
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        List<icon> Icons;
        ObservableCollection<Contact> Zaposleni;
        public MainPage()
        {
            this.InitializeComponent();
            Icons = new List<icon>();
            Icons.Add(new icon { IconPath = "Assets/male-01.png" });
            Icons.Add(new icon { IconPath = "Assets/male-02.png" });
            Icons.Add(new icon { IconPath = "Assets/male-03.png" });
            Icons.Add(new icon { IconPath = "Assets/female-01.png" });
            Icons.Add(new icon { IconPath = "Assets/female-02.png" });
            Icons.Add(new icon { IconPath = "Assets/female-03.png" });
            Zaposleni = new ObservableCollection<Contact>();

        }

      

        private void BtnDodaj_Click(object sender, RoutedEventArgs e)
        {
            Contact a = new Contact();
            a.Ime = txtIme.Text;
            a.Priimek = txtPriimek.Text;
            a.AvatarPath = ((icon)(cboAvatar.SelectedValue)).IconPath;
            Zaposleni.Add(a);
        }
    }
}
