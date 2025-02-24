using System;
using System.Data;
using Microsoft.VisualBasic;

namespace FizzBuzz;

public class FizzBuzz
{
    public static void Main(){
        int limit = GetValidMaxNumber("Please enter the max number limit: ");
        for (var i=1; i <limit;i++){
        Console.WriteLine(GetFizzBuzzOutput(i));
         }
    }

    public static int GetValidMaxNumber(string prompt){
            int result;
            bool isValid;

            do
            {
                Console.WriteLine(prompt);
                string? input = Console.ReadLine();
                isValid = int.TryParse(input, out result);

                if(!isValid){
                    Console.WriteLine("Invalid input. Please enter a valid integer.");
                }
            } while(!isValid);
            
            return result;
    }
    public static string GetFizzBuzzOutput(int number){
        Dictionary<int, string> rules  = new Dictionary<int, string> {
            {3,"Fizz"},{13,"Fezz"}, {5,"Buzz"}, {7,"Bang"} 
        };

        var output = new List<string>{};
        string result = "";

        foreach (var rule in rules){
            if(number%rule.Key==0){
                output.Add(rule.Value);
            }
        }

        if(number%11==0){
            output.Clear();
            if(number%13==0){
                output.Add("Fezz");
            }
            output.Add("Bong");
        }

        if(number%17==0){
            output.Reverse();
            }
        if(output.Count==0){
            result = number.ToString();
            } else {
            result = string.Join("",output);
            };

     
        return result ; 
    }

}



