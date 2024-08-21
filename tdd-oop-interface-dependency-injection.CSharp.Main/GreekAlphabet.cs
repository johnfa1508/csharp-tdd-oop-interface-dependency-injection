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



            string greekAlphabet = "αειοφξβδπγηντζκρψλθχμσυω";

            foreach (char c in greekAlphabet.ToCharArray())
            {
                if (c == 'α' || c == 'ε' || c == 'ι' || c == 'ο' || c == 'φ' || c == 'ξ')
                {
                    words.Add(c, 1);
                }
                else if (c == 'β' || c == 'δ' || c == 'π')
                {
                    words.Add(c, 2);
                }
                else if (c == 'γ' || c == 'η' || c == 'ν' || c == 'τ')
                {
                    words.Add(c, 3);
                }
                else if (c == 'ζ' || c == 'κ' || c == 'ρ' || c == 'ψ' || c == 'λ')
                {
                    words.Add(c, 4);
                }
                else if (c == 'θ' || c == 'χ')
                {
                    words.Add(c, 5);
                }
                else if (c == 'μ' || c == 'σ')
                {
                    words.Add(c, 8);
                }
                else if (c == 'υ' || c == 'ω')
                {
                    words.Add(c, 10);
                }
            }

            //string onePoint = "αειοφξ";
            //foreach (char c in onePoint.ToCharArray())
            //{
            //    words.Add((char)c, 1);
            //}

            //string twoPoints = "βδπ";
            //foreach (char c in twoPoints.ToCharArray())
            //{
            //    words.Add((char)c, 2);
            //}

            //string threePoints = "γηντ";
            //foreach (char c in threePoints.ToCharArray())
            //{
            //    words.Add((char)c, 3);
            //}

            //string fourPoints = "ζκρψλ";
            //foreach (char c in fourPoints.ToCharArray())
            //{
            //    words.Add((char)c, 4);
            //}

            //string fivePoints = "θχ";
            //foreach (char c in fivePoints.ToCharArray())
            //{
            //    words.Add((char)c, 5);
            //}

            //string eightPoints = "μσ";
            //foreach (char c in eightPoints.ToCharArray())
            //{
            //    words.Add((char)c, 8);
            //}

            //string tenPoints = "υω";
            //foreach (char c in tenPoints.ToCharArray())
            //{
            //    words.Add((char)c, 10);
            //}

            return words;
        }
    }
}
