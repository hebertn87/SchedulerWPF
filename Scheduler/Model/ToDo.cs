using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace Scheduler.Model
{
    public class ToDo : ValidationRule
    {
        public String Name { get; set; }
        public String Desc { get; set; }
        public DateTime DoneBy { get; set; }
        public Boolean IsDone { get; set; }

        public ToDo(String Name, String Desc, DateTime DoneBy, Boolean IsDone)
        {
            this.Name = Name;
            this.Desc = Desc;
            this.DoneBy = DoneBy;
            this.IsDone = IsDone;
        }

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            throw new NotImplementedException();
        }
    }

    public class ToDoModel : ObservableCollection<ToDo>
    {
        private static object _threadLock = new Object();
        private static ToDoModel current = null;

        public static ToDoModel Current
        {
            get
            {
                lock (_threadLock)
                    if (current == null)
                        current = new ToDoModel();
                return current;
            }
        }
    }

}
