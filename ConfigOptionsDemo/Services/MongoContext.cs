using ConfigOptionsDemo.Models;
using Microsoft.Extensions.Options;

namespace ConfigOptionsDemo.Services
{
    public class MongoContext
    {
        private MongoDbSettings _mongoSettings;
        public MongoContext(IOptionsSnapshot<MongoDbSettings> optionsSnapshot)
        {
            _mongoSettings = optionsSnapshot.Value;
        }

        public void InsertMongo()
        {
            Console.WriteLine("Mongo Feature Toggle : " + _mongoSettings.FeatureToggle);
        }
    }
}
