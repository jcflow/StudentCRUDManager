using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{   
    public class Student
    {
        /// <summary>
        /// The id of the student.
        /// </summary>
        public string Id { get; set; }
        /// <summary>
        /// The name of the student.
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// The lastname of the student.
        /// </summary>
        public string Lastname { get; set; }
        /// <summary>
        /// The height of the student.
        /// </summary>
        public double Height { get; set; }

        /// <summary>
        /// The career of the student.
        /// </summary>
        public int CareerId { get; set; }

        /// <summary>
        /// Returns true if the students is greater that the minimal height.
        /// </summary>
        public bool IsValid
        {
            get { return Height > 1.65; }
        }

        /// <summary>
        /// Converts the student data to string.
        /// </summary>
        /// <returns>A string with the formatted student data.</returns>
        public override string ToString()
        {
            return string.Format("{0} {1}: {2}", Name, Lastname, Height);
        }
    }
}
