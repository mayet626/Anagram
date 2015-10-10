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
            StreamReader Reader = new StreamReader(@"C:\\c#\newFile.txt", Encoding.UTF8);
            File.Create(@"C:\\c#\Result.txt");
            //File.Create(@"C:\\c#\tmpRegist.txt");
            StreamReader Regist = new StreamReader(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);
            StreamWriter RegistW = new StreamWriter(@"C:\\c#\tmpRegist.txt", Encoding.UTF8);


            string word = null;
            string tmpWord = null;


            IsAnagram flag = new IsAnagram();
            while ((word = Reader.ReadLine()) != null)
            {
                if((tmpWord = Regist.ReadLine()) != null)
                    while((tmpWord = Regist.ReadLine()) != null
                    {
                        if(flag.check(word, tmpWord) == 1)
                        Console.WriteLine(word);
                    }
               
            }

            //FileStream lenth = new FileStream.Lenght;
            Console.WriteLine();
            Reader.Close();
            Regist.Close();
        }
    }
}
