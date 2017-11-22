using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Objects;
using System.Globalization;
using System.Data.EntityClient;
using System.Data.SqlClient;
using System.Data.Common;


namespace Lab11_A
{
    class Program
    {
        static void Main(string[] args)
        {
            //1
            /*using(AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;
                IQueryable<string> productNames = from p in products
                                                  select p.Name;

                Console.WriteLine("Productos:");
                foreach(var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
            }*/
            //2
            /*using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;
                IQueryable<string> productNames = products.Select(p => p.Name);

                Console.WriteLine("Productos:");
                foreach (var productName in productNames)
                {
                    Console.WriteLine(productName);
                }
                Console.ReadKey();
            }*/
            //3
            /*using (AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                var products = AWEntities.Product;
                IQueryable<Product> productsQuery = from p in products
                                                    select p;
                IQueryable<Product> largeProducts = productsQuery.Where(p => p.Size == "L");

                Console.WriteLine("Productos de tamaño 'L':");
                foreach (var product in largeProducts)
                {
                    Console.WriteLine(product.Name);
                }
                Console.ReadKey();
            }*/
            //4
            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Product> productsQuery = from product in context.Product
                                                    select product;

                Console.WriteLine("Productos:");
                foreach (var prod in productsQuery)
                {
                    Console.WriteLine(prod.Name);
                }
                Console.ReadKey();
            }*/
            //5
            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from product in context.Product
                            select new
                            {
                                ProductID = product.ProductID,
                                ProductName = product.Name
                            };
                Console.WriteLine("Informacion de productos:");
                foreach(var productInfo in query)
                {
                    Console.WriteLine("Product Id: {0} Product name: {1} ",
                        productInfo.ProductID, productInfo.ProductName);
                }
                Console.ReadKey();
            }*/
            //6
            /*decimal totalDue = 500.00M;
            using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var contacts = context.Contact;
                var orders = context.SalesOrderHeader;

                var query = from contact in contacts
                            from order in orders
                            where contact.ContactID == order.Contact.ContactID
                                    && order.TotalDue < totalDue
                            select new
                            {
                                ContactID = contact.ContactID,
                                LastName = contact.LastName,
                                FirstName = contact.FirstName,
                                OrderID = order.SalesOrderID,
                                Total = order.TotalDue
                            };
                foreach(var smallOrder in query)
                {
                    Console.WriteLine("Contact ID: {0} \t Name: {1}, {2} \t Order ID: {3} " +
                        "\tTotal Due: ${4} ",
                                smallOrder.ContactID, smallOrder.LastName,
                                smallOrder.FirstName, smallOrder.OrderID, smallOrder.Total);
                }
                Console.ReadKey();
            }*/
            //7
            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var contacts = context.Contact;
                var orders = context.SalesOrderHeader;

                var query = from contact in contacts
                            from order in orders
                            where contact.ContactID == order.Contact.ContactID
                            && order.OrderDate >= new DateTime(2002, 10, 1)
                            select new
                            {
                                ContactID = contact.ContactID,
                                LastName = contact.LastName,
                                FirstName = contact.FirstName,
                                OrderID = order.SalesOrderID,
                                OrderDate = order.OrderDate
                            };
                foreach (var order in query)
                {
                    Console.WriteLine("Contact ID: {0} \t Order ID: {3} \t Order date: {4} ",
                        order.ContactID, order.LastName, order.FirstName,
                        order.OrderID, order.OrderDate);
                }
                Console.ReadKey();
            }*/
            //8
            /*int orderQtyMin = 2;
            int orderQtyMax = 6;
            using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from order in context.SalesOrderDetail
                            where order.OrderQty > orderQtyMin
                            && order.OrderQty < orderQtyMax
                            select new
                            {
                                SalesOrderID = order.SalesOrderID,
                                OrderQty = order.OrderQty
                            };
                foreach(var order in query)
                {
                    Console.WriteLine("Order ID: {0} Order quantity: {1}",
                        order.SalesOrderID, order.OrderQty);
                }
                Console.ReadKey();
            }*/
            //9
            /*String color = "Red";
            using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var query = from product in context.Product
                            where product.Color == color
                            select new
                            {
                                Name = product.Name,
                                ProductNumber = product.ProductNumber,
                                ListPrice = product.ListPrice
                            };
                foreach(var product in query)
                {
                    Console.WriteLine("Name: {0}", product.Name);
                    Console.WriteLine("Product Number: {0}", product.ProductNumber);
                    Console.WriteLine("List Price: ${0}", product.ListPrice);
                    Console.WriteLine("");
                }
                Console.ReadKey();
            }*/
            //10
            /*using(AdventureWorksEntities AWEntities = new AdventureWorksEntities())
            {
                int?[] productModelIds = { 19, 26, 118 };
                var products = from p in AWEntities.Product
                               where productModelIds.Contains(p.ProductModelID)
                               select p;
                foreach(var product in products)
                {
                    Console.WriteLine("{0}: {1}",
                        product.ProductModelID, product.ProductID);
                }
                Console.ReadKey();
            }*/
            //11
            /*using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> sortedNames = from n in context.Contact
                                                  orderby n.LastName
                                                  select n;
                Console.WriteLine("Lista ordenada por apellidos:");
                foreach(Contact n in sortedNames)
                {
                    Console.WriteLine(n.LastName);
                }
                Console.ReadKey();
            }*/
            //12
            /*using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Decimal> sortedPrices = from p in context.Product
                                                   orderby p.ListPrice descending
                                                   select p.ListPrice;
                Console.WriteLine("Lista de precios desde el mas alto al mas bajo");
                foreach(Decimal price in sortedPrices)
                {
                    Console.WriteLine(price);
                }
                Console.ReadKey();
            }*/
            //13
            /*using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                IQueryable<Contact> sortedContacts = from contact in context.Contact
                                                     orderby contact.LastName, contact.FirstName
                                                     select contact;
                Console.WriteLine("Contactos ordenados por apellidos luego por nombre:");
                foreach(Contact sortedContact in sortedContacts)
                {
                    Console.WriteLine(sortedContact.LastName + ", " +
                        sortedContact.FirstName);
                }
                Console.ReadKey();
            }*/
            //14
            /*using (AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Style into g
                            select new
                            {
                                Style = g.Key,
                                AverageListPrice = g.Average(product => product.ListPrice)
                            };
                foreach(var product in query)
                {
                    Console.WriteLine("Estilo: {0} Precio promedio: {1}",
                        product.Style, product.AverageListPrice);
                }
                Console.ReadKey();
            }*/
            //15
            /*using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var products = context.Product;
                var query = from product in products
                            group product by product.Color into g
                            select new
                            {
                                Color = g.Key,
                                ProductCount = g.Count()
                            };
                foreach(var product in query)
                    {
                        Console.WriteLine("Color = {0} \t Cantidad = {1}",
                            product.Color, product.ProductCount);
                    }
                    Console.ReadKey();
            }*/
            //16
            using(AdventureWorksEntities context = new AdventureWorksEntities())
            {
                var orders = context.SalesOrderHeader;
                var query = from order in orders
                            group order by order.Contact.ContactID into g
                            select new
                            {
                                Category = g.Key,
                                maxTotalDue = g.Max(order => order.TotalDue)
                            };
                foreach(var order in query)
                {
                    Console.WriteLine("ContactID = {0} \t TotalDue maximo = {1}",
                        order.Category, order.maxTotalDue);
                }
                Console.ReadKey();
            }
        }
    }
}
