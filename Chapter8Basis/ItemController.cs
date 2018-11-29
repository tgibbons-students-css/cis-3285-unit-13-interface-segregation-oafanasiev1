using CrudInterfaces;
using Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8Basis
{
    public class OrderController
    {
        private readonly IRead<Order> reader;
        private readonly ISave<Order> saver;
        private readonly IDelete<Order> deleter;

        public OrderController(IRead<Item> orderReader, ISave<Item> orderSaver, IDelete<Item> orderDeleter)
        {
            reader = orderReader;
            saver = orderSaver;
            deleter = orderDeleter;
        }

        public void CreateOrder(Item item)
        {
            saver.Save(item);
            Console.WriteLine("CreateOrder: Saving order of " + item.product);
        }

        public Order GetSingleOrder(Guid identity)
        {
            Order ord = reader.ReadOne(identity);
            Console.WriteLine("GetSingleOrder: Saving order of " + ord.product);
            return ord;
        }

        public void UpdateOrder(Item item)
        {
            saver.Save(item);
            Console.WriteLine("UpdateOrder: Saving order of " + order.product);
        }

        public void DeleteOrder(Item item)
        {
            deleter.Delete(item);
            Console.WriteLine("DeleteOrder: Delete order of " + item.product);
        }
    }   
}
