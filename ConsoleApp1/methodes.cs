using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{
    class MyClass
    {
        private string field = null;

        public void SetField(string value)
        {
            if (value == "fool")
                field = "";
            else
                field = value;
        }

        public string GetField()
        {
            return field;
        }
    }

    class Program
    {
        static void Main()
        {
            MyClass instance = new MyClass();

            instance.SetField("Hello World!");

            string @string = instance.GetField();

            Console.WriteLine(@string);
            Console.ReadKey();
        }
    }
}
