using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Buyer : User
    {
        private List<Product> cart;

        public Buyer(string username, string password, Address address) : base(username, password, address)
        {
            try
            {
                Cart = new List<Product>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Buyer() : base()
        {
            Cart = new List<Product>();
        }
        public Buyer(Buyer other) : base(other)
        {
            try
            {
                Cart = new List<Product>();
                foreach (Product p in other.Cart)
                {
                    Cart.Add(new Product(p));
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<Product> Cart
        {
            get
            {
                return cart;
            }
            set
            {
                try
                {
                    cart = new List<Product>(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            string str = base.ToString() + "\ncart:\n";
            if (Cart.Count == 0)
            {
                str += "cart is empty\n";
            }
            for (int i = 0; i < Cart.Count; i++)
            {
                if (Cart[i] is Special_Product)
                {
                    Special_Product temp = Cart[i] as Special_Product;
                    str += (i + 1) + ") " + temp.ToString() + "\n";
                }
                else
                {
                    str += (i + 1) + ") " + Cart[i].ToString() + "\n";
                }
            }
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Buyer other = (Buyer)obj;
            if (other.Cart.Count != Cart.Count)
            {
                return false;
            }
            for (int i = 0; i < Cart.Count; i++)
            {
                if (!(Cart[i].Equals(other.Cart[i])))
                {
                    return false;
                }
            }
            return base.Equals(obj);
        }
        public override object Clone()
        {
            return new Buyer(this);
        }

        public float TotalPriceCart()
        {
            float totalPrice = 0;
            for (int i = 0; i < Cart.Count; i++)
            {
                try
                {
                    Cart[i].ValidateProduct();
                }
                catch (InvalidOperationException e)
                {
                    throw e;
                }
                if (Cart[i] is Special_Product)
                {
                    totalPrice += ((Special_Product)Cart[i]).TotalPrice;
                }
                else
                {
                    totalPrice += Cart[i].Price;
                }
            }
            return totalPrice;
        }
        public bool AddProductToCart(Product product)
        {
            try
            {
                if (product == null) // in case there was an error in sending the product to this method
                {
                    throw new InvalidOperationException("Error in Locating Product");
                }
                product.ValidateProduct();
                Cart.Add(product);
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (Exception e) // in case an unexpected error occurs
            {
                throw e;
            }
        }
        public static bool operator >(Buyer buyer, Buyer compare)
        {
            try
            {
                if (buyer == null || compare == null)
                {
                    throw new ArgumentNullException("Error in sending buyer information to comparison");
                }
                return buyer.TotalPriceCart() > compare.TotalPriceCart();
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public static bool operator <(Buyer buyer, Buyer compare)
        {
            try
            {
                if (buyer == null || compare == null)
                {
                    throw new ArgumentNullException("Error in sending buyer information to comparison");
                }
                return buyer.TotalPriceCart() < compare.TotalPriceCart();
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
    }
}