
    public class ProductRepository
    {
        static List<Product> Products = new List<Product>();

        public static IList<Product> GetProductList() => Products;

        public static void init()
        {
            Products = new List<Product> {
            new Product("Пельмені", 157.99, DateTime.Today.AddDays(-5)),
            new Product("Вареники", 98.50, DateTime.Today.AddDays(-12)),
            new Product("Пиво", 54.99, DateTime.Today.AddDays(-4)),
            new Product("Моршинська Негазована", 17.89, DateTime.Today),
            };
        }

        public static bool AddProduct(Product? product)
        {
            if (product == null)
            {
                return false;
            }

            Products.Add(product);

            return true;
        }
    }
