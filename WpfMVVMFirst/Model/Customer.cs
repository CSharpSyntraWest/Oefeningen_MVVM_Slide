using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMFirst.Model
{
    class Customer : INotifyPropertyChanged
    {

        private string name;
        private int amount;
        private string country;
        private int tax;
        public string Name
        {
            get { return name; }
            set { name = value;
                NotifyPropertyChanged();
            }
        }
        public int Amount
        {
            get { return amount; }
            set
            {
                amount = value;
                NotifyPropertyChanged();
            }
        }
        public string Country
        {
            get { return country; }
            set
            {
                country = value;
                NotifyPropertyChanged();
            }
        }
        public int Tax
        {
            get { return tax; }
        }
        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
