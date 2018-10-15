using Scheduler.Model;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Input;

namespace Scheduler.ViewModel
{
    class MainVM
    {
        public class ToDoList
        {
            public ToDoModel tdModel { get; set; }

            ObservableCollection<ToDoModel> toDoItem = new ObservableCollection<ToDoModel>();

            public void AddToDoItem(object obj)
            {
                var data = new ToDoModel
                {
                    
                     
                };
                this.toDoItem.Add(data);
            }
        }
    }
}
