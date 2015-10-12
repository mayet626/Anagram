using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Threading;

namespace Anagram
{
    class Anagram
    {
        public Anagram()
        {
            FileStream s = new FileStream("C:\\c#\\Result.txt", FileMode.Create);
            s.Close();
            FileStream w = new FileStream("C:\\c#\\tmpRegist.txt", FileMode.Create);
            //w.Close();
            string word = null;
            string tmpWord = null;
            IsAnagram flag = new IsAnagram();
            StreamReader Regist = new StreamReader(w, Encoding.UTF8);
            StreamReader Reader = new StreamReader(@"C:\\c#\newFile.txt", Encoding.UTF8);
            while ((word = Reader.ReadLine()) != null)
            {
                int f = 1;
                while((tmpWord = Regist.ReadLine())!= null)
                {
                    if (flag.check(word, tmpWord) == 1)
                        f = 0;
                }
                Regist.Close();
                AddToTmp addword = new AddToTmp(word, f);
                Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
            }
            Reader.Close();


            StreamWriter ResultWriter = new StreamWriter(@"C:\\c#\Result.txt", true, Encoding.UTF8);
            Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
            while ((tmpWord = Regist.ReadLine()) != null)
            {
                 Reader = new StreamReader(@"C:\\c#\newFile.txt", Encoding.UTF8);
                 while ((word = Reader.ReadLine()) != null)
                {
                        if(flag.check(word, tmpWord) == 1)
                            ResultWriter.Write(word + " ");               
                }
                ResultWriter.WriteLine("\n");
                Reader.Close();
            }
            
            


            //FileStream lenth = new FileStream.Lenght;
            Console.WriteLine();
            Reader.Close();
            Regist.Close();
            ResultWriter.Close();
            File.Delete("C:\\c#\tmpRegist.txt");
        }
    }
}
