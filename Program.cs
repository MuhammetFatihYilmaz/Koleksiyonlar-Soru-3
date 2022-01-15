using System;
using System.Collections.Generic;

namespace Koleksiyonlar_Soru_3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir cümle yazınız.");
            string sentence = Console.ReadLine();
            sentence = sentence.ToLower();
            //
            char[] charInsideSentence = sentence.ToCharArray();
            //
            string vowels = "aeıioöuü";
            //
            List<char> vowelList = new List<char>();

            

            for (int i = 0; i < charInsideSentence.Length; i++)
            {
                 if(vowels.Contains(charInsideSentence[i]))
                 {
                     vowelList.Add(charInsideSentence[i]);
                 }

            }

            Console.WriteLine("Cümle içerisinde kullanılan sesli harfler.");

             foreach (var item in vowelList)
             {
                 Console.WriteLine(item);
             }


            
        }
    }
}
