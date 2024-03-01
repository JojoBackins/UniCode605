using System;
using System.IO;
using System.Text;
using System.Text.Json;
class Program
{
    static void Main(string[] args)
    {
        //File.WriteAllText("eureka.txt", "ש ", Encoding.Unicode);
        //byte[] eurekaBytes = File.ReadAllBytes("eureka.txt");
        //foreach (byte b in eurekaBytes) Console.Write("{0} ", b); // 2 numbers
        //Console.WriteLine(Encoding.UTF8.GetString(eurekaBytes));

        //Console.WriteLine("Hellow ש");

        //foreach (byte b in eurekaBytes) Console.Write("{0:x2} ", b); //16 numbers
        //Console.WriteLine();

        //Console.WriteLine(JsonSerializer.Serialize("ש")); //UTF-16
        //File.WriteAllText("elephant1.txt", "\uD83D\uDC18");
        //File.WriteAllText("elephant2.txt", "\U0001F418");

        int intValue = 48769414;
        string stringValue = "Hellow";
        byte[] byteArray = { 47, 129, 0, 116 };
        float floatValue = 491.695F;
        char charValue = 'E';

        using (var output = File.Create("binarydata.dat"))
        using (var writer = new BinaryWriter(output))
        {
            writer.Write(intValue);
            writer.Write(stringValue);
            writer.Write(byteArray);
            writer.Write(floatValue);
            writer.Write(charValue);
        }

        byte[] dataWritten = File.ReadAllBytes("binarydata.dat");
        foreach (byte b in dataWritten)
            Console.Write("{0:x2} ", b);
        Console.WriteLine(" - {0} bytes", dataWritten.Length);
    }
}