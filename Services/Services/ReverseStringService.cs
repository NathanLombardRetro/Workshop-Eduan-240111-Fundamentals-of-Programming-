using Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Services.Services
{
    public class ReverseStringService:IReverseStringService
    {
        public string ReverseString(string Unreversed)
        {
            /* First attempt, reversed everything
            char[] stringArray = Unreversed.ToCharArray();
            Array.Reverse(stringArray);
            string reversedString = new string(stringArray);
            return Unreversed + " reversed is " + reversedSentence;
            */

            string[] words = Unreversed.Split(' ');
            var reversedBuilder = new StringBuilder();
            for (int i = words.Length - 1; i >= 0; i--)
            {
                reversedBuilder.Append(words[i]);
                if (i != 0)
                    reversedBuilder.Append(" ");
            }
            string reversedSentence = reversedBuilder.ToString();
            return Unreversed+" reversed is as follows: "+ reversedSentence;
        }
    }
}
