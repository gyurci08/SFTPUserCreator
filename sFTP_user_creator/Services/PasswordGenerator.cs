using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services
{
    public static class PasswordGenerator
    {

        public static int Contains(string x, string y)
        {
            int num = 0;

            for (int i = 0; i < x.Length; i++)
            {
                for (int j = 0; j < y.Length; j++)
                {
                    if (x[i] == y[j]) num++;
                }
            }


            return num;
        }



        public static String Generate(int CharLength, int SpecNum)
        {
            String pass = "";
            String letters = "abcdefghijkljmnopqrstuvwxyz";
            String capitals = "ABCDEFGHIJKLJMNOPQRSTUVWXYZ";
            String numbers = "1234567890";
            String specials = "#&.@";

            Random random = new Random();

            int randNum;
            int numOfSpecials = 0;

            while (numOfSpecials != SpecNum)
            {
                pass = "";

                while (pass.Length != CharLength)
                {
                    randNum = random.Next(1, 5);

                    switch (randNum)
                    {
                        case 1: pass = pass + (letters[random.Next(1, letters.Length)]); break;
                        case 2: pass = pass + (capitals[random.Next(1, capitals.Length)]); break;
                        case 3: pass = pass + (numbers[random.Next(1, numbers.Length)]); break;
                        case 4: pass = pass + (specials[random.Next(1, specials.Length)]); break;
                    }

                    numOfSpecials = 0;
                    numOfSpecials = Contains(pass, specials);

                }
            }











            return pass;
        }


    }
}
