using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;

class Program
{
    public class User
    {
        public required string Name { get; set; }
        public int Age { get; set; }
        public required string City { get; set; }
    }

    public class UserTypes : User
    {
        public string Type { get; set; }
    }

    static void Main(string[] args)
    {
        // Deserialize the first JSON file into a list of User objects
        string filePath = "data.json";
        string jsonData = File.ReadAllText(filePath);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

        // Deserialize the second JSON file into a list of UserTypes objects
        filePath = "user_types.json";
        jsonData = File.ReadAllText(filePath);
        List<UserTypes> userTypes = JsonConvert.DeserializeObject<List<UserTypes>>(jsonData);

        // Print the list of UserTypes
        foreach (var user in userTypes)
        {
            Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}\nCity: {user.City}\nType: {user.Type}\n");
        }
    }
}
