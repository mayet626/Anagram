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
            
            //File.Create(@"C:\\c#\Result.txt");
            //File.Create(@"C:\\c#\tmpRegist.txt");
            string word = null;
            string tmpWord = null;
            IsAnagram flag = new IsAnagram();
            //AddToTmp add = new AddToTmp("\nКЛОУН");
            StreamReader Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
            StreamReader Reader = new StreamReader(@"C:\\c#\newFile.txt", Encoding.UTF8);
            while ((word = Reader.ReadLine()) != null)
            {
                Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
                while ((tmpWord = Reader.ReadLine()) != null || tmpWord == null)
                {
                    if (tmpWord != null && flag.check(word, tmpWord) == 1)
                        break;
                    else if(tmpWord == null)
                    {
                        Regist.Close();
                        Reader.Close();
                        Thread.Sleep(300);
                        AddToTmp addword = new AddToTmp(word);
                        Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
                    }
                }

            }
            Reader.Close();

            
            Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
            while ((tmpWord = Regist.ReadLine()) != null)
            {
                 Reader = new StreamReader(@"C:\\c#\newFile.txt", Encoding.UTF8);
                 while ((word = Reader.ReadLine()) != null)
                {
                        if(flag.check(word, tmpWord) == 1)
                            Console.WriteLine(word);               
                }
                Console.WriteLine("///////////////");
                Reader.Close();
            }
            
            


            //FileStream lenth = new FileStream.Lenght;
            Console.WriteLine();
            
            //Regist.Close();
        }
    }
}
