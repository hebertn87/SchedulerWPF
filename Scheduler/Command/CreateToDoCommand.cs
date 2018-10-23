using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Scheduler.Model;
using Scheduler.ViewModel;

namespace Scheduler.Command
{
    public class CreateToDoCommand : ICommand
    {
        public event EventHandler CanExecuteChanged;

        private ToDo todo = new ToDo();

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(Object parameter)
        {
            if (parameter is ToDoListVM toDoList)
            {
                toDoList.ToDoItem.Add(new ToDoListVM() {Name = toDoList.Name, Desc = toDoList.Desc, DoneBy = toDoList.DoneBy});
            }
        }
    }
}
