using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    internal class CompareSellersByProductsCount : IComparer<Seller>
    {
        public int Compare(Seller x, Seller y)
        {
            if (x.Products.Count < y.Products.Count)
            {
                return -1;
            }
            else
            {
                if (x.Products.Count > y.Products.Count)
                {
                    return 1;
                }
                else
                {
                    return 0;
                }
            }
        }
    }
}
