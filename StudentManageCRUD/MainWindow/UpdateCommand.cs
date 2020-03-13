using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class UpdateCommand : ICommand
    {
        private MainWindowController controller;

        public UpdateCommand(MainWindowController controller)
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
            var form = new StudentForm((Student)parameter, this.controller.Source, this.controller);
            form.Show();
        }
    }
}
