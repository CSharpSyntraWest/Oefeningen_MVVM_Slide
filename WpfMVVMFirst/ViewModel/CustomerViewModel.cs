using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using WpfMVVMFirst.Model;

namespace WpfMVVMFirst.ViewModel
{
    class CustomerViewModel:BaseViewModel
    {
        public CustomerViewModel()
        {
            LadenCustomer();
            KoppelenCommand();
        }

        private void KoppelenCommand()
        {
            CalculateTaxCommand = new BaseCommand(BerekenTax);
        }

        private void BerekenTax()
        {
            Customer.CalculateTax();
        }

        private void LadenCustomer()
        {
            Customer = new Customer("Bert Boonen", 2000, "België");
        }
        //code ICommand
        private ICommand calculateTaxCommand;

        public ICommand CalculateTaxCommand
        {
            get { return calculateTaxCommand; }
            set { calculateTaxCommand = value; }
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
