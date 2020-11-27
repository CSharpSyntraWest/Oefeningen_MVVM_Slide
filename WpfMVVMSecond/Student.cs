using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace WpfMVVMSecond
{
    class Student : INotifyPropertyChanged
    {
        private string naam;
        private string jaar;
        private int groep;

        public Student(string naam, string jaar, int groep)
        {
            Naam = naam;
            Jaar = jaar;
            Groep = groep;
        }

        public string Naam
        {
            get { return naam; }

            set
            {
                naam = value;
                NotifyPropertyChanged();
            }
        }

        public string Jaar
        {
            get { return jaar; }

            set
            {
                jaar = value;
                NotifyPropertyChanged();
            }
        }

        public int Groep
        {
            get { return groep; }

            set
            {
                groep = value;
                NotifyPropertyChanged();
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        private void NotifyPropertyChanged([CallerMemberName] String propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

    }
}
