using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class UserValidationManager : IUserValidationService
    {
        public bool Validate(Gamer gamer)
        {
            if (gamer.BirthYear == 1994 && gamer.FirstName =="YASİN" && gamer.LastName=="GÜL" && gamer.NationalIdentity==12345678910)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
