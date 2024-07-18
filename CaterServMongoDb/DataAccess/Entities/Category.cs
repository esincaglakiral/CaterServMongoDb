using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace CaterServMongoDb.DataAccess.Entities
{
    public class Category
    {
        [BsonId]
        [BsonRepresentation(BsonType.ObjectId)]  //mongo db olduğu için id string formatta olur. bunları da dahil ederiz, Mongodriver paketini dahil etmeliyiz
        public string CategoryId { get; set; }
        public string CategoryName { get; set; }


        [BsonIgnore]
        public List<Product> Products { get; set; }
    }
}
