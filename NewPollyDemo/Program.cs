using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using Polly;

namespace NewPollyDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            for (var i = 0; i < 24; i++)
            {
                Console.WriteLine($"Polly Demo Attempt {i}");
                Console.WriteLine("-------------");
                Polly.ExecuteRemoteLookUpWithPolly();
                Console.WriteLine("-------------");
            }
        }  
    }
}


