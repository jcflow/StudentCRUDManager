using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public class StudentFormController
    {
        private int source;
        private Student student;
        private MainWindowController mainController;
        public SubmitCommand SubmitCommand { get; set; }
        public StudentForm Window { get; set; }
        public string Name { get; set; }
        public string Lastname { get; set; }
        public double Height { get; set; }
        public int SelectedResourceIndex { get; set; }

        public StudentFormController(StudentForm window, MainWindowController mainController, Student student, int source)
        {
            this.Window = window;
            this.mainController = mainController;
            this.SubmitCommand = new SubmitCommand(this, student == null);
            this.source = source;
            this.student = student;
            if (student != null)
            {
                Name = student.Name;
                Lastname = student.Lastname;
                Height = student.Height;
            }
        }

        public void AddStudent()
        {
            var student = new Student()
            {
                Id = System.Guid.NewGuid().ToString(),
                Name = Name,
                Lastname = Lastname,
                Height = Height,
                CareerId = 0
            };
            var manager = DataManagerFactory.CreateDataManager<Student>(source);
            var students = manager.Add(student);
            mainController.Load();
        }

        public void UpdateStudent()
        {
            student.Name = Name;
            student.Lastname = Lastname;
            student.Height = Height;
            var manager = DataManagerFactory.CreateDataManager<Student>(source);
            var students = manager.Update(student);
            mainController.Load();
        }
    }
}
