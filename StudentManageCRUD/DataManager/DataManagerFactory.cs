using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public static class DataManagerFactory
    {
        /// <summary>
        /// Creates a data manager based on the source.
        /// </summary>
        /// <typeparam name="T">The element type.</typeparam>
        /// <param name="source">The data source.</param>
        /// <returns>A constructed data manager.</returns>
        public static IDataManager<T> CreateDataManager<T>(int source)
        {
            switch (source)
            {
                case 0:
                    return (IDataManager<T>)new StudentXmlDataManager("Data/students.xml");
                case 1:
                    return (IDataManager<T>)new StudentTextDataManager("Data/students.txt");
                case 2:
                default:
                    return (IDataManager<T>)new StudentDBDataManager();
            }
        }
    }
}
