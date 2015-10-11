using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagram
{
    class AddToTmp
    {
        public AddToTmp(string word)
        {
            StreamWriter writer = new StreamWriter(@"C:\\c#\tmpRegist.txt", true, Encoding.UTF8);
            writer.WriteLine(word);
            writer.Close();
        }
    }
}
