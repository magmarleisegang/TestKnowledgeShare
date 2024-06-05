using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKnowledgeShare
{
    internal class OrderService
    {
        public OrderService() { }
        public Task Process(Order order)
        {
            //validate
            //store in the db
            //check distribution
            //create waybil if required
            //send email
            //notify warehouse
        }
    }
}
