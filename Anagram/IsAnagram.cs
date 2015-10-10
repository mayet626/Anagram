using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class IsAnagram
    {
        public int check (string word, string tmpWord)
        {
            if((word.Length != tmpWord.Length) || (comparison(word, tmpWord) == 0) )
                return 0;
            return 1;
        }

        static int comparison (string word, string tmpWord)
        {
            int n=0, k=0;
            for (int i = 0; i != word.Length; i++)
                for (int j = 0; j != tmpWord.Length; j++)
                    if (word[i] == tmpWord[j])
                        n++;
            for (int i = 0; i != word.Length; i++)
                for (int j = 0; j != word.Length; j++)
                    if (word[i] == word[j])
                        k++;

            if (n == k)
                return 1;
            return 0;
        }
    }
}
