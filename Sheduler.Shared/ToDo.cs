using Scheduler.Shared.ViewModel;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Scheduler.Shared
{
    public class ToDo
    {
        public String Name { get; set; }
        public String Desc { get; set; }
        public String DoneBy { get; set; }

        public ToDo()
        {
            Name = "";
            Desc = "";
            DoneBy = "";
        }

        public ToDo(String Name, String Desc, String DoneBy)
        {
            this.Name = Name;
            this.Desc = Desc;
            this.DoneBy = DoneBy;
        }
    }
}
