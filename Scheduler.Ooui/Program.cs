using System;
using System.Diagnostics;
using Scheduler.Shared.ViewModel;
using Ooui;
using Xamarin.Forms;

namespace Scheduler.Ooui
{
    class Program
    {
        static void Main(string[] args)
        {
            Forms.Init();
            var vm = new ToDoListVM();
            UI.Publish("/", new MainPage() { BindingContext = vm }.GetOouiElement());
#if DEBUG
            UI.Port = 12345;
            UI.Host = "localhost";
            Process.Start("explorer", $"http://{UI.Host}:{UI.Port}");
            Console.ReadLine();
#endif
        }
    }
}
