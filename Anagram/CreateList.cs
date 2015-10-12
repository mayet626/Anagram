using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Anagram
{
    class CreateList
    {
        FileStream tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.Create, FileAccess.ReadWrite);
        FileStream mainFile = new FileStream("C:\\c#\\newFile.txt", FileMode.Open, FileAccess.ReadWrite);
        string word = null;
        string tmpWord = null;
        IsAnagram flag = new IsAnagram();
        StreamReader Regist = new StreamReader(tmpFile, Encoding.UTF8);
        StreamReader Reader = new StreamReader(mainFile, Encoding.UTF8);

    }
}
