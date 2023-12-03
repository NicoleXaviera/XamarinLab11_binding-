using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Input;
using Xamarin.Forms;

namespace DemoMVVC.ViewModels
{
    public class TaskViewModel : ViewModelBase
    {
        private ObservableCollection<Task> tasks;
        private ObservableCollection<Task> displayedTasks;

        public ObservableCollection<Task> Tasks
        {
            get { return tasks; }
            set
            {
                if (tasks != value)
                {
                    tasks = value;
                    OnPropertyChanged();
                }
            }
        }

        public ObservableCollection<Task> DisplayedTasks
        {
            get { return displayedTasks; }
            set
            {
                if (displayedTasks != value)
                {
                    displayedTasks = value;
                    OnPropertyChanged();
                }
            }
        }

        private Task newTask;

        public Task NewTask
        {
            get { return newTask; }
            set
            {
                if (newTask != value)
                {
                    newTask = value;
                    OnPropertyChanged();
                }
            }
        }

        public ICommand Save { protected set; get; }
        public ICommand Get { protected set; get; }

        public TaskViewModel()
        {
            tasks = new ObservableCollection<Task>();
            displayedTasks = new ObservableCollection<Task>();
            newTask = new Task();

            Save = new Command(Insertar);
            Get = new Command(Listar);
        }

        private void Insertar()
        {
            if (NewTask != null)
            {
                tasks.Add(NewTask);
                newTask = new Task();
            }
        }

        private void Listar()
        {
            DisplayedTasks = new ObservableCollection<Task>(Tasks);
        }
    }
}
