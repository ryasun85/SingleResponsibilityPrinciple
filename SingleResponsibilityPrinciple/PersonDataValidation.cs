using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SingleResponsibilityPrinciple
{
    public class PersonDataValidation
    {
        public static bool Validate(Person person)
        {
            if (string.IsNullOrEmpty(person.FirstName))
            {
                StandardMessages.DisplayValidationErrorMsg("fist name");
                return false;
            }

            if (string.IsNullOrEmpty(person.LastName))
            {
                StandardMessages.DisplayValidationErrorMsg("last name");
                return false;
            }
            return true;
        }
    }
}
