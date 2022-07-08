using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassDemo
{
    internal class Generic1
    {
        public bool compare(object a, object b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }

        //generic method
        public bool Genericcompare<T>(T a, T b)
        {
            if (a.Equals(b))
                return true;
            return false;
        }


        //public bool compare(float a, float b)
        //{
        //    if (a == b)
        //        return true;
        //    return false;
        //}

        static void Main(string[] args)
        {
            Generic1 generic1 = new Generic1();
           bool res =  generic1.compare(1, 1);
            Console.WriteLine("Result = " + res);
            //result will be false

            bool res4 = generic1.compare(1.0, 1.0f);
            Console.WriteLine("Result = " + res4);

            bool res2 = generic1.Genericcompare<int>(1, 1);
            Console.WriteLine("Result = " + res2);



            bool res3 = generic1.Genericcompare<float>(1.0f, 1.0f);
            Console.WriteLine("Result = " + res3);


            //GenericClass go = new GenericClass();
            //go.Add<int>(12, 20);
            //go.Sub<int>(12, 20);
            //go.Mul<int>(12, 20);
            //go.Div<int>(12, 20);

            GenericClass<int> go = new GenericClass<int>();
            go.Add(12, 20);
            go.Sub(12, 20);
            go.Mul(12, 20);
            go.Div(12, 20);








            //bool res1 = generic1.compare(1.0f, 1.0f);
            //Console.WriteLine("Result = " + res1);


            Console.ReadLine();

        }
    }
}
