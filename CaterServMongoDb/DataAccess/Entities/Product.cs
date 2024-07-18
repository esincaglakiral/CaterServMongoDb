using MongoDB.Bson.Serialization.Attributes;
using MongoDB.Bson;

namespace CaterServMongoDb.DataAccess.Entities
{
    public class Product
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  //mongo db olduğu için id string formatta olur. bunları da dahil ederiz
        public string ProductId { get; set; }
        public string ProductName { get; set; }
        public string ImageUrl { get; set; }
        public decimal Price { get; set; }
        public string Description { get; set; }


        public string CategoryName { get; set; }

        [BsonIgnore] //tabloları oluşturduğumuz zaman böyle bir alan (column) oluşturmaması için bunu kullanırız yani amacımız sadece category tablosuna erişmek
        public Category Category { get; set; }
    }
}
