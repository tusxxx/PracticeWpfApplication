using System;
using System.Collections.Generic;
using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace PracticeWpfApplication.Database
{
    public class Selling
    {
        public Dictionary<int, int> Cart { get; set; }
        [BsonElement("customerId")]
        public ObjectId CustomerId { get; set; }
        public DateTime OrderDate { get; set; }
        public DateTime DeliveryDate { get; set; }
        public bool IsDiscount { get; set; }
    }
}