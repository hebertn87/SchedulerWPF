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

        public override ValidationResult Validate(object value, CultureInfo cultureInfo)
        {

            throw new NotImplementedException();
        }
    }
}
