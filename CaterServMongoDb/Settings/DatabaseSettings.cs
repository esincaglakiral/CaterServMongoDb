namespace CaterServMongoDb.Settings
{
    public class DatabaseSettings : IDatabaseSettings  //vertabanına yansıtacağımız entityler
    {
        public string ConnectionString { get; set; }
        public string DatabaseName { get; set; }
        public string CategoryCollectionName { get; set; }
        public string ProductCollectionName { get; set; }
    }
}
