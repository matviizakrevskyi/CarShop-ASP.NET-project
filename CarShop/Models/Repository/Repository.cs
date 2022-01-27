﻿using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;

namespace CarShop.Models.Repository
{
    public class Repository
    {
        private EFDbContext context = new EFDbContext();

        public IEnumerable<Product> Products
        {
            get 
            {
                context.IfObjects();
                return context.Products; 
            }
        }

        //wczytywanie tabeli orders
        public IEnumerable<Order> Orders
        {
            get
            {
                return context.Orders
                    .Include(o => o.OrderLines.Select(ol => ol.Product));
            }
        }

        public void SaveProduct(Product product)
        {
            if (product.ProductId == 0)
            {
                product = context.Products.Add(product);
            }
            else
            {
                Product dbGame = context.Products.Find(product.ProductId);
                if (dbGame != null)
                {
                    dbGame.Name = product.Name;
                    dbGame.Description = product.Description;
                    dbGame.Price = product.Price;
                    dbGame.Category = product.Category;
                }
            }
            context.SaveChanges();
        }

        public void DeleteProduct(Product product)
        {
            IEnumerable<Order> orders = context.Orders
                .Include(o => o.OrderLines.Select(ol => ol.Product))
                .Where(o => o.OrderLines
                    .Count(ol => ol.Product.ProductId == product.ProductId) > 0)
                .ToArray();

            foreach (Order order in orders)
            {
                context.Orders.Remove(order);
            }
            context.Products.Remove(product);
            context.SaveChanges();
        }

        // Sachovac dane w bazie
        public void SaveOrder(Order order)
        {
            if (order.OrderId == 0)
            {
                order = context.Orders.Add(order);

                foreach (OrderLine line in order.OrderLines)
                {
                    context.Entry(line.Product).State
                        = EntityState.Modified;
                }

            }
            else
            {
                Order dbOrder = context.Orders.Find(order.OrderId);
                if (dbOrder != null)
                {
                    dbOrder.Name = order.Name;
                    dbOrder.Line1 = order.Line1;
                    dbOrder.Line2 = order.Line2;
                    dbOrder.Line3 = order.Line3;
                    dbOrder.City = order.City;
                    dbOrder.GiftWrap = order.GiftWrap;
                    dbOrder.Dispatched = order.Dispatched;
                }
            }
            context.SaveChanges();
        }
    }
}