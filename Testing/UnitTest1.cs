using System;
using Xunit;
using Scheduler.ViewModel;
using System.Windows.Input;
using Scheduler.Model;
using System.Collections.ObjectModel;
using Scheduler.Command;

namespace Testing
{
    public class UnitTest1
    {
        ToDoListVM todolist = new ToDoListVM();
        ObservableCollection<ToDoListVM> todo = new ObservableCollection<ToDoListVM>();
        

        [Fact]
        public void Test1()
        {
            //Checks to see if initial state of checkbox is false
            Assert.False(todolist.IsDone);
        }

        [Fact]
        public void Test2()
        {
            //Checks to see if initial state of name is null
            Assert.Null(todolist.Name);
        }

        [Fact]
        public void Test3()
        {
            //Checks to see if initial state of description is null
            Assert.Null(todolist.Desc);
        }

        [Fact]
        public void Test4()
        {
            //Checks to see if initial state of doneby is null
            Assert.Null(todolist.DoneBy);

        }

        [Fact]
        public void Test5()
        {
            todolist.Desc = "that";
            todo.Add(todolist);

            Assert.Equal("that", todolist.Desc);
        }

        [Fact]
        public void Test6()
        {
            todolist.Name = "this";
            todo.Add(todolist);

            Assert.Equal("this", todolist.Name);
        }

        [Fact]
        public void Test7()
        {
            todolist.DoneBy = "this";
            todo.Add(todolist);

            Assert.Equal("this", todolist.DoneBy);

        }

        [Fact]
        public void Test8()
        {
            //checking for edge cases on string
            todolist.Name = "this!!@!ASDFAS*T*$#%@$(@#)@#$)%";
            todo.Add(todolist);

            Assert.Equal("this!!@!ASDFAS*T*$#%@$(@#)@#$)%", todolist.Name);

        }

        [Fact]
        public void Test9()
        {
            //checking for edge cases on string
            todolist.Desc = "this!!@!ASDFAS*T*$#%@$(@#)@#$)%";
            todo.Add(todolist);

            Assert.Equal("this!!@!ASDFAS*T*$#%@$(@#)@#$)%", todolist.Desc);


        }

        [Fact]
        public void Test10()
        {
            todolist.IsDone = false;

            Assert.DoesNotMatch(todolist.IsDone.ToString(), "sdkflaj;");
        }

    }
}
