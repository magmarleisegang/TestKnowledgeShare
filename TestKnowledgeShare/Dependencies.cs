using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestKnowledgeShare
{
    public interface IDatabaseService
    {
        Task<Order> SaveToDb(Order order);
    }

    public interface IDistributionService
    {
        Task PrepareWaybil(Order order);
    }

    public interface IUserCommunications
    {
        Task NotifyUserOfCompletedOrder(Order order);
    }

    public interface IWarehouse
    {
        Task CreateWarehouseJobcard(Order order);
    }
}
