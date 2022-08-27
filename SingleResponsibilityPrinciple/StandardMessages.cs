﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class StandardMessages { 
    
        public static void WelcomeMessage()
        {
            Console.WriteLine("Welcome to the application!");
        }

        public static void EndApplication()
        {
            Console.Write("Press enter to close...");
            Console.ReadLine();
        }

        public static void DisplayValidationErrorMsg(string fieldName)
        { 
            Console.WriteLine($"Please enter valid {fieldName}.");
        }
    }
}
