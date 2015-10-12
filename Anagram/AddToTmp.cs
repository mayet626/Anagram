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
        public AddToTmp(string word, int f)
        {
            StreamWriter writer = new StreamWriter(@"C:\\c#\tmpRegist.txt", true, Encoding.UTF8);
            if(f != 0)
                writer.WriteLine(word);
            writer.Close();
        }
    }
}
