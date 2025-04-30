using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;

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
        string filePath = "data.json";

        // Read the JSON file and deserialize it into a list of User objects
        string jsonData = File.ReadAllText(filePath);
        List<User> users = JsonConvert.DeserializeObject<List<User>>(jsonData);

        // Print the list of users
        foreach (var user in users)
        {
            Console.WriteLine($"Name: {user.Name}\nAge: {user.Age}\nCity: {user.City}\n");
        }

    }
}
