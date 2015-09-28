namespace Orders
{
    using System;
    using System.Collections.Generic;
    using System.Globalization;
    using System.Linq;
    using System.Threading;

    using Orders.Models;

    class OrdersMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            var dataMapper = new DataMapper();
            var allCategories = dataMapper.GetAllCategories();
            var allProducts = dataMapper.GetAllProducts();
            var allOrders = dataMapper.GetAllOrders();

            // Names of the 5 most expensive products
            PrintNamesOfTheFiveMostExpensiveProducts(allProducts);

            Console.WriteLine(new string('-', 10));

            // Number of products in each category
            PrintNumberOfProductsInEachCategory(allProducts, allCategories);

            Console.WriteLine(new string('-', 10));

            // The 5 top products (by order quantity)
            PrintFiveTopProducts(allOrders, allProducts);

            Console.WriteLine(new string('-', 10));

            // The most profitable category
            PrintMostProfitableCategory(allOrders, allProducts, allCategories);
        }

        private static void PrintMostProfitableCategory(
            IEnumerable<Order> allOrders,
            IEnumerable<Product> allProducts,
            IEnumerable<Category> allCategories)
        {
            var category = allOrders.GroupBy(o => o.ProductId)
                    .Select(ordersGroup => new
                            {
                                categoryId = allProducts.First(p => p.Id == ordersGroup.Key).CategoryId,
                                price = allProducts.First(p => p.Id == ordersGroup.Key).UnitPrice,
                                quantity = ordersGroup.Sum(p => p.Quant)
                            })
                    .GroupBy(product => product.categoryId)
                    .Select(productGroup => new
                            {
                                categoryName = allCategories.First(c => c.Id == productGroup.Key).Name,
                                totalQuantity = productGroup.Sum(g => g.quantity * g.price)
                            })
                    .OrderByDescending(g => g.totalQuantity)
                    .First();

            Console.WriteLine("{0}: {1}", category.categoryName, category.totalQuantity);
        }

        private static void PrintFiveTopProducts(IEnumerable<Order> allOrders, IEnumerable<Product> allProducts)
        {
            var result =
                allOrders.GroupBy(o => o.ProductId)
                    .Select(ordersGroup => new
                            {
                                product = allProducts.First(p => p.Id == ordersGroup.Key).Name,
                                quantities = ordersGroup.Sum(productsOrdered => productsOrdered.Quant)
                            })
                    .OrderByDescending(q => q.quantities)
                    .Take(5);

            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.product, item.quantities);
            }
        }

        private static void PrintNumberOfProductsInEachCategory(
            IEnumerable<Product> allProducts,
            IEnumerable<Category> allCategories)
        {
            var result =
                allProducts.GroupBy(p => p.CategoryId)
                    .Select(group => new
                                {
                                    Category = allCategories.First(c => c.Id == group.Key).Name, Count = group.Count()
                                })
                    .ToList();

            foreach (var item in result)
            {
                Console.WriteLine("{0}: {1}", item.Category, item.Count);
            }
        }

        private static void PrintNamesOfTheFiveMostExpensiveProducts(IEnumerable<Product> allProducts)
        {
            var result = allProducts.OrderByDescending(p => p.UnitPrice).Take(5).Select(p => p.Name);

            Console.WriteLine(string.Join(Environment.NewLine, result));
        }
    }
}
