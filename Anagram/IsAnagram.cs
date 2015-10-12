using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class IsAnagram
    {
        public bool check (string word, string tmpWord)
        {
            if ( (word.Length != tmpWord.Length) || 
                (comparison(word, tmpWord) != comparison(word, word)) )
                return false;
            else
                return true;
        }

        static int comparison(string word, string tmpWord)
        {
            int n = 0;
            for (int i = 0; i != word.Length; i++)
                for (int j = 0; j != tmpWord.Length; j++)
                    if (word[i] == tmpWord[j])
                        n++;
            return n;
        }
    }
}
