using ExercicioPropostoComposicoes.Entities.Enums;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace ExercicioPropostoComposicoes.Entities
{
    class Order
    {
        public DateTime Moment { get; set; }
        public OrderStatus Status { get; set; }
        public List<OrderItem> Items { get; set; } = new List<OrderItem>();
        public Client Client { get; set; }

        public Order(OrderStatus status, Client client)
        {
            Moment = DateTime.Now;
            Status = status;
            Client = client;
        }

        public void AddItem(OrderItem item)
        {
            Items.Add(item);
        }

        public void RemoveItem(OrderItem item)
        {
            Items.Remove(item);
        }

        public double Total()
        {
            double total = 0.00;
            foreach (OrderItem i in Items)
            {
                total += (i.Price * i.Quantity);
            }
            return total;
        }

        public override string ToString()
        {
            StringBuilder stringBuilder = new StringBuilder();
            stringBuilder.AppendLine($"Order moment: {Moment.ToString("dd/MM/yyyy")}");
            stringBuilder.AppendLine($"Order status: {Status.ToString()}");
            stringBuilder.AppendLine($"Client: {Client}");
            stringBuilder.AppendLine("Order items:");
            foreach(OrderItem o in Items)
            {
                stringBuilder.AppendLine(o.ToString());
            }
            stringBuilder.AppendLine($"Total price: {Total().ToString("F2", CultureInfo.InvariantCulture)}");

            return stringBuilder.ToString();
        }
    }
}
