using Client_WPF.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace Client_WPF
{
    public class MainViewModel : PropertyChangedHelper
    {
        private ObservableCollection<QueueItem> _queueItems;
        public ObservableCollection<QueueItem> QueueItems
        {
            get { return _queueItems; }
            set { SetField(ref _queueItems, value, "ItemsSource"); }
        }

        private QueueItem _selectedCustomer;
        public QueueItem SelectedCustomer
        {
            get { return _selectedCustomer; }
            set { SetField(ref _selectedCustomer, value, "ItemsSource"); }
        }

        public ICommand RemoveCommand { get; set; }

        public MainViewModel()
        {
            RemoveCommand = new DelegateCommand(RemoveCommandAction);
            QueueItems = new ObservableCollection<QueueItem>();
            QueueItems.Add(new QueueItem()
            {
                Id = "1",
                Value = "aaa"
            });
            QueueItems.Add(new QueueItem()
            {
                Id = "2",
                Value = "bbb"
            });
        }

        private void RemoveCommandAction()
        {

        }
    }
}
