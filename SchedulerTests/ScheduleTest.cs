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
        DateTimePicker date = new DateTimePicker();
        ToDoListVM name = new Scheduler.ViewModel.ToDoListVM();
        //ToDo todo = new ToDo("Do Work", "Get all my work done", date.ToString, false);

        [Test]
        public void Test1()
        {
           
            //Assert.AreEqual(todo.Name, name);
        }

        [Test]
        public void boolFalse()
        {
            Assert.AreEqual(false, false);
        }
    }
}
