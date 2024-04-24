using MongoDB.Bson;
using MongoDB.Bson.Serialization.Attributes;

namespace StockSavvy.Models;

public class BetMongoModel
{
    [BsonId]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId Id { get; set; }

    [BsonElement("UserId")]
    [BsonRepresentation(BsonType.ObjectId)]
    public ObjectId UserId { get; set; }
    
    [BsonElement("Status")]
    [BsonRepresentation(BsonType.Boolean)]
    public bool Status { get; set; }
    
    [BsonElement("Matches")]
    //this list contaions id of stocks that part of this particular portfolio
    public List<string> Matches { get; set; }

    public BetMongoModel()
    {
        Matches = new List<string>();
    }
}