using System;
using System.Collections.ObjectModel;
using System.Globalization;
using System.Windows.Controls;
using Xceed.Wpf.Toolkit;

namespace Scheduler.Model
{
    public class ToDo : ValidationRule
    {
        public String Name { get; set; }
        public String Desc { get; set; }
        public DateTimePicker DoneBy { get; set; }
        public Boolean IsDone { get; set; }

        public ToDo()
        {
            Name = "";
            Desc = "";
            DoneBy = new DateTimePicker();
            IsDone = false;        }

        public ToDo(String Name, String Desc, DateTimePicker DoneBy, Boolean IsDone)
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
}
