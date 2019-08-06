using System;
using System.Collections.Generic;
 
namespace Boxing
{
    class Program
    {
        static void Main(string[] args)
        {
            List<object> boxarray = new List<object>();
            boxarray.Add(7);
            boxarray.Add(28);
            boxarray.Add(-1);
            boxarray.Add(true);
            boxarray.Add("chair");


            int sum = 0;

            for(int i = 0; i < boxarray.Count; i++){

                Console.WriteLine("array element " + i + " = " + boxarray[i]);

                if(boxarray[i] is int){
                    int add = (int) boxarray[i];
                    sum += add;
                }
            }

            Console.WriteLine("Sum of all integers: " + sum);
        }
    }
}
