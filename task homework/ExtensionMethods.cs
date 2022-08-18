using System;
using System.Collections.Generic;
using System.Text;

namespace task_homework
{
   static class ExtensionMethods
    {
        public static bool Isodd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
             return false;
            
        }
        public static bool IsEven(this int num)
        {
            if (num % 2 == 0) 
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit( this string str)
        {
            foreach (var item in str)
            {
            if(47<item && item<58)
            {
               return true;
            }
               
            }
            return false;
           
        
        }
        public static string ToCapitalize(this string str)
        {
            StringBuilder n = new StringBuilder();
            n.Append(char.ToUpper(str[0]));
            n.Append(str.Substring(1).ToLower());
            return  n.ToString();
            
        }
        public static int[] GetValueIndexes(this string str,char m)
        {
            int [] arr =new int[0];
            for (int i = 0; i < str.Length; i++) 
            {
                if (str[i] == m)
                {


                    Array.Resize<int>(ref arr, arr.Length + 1);
                    arr[arr.Length - 1] = i;
                    
                }
              
            }

            return arr;
        }

    }
}
