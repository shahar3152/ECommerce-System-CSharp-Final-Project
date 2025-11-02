using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Product : ICloneable
    {
        public enum eCategory { kids, electronics, office, clothing };

        private static int counter = 0;
        private int id;
        private string name;
        private float price;
        private eCategory category;

        public Product(string name, float price, string category)
        {
            try
            {
                Name = name;
                Price = price;
                counter++;
                id = counter;
                ConvertToCategory(category);
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Product()
        {
            Name = "";
            Price = 0;
            id = counter;
        }
        public Product(Product other)
        {
            try
            {
                Name = other.Name;
                Price = other.Price;
                id = other.Id;
                Category = other.Category;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public int Id
        {
            get
            {
                return id;
            }
        }
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                try
                {
                    if (value == null)
                    {
                        throw new Exception("\nProduct name must be with one or more chars\n");
                    }
                    name = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public float Price
        {
            get
            {
                return price;
            }
            set
            {
                try
                {
                    if (value < 0)
                    {
                        throw new Exception("Price must be positive number\n");
                    }
                    price = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public eCategory Category
        {
            get
            {
                return category;
            }
            set
            {
                try
                {
                    category = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public override string ToString()
        {
            string str = "ID: " + Id + ", Product name: " + Name + ", Category: " + Category + ", Price: " + Price;
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Product other = (Product)obj;
            return (Id == other.Id && Name == other.Name && Price == other.Price && Category == other.Category);
        }
        public virtual object Clone()
        {
            return new Product(this);
        }

        public virtual bool ValidateProduct()
        {
            try
            {
                if (Name == null || Name == "" || Name == " " || Name == "\n" || Price <= 0)
                {
                    throw new InvalidOperationException("Invalid product");
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        private void ConvertToCategory(string userInput)
        {
            try
            {
                eCategory category = (eCategory)Enum.Parse(typeof(eCategory), userInput);
            }
            catch (FormatException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public virtual string PrintProduct()
        {
            return Id + "," + Name + "," + Category + "," + Price;
        }
    }
}