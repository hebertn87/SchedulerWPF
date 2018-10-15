﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Scheduler.Model
{
    public class ToDo : IDataErrorInfo
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

        string IDataErrorInfo.Error
        {
            get
            {
                return null;
            }
        }

        string IDataErrorInfo.this[string columnName]
        {
            get
            {
                if(columnName == Name)
                {
                    if (string.IsNullOrEmpty(Name))
                        return "Must input the Name of Task";
                }
                return null;
            }
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