using System.Collections.Generic;

namespace Katas
{
    public class FizzBuzzTDD
    {
        /**
            Escribe un programa que imprima los números del 1 al 100, 
            pero aplicando las siguientes normas:
            Devuelve Fizz si el número es divisible por 3.
            Devuelve Buzz si el número es divisible por 5.
            Devuelve FizzBuzz si el número es divisible por 3 y por 5.
        */

        public static object ShowNumber(int n)
        {
            if (n%3==0 && n%5==0)
            {
                return "FizzBuzz";
            }
            if (n%3==0)
            {
                return "Fizz";
            }
            if (n%5==0)
            {
                return "Buzz";
            }            
            return n;                
        }

        public static List<object> FizzBuzz()
        {
            List<object> list = new List<object>();
            for(int i = 1; i <= 100; i++)
            {                
                list.Add(ShowNumber(i));
            }
            return list;
        }
        
    }
}
