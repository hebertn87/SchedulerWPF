using Scheduler.Command;
using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Data;
using System.Windows.Input;

namespace Scheduler.ViewModel
{
    class ToDoListVM : INotifyPropertyChanged
    {
        private ObservableCollection<ToDoListVM> todo = new ObservableCollection<ToDoListVM>();

        public ObservableCollection<ToDoListVM> ToDoItem {
            get { return todo; } 
            set
            {
                if (todo != value)
                {
                    todo = value;
                    NotifyPropertyChanged(nameof(ToDoItem));
                }
            }
        }

        public ICommand CreateToDoCommand { get { return new CreateToDoCommand(); } }

        public DateTime DoneBy { get; set; }
        public string Desc { get; set; }
        public string Name { get; set; }
        public bool IsDone { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }

    //Custom class that implements the Ivalue Converter
    public class DateToStringConverter : IValueConverter
    {
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            String dateTime = (String)value.ToString();

            return dateTime;
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}
