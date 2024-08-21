using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class RussianAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();

            string onePoint = "абвгд";
            foreach (char c in onePoint.ToCharArray())
            {
                words.Add((char)c, 1);
            }

            string twoPoints = "еёжзи";
            foreach (char c in twoPoints.ToCharArray())
            {
                words.Add((char)c, 2);
            }

            string threePoints = "йклмн";
            foreach (char c in threePoints.ToCharArray()) { 
                words.Add((char)c, 3);
            }

            string fourPoints = "опрстуф";
            foreach (char c in fourPoints.ToCharArray())
            {
                words.Add((char)c, 4);
            }

            string fivePoints = "хцчш";
            foreach (char c in fivePoints.ToCharArray())
            {
                words.Add((char)c, 5);
            }

            string eightPoints = "щъы";
            foreach (char c in eightPoints.ToCharArray())
            {
                words.Add((char)c, 8);
            }

            string tenPoints = "ьэю";
            foreach (char c in tenPoints.ToCharArray())
            {
                words.Add((char)c, 10);
            }

            return words;
        }
    }
}
