using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WpfMVVMFirst.Model;

namespace WpfMVVMFirst.ViewModel
{
    class CustomerViewModel:BaseViewModel
    {
        public CustomerViewModel()
        {
            Customer = new Customer() { Name="Bert Boonen",Amount=2000,Country="België"};
        }
        private Customer customer;
        public Customer Customer
        {
            get { return customer; }
            set {
                customer = value;
                NotifyPropertyChanged();
            }
        }
    }
}
