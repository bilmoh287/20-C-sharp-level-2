using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_sharp_lever_2
{
    public class _45_Task_Class_With_Call_back_Event_Example2
    {
        // 1️ Event data
        public class PaymentEventArgs : EventArgs
        {
            public int PaymentId { get; }
            public decimal Amount { get; }

            public PaymentEventArgs(int paymentId, decimal amount)
            {
                PaymentId = paymentId;
                Amount = amount;
            }
        }

        class Program
        {
            // 2️ Delegate (callback contract)
            public delegate void PaymentCompletedHandler(object sender, PaymentEventArgs e);

            // 3️ Event (MULTI-cast callback)
            public static event PaymentCompletedHandler PaymentCompleted;

            static async Task Main()
            {
                // 4️ Subscribe MULTIPLE handlers
                PaymentCompleted += SendEmail;
                PaymentCompleted += SendSMS;
                PaymentCompleted += SaveToDatabase;

                Console.WriteLine("Processing payment...\n");

                // 5️ ONE async task
                await ProcessPaymentAsync(PaymentCompleted);

                Console.WriteLine("\nAll callbacks executed.");
                Console.ReadKey();
            }

            // 6️ Async operation (runs ONCE)
            static async Task ProcessPaymentAsync(PaymentCompletedHandler callback)
            {
                await Task.Delay(2000); // simulate payment processing

                var args = new PaymentEventArgs(101, 500);

                // 7️⃣ Notify ALL subscribers
                callback?.Invoke(null, args);
            }

            // 8️ Multiple callback targets

            static void SendEmail(object sender, PaymentEventArgs e)
            {
                Console.WriteLine($"📧 Email sent for Payment {e.PaymentId} | Amount: {e.Amount}");
            }

            static void SendSMS(object sender, PaymentEventArgs e)
            {
                Console.WriteLine($"📱 SMS sent for Payment {e.PaymentId}");
            }

            static void SaveToDatabase(object sender, PaymentEventArgs e)
            {
                Console.WriteLine($"💾 Payment {e.PaymentId} saved to DB");
            }
        }
    }
}
