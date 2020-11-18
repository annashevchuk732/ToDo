using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Text;
using System.Windows.Input;

namespace ToDo
{
    public class TaskList : INotifyPropertyChanged
    {
        public string Object { get; set; }
        public event PropertyChangedEventHandler PropertyChanged;
        public ObservableCollection<TaskClassView> List { get; set; }
        public ICommand AddTask { get; set; }
        public ICommand DelTask { get; set; }
        public TaskList(){
            List = new ObservableCollection<TaskClassView>();
            AddTask = new Command(addTask);
            DelTask = new Command(delTask);
        }
        void addTask(Object obj)
        {
            if (!string.IsNullOrEmpty(Object))
            {
                List.Add(new TaskClassView { tasktext_view = Object});
            }
        }
        void delTask(Object obj)
        {
            List.Remove( (TaskClassView)(obj)); 
        }
    }
}
