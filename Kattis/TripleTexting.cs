using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kattis
{
    public class TripleTexting
    {
        public string GrandmasText()
        {
            char[] fullText = Console.ReadLine().ToCharArray();
            char[] firstWord = new char[fullText.Length/3];
            char[] secondWord = new char[fullText.Length / 3];
            char[] thirdWord = new char[fullText.Length / 3];
            int j = 0;
            int n = 0;


            for (int i = 0; i < fullText.Length; i++)
            {
                
                if (i < fullText.Length / 3)
                {
                    firstWord[i] = fullText[i];
                }
                else if(i >= fullText.Length / 3 && i < (fullText.Length / 3) * 2)
                {
                    secondWord[j] = fullText[i];
                    j++;
                }
                else
                {
                    thirdWord[n] = fullText[i];
                    n++;
                }
            }

            char[] result = new char[firstWord.Length];
            for(int i = 0; i < firstWord.Length; i++)
            {
                if(firstWord[i] != secondWord[i] && firstWord[i] == thirdWord[i])
                {
                    result[i] = firstWord[i];
                }
                else
                {
                    result[i] = secondWord[i];
                }
            }
            return new string(result);
        }
        
    }
}
