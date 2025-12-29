using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;


[Serializable]
public class Person
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class Program
{
    static void main()
    {
        // Create an instance of the Person class
        Person person = new Person { Name = "Mohammed Abu-Hadhoud", Age = 46 };


        // XML serialization
        XmlSerializer serializer = new XmlSerializer(typeof(Person));
        using (TextWriter writer = new StreamWriter("person.xml"))
        {
            serializer.Serialize(writer, person);
        }


        // Deserialize the object back
        using (TextReader reader = new StreamReader("person.xml"))
        {
            Person deserializedPerson = (Person)serializer.Deserialize(reader);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
        }
    }
}
