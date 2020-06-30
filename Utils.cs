using System;
using System.Text;

namespace Utils
{
    class Text
    {
        public static string OnlyLetters(string path)
        {
            StringBuilder stringBuilder = new StringBuilder();
            foreach (char c in path)
            {
                if (Char.IsLetter(c))
                {
                    stringBuilder.Append(c);
                }
            }
            return stringBuilder.ToString();
        }
    }
}