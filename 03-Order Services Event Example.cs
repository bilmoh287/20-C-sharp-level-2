using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _03_Order_Services_Event_Example
    {
        public class OrderEventArgs : EventArgs
        {
            public int OrderID;
            public int OrderPrice;
            public string ClientEmial;

            public OrderEventArgs(int OrderID, int OrderPrice, string ClientEmail)
            {
                this.OrderID = OrderID;
                this.OrderPrice = OrderPrice;
                this.ClientEmial = ClientEmail;
            }
        }

        public class Order
        {
            public event EventHandler<OrderEventArgs> OrderCreated;

            public void Create(int OrderID, int OrderPrice, string ClientEmail)
            {
                Console.WriteLine("New Order Created now we will notify subcribers by Raising the Event!\n");
                if (OrderCreated != null)
                {
                    OrderCreated(this, new OrderEventArgs(OrderID, OrderPrice, ClientEmail));
                }
            }
        }
        public class EmailService
        {
            public void Subscribe(Order order)
            {
                order.OrderCreated += HandleNewOrder;
            }
            public void UnSubscribe(Order order)
            {
                order.OrderCreated -= HandleNewOrder;
            }

            private void HandleNewOrder(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"__________Email_________");
                Console.WriteLine($"Emial Object recieved a new Order Event");
                Console.WriteLine($"OrderID     : {e.OrderID}");
                Console.WriteLine($"OrderPrice  : {e.OrderPrice}");
                Console.WriteLine($"ClientEmail : {e.ClientEmial}");
                Console.WriteLine("\nSend Email");
                Console.WriteLine("__________________________");
                /*
                  here we write send email code or whatever;
                */
                Console.WriteLine();
            }
        }
        public class SMSService
        {
            public void Subscribe(Order order)
            {
                order.OrderCreated += HandleNewOrder;
            }
            public void UnSubscribe(Order order)
            {
                order.OrderCreated -= HandleNewOrder;
            }

            private void HandleNewOrder(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"__________SMS_________");
                Console.WriteLine($"SMS Object recieved a new Order Event");
                Console.WriteLine($"OrderID     : {e.OrderID}");
                Console.WriteLine($"OrderPrice  : {e.OrderPrice}");
                Console.WriteLine($"ClientEmail : {e.ClientEmial}");
                Console.WriteLine("\nSend SMS");
                Console.WriteLine("__________________________");
                /*
                  here we write send SMS code or whatever;
                */
                Console.WriteLine();
            }
        }
        public class ShippingService
        {
            public void Subscribe(Order order)
            {
                order.OrderCreated += HandleNewOrder;
            }
            public void UnSubscribe(Order order)
            {
                order.OrderCreated -= HandleNewOrder;
            }

            private void HandleNewOrder(object sender, OrderEventArgs e)
            {
                Console.WriteLine($"__________Shipping_________");
                Console.WriteLine($"Shipping Object recieved a new Order Event");
                Console.WriteLine($"OrderID     : {e.OrderID}");
                Console.WriteLine($"OrderPrice  : {e.OrderPrice}");
                Console.WriteLine($"ClientEmail : {e.ClientEmial}");
                Console.WriteLine("\nShipping");
                Console.WriteLine("____________________________");
                /*
                  here we write send SMS code or whatever;
                */
                Console.WriteLine();
            }
        }

        public class Program
        {
            static void main(string[] args)
            {
                Order order = new Order();
                EmailService emailService = new EmailService();
                SMSService smsService = new SMSService();
                ShippingService shippingServise = new ShippingService();

                emailService.Subscribe(order);
                smsService.Subscribe(order);
                shippingServise.Subscribe(order);

                order.Create(10, 550, "bilmoh287@gamil.com");

                //shipppin unsubscribes from order
                shippingServise.UnSubscribe(order);
                order.Create(12, 300, "bilmoh287@gamil.com");

                //creating order2 and emailService subscribes for it
                Order order2 = new Order();
                emailService.Subscribe(order2);

                order2.Create(15, 1000, "Exex@gmail.com");

            }
        }
    }
}
