using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Seller : User
    {
        private List<Product> products;

        public Seller(string username, string password, Address address) : base(username, password, address)
        {
            try
            {
                Products = new List<Product>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Seller() : base()
        {
            Products = new List<Product>();
        }
        public Seller(Seller other) : base(other)
        {
            try
            {
                Products = new List<Product>();
                foreach (Product p in other.Products)
                {
                    Products.Add(new Product(p));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Product> Products
        {
            get
            {
                return products;
            }
            set
            {
                try
                {
                    products = new List<Product>(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            string str = base.ToString() + "\n Product:\n";
            if (Products.Count == 0)
            {
                str += "No product sold by this seller \n";
            }
            for (int i = 0; i < Products.Count; i++)
            {
                str += (i + 1) + ") " + Products[i].ToString() + "\n";
            }
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Seller other = (Seller)obj;
            for (int i = 0; i < Products.Count; i++)
            {
                if (!(Products[i].Equals(other.Products[i])))
                {
                    return false;
                }
            }
            return base.Equals(obj);
        }
        public override object Clone()
        {
            return new Seller(this);
        }

        public bool AddProduct(Product product)
        {
            try
            {
                if (product == null)
                {
                    throw new InvalidOperationException("Product is empty");
                }
                product.ValidateProduct();
                IsExistInSeller(product);
                Products.Add(product);
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public bool IsExistInSeller(Product product)
        {
            try
            {
                for (int i = 0; i < Products.Count; i++)
                {
                    if (Products[i].Name.ToLower() == product.Name.ToLower())
                    {
                        throw new InvalidOperationException("Product already sold by this Seller");
                    }
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
    }
}