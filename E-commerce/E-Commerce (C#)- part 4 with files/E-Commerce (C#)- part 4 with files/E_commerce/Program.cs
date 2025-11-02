using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace E_commerce
{
    public class InvalidNumOfSellersException : Exception
    {
        public InvalidNumOfSellersException(string message) : base(message) { }
    }
    public class InvalidNumOfBuyersException : Exception
    {
        public InvalidNumOfBuyersException(string message) : base(message) { }
    }
    internal class Program
    {
        static void Main(string[] args)
        //Shahar Lankry- 322659137, Shaked Rosenberg- 209547033
        {
            int choice = 0;
            Manager manager = new Manager("E-commerce");
            //Loading the data from the file into the program
            manager.ReadFile();
            while (choice != 10)
            {
                Console.WriteLine("\nPlease select an option (1-10):");
                Console.WriteLine("1) Add Buyer\n" +
                    "2) Add Seller\n" +
                    "3) Add product to seller\n" +
                    "4) Add product to cart\n" +
                    "5) Pay for order\n" +
                    "6) Show all Buyers information\n" +
                    "7) Show all sellers information\n" +
                    "8) Copy past order to your cart\n" +
                    "9) Compare 2 buyers (1 buyer must log in)\n" +
                    "10) Exit\n");
                while (true)
                {
                    choice = 0;
                    Console.WriteLine("Your choice: ");
                    try
                    {
                        choice = int.Parse(Console.ReadLine());
                        break;
                    }
                    catch (FormatException e)
                    {
                        Console.WriteLine($"{e.Message}\nPlease select an option (1-10):");
                    }
                }
                Console.WriteLine(); //this is for space in the print
                switch (choice)
                {
                    case 1://add buyer  
                        {
                            try
                            {
                                NewAccount(manager, true); //Seller = false, Buyer = true
                                break;
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                        }
                    case 2://add seller
                        {
                            try
                            {
                                NewAccount(manager, false); //Seller = false, Buyer = true
                                break;
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                        }
                    case 3://add product to seller ------ special product
                        {
                            try
                            {
                                if (manager.Sellers.Count == 0)
                                {
                                    throw new InvalidNumOfSellersException("No seller in E-commerce\n");
                                }
                            }
                            catch (InvalidNumOfSellersException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            int sellerIndex = LogIn(manager, false); //false = Seller, true = Buyer
                            if (sellerIndex == -1)
                            {
                                Console.WriteLine("Incorrect username or password\n");
                                break;
                            }
                            while (true)
                            {
                                Console.WriteLine("\nPlease enter name of product: ");
                                string productName = Console.ReadLine();

                                Console.WriteLine("\nPlease enter price of product: ");
                                float productPrice;
                                while (true)
                                {
                                    productPrice = 0;
                                    try
                                    {
                                        productPrice = float.Parse(Console.ReadLine());
                                        break;
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine($"{e.Message}\nPlease try again");
                                        continue;
                                    }
                                }
                                int intCategory = 0;
                                string category = "";
                                while (intCategory != 1 && intCategory != 2 && intCategory != 3 && intCategory != 4)
                                {
                                    Console.WriteLine("\nPlease choose product's category:\n" +
                                    "1) kids\n" +
                                    "2) electronics\n" +
                                    "3) office\n" +
                                    "4) clothing");
                                    try
                                    {
                                        intCategory = int.Parse(Console.ReadLine());
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine($"{e.Message}");
                                        intCategory = 0;
                                        continue;
                                    }
                                    switch (intCategory)
                                    {
                                        case 1:
                                            {
                                                category = "kids";
                                                break;
                                            }
                                        case 2:
                                            {
                                                category = "electronics";
                                                break;
                                            }
                                        case 3:
                                            {
                                                category = "office";
                                                break;
                                            }
                                        case 4:
                                            {
                                                category = "clothing";
                                                break;
                                            }
                                        default:
                                            {
                                                Console.WriteLine("Invalid choice\n");
                                                continue;
                                            }
                                    }
                                }
                                float packagePrice = 0;
                                int special = 0;
                                while (special != 1 && special != 2)
                                {
                                    special = 0;
                                    Console.WriteLine("\nDoes the product have special packaging?\n" +
                                    "1) yes\n2) no");
                                    try
                                    {
                                        special = int.Parse(Console.ReadLine());
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine($"{e.Message}");
                                        continue;
                                    }
                                    if (special != 1 && special != 2)
                                    {
                                        Console.WriteLine("Invalid choice. Please enter a valid choice\n");
                                    }
                                    if (special == 1)
                                    {
                                        Console.WriteLine("Please enter special packaging price: ");
                                        packagePrice = 0;
                                        try
                                        {
                                            packagePrice = float.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException e)
                                        {
                                            Console.WriteLine($"{e.Message}");
                                            special = 0;
                                            continue;
                                        }
                                        try
                                        {
                                            if (packagePrice <= 0)
                                            {
                                                packagePrice = 0;
                                                special = 0;
                                                throw new InvalidOperationException("Invalid package price. Please enter a valid package price\n");
                                            }
                                        }
                                        catch (InvalidOperationException e)
                                        {
                                            Console.WriteLine($"{e.Message}");
                                            continue;
                                        }
                                        break;
                                    }
                                    if (special == 2)
                                    {
                                        break;
                                    }
                                }
                                try
                                {
                                    manager.AddProductToSeller(sellerIndex, productName, productPrice, category, packagePrice);
                                    Console.WriteLine("Product was successfully added to your user\n");
                                }
                                catch (InvalidOperationException e)
                                {
                                    Console.WriteLine($"{e.Message}");
                                    break;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"{e.Message}");
                                    break;
                                }
                                if (!Again()) // checking if user wants to add another product
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    case 4://add product to cart
                        {
                            try
                            {
                                if (manager.Buyers.Count == 0)
                                {
                                    throw new InvalidNumOfBuyersException("No Buyers in E-commerce\n");
                                }
                                if (manager.Sellers.Count == 0)
                                {
                                    throw new InvalidNumOfSellersException("No seller in E-commerce\n");
                                }
                            }
                            catch (InvalidNumOfSellersException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            catch (InvalidNumOfBuyersException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                break;
                            }
                            int buyerIndex = LogIn(manager, true); //false = Seller, true = Buyer
                            if (buyerIndex == -1)
                            {
                                Console.WriteLine("Incorrect username or password\n");
                                break;
                            }

                            while (true)
                            {
                                Console.WriteLine("Please enter the name of the product you wish to add to your cart: ");
                                string productName = Console.ReadLine();
                                List<int> idArr = manager.PrintProductsOptions(productName);
                                if (idArr[0] != -1)
                                {
                                    bool done = false;
                                    while (!done)
                                    {
                                        int productId = 0;
                                        try
                                        {
                                            productId = int.Parse(Console.ReadLine());
                                        }
                                        catch (FormatException e)
                                        {
                                            Console.WriteLine($"{e.Message}\nPlease try again");
                                            continue;
                                        }
                                        if (productId == 0)
                                        {
                                            Console.WriteLine("Canceling adding of product to your cart\n");
                                            break;
                                        }
                                        for (int i = 0; i < idArr.Count; i++)
                                        {
                                            if (productId == idArr[i])
                                            {
                                                try
                                                {
                                                    manager.AddProductToBuyer(buyerIndex, productId);
                                                    Console.WriteLine("Product was successfully added to your cart\n");
                                                    done = true;
                                                    break;
                                                }
                                                catch (InvalidOperationException e)
                                                {
                                                    Console.WriteLine($"Failed to add product to your cart: {e.Message}\n");
                                                }
                                            }
                                        }
                                        if (!done)
                                        {
                                            Console.WriteLine("Please enter valid product id");
                                        }
                                    }

                                }
                                if (!Again()) // checking if user wants to add another product
                                {
                                    break;
                                }
                            }
                            break;
                        }
                    case 5://pay for order
                        {
                            int buyerIndex = LogIn(manager, true); //false = Seller, true = Buyer
                            if (buyerIndex == -1)
                            {
                                Console.WriteLine("Incorrect Username or Password\n");
                                break;
                            }
                            try
                            {
                                manager.PayOrder(buyerIndex);
                                Console.WriteLine("\nPayment successful\n" +
                                    "Your order was saved to your order history\n");
                                break;
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"Failed to pay: {e.Message}");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"Failed to pay: {e.Message}");
                                break;
                            }
                        }
                    case 6://all buyers info
                        {
                            manager.PrintBuyers();
                            break;
                        }
                    case 7://all sellers info
                        {
                            manager.PrintSellers();
                            break;
                        }
                    case 8://Copy past order to your cart
                        {
                            try
                            {
                                if (manager.Buyers.Count == 0)
                                {
                                    throw new InvalidNumOfBuyersException("No Buyers in E-commerce\n");
                                }
                            }
                            catch (InvalidNumOfBuyersException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                break;
                            }
                            int buyerIndex = LogIn(manager, true); //false = Seller, true = Buyer
                            try
                            {
                                int orderIndex = 0;
                                if (buyerIndex == -1)
                                {
                                    throw new InvalidOperationException("Incorrect username or password\n");
                                }
                                manager.PrintHistorty(buyerIndex);
                                Console.WriteLine("Please enter the number of the order you would like to add to your cart\n" +
                                    "If you wish to cancel the copy option, please enter 0");
                                while (true)
                                {
                                    try
                                    {
                                        orderIndex = int.Parse(Console.ReadLine());
                                        if (orderIndex == 0)
                                        {
                                            break;
                                        }
                                        manager.CopyCartFromHistory(buyerIndex, orderIndex);
                                        break;
                                    }
                                    catch (FormatException e)
                                    {
                                        Console.WriteLine($"{e.Message}\nPlease try again, If you wish to cancel the copy option, please enter 0");
                                        continue;
                                    }
                                    catch (ArgumentOutOfRangeException e)
                                    {
                                        Console.WriteLine($"{e.Message}\nTry again, If you wish to cancel the copy option, please enter 0");
                                        continue;
                                    }
                                    catch (Exception e)
                                    {
                                        Console.WriteLine($"{e.Message}");
                                        orderIndex = 0;
                                        break;
                                    }
                                }
                                if (orderIndex == 0)
                                {
                                    break;
                                }
                                Console.WriteLine("Copied successfully");
                                break;
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                        }
                    case 9: //compare 2 buyers
                        {
                            try
                            {
                                if (manager.Buyers.Count == 0) //not checking num of sellers, since they don't matter in the comparison
                                {
                                    throw new InvalidNumOfBuyersException("No Buyers in E-commerce\n");
                                }
                                if (manager.Buyers.Count == 1)
                                {
                                    throw new InvalidNumOfBuyersException("No Buyers in E-commerce to compare to\n");
                                }
                            }
                            catch (InvalidNumOfBuyersException ex)
                            {
                                Console.WriteLine($"{ex.Message}");
                                break;
                            }
                            int buyerIndex = LogIn(manager, true); //false = Seller, true = Buyer
                            if (buyerIndex == -1)
                            {
                                Console.WriteLine("Incorrect username or password\n");
                                break;
                            }
                            Console.WriteLine("choose the number of the buyer you wish to compare their cart to your's:");
                            try
                            {
                                manager.PrintBuyersUsernames(buyerIndex);
                            }
                            catch (InvalidOperationException e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            catch (Exception e)
                            {
                                Console.WriteLine($"{e.Message}");
                                break;
                            }
                            int compareIndex = 0;
                            while (true)
                            {
                                try
                                {
                                    compareIndex = 0;
                                    Console.WriteLine("your choice (if you would like to return to the menu enter 0):");
                                    compareIndex = int.Parse(Console.ReadLine());
                                    if (compareIndex < 0)
                                    {
                                        throw new InvalidOperationException("Choice must be a positive number");
                                    }
                                    if (compareIndex == 0)
                                    {
                                        break;
                                    }
                                }
                                catch (FormatException e)
                                {
                                    Console.WriteLine($"{e.Message}\nTry again:");
                                    continue;
                                }
                                catch (InvalidOperationException e)
                                {
                                    Console.WriteLine($"{e.Message}.Please try again");
                                    continue;
                                }

                                try
                                {
                                    manager.CompareCartPrice(buyerIndex, compareIndex - 1);
                                    break;
                                }
                                catch (ArgumentNullException e)
                                {
                                    Console.WriteLine($"{e.Message}");
                                    continue;
                                }
                                catch (IndexOutOfRangeException e)
                                {
                                    Console.WriteLine($"{e.Message}Please enter valid choice");
                                    continue;
                                }
                                catch (Exception e)
                                {
                                    Console.WriteLine($"{e.Message}");
                                    break;
                                }
                            }
                            break;
                        }
                    case 10://exit
                        {
                            manager.WriteFile();
                            Console.WriteLine("Goodbye and may the force be with you.\n");
                            break;
                        }
                    default://error
                        {
                            Console.WriteLine("Invalid choice.\nPlease enter a valid choice (1-8)\n");
                            break;
                        }

                }
                //a visual space 
                Console.WriteLine("***************************************");
            }
        }
        static int LogIn(Manager manager, bool userType)
        {
            Console.WriteLine("Please enter username: ");
            string username = Console.ReadLine();
            Console.WriteLine("\nPlease enter password: ");
            string password = Console.ReadLine();

            if (userType)
            {
                return manager.GetBuyerIndex(username, password);
            }
            else
            {
                return manager.GetSellerIndex(username, password);
            }
        }
        static void NewAccount(Manager manager, bool userType)
        {
            Console.WriteLine("Please enter new username: ");
            string username = Console.ReadLine();
            try
            {
                manager.IsUsernameExist(username);
                manager.ValidateUsername(username);
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }
            Console.WriteLine("\nPlease enter new password: ");
            string password = Console.ReadLine();
            try
            {
                manager.ValidatePassword(password);
            }
            catch (InvalidOperationException e)
            {
                throw e;
            }

            Console.WriteLine("\nPlease enter new address: ");
            Console.WriteLine("Please enter new street: ");
            string street = Console.ReadLine();
            int houseNumber;
            while (true)
            {
                houseNumber = 0;
                try
                {
                    Console.WriteLine("\nPlease enter new house number: ");
                    houseNumber = int.Parse(Console.ReadLine());
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message}");
                    continue;
                }
                break;
            }
            Console.WriteLine("Please enter new city: ");
            string city = Console.ReadLine();

            Console.WriteLine("Please enter new state: ");
            string state = Console.ReadLine();
            try
            {
                manager.ValidateAddressFromMain(street, houseNumber, city, state);
            }
            catch (InvalidOperationException e)
            {
                Console.WriteLine($"Invalid Address: {e.Message}\n");
                return;
            }
            if (userType)
            {
                try
                {
                    manager.AddBuyer(username, password, street, houseNumber, city, state);
                    Console.WriteLine("Successfully added\n");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Failure to add buyer: {e.Message}\n");
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failure to add buyer: {e.Message}\n");
                    return;
                }
            }
            else
            {
                try
                {
                    manager.AddSeller(username, password, street, houseNumber, city, state);
                    Console.WriteLine("Successfully added\n");
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"Failure to add seller: {e.Message}\n");
                    return;
                }
                catch (Exception e)
                {
                    Console.WriteLine($"Failure to add seller: {e.Message}\n");
                    return;
                }
            }
        }
        static bool Again() //flag help function
        {
            int again = 0;
            while (again != 1 && again != 2)
            {
                Console.WriteLine("Would you like to add another product?\n" +
                "1) Yes\n2) No");
                again = 0;
                try
                {
                    again = int.Parse(Console.ReadLine());
                    if (again != 1 && again != 2)
                    {
                        throw new InvalidOperationException("Invalid choice. Please enter a valid choice");
                    }
                }
                catch (FormatException e)
                {
                    Console.WriteLine($"{e.Message}");
                    continue;
                }
                catch (InvalidOperationException e)
                {
                    Console.WriteLine($"{e.Message}");
                    continue;
                }
            }
            if (again == 1)
            {
                return true;
            }
            return false;
        }
    }
}