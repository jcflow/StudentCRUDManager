using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public class StudentTextDataManager : IDataManager<Student>
    {
        private string path;

        /// <summary>
        /// Creates a text file data manager for students.
        /// </summary>
        public StudentTextDataManager(string path)
        {
            this.path = path;
        }

        /// <inheritdoc />
        public bool Add(Student item)
        {
            try
            {
                var line = string.Format("{0}/{1}/{2}/{3}/{4}", item.Id, item.Name, item.Lastname, item.Height, item.CareerId);
                File.AppendAllText(this.path, Environment.NewLine + line);
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
                var expectedLine = string.Format("{0}/{1}/{2}/{3}/{4}", item.Id, item.Name, item.Lastname, item.Height, item.CareerId);
                var lines = File.ReadAllLines(this.path);
                // TODO
                var filtered = lines.Where(arg => !arg.Contains(item.Name));
                if (lines.Count<string>() == filtered.Count<string>()) return false;
                File.WriteAllLines(this.path, filtered);
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
            var items = new List<Student>();
            foreach (var line in File.ReadAllLines(this.path))
            {
                string[] values = line.Split('/');

                if (values.Length == 5)
                {
                    items.Add(new Student()
                    {
                        Id = values[0],
                        Name = values[1],
                        Lastname = values[2],
                        Height = double.Parse(values[3]),
                        CareerId = int.Parse(values[4])
                    });
                }
            }
            return items;
        }

        /// <inheritdoc />
        public bool Update(Student item)
        {
            try
            {
                var newFile = new StringBuilder();
                var updated = false;
                var newLine = string.Format("{0}/{1}/{2}/{3}/{4}", item.Id, item.Name, item.Lastname, item.Height, item.CareerId);
                foreach (string line in File.ReadAllLines(this.path))
                {
                    if (line.Split('/')[0] == item.Id)
                    {
                        newFile.Append(newLine + "\r\n");
                        updated = true;
                        continue;
                    }
                    newFile.Append(line + "\r\n");

                }
                File.WriteAllText(this.path, newFile.ToString());
                return updated;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
