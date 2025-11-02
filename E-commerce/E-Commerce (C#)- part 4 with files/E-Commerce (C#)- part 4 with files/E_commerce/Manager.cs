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
        public bool PayOrder(int buyerIndex)
        {
            try
            {
                if (buyers[buyerIndex].Cart.Count <= 1)
                {
                    throw new InvalidOperationException("Cart must contain at least 2 items at payment");
                }
                float totalPrice = buyers[buyerIndex].TotalPriceCart();
                string username = buyers[buyerIndex].Username;
                Address address = (Address)buyers[buyerIndex].Address.Clone();
                ValidateAddress(address);
                List<Product> cart = new List<Product>(buyers[buyerIndex].Cart.Count);
                for (int i = 0; i < buyers[buyerIndex].Cart.Count; i++)
                {
                    Product item = (Product)buyers[buyerIndex].Cart[i].Clone();
                    cart.Add(item);
                }
                Order order = new Order(username, address, cart, totalPrice);
                order.ValidateOrder();
                buyers[buyerIndex].AddOrderToHistory(order);
                Console.WriteLine("The total price for your order is: " + totalPrice + "\n");
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
        public void PrintBuyers()
        {
            if (buyers.Count == 0)
            {
                Console.WriteLine("There are no Buyers in E-commerce");
            }
            for (int i = 0; i < buyers.Count; i++)
            {

                Console.WriteLine(buyers[i].ToString() + "------------------------");
            }
        }
        public void PrintSellers()
        {
            if (sellers.Count == 0)
            {
                Console.WriteLine("there are no Sellers in E-commerce");
            }
            CompareSellersByProductsCount comparer = new CompareSellersByProductsCount();
            sellers.Sort(comparer);
            for (int i = 0; i < sellers.Count; i++)
            {
                Console.WriteLine(sellers[i].ToString() + "------------------------");
            }
        }
        public bool CopyCartFromHistory(int buyerIndex, int orderIndex)
        {
            try
            {
                orderIndex--;
                if (orderIndex >= 0 && buyers[buyerIndex].OrdersHistory.Count >= orderIndex)
                {
                    List<Product> temp = new List<Product>();
                    foreach (Product p in buyers[buyerIndex].OrdersHistory[orderIndex].Cart)
                    {
                        temp.Add((Product)p.Clone());
                    }
                    buyers[buyerIndex].Cart = temp;
                }
                else
                {
                    throw new InvalidOperationException("Invalid Order choice");
                }
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
        public void CompareCartPrice(int buyerIndex, int compareIndex)
        {
            if (buyerIndex == compareIndex)
            {
                Console.WriteLine("You chose yourself, therefore the carts are equal");
                return;
            }
            try
            {
                if (compareIndex > buyers.Count)
                {
                    throw new IndexOutOfRangeException("choice out of range\n"); //wasn't cought normally in the appropriate catch, so we had to throw new
                }
                if (buyers[buyerIndex] > buyers[compareIndex])
                {
                    Console.WriteLine("Your cart price is higher than the user you compared to");
                }
                else
                {
                    if (buyers[buyerIndex] < buyers[compareIndex])
                    {
                        Console.WriteLine("Your cart price is lower than the user you compared to");
                    }
                    else
                    {
                        Console.WriteLine("Your cart prices are equal");
                    }
                }
            }
            catch (ArgumentNullException e)
            {
                throw e;
            }
            catch (IndexOutOfRangeException e)
            {
                throw e;
            }
            catch (Exception e)
            {
                throw e;
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
        public List<int> PrintProductsOptions(string productName)
        {
            List<int> idArr = new List<int>();
            if (sellers.Count == 0)
            {
                Console.WriteLine("No sellers are saved to the manager\n");
                return idArr;
            }
            for (int i = 0; i < sellers.Count; i++)
            {
                for (int j = 0; j < sellers[i].Products.Count; j++)
                {
                    if (productName.ToLower() == sellers[i].Products[j].Name.ToLower())
                    {
                        Console.WriteLine(sellers[i].Products[j].ToString());
                        idArr.Add(sellers[i].Products[j].Id);
                    }
                }
            }
            if (idArr.Count == 0)
            {
                Console.WriteLine("The product you are looking for isn't being sold\n");
                idArr = new List<int> { -1 };
            }
            else
            {
                Console.WriteLine("Please enter the id of the product you wish to buy\n" +
                    "if you wish to not purchas any product from the options, then please enter 0");
            }
            return idArr;
        }
        public void PrintHistorty(int buyerIndex)
        {
            string str = "Order History:\n";
            try
            {
                if (buyers[buyerIndex].OrdersHistory.Count == 0)
                {
                    throw new InvalidOperationException("Order history is empty");
                }
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            for (int i = 0; i < buyers[buyerIndex].OrdersHistory.Count; i++)
            {
                str += (i + 1) + ") " + buyers[buyerIndex].OrdersHistory[i].PrintCart() + "~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~\n";
            }
            Console.WriteLine(str);
        }
        public void PrintBuyersUsernames(int buyerIndex)
        {
            try
            {
                if (buyers.Count == 1) // we left this in in case the code is legally changes later by 3rd party
                {
                    throw new InvalidOperationException("There are no buyers other than you");
                }
                string str = "";
                for (int i = 0; i < buyers.Count; i++)
                {
                    str += (i + 1) + ") " + buyers[i].Username;
                    if (i == buyerIndex)
                    {
                        str += " (you)";
                    }
                    str += "\n";
                }
                Console.WriteLine(str);
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
        public string PrintForFile()
        {
            string str = "";
            for (int i = 0; i < sellers.Count; i++)
            {
                if (i + 1 < sellers.Count)
                {
                    str += sellers[i].PrintSeller() + "\n";
                }
                else
                {
                    str += sellers[i].PrintSeller();
                }
            }
            return str;
        }
        public void WriteFile()
        {
            StreamWriter streamWriter = new StreamWriter(fileName);
            streamWriter.WriteLine(PrintForFile());
            streamWriter.Close();
            Console.WriteLine("saved");
        }
        public void ReadFile()
        {
            try
            {
                List<Seller> fileSellers = new List<Seller>();
                StreamReader streamReader = null;
                streamReader = new StreamReader(fileName);
                streamReader.BaseStream.Seek(0, SeekOrigin.Begin);
                string line;
                bool nextIsSeller = true;
                int index = 0;
                while (!streamReader.EndOfStream)
                {
                    line = streamReader.ReadLine();
                    if (line == "EOS")
                    {
                        nextIsSeller = true;
                        index = 0;
                    }
                    else
                    {
                        //this is a new seller
                        if (nextIsSeller)
                        {
                            string[] sellerInfo = line.Split(',');
                            //[0]=Username, [1]=Password, [2]=Street, [3]=houseNumber, [4]=City, [5]=State
                            if (sellerInfo.Length != 6)
                            {
                                throw new InvalidOperationException("Incorrect amount of seller information");
                            }
                            AddSeller(sellerInfo[0], sellerInfo[1], sellerInfo[2], int.Parse(sellerInfo[3]), sellerInfo[4], sellerInfo[5]);
                            index = GetSellerIndex(sellerInfo[0], sellerInfo[1]);
                            if (index == -1)
                            {
                                break;
                            }
                            nextIsSeller = false;
                        }
                        //currentSeller's products
                        else
                        {
                            string[] productInfo = line.Split(',');
                            //[0]=Id, [1]=Name, [2]=Category, [3]=Price, [4]=PackagePrice
                            if (productInfo.Length == 4) //regular product
                            {
                                AddProductToSeller(index, productInfo[1], float.Parse(productInfo[3]), productInfo[2], 0);
                            }
                            else
                            {
                                if (productInfo.Length == 5) //special product
                                {
                                    AddProductToSeller(index, productInfo[1], float.Parse(productInfo[3]), productInfo[2], float.Parse(productInfo[4]));
                                }
                            }
                        }
                    }
                }
                streamReader.Close();
            }
            // all program closes are for when the error can't be fixed,
            // causes errors in loading past data
            // or hinders the functionality of the program (like out of memory)
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
            catch (FileNotFoundException e) //not a cause for closing the program, since this error should only activate when there is no file in the folder
            {
                Console.WriteLine($"{e.Message}\nOrfile doesn't exist yet");
            }
            catch (FileLoadException e)
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
            catch (IOException e) // we can't know what the error will be, so closing the program for safety
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
            catch (OutOfMemoryException e)
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
            catch (FormatException e) // this error will only happen if we wrote the reading from file or into the file incorrectly and it tries to Parse float from characters
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
            catch (Exception e) // for all other unforeseen errors
            {
                Console.WriteLine($"Error in loading data from file: {e.Message}\nThis program will now close\n");
                Environment.Exit(0);
            }
        }
    }
}