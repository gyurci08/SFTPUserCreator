using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public class PasswordGenerator
    {
        public String Generate(int length)
        {
            String pass="";
            String letters = "abcdefghijkljmnopqrstuvwxyz";
            String capitals = "ABCDEFGHIJKLJMNOPQRSTUVWXYZ";
            String numbers = "1234567890";
            String specials = "#&@";
            Random random = new Random();


            for(int i = 0; i < length; i++)
            {
             switch (random.Next(1, 7))
                    {
                        case 1: pass = pass + (letters[random.Next(1, letters.Length)]); break;
                        case 2: pass = pass + (capitals[random.Next(1, capitals.Length)]); break;
                        case 3: pass = pass + (numbers[random.Next(1, numbers.Length)]); break;
                        case 4: pass = pass + (specials[random.Next(1, specials.Length)]); break;
                        case 5: pass = pass + (letters[random.Next(1, letters.Length)]); break;
                        case 6: pass = pass + (capitals[random.Next(1, capitals.Length)]); break;
                        case 7: pass = pass + (capitals[random.Next(1, letters.Length)]); break;

                }
                   
             }


            return pass;
        }


    }
}
