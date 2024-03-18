using BookApp.Data;
using BookApp.Forms.DTO;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookApp.Forms.Services.Admin
{
    public class OrdersUtility
    {
        private readonly BookAppContext dbContext;

        public OrdersUtility(BookAppContext dbContext)
        {
            this.dbContext = dbContext;
        }

        public List<OrdersDTO> FilterOrdersByStatus(int statusId)
        {
            var filteredOrders = dbContext.Orders
               .Where(o => o.StatusId == statusId)
               .Select(o => new OrdersDTO
               {
                   OrderId = o.OrderId,
                   CustomerName = o.User.FirstName + " " + o.User.LastName,
                   DateOrder = o.DateOrder,
                   BookOrder = string.Join(", ", o.BookOrders.Select(b =>
                       $"{b.Book.Title}{(b.Quantity > 1 ? $" ({b.Quantity} бр.)" : "")}")),
                   TotalPrice = o.BookOrders.Sum(b => b.Quantity * b.Book.Price),
                   Status = o.StatusOrder.StatusName
               })
			   .OrderByDescending(o => o.DateOrder)
		       .ThenBy(o => o.OrderId)
			   .ThenBy(o => o.CustomerName)
			   .ThenByDescending(o => o.Status)
			   .ToList();

            return filteredOrders;
        }

        public void GetOrdersFromDatabase(DataGridView dataGridView)
        {
            var orders = dbContext.Orders
                .Select(o => new OrdersDTO
                {
                    OrderId = o.OrderId,
                    CustomerName = o.User.FirstName + " " + o.User.LastName,
                    DateOrder = o.DateOrder,
                    BookOrder = string.Join(", ", o.BookOrders.Select(b =>
                        $"{b.Book.Title}{(b.Quantity > 1 ? $" ({b.Quantity} бр.)" : "")}")),
                    TotalPrice = o.BookOrders.Sum(b => b.Quantity * b.Book.Price),
                    Status = o.StatusOrder.StatusName
                })
                .OrderByDescending(o => o.DateOrder)
                .ThenBy(o => o.OrderId)
                .ThenBy(o => o.CustomerName)
                .ThenByDescending(o => o.Status)
                .ToList();

            DataGridViewUtility.LoadFilterOrdersToDataGridView(dataGridView, orders);
        }

        public bool UpdateOrderStatus(int orderId, int statusId)
        {
            try
            {
                var order = dbContext.Orders.FirstOrDefault(o => o.OrderId == orderId);
                if (order != null)
                {
                    order.StatusId = statusId;
                    dbContext.SaveChanges();

                    return true;
                }

                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error updating order status: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
    }
}
