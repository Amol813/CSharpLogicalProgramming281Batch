using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpProgramsDemo281Batch_
{
    public class ReverseProgram
    {
        public static void ReverseWord(string word)
        {
            string reverse = "";
            foreach (char letter in word)
            {
                reverse = letter + reverse;

            }
            Console.WriteLine(reverse);
        }

        internal static void ReverseEachWordInSamePosition(string? word)
        {
            throw new NotImplementedException();
        }
    }
}