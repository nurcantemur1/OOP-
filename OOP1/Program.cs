namespace OOP1
{
     class Program
    {
        static void Main(string[] args)
        {
            
            Product product = new Product();
            product.ProductId = 1;
            product.CategoryId = 1;
            product.ProductName= "hh";
            product.UnitPrice = 10;
            product.UnitInStock = 3;

            
          //  Console.WriteLine(product.ProductName);

            ProductManager productManager = new ProductManager();
            productManager.Add(product);





            Console.ReadLine();
        }
    }
}