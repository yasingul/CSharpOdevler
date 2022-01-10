using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GameProject
{
    class Program
    {
        static void Main(string[] args)
        {
            GamerManager gamerManager = new GamerManager(new NewEStateUserValidetionManager());
            gamerManager.Add(new Gamer { 
                Id = 1, 
                BirthYear = 1994, 
                FirstName = "YASİN", 
                LastName = "GÜL", 
                NationalIdentity = 12345678910 
            });
            Console.ReadLine();
        }
    }
}
