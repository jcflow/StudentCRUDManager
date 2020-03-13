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

namespace StudentManageCRUD.SearchWindow
{
    /// <summary>
    /// Interaction logic for SearchWindow.xaml
    /// </summary>
    public partial class SearchWindow : Window
    {
        private SearchWindowController controller;
        public SearchWindow(MainWindowController controller)
        {
            this.controller = new SearchWindowController(controller.Students.ToList());
            InitializeComponent();
            this.DataContext = this.controller;
        }
    }
}
