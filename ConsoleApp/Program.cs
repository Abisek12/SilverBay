using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;
namespace ConsoleApp
{
    public  class Program
    {
        static void Main(string[] args)
        {
            var student = new Student(1,"Abisek","Kharel",25,"male",'B');
            PrintObjectProperties(student);
            
        }
        public static void PrintObjectProperties(Student obj)
        {
            Type t = typeof(Student);
            var props = t.GetProperties(BindingFlags.NonPublic | BindingFlags.Instance);
            foreach (var prop in props)
            {
                Console.WriteLine(prop.Name + " -  " + prop.GetValue(obj, null)+ " " + "DataType "+ " - " + prop.PropertyType);    
            }           
        }
    }
}
