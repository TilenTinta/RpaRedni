using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace MVVMModel
{
    class MyViewModel:INotifyPropertyChanged
    {
        public DelegateCommand NarediZeleno { get; set; }
        public ObservableCollection<MojZapis> Zapisi { get; set; }
        public string Naslov { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private MojZapis trenutni;
        public MojZapis Trenutni
        {
            get { return trenutni; }
            set { trenutni = value;OnPropertyChanged();
                NarediZeleno.RaiseCanExecuteChanged();
            }
        }
        public MyViewModel()
        {
            NarediZeleno = new DelegateCommand(
            (p) => { Trenutni.Barva = Colors.Green; },
            (p) => { return Trenutni != null; }
            );

            Zapisi = new ObservableCollection<MojZapis>();
            for(int k = 0; k < 10; k++)
            {
                Zapisi.Add(new MojZapis { Ime = k + "", Barva = Colors.OrangeRed });
            }
            Naslov = "Moji zapiski";
            trenutni = Zapisi.First();
            
        }
    }
}
