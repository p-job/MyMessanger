using System;
using Newtonsoft.Json;

namespace MyMessanger
{
    class Program
    {
        static void Main(string[] args)
        {
            Message msg = new Message("Paul", "Hello", DateTime.UtcNow);
            string output = JsonConvert.SerializeObject(msg);
            Console.WriteLine(output);
            Message deserializedMsg = JsonConvert.DeserializeObject<Message>(output);
            Console.WriteLine(deserializedMsg);

            //{ "UserName":"Paul","MessageText":"Hello","TimeStamp":"2021-07-18T22:00:33.9904406Z"}
            //Paul < 18.07.2021 22:00:33 >: Hello
        }
    }
}
