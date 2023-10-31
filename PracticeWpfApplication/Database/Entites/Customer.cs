using System.Linq;
using MongoDB.Bson.Serialization.Attributes;

namespace PracticeWpfApplication.Database
{
    [BsonIgnoreExtraElements]
    public class Customer
    {
        [BsonElement("name")]
        public string Name { get; set; }
        [BsonElement("surname")]
        public string Surname { get; set; }
        [BsonElement("patronymic")]
        public string Patronymic { get; set; }
        [BsonElement("address")]
        public string Address { get; set; }
        [BsonElement("phone")]
        public string Phone { get; set; }
        [BsonElement("email")]
        public string Email { get; set; }
        [BsonElement("isRegular")]
        public bool IsRegular { get; set; }
        [BsonElement("boughtAmount")]
        public float BoughtAmount { get; set; }

        public override string ToString()
        {
            var propertyStrings = from prop in GetType().GetProperties()
                select $"{prop.Name}={prop.GetValue(this)}";
            return string.Join(", ", propertyStrings);
        }
    }
}