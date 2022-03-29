using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    static class ExtentionMethods
    {
        public static bool IssOdd(this int num)
        {
            if (num % 2 == 1)
            {
                return true;
            }
            return false;
        }
        public static bool IssEven(this int num)
        {
            if (num % 2 == 0)
            {
                return true;
            }
            return false;
        }
        public static bool IsContainsDigit(this string word)
        {
            if(!string.IsNullOrWhiteSpace(word))
            {
                for (int i = 0; i < word.Length; i++)
                {
                    if (char.IsDigit(word[i]))
                        return false;
                }
                return true ;
            }
            else
            {
                return false;
            }
        }
        public static string ToCapitalize(this string word)
        {
            word = word.ToLower();
            string[]words=word.Split(' ');
            string newWord = "";
            foreach (var text in words)
            {
             string newText = char.ToUpper(text[0])+text.Substring(1) + " ";
            }
            return newWord;
        }
        public static int[] GetvalueIndexes(this string word,char letter)
        {
            int[] indexes = new int[0];
            for (int i = 0; i < word.Length; i++)
            {
                if (word[i] == letter)
                {
                    Array.Resize(ref indexes,indexes.Length + 1);
                    indexes[indexes.Length-1] = i;
                }
            }
            return indexes; 
        }

    }
}
