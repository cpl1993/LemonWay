using LemonWayBusiness.CustomException;
using Serilog;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LemonWayApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var log = new LoggerConfiguration().WriteTo.Console().CreateLogger();
            FibonnaciServiceWebRef.FibonnaciService fibonnaciService = new FibonnaciServiceWebRef.FibonnaciService();

            log.Information("Please enter a parameter: ");
            var input = Console.ReadLine();

            int numberInput;
            Int32.TryParse(input, out numberInput);

            log.Information($"Fibonnaci result of {input} is {fibonnaciService.Fibonacci(numberInput)}");
            log.Information("Please press a key to exit");

            Console.ReadLine();
        }
    }
}
