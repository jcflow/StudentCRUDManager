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
    /// Interaction logic for CareerSelector.xaml
    /// </summary>
    public partial class CareerSelector : Window
    {
        private CareerSelectorController controller;
        public CareerSelector(MainWindowController controller, Student student)
        {
            this.controller = new CareerSelectorController(this, controller, student);
            InitializeComponent();
            this.DataContext = this.controller;
        }
    }
}
