# NuGET, JSON
Version 0.1
- Created "data.json" file which holds an array of json objects
- Set the json file to always copy to output path in the properties tab
- json object format:
    - Name: String
    - Age: Int
    - City: String
Version 0.2
- Imported libraries:
    - Newtonsoft.Json: used to handle json files
    - System: for basic functions
    - System.IO: used for reading files and writing files
    - System.Collections.Generic: Used for Lists
- Created the main class Program
- Created a public class named User which holds the json object with the following variables:
    - public required string Name {get; set}
    - public int Age {get; set}
    - public required string City {get; set}
- Created the Main function:
    - read the "data.json" file
    - Deserialized the json objects into a User class list
    - Printed out the deserialized json objects
Version 0.3
- Created public class UserTypes which inherits the class User and holds the following variables:
    - public string Type {get; set}