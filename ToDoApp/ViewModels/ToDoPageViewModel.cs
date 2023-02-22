using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using System.Collections.ObjectModel;
using ToDoApp.Models;

namespace ToDoApp.ViewModels
{
    public partial class ToDoPageViewModel : BaseViewModel
    {
        [ObservableProperty]
        ObservableCollection<ToDoListModel> toDos;

        [ObservableProperty]
        private string task;

        [ObservableProperty]
        private bool isDone;

        public ToDoPageViewModel()
        {
            Title = "ToDo";
            ToDos = new ObservableCollection<ToDoListModel>();
        }

        [RelayCommand]
        private void AddToDo()
        {
            if (!string.IsNullOrWhiteSpace(Task))
            {
                ToDoListModel newtodo = new ToDoListModel { Task = Task };
                ToDos.Add(newtodo);
                Task = string.Empty;
            }
        }

        [RelayCommand]
        private void RemoveToDo(ToDoListModel toDo)
        {
            ToDos.Remove(toDo);
        }
    }
}