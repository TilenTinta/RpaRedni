﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using Windows.UI;

namespace MVVMModel
{
    class MojZapis : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName]string propertyName = null)
        {
            PropertyChangedEventHandler handler = PropertyChanged;
            if (handler != null)
            {
                handler(this, new PropertyChangedEventArgs(propertyName));
            }
        }
        private string ime;
        public string Ime
        {
            get { return ime; }
            set { ime = value;OnPropertyChanged(); }
        }
        private Color barva;
        public Color Barva
        {
            get { return barva; }
            set { barva = value;OnPropertyChanged(); }
        }

    }

}
