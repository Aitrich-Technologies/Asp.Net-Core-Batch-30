using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class ClothingProduct:product
    {
        public int size;
        public string material;

        public ClothingProduct(int id, string name, decimal price, int stockquantity,int Size, string Material) :base (id, name, price, stockquantity)
        {
            size=Size;
            material=Material;
        }
    }
}
