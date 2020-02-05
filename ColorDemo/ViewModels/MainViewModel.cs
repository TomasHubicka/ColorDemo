using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace ColorDemo.ViewModels
{
    class MainViewModel : INotifyPropertyChanged
    {
        private byte _red;
        private byte _green;
        private byte _blue;
        private SolidColorBrush _colour;

        public MainViewModel()
        {
            Red = 255;
            Green = 160;
            Blue = 40;
        }

        public byte Red
        {
            get
            {
                return _red;
            }
            set
            {
                _red = value;
                Colour = new SolidColorBrush(Color.FromArgb(255,Red,Green,Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("Hexadecimal");
            }
        }
        public byte Green
        {
            get
            {
                return _green;
            }
            set
            {
                _green = value;
                Colour = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("Hexadecimal");
            }
        }
        public byte Blue
        {
            get
            {
                return _blue;
            }
            set
            {
                _blue = value;
                Colour = new SolidColorBrush(Color.FromArgb(255, Red, Green, Blue));
                NotifyPropertyChanged();
                NotifyPropertyChanged("MergedDecimal");
                NotifyPropertyChanged("Hexadecimal");
            }
        }
        public string MergedDecimal
        {
            get
            {
                return String.Format("({0},{1},{2})",Red,Green,Blue);
            }
        }
        public string Hexadecimal
        {
            get
            {
                string r = Red.ToString("X");
                string g = Green.ToString("X");
                string b = Blue.ToString("X");
                return "#" + r.PadLeft(2, '0') + g.PadLeft(2, '0') + b.PadLeft(2, '0');
            }
        }
        public SolidColorBrush Colour
        {
            get { return _colour; }
            set { _colour = value; NotifyPropertyChanged(); NotifyPropertyChanged("MergedDecimal"); NotifyPropertyChanged("Hexadecimal"); }
        }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
