﻿using System;

namespace task_homework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(23.Isodd());
            Console.WriteLine(23.IsEven());
            Console.WriteLine("Apple".IsContainsDigit());
            Console.WriteLine("appLe".ToCapitalize());

            int[] arr = "iPhone".GetValueIndexes('m');
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(i);
            }
        } 
        
    }
}
