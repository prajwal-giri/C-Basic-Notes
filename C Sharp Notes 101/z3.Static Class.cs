/*namespace C_Sharp_Notes_101;

// static class cannot be instantiated or inherited are known as static classes.
// the static keyword is used before the class name and only consists of static data members and static methods.

// It is not possible to create an instance of a static class using the new keyword. 
// The main features of static classes are:

// 1. They can only contain static members.
// 2. They cannot be instantiated or inherited and cannot contain instance constructors. However, the developer can create
// static constructors to initialize the static members.

static class Product
{
    private static int ProductId;
    private static string ProductName;
    private static int ProductPrice;

    static Product()
    {
        ProductId = 218;
        ProductName = "MacBook Air";
        ProductPrice = 155000;
    }

    public static void getProductDetails()

    {
        Console.WriteLine($"Product Id: {ProductId}");
        Console.WriteLine($"Product Name: {ProductName}");
        Console.WriteLine($"Product Price: {ProductPrice}");
    }

    public static void getDiscout() 
    {
        int discount = ProductPrice / 10;
        Console.WriteLine($"The discount amount is {discount}");
        Console.WriteLine($"The final discounted price is {ProductPrice - discount}");
        
    }
}


public class Static_Class
{
    static void Main(string[] args)
    {
       Product.getProductDetails();
       Product.getDiscout();
        
    }
}*/