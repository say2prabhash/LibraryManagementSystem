using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibraryManagementSystem
{
    public class Product
    {
        public string Id { get; }
        public string Title { get; }
        public GenreType Genre { get; }
        public ProductType Type { get; }
        public Product()
        {

        }
    }
}
