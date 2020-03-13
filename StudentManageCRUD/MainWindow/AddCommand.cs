using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class AddCommand : ICommand
    {
        private MainWindowController controller;

        public AddCommand(MainWindowController controller)
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
            var form = new StudentForm(null, this.controller.Source, this.controller);
            form.Show();
        }
    }
}
