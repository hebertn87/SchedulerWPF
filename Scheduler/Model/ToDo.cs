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
        public DateTime DoneBy { get; set; }
        public Boolean IsDone { get; set; }

        public ToDo()
        {
            Name = "";
            Desc = "";
            DoneBy = DateTime.Today;
            IsDone = false;
        }

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
}
