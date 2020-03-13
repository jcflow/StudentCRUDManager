using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    class StudentDBDataManager : IDataManager<Student>
    {
        private static string connectionString = "Data Source=LAPTOP-NKE0O0IF\\SQLEXPRESS;Initial Catalog=manager;Integrated Security=True";

        private SqlConnection connection;

        /// <summary>
        /// Creates a DB data manager for students.
        /// </summary>
        public StudentDBDataManager()
        {
            this.connection = new SqlConnection(connectionString);
            this.connection.Open();
        }

        /// <inheritdoc />
        public bool Add(Student item)
        {
            try
            {
                string query = string.Format("INSERT INTO Student (Id, Name, Lastname, Height, CareerId) VALUES ('{0}', '{1}', '{2}', '{3}', '{4}')", item.Id, item.Name, item.Lastname, item.Height, item.CareerId);
                SqlCommand command = new SqlCommand(query, this.connection);
                command.ExecuteNonQuery();
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
                string query = string.Format("DELETE FROM Student WHERE Id = '{0}'", item.Id);
                SqlCommand command = new SqlCommand(query, this.connection);
                command.ExecuteNonQuery();
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
            string query = "SELECT * FROM Student";
            SqlCommand command = new SqlCommand(query, this.connection);
            SqlDataReader reader = command.ExecuteReader();
            try
            {
                while (reader.Read())
                {
                    items.Add(new Student()
                    {
                        Id = reader[0].ToString(),
                        Name = reader[1].ToString(),
                        Lastname = reader[2].ToString(),
                        Height = double.Parse(reader[3].ToString()),
                        CareerId = int.Parse(reader[4].ToString())
                    });
                }
            }
            finally
            {
                reader.Close();
            }
            return items;
        }

        /// <inheritdoc />
        public bool Update(Student item)
        {
            try
            {
                string query = string.Format("UPDATE Student SET Id = '{0}', Name = '{1}', LastName = '{2}', Height = '{3}', CareerId = '{4}' WHERE Id = '{4}'", item.Id, item.Name, item.Lastname, item.Height, item.CareerId, item.Name);
                SqlCommand command = new SqlCommand(query, this.connection);
                command.ExecuteNonQuery();
                return true;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}
