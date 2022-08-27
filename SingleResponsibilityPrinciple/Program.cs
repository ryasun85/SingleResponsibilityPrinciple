using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace SingleResponsibilityPrinciple
{
    internal class Program
    {
        static void Main(string[] args)
        {
            StandardMessages.WelcomeMessage();

            Person user = PersonDataCapture.Capture();
                        
            bool isUserDataValid = PersonDataValidation.Validate(user);

            if (isUserDataValid == false)
            {
                StandardMessages.EndApplication();
                return;
            }

            AccountGenerator.GenerateUserName(user);

            StandardMessages.EndApplication();
        }
    }
}
