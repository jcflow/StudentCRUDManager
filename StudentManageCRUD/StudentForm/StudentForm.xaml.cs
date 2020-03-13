using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace StudentManageCRUD
{
    /// <summary>
    /// Interaction logic for StudentForm.xaml
    /// </summary>
    public partial class StudentForm : Window
    {
        StudentFormController controller;
        public StudentForm(Student student, int source, MainWindowController mainController)
        {
            this.controller = new StudentFormController(this, mainController, student, source);
            InitializeComponent();
            this.DataContext = this.controller;
        }
    }
}
