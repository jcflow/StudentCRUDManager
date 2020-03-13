using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentManageCRUD
{
    public interface IDataManager<T>
    {
        /// <summary>
        /// Reads all the items.
        /// </summary>
        /// <returns>A list of the read items.</returns>
        List<T> Read();
        /// <summary>
        /// Adds an item to the data source.
        /// </summary>
        /// <param name="item">The item to be added.</param>
        /// <returns>A confirmation of the adding process.</returns>
        bool Add(T item);
        /// <summary>
        /// Updates an item from the data source.
        /// </summary>
        /// <param name="item">The item to be updated based on its name.</param>
        /// <returns>A confirmation of the adding process.</returns>
        bool Update(T item);
        /// <summary>
        /// Deletes an item from the data source.
        /// </summary>
        /// <param name="item">The item to be deleted based on its name.</param>
        /// <returns>A confirmation of the adding process.</returns>
        bool Delete(T item);
    }
}
