using System;
using System.Collections.Generic;
using System.Linq;
using Project_1___Bakkerij.Data;
using Project_1___Bakkerij.Models;

namespace Project_1___Bakkerij.Services
{
    public class OrderService
    {
        private readonly ContosoBreadContext _context;

        public OrderService(ContosoBreadContext context)
        {
            _context = context;
        }

        public List<OrderModel> GetAllOrders()
        {
            return _context.Orders.ToList();
        }

        public void CreateOrder(OrderModel order)
        {
            _context.Orders.Add(order);
            _context.SaveChanges();
        }

        public void UpdateOrder(OrderModel order)
        {
            _context.Orders.Update(order);
            _context.SaveChanges();
        }

        public void DeleteOrder(int orderId)
        {
            var order = _context.Orders.Find(orderId);
            if (order != null)
            {
                _context.Orders.Remove(order);
                _context.SaveChanges();
            }
        }

        public void PurgeOrdersAfterTime()
        {
            // Bepaal de tijd voor het purgen (14:30)
            var purgeTime = DateTime.Today.AddHours(14).AddMinutes(30);

            // Verwijder bestellingen die vóór de purge-tijd zijn geplaatst
            var ordersToDelete = _context.Orders.Where(o => o.OrderDate < purgeTime).ToList();
            _context.Orders.RemoveRange(ordersToDelete);
            _context.SaveChanges();
        }
    }
}
