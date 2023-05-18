using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicCSharpProgramsDemo281Batch_
{
    public class ReverseWordSamePosition
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

        public static void ReverseEachWordInSamePosition(string word)
        {
            string sentance = "";
            string[] words = word.Split(' ');
            for (int i = 0; i < words.Length; i++)

            {
                string reverse = "";
                foreach (char letter in words[i])
                {
                    reverse = letter + reverse;
                }
                sentance = sentance + reverse + " ";
            }
            Console.WriteLine(sentance);
        }
    }
}