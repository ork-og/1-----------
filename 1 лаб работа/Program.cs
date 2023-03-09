static void Main()
{
    Market market = new Market();
    for (int i = 0; i < market.allProducts.Count(); i++) 
    {
        Console.WriteLine($"{market.allProducts[i].Name}");
    }
}

Main();

public class Product
{
    public string? Name { get; set; }
    public string? Elem { get; set; }
}

public class Market
{
    public List<Product> Snacks = new List<Product>(new Product[] {new Product{Name="ChocolateBar", Elem="Carbohydratese"}, 
                                                               new Product{Name="BalykCheese", Elem="Углевод"},
                                                               new Product{Name="Crisps", Elem="Углевод"}});
    public List<Product> semiFinishedProduct = new List<Product>(new Product[] {new Product{Name="Шоколадный ботончик", Elem="Углевод"}, 
                                                               new Product{Name="Шоколадный ботончик", Elem="Углевод"},
                                                               new Product{Name="Шоколадный ботончик", Elem="Углевод"}});
    public List<Product> firtstProducts =  new List<Product>(new Product[] {new Product{Name="Шоколадный ботончик", Elem="Углевод"}, 
                                                               new Product{Name="Шоколадный ботончик", Elem="Углевод"},
                                                               new Product{Name="Шоколадный ботончик", Elem="Углевод"}});
    public List<Product> allProducts = new List<Product>();
    

    public Market()
    {
        var all = this.Snacks.Concat(this.semiFinishedProduct).ToList().Concat(this.firtstProducts).ToList();
        this.allProducts = all;
    }
}


public class Cart
{
    public List<Product> cart = new List<Product>();
    public Market market = new Market();
    
    public void take_products()
    {
        while (true)
        {
            Console.WriteLine("Введите номер товара, 0 для завершения\n");
            Console.WriteLine("Список товаров:");
            for (int i = 0; i < market.allProducts.Count(); i++) 
            {
                Console.WriteLine($"{i + 1}) {market.allProducts[i].Name}");
            }
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 0)
            {
                return;
            }
            cart.Add(market.allProducts[choise - 1]);
        }
    }
}


