using Scheduler.Shared;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Windows.Input;

namespace Scheduler.Shared.ViewModel
{
    public class ToDoListVM : INotifyPropertyChanged
    {
        private ObservableCollection<ToDoListVM> todo = new ObservableCollection<ToDoListVM>();

        public ObservableCollection<ToDoListVM> ToDoItem {
            get { return todo; } 
            set
            {
                if (todo != value)
                {
                    todo = value;
                    NotifyPropertyChanged(nameof(todo));
                }
            }
        }

        public ICommand CreateToDoCommand { get { return new CreateToDoCommand(); } }

        public String DoneBy { get; set; }
        public String Desc { get; set; }
        public String Name { get; set; }
        public Boolean IsDone { get; set; }


        public event PropertyChangedEventHandler PropertyChanged;

        private void NotifyPropertyChanged(String name)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));
        }
    }
}
