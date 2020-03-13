using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class CareerSelectCommand : ICommand
    {
        private MainWindowController controller;

        public CareerSelectCommand(MainWindowController controller)
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
            var selector = new CareerSelector(this.controller, (Student)parameter);
            selector.Show();
        }
    }
}
