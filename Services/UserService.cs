using MongoDB.Bson;
using MongoDB.Driver;
using NoBet.Models;

namespace NoBet.Services;

public class UserService
{
    private IMongoCollection<UserMongoModel> userCollection;

    public UserService()
    {
        var client =
            new MongoClient("mongodb+srv://user:user@nobet.xfefuau.mongodb.net/?retryWrites=true&w=majority");
                        
        var database = client.GetDatabase("nobet");
        userCollection = database.GetCollection<UserMongoModel>("User");
    }

    //returns all of the Users from db
    public List<UserMongoModel> Get()
    {
        return userCollection.Find(model => true).ToList();
    }

    //returns user by unique username
    public UserMongoModel GetOneByUsername(String username)
    {
        return userCollection.Find(model => model.Username == username).FirstOrDefault();
    }

    //creates a user from scratch, Id field must be null in order to create new one otherwise it will try to update an existing one
    public string Create(UserMongoModel userMongoModel)
    {
        userCollection.InsertOne(userMongoModel);
        return userMongoModel.Id.ToString();
    }

    //updates a user, usermongomodel has to contain a valid user id
    public string Update(UserMongoModel userMongoModel)
    {
        userCollection.ReplaceOne(model => model.Id == userMongoModel.Id, userMongoModel);
        return userMongoModel.Id.ToString();
    }
    
    //deletes user by its id
    public void Delete(ObjectId id)
    {
        userCollection.DeleteOne(model => model.Id == id);
    }
}