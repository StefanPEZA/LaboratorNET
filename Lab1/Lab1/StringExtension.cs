using System;

namespace Lab1
{
    public static class StringExtension
    {
        public static string[] ComputeWords(this string sentence)
        {
            return sentence.Split(" ");
        }
    }
}
