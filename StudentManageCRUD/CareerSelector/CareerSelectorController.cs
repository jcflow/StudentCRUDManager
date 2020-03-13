using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManageCRUD
{
    public class CareerSelectorController
    {
        private Student student;
        private MainWindowController controller;
        private CareerSelector view;
        public Career SelectedCareer { get; set; }
        public ObservableCollection<Career> Careers { get; set; }
        public CareerUpdateCommand CareerUpdateCommand { get; set; }
        public CareerSelectorController(CareerSelector view, MainWindowController controller, Student student)
        {
            this.CareerUpdateCommand = new CareerUpdateCommand(this);
            this.Careers = new ObservableCollection<Career>();
            var list = this.ReadCareers();
            list.ForEach(this.Careers.Add);
            this.student = student;
            this.SelectedCareer = Careers[student.CareerId];
            this.controller = controller;
            this.view = view;
        }

        public void Update()
        {
            var manager = DataManagerFactory.CreateDataManager<Student>(this.controller.Source);
            this.student.CareerId = SelectedCareer.Id;
            manager.Update(this.student);
            this.controller.Load();
            this.view.Close();
        }

        public List<Career> ReadCareers()
        {
            var xmlDocument = XDocument.Load("Data/careers.xml");
            var items = from s in xmlDocument.Element("careers")
                        .Descendants("career")
                        select new Career()
                        {

                            Id = (int)s.Element("id"),
                            Name = (string)s.Element("name"),
                            Duration = (int)s.Element("duration"),
                            Price = (int)s.Element("price"),
                            Description = (string)s.Element("description")
                        };
            return items.ToList();
        }
    }
}
