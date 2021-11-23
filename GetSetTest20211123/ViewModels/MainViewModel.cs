using BindingLibrary;
using GetSetTest20211123.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GetSetTest20211123.ViewModels
{
    internal class MainViewModel : NotifyPropertyBase
    {
        public Calc calc = new();
        
        public int Count
        {
            get { return calc.count; }
            set
            {
                if (calc.count != value)
                {
                    calc.count = value;
                    OnPropertyChanged("total");
                }
            }
        }

        public int Money
        {
            get { return calc.money; }
            set
            {
                if (calc.money != value)
                {
                    calc.money = value;
                    OnPropertyChanged("total");
                }
            }
        }

        public int Total
        {
            get { return calc.total; }
        }
    }
}
