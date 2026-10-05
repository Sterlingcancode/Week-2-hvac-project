using System;
using System.Reflection; 

namespace HVACProject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("==================================================");
            Console.WriteLine("   HVAC Redesign Portal - Week 2 Test             ");
            Console.WriteLine("==================================================\n");

            // Instantiate the extended class
            SmartHVACUnit smartUnit1 = new SmartHVACUnit(
                brand: "Carrier",
                modelNumber: "Infinity 26",
                systemType: "Heat Pump",
                tonnage: 3.5,
                seerRating: 24.0,
                isWifiEnabled: true
            );

            // Print the interface diagnostic method
            Console.WriteLine("--- System Diagnostics ---");
            Console.WriteLine(smartUnit1.RunSystemDiagnostics());
            Console.WriteLine();

            // Print properties using Reflection
            Console.WriteLine("--- Reflection Properties Output ---");
            printProperties(smartUnit1);
            
            Console.WriteLine("\n==================================================");
        }

        // Week 2 Requirement: Print properties using Reflection
        static void printProperties(object obj)
        {
            Type type = obj.GetType();
            PropertyInfo[] properties = type.GetProperties();

            foreach (PropertyInfo prop in properties)
            {
                Console.WriteLine($"{prop.Name}: {prop.GetValue(obj)}");
            }
        }
    }
}