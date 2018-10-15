using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Data;

namespace Scheduler.ViewModel
{
    public class VMLocator : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected void INotifyPropertyChanged()
        {

        }
    }
    
    //Custom class that implements the Ivalue Converter
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String dateTime = (String)value;

            return dateTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }

    public class ToDoList
    {

    }
}
