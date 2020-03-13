using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public class MainWindowController
    {
        public int Source { get; set; }
        public UpdateCommand UpdateCommand { get; set; }
        public DeleteCommand DeleteCommand { get; set; }
        public SearchButtonCommand SearchCommand { get; set; }
        public CareerSelectCommand CareerSelectCommand { get; set; }
        public AddCommand AddCommand { get; set; }
        public MainWindow Window { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public MainWindowController(MainWindow window, int source)
        {
            this.Window = window;
            this.UpdateCommand = new UpdateCommand(this);
            this.DeleteCommand = new DeleteCommand(this);
            this.SearchCommand = new SearchButtonCommand(this);
            this.CareerSelectCommand = new CareerSelectCommand(this);
            this.AddCommand = new AddCommand(this);
            this.Students = new ObservableCollection<Student>();
            this.Source = source;
            this.Load();
        }

        public void Delete(Student student)
        {
            var manager = DataManagerFactory.CreateDataManager<Student>(this.Source);
            manager.Delete(student);
            this.Load();
        }

        public void Load()
        {
            this.Students.Clear();
            var manager = DataManagerFactory.CreateDataManager<Student>(this.Source);
            var students = manager.Read();
            students.ForEach(this.Students.Add);
        }
    }
}
