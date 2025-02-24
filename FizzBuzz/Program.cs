using System;
using System.Data;
using Microsoft.VisualBasic;

namespace FizzBuzz;

public class FizzBuzz
{
    public static void Main()
    {   Console.WriteLine("Hello World");
        FizzBuzz.GetFizzBuzzOutput(101);
    }

    public static void GetFizzBuzzOutput(int number) {

            for(var i=1; i<number;i++){
                if(i%3==0 && i%5==0){
                    Console.WriteLine("FizzBuzz");
                }
                else if(i%3==0){
                    Console.WriteLine("Fizz");
                } else if (i%5==0){
                    Console.WriteLine("Buzz");
                } else {
                    Console.WriteLine(i);
                }
            }
    }
    


}



