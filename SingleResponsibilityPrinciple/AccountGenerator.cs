using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class AccountGenerator
    {
        public static void GenerateUserName(Person user)
        {
            Console.WriteLine($"Your username  {user.FirstName.Substring(0, 1)}{user.LastName} ");
        }
    }
}
