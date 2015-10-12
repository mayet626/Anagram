using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anagram
{
    class CreateListOfAnagrams
    {
        public CreateListOfAnagrams()
        {
            FileStream tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.Create, FileAccess.ReadWrite);
            FileStream mainFile = new FileStream("C:\\c#\\newFile.txt", FileMode.Open, FileAccess.ReadWrite);
            IsAnagram flag = new IsAnagram();
            StreamReader Regist = new StreamReader(tmpFile, Encoding.UTF8);
            StreamReader Reader = new StreamReader(mainFile, Encoding.UTF8);
            string word = null;
            string tmpWord = null;

            while ((word = Reader.ReadLine()) != null)
            {
                bool f = true;
                while ((tmpWord = Regist.ReadLine()) != null)
                {
                    if (flag.check(word, tmpWord) == true)
                        f = false;
                }
                tmpFile.Close();
                if (f == true)
                    File.AppendAllText("C:\\c#\\tmpRegist.txt", word + Environment.NewLine);

                tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Regist = new StreamReader(tmpFile, Encoding.UTF8);
            }
            mainFile.Close();
            tmpFile.Close();
        }
    }
}