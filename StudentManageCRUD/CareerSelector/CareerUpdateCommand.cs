using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class CareerUpdateCommand : ICommand
    {
        private CareerSelectorController controller;

        public CareerUpdateCommand(CareerSelectorController controller)
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
            this.controller.Update();
        }
    }
}
