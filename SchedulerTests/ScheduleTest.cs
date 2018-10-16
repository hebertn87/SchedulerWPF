using System;
using Scheduler.ViewModel;
using NUnit;
using NUnit.Framework;
using Scheduler.Model;
using Xceed.Wpf.Toolkit;

namespace SchedulerTests
{
    public class ScheduleTest
    {
        [Test]
        public void Test1()
        {
            DateTimePicker date = new DateTimePicker();
            
            ToDo todo = new ToDo("Do Work", "Get all my work done", date , false );

            Assert.AreEqual(todo.Name, todo.Desc, todo.IsDone.ToString());
        }
    }
}
