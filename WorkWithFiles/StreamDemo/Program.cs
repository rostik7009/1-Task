﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StreamDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            //Serializer.Serialize();
            Serializer.Deserialize();
            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
