using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tdd_oop_interface_dependency_injection.CSharp.Main
{
    public class GreekAlphabet : IAlphabet
    {
        public Dictionary<char, int> getLetterScores()
        {
            Dictionary<Char, int> words = new Dictionary<Char, int>();

            string onePoint = "αειοφξ";
            foreach (char c in onePoint.ToCharArray())
            {
                words.Add((char)c, 1);
            }

            string twoPoints = "βδπ";
            foreach (char c in twoPoints.ToCharArray())
            {
                words.Add((char)c, 2);
            }

            string threePoints = "γηντ";
            foreach (char c in threePoints.ToCharArray())
            {
                words.Add((char)c, 3);
            }

            string fourPoints = "ζκρψλ";
            foreach (char c in fourPoints.ToCharArray())
            {
                words.Add((char)c, 4);
            }

            string fivePoints = "θχ";
            foreach (char c in fivePoints.ToCharArray())
            {
                words.Add((char)c, 5);
            }

            string eightPoints = "μσ";
            foreach (char c in eightPoints.ToCharArray())
            {
                words.Add((char)c, 8);
            }

            string tenPoints = "υω";
            foreach (char c in tenPoints.ToCharArray())
            {
                words.Add((char)c, 10);
            }

            return words;
        }
    }
}
