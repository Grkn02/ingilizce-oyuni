using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Data;
using System.Reflection;

namespace ingilizce_Oyunu_2._0
{
    internal class Fileoperations
    {  
        public static string[][] words =  new string[10][];
       
        public static int lenghtoftext;
        static List<string> wordlist = new List<string>();
       
        static string resourcename = "ingilizce_Oyunu_2._0.tablo.txt";
        static Assembly assembly = Assembly.GetExecutingAssembly();
        
        public static void Readingfile()
        {
            using (Stream stream = assembly.GetManifestResourceStream(resourcename))
            {
              
                using (StreamReader reader = new StreamReader(stream))
                {

                    for (int i = 1; i <= 2000; i++)
                        wordlist.Add(reader.ReadLine());

                }
                
             

            }
           
            
            lenghtoftext = wordlist.Count;
        
        }

        public static void Takewords() // her basmada
        {
            int n;

            for (int i = 0; i < 10; i++)
            {
                n = Randomm.Takenumber();

                words[i] = wordlist[n].Split(new char[] { '|' }, 2);
            }
           
        }

       






           
                
                
                
               

     
                    
        




    }


    
}
