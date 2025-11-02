using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Order : ICloneable
    {
        private string username;
        private Address address;
        private List<Product> cart;
        private float totalPrice;

        public Order(string username, Address address, List<Product> cart, float totalPrice)
        {
            Username = username;
            Address = address;
            Cart = new List<Product>(cart);
            TotalPrice = totalPrice;
        }
        public Order()
        {
            Username = "";
            Address = new Address();
            Cart = new List<Product> { new Product() };
            TotalPrice = 0;
        }
        public Order(Order other)
        {
            try
            {
                Username = other.Username;
                Address = other.Address;
                Cart = new List<Product>(other.Cart);
                TotalPrice = other.TotalPrice;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public string Username
        {
            get
            {
                return username;
            }
            set
            {
                try
                {
                    username = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public Address Address
        {
            get
            {
                return address;
            }
            set
            {
                try
                {
                    address = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
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
        public float TotalPrice
        {
            get
            {
                return totalPrice;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("Price must be positive number\n");
                    }
                    totalPrice = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            string str = "Username: " + Username + "\nAddress: " + Address.ToString() + "\norder:\n";
            for (int i = 0; i < cart.Count; i++)
            {
                if (Cart[i] is Special_Product specialProduct)
                {
                    str += (i + 1) + ") " + (specialProduct).ToString() + "\n";
                }
                else
                {
                    str += (i + 1) + ") " + Cart[i].ToString() + "\n";
                }
            }
            str += "\nTotal price: " + TotalPrice + "\n";
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Order other = (Order)obj;
            if (Username != other.Username)
            {
                return false;
            }
            if (!Address.Equals(other.Address))
            {
                return false;
            }
            if (cart.Capacity != other.cart.Capacity)
            {
                return false;
            }
            for (int i = 0; i < cart.Capacity; i++)
            {
                if (!(Cart[i].Equals(other.Cart[i])))
                {
                    return false;
                }
            }
            if (TotalPrice != other.TotalPrice)
            {
                return false;
            }
            return true;
        }
        public object Clone()
        {
            return new Order(this);
        }

        public bool ValidateOrder()
        {
            try
            {
                if (Username == null || Username == "" || Username == " " || Username == "\n")
                {
                    throw new InvalidOperationException("Invalid buyer");
                }
                if (TotalPrice <= 0)
                {
                    throw new InvalidOperationException("Invalid total price");
                }
                for (int i = 0; i < cart.Capacity; i++)
                {
                    Cart[i].ValidateProduct();
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        public string PrintCart()
        {
            string str = "";
            for (int i = 0; i < cart.Count; i++)
            {
                if (Cart[i] is Special_Product specialProduct)
                {
                    str += "* " + (specialProduct).ToString() + "\n";
                }
                else
                {
                    str += "* " + Cart[i].ToString() + "\n";
                }
            }
            str += "\nTotal price: " + TotalPrice + "\n";
            return str;
        }
    }
}