using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace StudentManageCRUD
{
    public class StudentXmlDataManager : IDataManager<Student>
    {
        private string path;

        /// <summary>
        /// Creates a XML file data manager for students.
        /// </summary>
        public StudentXmlDataManager(string path)
        {
            this.path = path;
        }

        /// <inheritdoc />

        public bool Add(Student item)
        {
            try
            {
                XDocument doc = XDocument.Load(this.path);
                XElement student = new XElement("student");
                student.Add(new XElement("id", item.Id));
                student.Add(new XElement("name", item.Name));
                student.Add(new XElement("lastname", item.Lastname));
                student.Add(new XElement("height", item.Height));
                student.Add(new XElement("careerId", item.CareerId));
                doc.Element("students").Add(student);
                doc.Save(this.path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <inheritdoc />
        public bool Delete(Student item)
        {
            try
            {
                XDocument doc = XDocument.Load(this.path);
                var root = doc.Element("students");
                foreach (var node in root.Elements("student"))
                {
                    var id = node.Element("id").Value;
                    if (id == item.Id)
                    {
                        node.Remove();
                    }
                }
                doc.Save(this.path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }

        /// <inheritdoc />
        public List<Student> Read()
        {
            var xmlDocument = XDocument.Load(this.path);
            var items = from s in xmlDocument.Element("students")
                        .Descendants("student")
                        select new Student()
                        {
                            Id = (string)s.Element("id"),
                            Name = (string)s.Element("name"),
                            Lastname = (string)s.Element("lastname"),
                            Height = (double)s.Element("height"),
                            CareerId = (int)s.Element("careerId")
                        };
            return items.ToList();
        }

        /// <inheritdoc />
        public bool Update(Student item)
        {
            try
            {
                XDocument doc = XDocument.Load(this.path);
                var root = doc.Element("students");
                foreach (var node in root.Elements("student"))
                {
                    var id = node.Element("id").Value;
                    if (id == item.Id)
                    {
                        node.Element("id").SetValue(item.Id);
                        node.Element("name").SetValue(item.Name);
                        node.Element("lastname").SetValue(item.Lastname);
                        node.Element("height").SetValue(item.Height);
                        node.Element("careerId").SetValue(item.CareerId);
                    }
                }
                doc.Save(this.path);
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
