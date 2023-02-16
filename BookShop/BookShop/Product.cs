using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OnlineBookStore
{
    public abstract class Product
    {
        /// <summary>
        /// This functions is getters and setters.
        /// </summary>
        public string Name { get; set; }
        public string Id { get; set; }
        public string Price { get; set; }
        public byte[] Picture { get; set; }
        /// <summary>
        /// This function is abstract print properties.
        /// </summary>
        public abstract string printProperties();
    }
}
