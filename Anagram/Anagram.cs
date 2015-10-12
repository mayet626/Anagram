using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Anagram
{
    class Anagram
    {
        public Anagram()
        {
            FileStream tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.Create, FileAccess.ReadWrite);
            FileStream mainFile = new FileStream("C:\\c#\\newFile.txt", FileMode.Open, FileAccess.ReadWrite);
            string word = null;
            string tmpWord = null;
            IsAnagram flag = new IsAnagram();
            StreamReader Regist = new StreamReader(tmpFile, Encoding.UTF8);
            StreamReader Reader = new StreamReader(mainFile, Encoding.UTF8);
            while ((word = Reader.ReadLine()) != null)
            {
                bool f = true;
                while ((tmpWord = Regist.ReadLine())!= null)
                {
                    if (flag.check(word, tmpWord) == 1)
                        f = false;
                }
                tmpFile.Close();
                if (f == true)
                    File.AppendAllText("C:\\c#\\tmpRegist.txt", word+Environment.NewLine);
                
                tmpFile = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.OpenOrCreate, FileAccess.ReadWrite);
                Regist = new StreamReader(tmpFile, Encoding.UTF8);
            }
            mainFile.Close();


            FileStream ResultFile = new FileStream("C:\\c#\\Result.txt", FileMode.Create);
            ResultFile.Close();           
            mainFile = new FileStream("C:\\c#\\newFile.txt", FileMode.Open, FileAccess.Read);
            Reader = new StreamReader(mainFile, Encoding.UTF8);
            //tmpFile.Seek(0, SeekOrigin.Begin);
            while ((tmpWord = Regist.ReadLine()) != null)
            {
                //mainFile.Seek(0, SeekOrigin.Begin);
                while ((word = Reader.ReadLine()) != null)
                {

                    if (flag.check(word, tmpWord) == 1)
                        File.AppendAllText("C:\\c#\\Result.txt", word + " ");
                }
                
                File.AppendAllText("C:\\c#\\Result.txt", Environment.NewLine);
            }            
            Console.WriteLine();
            tmpFile.Close();
            File.Delete(@"C:\\c#\tmpRegist.txt");
        }
    }
}
