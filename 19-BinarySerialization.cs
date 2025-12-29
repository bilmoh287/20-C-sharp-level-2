using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;


[Serializable]
public class Person3
{
    public string Name { get; set; }
    public int Age { get; set; }
}


class BinarySerialization
{
    static void main()
    {
        // Create an instance of the Person class
        Person3 person = new Person3 { Name = "Mohammed Abu-Hadhoud", Age = 46 };


        // Binary serialization
        BinaryFormatter formatter = new BinaryFormatter();
        using (FileStream stream = new FileStream("person.bin", FileMode.Create))
        {
            formatter.Serialize(stream, person);
        }


        // Deserialize the object back
        using (FileStream stream = new FileStream("person.bin", FileMode.Open))
        {
            Person3 deserializedPerson = (Person3)formatter.Deserialize(stream);
            Console.WriteLine($"Name: {deserializedPerson.Name}, Age: {deserializedPerson.Age}");
            Console.ReadKey();
        }
    }
}

