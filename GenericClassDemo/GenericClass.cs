using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo
{
    
    internal class GenericClass<T>
    {
        //Generic Method
        //public void Add<T>(T a, T b)
        //{
        //    dynamic d1 = a;
        //    dynamic d2 = b;
        //    Console.WriteLine("Add = " + (d1 + d2));
        //}
        //public void Sub<T>(T a, T b)
        //{
        //    dynamic d1 = a;
        //    dynamic d2 = b;
        //    Console.WriteLine("Sub = " + (d1 - d2));
        //}
        //public void Mul<T>(T a, T b)
        //{
        //    dynamic d1 = a;
        //    dynamic d2 = b;
        //    Console.WriteLine("Mul = " + (d1 * d2));
        //}
        //public void Div<T>(T a, T b)
        //{
        //    dynamic d1 = a;
        //    dynamic d2 = b;
        //    Console.WriteLine("Div = " + (d1 / d2));
        //}

        public void Add(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Add = " + (d1 + d2));
        }
        public void Sub(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Sub = " + (d1 - d2));
        }
        public void Mul(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Mul = " + (d1 * d2));
        }
        public void Div(T a, T b)
        {
            dynamic d1 = a;
            dynamic d2 = b;
            Console.WriteLine("Div = " + (d1 / d2));
        }



    }
}
