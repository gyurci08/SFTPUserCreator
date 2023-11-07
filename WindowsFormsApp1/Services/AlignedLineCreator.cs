using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace sFTP_user_creator.Services
{
    internal class AlignedLineCreator
    {
        public string aligned(string toAlign, int width)
        {
            string aligned="";
            width = width - toAlign.Length;
            width = width / 2;

            for (int i = 0; i < width; i++)
            {
                aligned += "#";
            }
            aligned += toAlign;
            for (int i = 0; i < width; i++)
            {
                aligned += "#";
            }

            return aligned+"\n";
        }





        

}
}
