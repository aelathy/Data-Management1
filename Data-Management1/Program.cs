// Data Management Project
#nullable disable
Console.Clear();

// List<User> users = new List<User>();
// users.Add(new User(---------, —-------));

// class User {
// 	public string Username { get; set; }
// 	public string Password { get; set; }
// 	public List<Song> Faves { get; set; }

// 	public User(username, password) {
// 		this.Username = username;
// 		this.Password = password;
// 		this.Faves = new List<Song>();
// 	}
// }

List<User> users = new List<User>();
users.Add(new User("aly", "hi"));
List<Product> products = new List<Product>();
products.Add(new Product("Laptop", "Acer", 800));
products.Add(new Product("Phone", "Samsung", 1000));

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
    //  kickout
    // }
    // Main Menu Loop
    Console.WriteLine("\n Main Menu");
    Console.WriteLine("1. Display All Products");
    Console.WriteLine("2. Look for Product");
    Console.WriteLine("3. Sort & Show Lowest to Highest");
    Console.WriteLine("4. Add Product to Shopping Cart");
    Console.WriteLine("5. Display Shopping Cart");
    Console.WriteLine("6. Exit");
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
        // Implement Search Program
        Console.Write("Search by Brand: ");
        Console.ReadLine();
        // First letters of the product brand match the letters type (left to right)
        if (true)
        {

        }
    }
    else if (menuOption == "3")
    {
        // Do Some Type of Sort to Organize Products by Lowest to Highest Price

    }
    else if (menuOption == "4")
    {
        // Add Product to Shopping List
    }
    else if (menuOption == "5")
    {
        // Remove Product from Shopping List
    }
    else if (menuOption == "6")
    {
        // Display Shopping Cart
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