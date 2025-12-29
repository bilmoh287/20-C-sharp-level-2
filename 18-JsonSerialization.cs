using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Json;
using System.IO;


[Serializable]
public class Person2
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class JsonSerialization
{
    static void main()
    {
        // Create an instance of the Person class
        Person2 person = new Person2 { Name = "Mohammed Abu-Hadhoud", Age = 30 };


        // JSON serialization
        DataContractJsonSerializer serializer = new DataContractJsonSerializer(typeof(Person2));
        using (MemoryStream stream = new MemoryStream())
        {
            serializer.WriteObject(stream, person);
            string jsonString = System.Text.Encoding.UTF8.GetString(stream.ToArray());


            // Save the JSON string to a file (optional)
            File.WriteAllText("person.json", jsonString);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.json", FileMode.Open))
        {
            Person2 deserializedPerson = (Person2)serializer.ReadObject(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}