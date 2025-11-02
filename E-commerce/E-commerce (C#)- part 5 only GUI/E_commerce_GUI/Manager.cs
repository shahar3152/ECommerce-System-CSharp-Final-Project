using System;
using System.CodeDom;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Linq.Expressions;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using E_commerce;
using static E_commerce.Product;

namespace E_commerce
{
    internal class Manager
    {
        private string name;
        private List<Seller> sellers;
        private List<Buyer> buyers;
        public const string fileName = @"Data.txt";

        public Manager(string name)
        {
            try
            {
                Name = name;
                Sellers = new List<Seller>();
                Buyers = new List<Buyer>();
            }
            catch (Exception e)
            {
                throw e;
            }
        }
        public Manager()
        {
            this.Name = "";
            Sellers = new List<Seller>();
            Buyers = new List<Buyer>();
        }
        public Manager(Manager other)
        {
            try
            {
                Name = other.Name;
                Sellers = new List<Seller>();
                foreach (Seller s in other.Sellers)
                {
                    Sellers.Add(new Seller(s));
                }
                Buyers = new List<Buyer>();
                foreach (Buyer b in other.Buyers)
                {
                    Buyers.Add(new Buyer(b));
                }
            }
            catch (Exception e)
            {
                throw e;
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
                        throw new Exception("\nSystem name must be with one or more chars\n");
                    }
                    name = value;
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public List<Seller> Sellers
        {
            get
            {
                return sellers;
            }
            set
            {
                try
                {
                    sellers = new List<Seller>(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }
        public List<Buyer> Buyers
        {
            get
            {
                return buyers;
            }
            set
            {
                try
                {
                    buyers = new List<Buyer>(value);
                }
                catch (Exception e)
                {
                    throw e;
                }
            }
        }

        public bool AddBuyer(string username, string password, string street, int houseNumber, string city, string state)
        {
            try
            {
                Address address = new Address(street, houseNumber, city, state);
                ValidateAddress(address);
                Buyer newBuyer = new Buyer(username, password, address);
                buyers = this + newBuyer;
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (Exception e) // for unexpected errors
            {
                throw e;
            }
        }
        public bool AddSeller(string username, string password, string street, int houseNumber, string city, string state)
        {
            try
            {
                Address address = new Address(street, houseNumber, city, state);
                ValidateAddress(address);
                Seller newSeller = new Seller(username, password, address);
                sellers = this + newSeller;
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            catch (Exception e) // for unexpected errors
            {
                throw e;
            }
        }
        public bool AddProductToSeller(int sellerIndex, string productName, float productPrice, string category, float packagePrice)
        {
            try
            {
                Product product;
                if (packagePrice > 0)
                {
                    product = new Special_Product(productName, productPrice, category, packagePrice);
                }
                else
                {
                    product = new Product(productName, productPrice, category);
                }
                product.ValidateProduct();
                sellers[sellerIndex].AddProduct(product);
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
        public bool AddProductToBuyer(int buyerIndex, int productId)
        {
            try
            {
                Product productToAdd = null;
                bool breaker = false;
                for (int i = 0; i < sellers.Count; i++)
                {
                    for (int j = 0; j < sellers[i].Products.Count; j++)
                    {
                        if (productId == sellers[i].Products[j].Id)
                        {
                            productToAdd = (Product)sellers[i].Products[j].Clone();
                            breaker = true;
                            break;
                        }
                    }
                    if (breaker)
                    {
                        break;
                    }
                }
                if (productToAdd == null)
                {
                    throw new InvalidOperationException("Product not fount");
                }
                buyers[buyerIndex].AddProductToCart(productToAdd);
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
        public string PrintBuyers()
        {
            string str = "";
            if (buyers.Count == 0)
            {
                str+="There are no Buyers in E-commerce";
            }
            for (int i = 0; i < buyers.Count; i++)
            {

                str += buyers[i].ToString() + "--------------------------------------------------------------------------------------------------------------------------------------------------\n";
            }
            return str;
        }
        public string PrintSellers()
        {
            string str = "";
            if (sellers.Count == 0)
            {
                str+="there are no Sellers in E-commerce";
            }
            CompareSellersByProductsCount comparer = new CompareSellersByProductsCount();
            sellers.Sort(comparer);
            for (int i = 0; i < sellers.Count; i++)
            {
                str += sellers[i].ToString() + "---------------------------------------------------------------------------------------------------------------------------------------------------\n";
            }
            return str;
        }

        public int LogIn(string username, string password, bool userType)
        {
            if (userType)
            {
                return GetBuyerIndex(username, password);
            }
            else
            {
                return GetSellerIndex(username, password);
            }
        }

        public int GetBuyerIndex(string username, string password)
        {
            int index = -1;
            for (int i = 0; i < buyers.Count; i++)
            {
                if (buyers[i].Username == username && buyers[i].Password == password)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public int GetSellerIndex(string username, string password)
        {
            int index = -1;
            for (int i = 0; i < sellers.Count; i++)
            {
                if (sellers[i].Username == username && sellers[i].Password == password)
                {
                    index = i;
                    break;
                }
            }
            return index;
        }
        public bool IsUsernameExist(string username)
        {
            try
            {
                if (buyers.Count != 0)
                {
                    for (int i = 0; i < buyers.Count; i++)
                    {
                        if (username == buyers[i].Username)
                        {
                            throw new InvalidOperationException("Username already taken. Please choose a diffrent username");
                        }
                    }
                }

                if (sellers.Count != 0)
                {
                    for (int i = 0; i < sellers.Count; i++)
                    {
                        if (username == sellers[i].Username)
                        {
                            throw new InvalidOperationException("Username already taken. Please choose a diffrent username");
                        }
                    }
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        public bool ValidateUsername(string username)
        {
            try
            {
                if (username == null || username == "" || username == "\n" || username == " ")
                {
                    throw new InvalidOperationException("Invalid username\n");
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }
        public bool ValidatePassword(string password)
        {
            try
            {
                if (password == null || password == "" || password == "\n" || password == " ")
                {
                    throw new InvalidOperationException("Invalid password\n");
                }
                return true;
            }
            catch (InvalidOperationException ex)
            {
                throw ex;
            }
        }
        public bool ValidateAddress(Address address)
        {
            try //the error catching will appear after all the info is entered and will only show for the first error cought.
            {
                if (address.Street == null || address.Street == "\n" || address.Street == "")
                {
                    throw new InvalidOperationException("Invalid street");
                }
                if (address.HouseNumber <= 0)
                {
                    throw new InvalidOperationException("Invalid house number\n");
                }
                if (address.City == null || address.City == "" || address.City == "\n")
                {
                    throw new InvalidOperationException("Invalid city\n");
                }
                if (address.State == null || address.State == "" || address.State == "\n")
                {
                    throw new InvalidOperationException("Invalid state\n");
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        public bool ValidateAddressFromMain(string street, int houseNumber, string city, string state)
        {
            try //the error catching will appear after all the info is entered and will only show for the first error cought.
            {
                if (street == null || street == "\n" || street == "")
                {
                    throw new InvalidOperationException("Invalid street");
                }
                if (houseNumber <= 0)
                {
                    throw new InvalidOperationException("Invalid house number\n");
                }
                if (city == null || city == "" || city == "\n")
                {
                    throw new InvalidOperationException("Invalid city\n");
                }
                if (state == null || state == "" || state == "\n")
                {
                    throw new InvalidOperationException("Invalid state\n");
                }
                return true;
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
        }
        public string PrintProductsOptions(string productName)
        {
            string str = "";
            int count = 0;
            for (int i = 0; i < sellers.Count; i++)
            {
                for (int j = 0; j < sellers[i].Products.Count; j++)
                {
                    if (productName.ToLower() == sellers[i].Products[j].Name.ToLower())
                    {
                        Console.WriteLine(sellers[i].Products[j].ToString());
                        str += sellers[i].Products[j].ToString() + "\n";
                        count++;
                    }
                }
            }
            if (count == 0)
            {
                str += "The product you are looking for isn't being sold";
            }
            return str;
        }
        public static List<Buyer> operator +(Manager manager, Buyer newBuyer)
        {
            manager.buyers.Add(newBuyer);
            return manager.buyers;
        }
        public static List<Seller> operator +(Manager manager, Seller newSeller)
        {
            manager.sellers.Add(newSeller);
            return manager.sellers;
        }       
    }
}