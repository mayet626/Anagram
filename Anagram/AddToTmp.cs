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
        public AddToTmp(string word, FileStream w, bool EndLine)
        {
            StreamWriter writer = new StreamWriter(w, Encoding.UTF8);
            if (EndLine == true)
                writer.WriteLine(word);
            else
                writer.Write(word);
            //writer.Close();
        }
    }
}
