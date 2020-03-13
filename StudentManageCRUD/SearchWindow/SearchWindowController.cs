using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public class SearchWindowController
    {
        private List<Student> students;
        public string Search { get; set; }
        public SearchCommand SearchCommand { get; set; }
        public ObservableCollection<Student> Students { get; set; }

        public SearchWindowController(List<Student> students)
        {
            this.students = students;
            this.SearchCommand = new SearchCommand(this);
            this.Students = new ObservableCollection<Student>();
            students.ForEach(this.Students.Add);
        }

        public void PerformSearch()
        {
            this.Students.Clear();
            var filtered = this.students.FindAll(student => student.Name.Contains(Search) || student.Lastname.Contains(Search));
            filtered.ForEach(this.Students.Add);
        }
    }
}
