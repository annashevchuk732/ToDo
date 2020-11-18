using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace ToDo
{
    public class TaskClassView : INotifyPropertyChanged
    {
        TaskClass Object;
        public event PropertyChangedEventHandler PropertyChanged;
        public string tasktext_view {
            get { return Object.task_text; }
            set {if (Object.task_text != value)
                {
                    Object.task_text = value;
                    OnPropertyChanged("tasktext_view");
                }
            }
        }
        public TaskClassView() { Object = new TaskClass(); }
        private void OnPropertyChanged(string name)
        {
            if (PropertyChanged != null)
                PropertyChanged(this, new PropertyChangedEventArgs(name));
        }
    }
}
