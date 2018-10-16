using System;
using Scheduler.ViewModel;
using Scheduler.Model;
using Xunit;

namespace SchedulerTests
{
    public class ScheduleTest
    {
        //DateTimePicker date = new DateTimePicker();
        ToDoListVM name = new Scheduler.ViewModel.ToDoListVM();
        ToDo todo = new ToDo();

        [Fact]
        public void Test1()
        {

            Assert.Equal(todo.Name, name.Name);
        }

        [Fact]
        public void boolFalse()
        {
            Assert.Equal(false, name.IsDone);
        }
    }
}
