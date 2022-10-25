// Data Management Project
#nullable disable
using static System.IComparable;
Console.Clear();

// List<User> users = new List<User>();
// users.Add(new User(---------, —-------));

List<User> users = new List<User>();
users.Add(new User("aly", "hi"));
List<Product> products = new List<Product>();
products.Add(new Product("Laptop", "Acer", 800));
products.Add(new Product("Phone", "Samsung", 1000));
products.Add(new Product("Phone", "Apple", 1000));
products.Add(new Product("Monitor", "Asus", 300));
// Temp Shopping List
List<Product> ShoppingList = new List<Product>();

bool loop = true;
while (loop)
{
    // Console.WriteLine("Please log in with your password and username");
    // Console.Write("Username: ");
    // string name = Console.ReadLine();
    // Console.Write("Password");
    // string password = Console.ReadLine();
    // if (name & password equal a user.Username & user.Password) {
    //  In
    // } else {
    //  Not In
    // }
    // Main Menu Loop
    Console.WriteLine("\n Main Menu");
    Console.WriteLine("1. Display All Products");
    Console.WriteLine("2. Look for Product");
    Console.WriteLine("3. Sort & Show Lowest to Highest");
    Console.WriteLine("4. Add Product to Shopping Cart");
    Console.WriteLine("5. Remove Product from Shopping Cart");
    Console.WriteLine("6. Display Shopping Cart");
    Console.WriteLine("7. Exit");
    string menuOption = Console.ReadLine().ToLower();
    Console.WriteLine();


    if (menuOption == "1")
    {
        for (int i = 0; i < products.Count; i++)
        {
            Console.WriteLine($"{products[i].Type} {products[i].Brand} ${products[i].Price}");
        }
    }
    else if (menuOption == "2")
    {
        bool result = false;
        // Implement Search Program
        Console.Write("Search by Brand: ");
        string brandSearch = Console.ReadLine().ToLower();
        // First letters of the product brand match the letters type (left to right)
        for (int i = 0; i < products.Count; i++)
        {
            if (brandSearch == products[i].Brand.ToLower())
            {
                result = true;
                Console.WriteLine($"{products[i].Type} {products[i].Brand} ${products[i].Price}");
            }
        }
        if (!result)
        {
            Console.WriteLine("Product not found.");
        }
    }
    else if (menuOption == "3")
    {
        // Do Some Type of Sort to Organize Products by Lowest to Highest Price
        for (int i = 0; i < products.Count; i++)
        {
            for (int j = 0; j < products.Count - (i + 1); j++)
            {
                int compare = products[j].Price.CompareTo(products[j + 1].Price);
                if (compare == 1)
                {
                    int chng = products[j + 1].Price;
                    products[j + 1].Price = products[j].Price;
                    products[j].Price = chng;
                }
            }
        }

    }
    else if (menuOption == "4")
    {
        // Add Product to Shopping List
        Console.WriteLine("Enter the type & brand of the product you want to ADD:");
        Console.Write("Type: ");
        string addType = Console.ReadLine().ToLower();
        Console.Write("Brand: ");
        string addBrand = Console.ReadLine().ToLower();
        for (int i = 0; i < products.Count; i++)
        {
            if (addType == products[i].Type.ToLower() && addBrand == products[i].Brand.ToLower())
            {
                if (ShoppingList.Count > 0)
                {
                    foreach (Product item in ShoppingList)
                    {
                        if (addType == item.Type.ToLower() && addBrand == item.Brand.ToLower())
                        {
                            Console.WriteLine("Item already in shopping list.");
                        }
                        else
                        {
                            ShoppingList.Add(products[i]);
                            Console.WriteLine("Item added to shopping list.");
                            break;
                        }
                    }
                }
                else
                {
                    ShoppingList.Add(products[i]);
                    Console.WriteLine("item addded to shopping list.");
                }
            }
        }
    }
    else if (menuOption == "5")
    {
        // Remove Product from Shopping List
        Console.WriteLine("Enter the type & brand of the product you want to REMOVE:");
        Console.Write("Type: ");
        string addType = Console.ReadLine();
        Console.Write("Brand: ");
        string addBrand = Console.ReadLine();
        for (int i = 0; i < products.Count; i++)
        {
            if (addType == products[i].Type && addBrand == products[i].Brand)
            {
            }
        }
    }
    else if (menuOption == "6")
    {
        // Display Shopping Cart
        for (int i = 0; i < ShoppingList.Count; i++)
        {
            Console.WriteLine($"{ShoppingList[i].Type} {ShoppingList[i].Brand} ${ShoppingList[i].Price}");
        }
    }
    else if (menuOption == "7")
    {
        break;
    }
}


class Product
{
    public string Type { get; set; }
    public string Brand { get; set; }
    public int Price { get; set; }

    public Product(string type, string brand, int price)
    {
        this.Type = type;
        this.Brand = brand;
        this.Price = price;
    }
}

class User
{
    public string Username { get; set; }
    public string Password { get; set; }
    public List<Product> ShopItem { get; set; }

    public User(string username, string password)
    {
        this.Username = username;
        this.Password = password;
        this.ShopItem = new List<Product>();
    }
}