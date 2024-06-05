using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Net.Http;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;

namespace TestKnowledgeShare
{
    public class UntestableOrderService
    {
        private readonly EmailService emailService;

        public async Task ProcessOrder(Order order)
        {
            SaveToTHeDb();

            if (order.DistributionType == DistributionType.Courier)
            {
                await TellCourrier(order);
            }

            await emailService.SendEmail(order);

        }

        private static async Task TellCourrier(Order order)
        {
            HttpClient client = new HttpClient();
            var stringContent = new StringContent(order!.ToString());
            await client.PostAsync("https://my.courier.com", stringContent);
        }

        private static void SaveToTHeDb()
        {
            SqlConnection conn = new SqlConnection();
            conn.Open();
            var command = conn.CreateCommand();
            command.CommandText = "Insert into Orders ...";
            command.ExecuteNonQuery();
            conn.Close();
        }
    }
}
