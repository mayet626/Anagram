using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Threading.Tasks;

namespace Anagram
{
    class CreateResultList
    {
        public CreateResultList()
        {
            FileStream tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.Open, FileAccess.ReadWrite);
            FileStream mainFile = new FileStream("C:\\c#\\newFile.txt", FileMode.Open, FileAccess.Read);
            StreamReader Regist = new StreamReader(tmpFile, Encoding.UTF8);
            StreamReader Reader = new StreamReader(mainFile, Encoding.UTF8);
            FileStream ResultFile = new FileStream("C:\\c#\\Result.txt", FileMode.Create);
            IsAnagram flag = new IsAnagram();
            ResultFile.Close();
            string word = null;
            string tmpWord = null;

            while ((tmpWord = Regist.ReadLine()) != null)
            {
                mainFile.Seek(0, SeekOrigin.Begin);
                while ((word = Reader.ReadLine()) != null)
                {

                    if (flag.check(word, tmpWord) == true)
                        File.AppendAllText("C:\\c#\\Result.txt", word + " ");
                }

                File.AppendAllText("C:\\c#\\Result.txt", Environment.NewLine);
            }
            tmpFile.Close();
            File.Delete("C:\\c#\\tmpRegist.txt");
        }
    }
}