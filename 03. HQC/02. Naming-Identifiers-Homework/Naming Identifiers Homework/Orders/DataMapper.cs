namespace Orders
{
    using System.Collections.Generic;
    using System.Linq;
    using System.IO;
    using Orders.Models;

    public class DataMapper
    {
        private readonly string categoryFileName;
        private readonly string productFileName;
        private readonly string orderFileName;

        public DataMapper(string categoryFileName, string productFileName, string orderFileName)
        {
            this.categoryFileName = categoryFileName;
            this.productFileName = productFileName;
            this.orderFileName = orderFileName;
        }

        public DataMapper()
            : this("../../Data/categories.txt", "../../Data/products.txt", "../../Data/orders.txt")
        {
        }

        public IEnumerable<Category> GetAllCategories()
        {
            var category = this.ReadFileLines(this.categoryFileName, true);
            return category
                .Select(c => c.Split(','))
                .Select(c => new Category { Id = int.Parse(c[0]), Name = c[1], Description = c[2] });
        }

        public IEnumerable<Product> GetAllProducts()
        {
            var products = this.ReadFileLines(this.productFileName, true);
            return products
                .Select(p => p.Split(','))
                .Select(p => new Product
                {
                    Id = int.Parse(p[0]),
                    Name = p[1],
                    CategoryId = int.Parse(p[2]),
                    UnitPrice = decimal.Parse(p[3]),
                    UnitInStock = int.Parse(p[4]),
                });
        }

        public IEnumerable<Order> GetAllOrders()
        {
            var orders = this.ReadFileLines(this.orderFileName, true);
            return orders
                .Select(p => p.Split(','))
                .Select(p => new Order
                {
                    Id = int.Parse(p[0]),
                    ProductId = int.Parse(p[1]),
                    Quant = int.Parse(p[2]),
                    Discount = decimal.Parse(p[3]),
                });
        }

        private List<string> ReadFileLines(string fileName, bool isHeader)
        {
            var allLines = new List<string>();
            using (var reader = new StreamReader(fileName))
            {
                string currentLine;

                if (isHeader)
                {
                    reader.ReadLine();
                }

                while ((currentLine = reader.ReadLine()) != null)
                {
                    allLines.Add(currentLine);
                }
            }

            return allLines;
        }
    }
}
