using System;

namespace Dictionary
{
    using System;
    using System.Reflection;

    public class MyClass
    {
        public int MyProperty { get; set; }
        public void MyMethod()
        {
            Console.WriteLine("Hello, world!");
        }
    }

    public class Program
    {
        public static void Main()
        {
            Type type = typeof(MyClass);
            PropertyInfo property = type.GetProperty("MyProperty");
            MethodInfo method = type.GetMethod("MyMethod");
            
            Console.WriteLine("Property: " + property.ToString());
            Console.WriteLine("Method: " + method.Name);
        }
    }

}
