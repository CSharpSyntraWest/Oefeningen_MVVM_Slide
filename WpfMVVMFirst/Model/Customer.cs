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
        public Customer(string name, int amount, string country)
        {
            Name = name;
            Amount = amount;
            Country = country;
        }

        public void CalculateTax()
        {
            if (Amount > 2000)
            {
                tax = 20;
            }
            else if (Amount > 1000)
            {
                tax = 10;
            }
            else
            {
                tax = 5;
            }
            NotifyPropertyChanged(nameof(Tax));//nameof(Tax) is hetzelfde als "Tax"
        }
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
