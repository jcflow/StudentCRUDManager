using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace StudentManageCRUD
{
    public class SubmitCommand : ICommand
    {
        private StudentFormController controller;
        private bool add;

        public SubmitCommand(StudentFormController controller, bool add)
        {
            this.controller = controller;
            this.add = add;
        }

        public event EventHandler CanExecuteChanged;

        public bool CanExecute(object parameter)
        {
            return true;
        }

        public void Execute(object parameter)
        {
            if (add)
            {
                this.controller.AddStudent();
            }
            else
            {
                this.controller.UpdateStudent();
            }
            this.controller.Window.Close();
        }
    }
}
