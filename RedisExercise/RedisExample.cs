using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using ServiceStack.Redis;
using ServiceStack.Redis.Generic;

namespace RedisExercise
{
    class RedisExample
    {
        static void Main(string[] args)
        {

            #region RedisBasicGetSetExample

            //using (IRedisNativeClient client = new RedisClient())
            //{
            //    client.Set("urn:messages:1", Encoding.UTF8.GetBytes("Hello c# world"));
            //}

            //using (IRedisNativeClient client = new RedisClient())
            //{
            //    var result = client.Get("urn:messages:1");
            //    Console.Write(Encoding.UTF8.GetString(result));
            //}

            #endregion

            #region RedisListExample

            //using (IRedisClient client = new RedisClient())
            //{

            //    var customerNames = client.Lists["urn:customernames"];

            //    customerNames.Add("Cagatay");
            //    customerNames.Add("Kuthay");
            //    customerNames.Add("Omer");

            //}

            //using (IRedisClient client = new RedisClient())
            //{
            //    var customerNames = client.Lists["urn:customernames"];

            //    foreach (var customerName in customerNames)
            //    {
            //        Console.WriteLine(customerName);
            //    }
            //}


            #endregion

            #region RedisObjectExample

            //long lastId = 0;
            //using (IRedisClient client = new RedisClient())
            //{
            //    IRedisTypedClient<Customer> customerClient = client.As<Customer>();

            //    Customer customer = new Customer()
            //    {
            //        Id = customerClient.GetNextSequence(),
            //        Address = "123 Main st",
            //        Name = "Bob Green",
            //        Orders = new List<Order>
            //        {
            //            new Order {OrderNumber = "AB123"},
            //            new Order {OrderNumber = "AB1234"}

            //        }
            //    };

            //    var storedCustomer = customerClient.Store(customer);
            //    lastId = storedCustomer.Id;
            //}

            //using (IRedisClient client = new RedisClient())
            //{
            //    var customerClient = client.As<Customer>();
            //    var customer = customerClient.GetById(lastId);

            //    Console.WriteLine("Got customer {0}, with name {1}", customer.Id, customer.Name);

            //}

            #endregion

            #region RedisTransactionExample

            //using (IRedisClient client = new RedisClient())
            //{
            //    var transaction = client.CreateTransaction();

            //    transaction.QueueCommand(c => c.Set("abc", 1));
            //    transaction.QueueCommand(c => c.Increment("abc", 1));

            //    transaction.Commit();

            //    var result = client.Get<int>("abc");

            //    Console.WriteLine(result);

            //}


            #endregion

            #region RedisPublishToConsoleExample

            //using (IRedisClient client = new RedisClient())
            //{
            //    client.PublishMessage("debug", "Hello C#");
            //}


            #endregion

            #region RedisSubscribeToRedisConsoleExample

            //using (IRedisClient client = new RedisClient())
            //{
            //    var sub = client.CreateSubscription();
            //    sub.OnMessage = (c, m) => Console.WriteLine("Got message: {0}, from channel {1}", c, m);

            //    sub.SubscribeToChannels("news");
            //}

            #endregion


            Console.ReadKey();
        }

        public class Customer
        {
            public long Id { get; set; }
            public string Name { get; set; }
            public string Address { get; set; }
            public List<Order> Orders { get; set; }
        }

        public class Order
        {
            public string OrderNumber { get; set; }
        }
    }
}
