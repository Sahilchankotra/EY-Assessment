using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingSite_GUI
{
    internal class AllProducts_List
    {

       public AllProducts_List()
        {
            List<Products> productobj1 = new List<Products>();
            productobj1.Add(new Products { Id = 1, Name = "Protein", Price = 2132, productDescription = "Health Protein" });
            productobj1.Add(new Products { Id = 2, Name = "Shaker", Price = 1000, productDescription = "Health Protein" });
            productobj1.Add(new Products { Id = 3, Name = "Sandwich", Price = 232, productDescription = "Health Protein" });
            productobj1.Add(new Products { Id = 4, Name = "Bread", Price = 322, productDescription = "Health Protein" });
        }
       

    }
}
