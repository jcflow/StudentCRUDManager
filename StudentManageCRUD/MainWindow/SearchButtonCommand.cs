using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class SearchButtonCommand : ICommand
    {
        private MainWindowController controller;

        public SearchButtonCommand(MainWindowController controller)
        {
            this.controller = controller;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            var window = new SearchWindow.SearchWindow(this.controller);
            window.Show();
        }
    }
}
