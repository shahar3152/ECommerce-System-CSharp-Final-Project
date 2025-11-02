using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
#pragma warning disable CS0659

namespace E_commerce
{
    internal class Special_Product : Product
    {
        private float packagePrice;

        public Special_Product(string name, float price, string category, float packagePrice) : base(name, price, category)
        {
            try
            {
                PackagePrice = packagePrice;
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Special_Product() : base()
        {
            PackagePrice = 0;
        }
        public Special_Product(Special_Product special_Product) : base(special_Product)
        {
            try
            {
                PackagePrice = special_Product.PackagePrice;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public float PackagePrice
        {
            get
            {
                return packagePrice;
            }
            set
            {
                try
                {
                    if (value <= 0)
                    {
                        throw new Exception("\nPackage price must be positive number\n");
                    }
                    packagePrice = value;
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
                return base.Price + PackagePrice;
            }
        }

        public override string ToString()
        {
            string str = base.ToString() + ", Package price: " + packagePrice + ", Total price: " + TotalPrice;
            return str;
        }
        public override bool Equals(object obj)
        {
            if (obj == null || GetType() != obj.GetType())
            {
                return false;
            }
            Special_Product other = (Special_Product)obj;
            return (base.Equals(obj) && packagePrice == other.packagePrice);
        }
        public override object Clone()
        {
            return new Special_Product(this);
        }

        public override bool ValidateProduct()
        {
            try
            {
                base.ValidateProduct();
                if (packagePrice <= 0)
                {
                    throw new InvalidOperationException("Package price must be positive\n");
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        public override string PrintProduct()
        {
            return base.PrintProduct() + "," + PackagePrice;
        }
    }
}