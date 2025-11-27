using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Activity
{
    internal class ElectronicProduct:product
    {
        public int warrentyperiod;
        public string brand;

        public ElectronicProduct(int id,string name,decimal price,int stockquantity, int Warrentyperiod,string Brand) : base(id, name, price, stockquantity)
        {
            warrentyperiod = Warrentyperiod;
            brand = Brand;
        }

    }
}
