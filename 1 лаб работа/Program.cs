static void Main()
{
    Cart cart = new Cart();
    cart.take_products();
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
                                                               new Product{Name="BalykCheese", Elem="Proteins"},
                                                               new Product{Name="Crisps", Elem="Fats"}});
    public List<Product> semiFinishedProduct = new List<Product>(new Product[] {new Product{Name="Chicken", Elem="Proteins"}, 
                                                               new Product{Name="Fruit", Elem="Carbohydratese"},
                                                               new Product{Name="OliveOil", Elem="Fats"}});
    public List<Product> firtstProducts =  new List<Product>(new Product[] {new Product{Name="DumplingsMeat", Elem="Proteins"}, 
                                                               new Product{Name="DumplingsBerries", Elem="Carbohydratese"},
                                                               new Product{Name="Cheburek", Elem="Fats"}});
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
    public List<String> elements = new List<string>();
    
    public void take_products()
    {
        while (true)
        {
            Console.WriteLine("Введите номер товара, 0 для завершения\n");
            Console.WriteLine("Список товаров:");
            for (int i = 0; i < this.market.allProducts.Count(); i++) 
            {
                int number = i + 1;
                Console.WriteLine($"{number.ToString()}) {this.market.allProducts[i].Name}");
            }
            int choise = Convert.ToInt32(Console.ReadLine());
            if (choise == 0)
            {
                return;
            }
            this.cart.Add(this.market.allProducts[choise - 1]);
            if (!this.elements.Contains(this.market.allProducts[choise - 1].Elem))
            {
                this.elements.Add(this.market.allProducts[choise - 1].Elem);
            }
            this.elements.Add(market.allProducts[choise - 1].Elem);
            Console.WriteLine($"{market.allProducts[choise - 1].Name} добавлен!");
        }
    }
}


