using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ingilizce_Oyunu_2._0
{
    internal class Randomm
    {
        static int len = 2000; //Fileoperations.lenghtoftext (2000);
        static Random random = new Random();
        static int[] array = new int[len];
        static int k = -1;

        public static int Wordormeaning() //
        {
            return random.Next(0, 2);
        }

        static void Createarray()
        {
            for (int i = 0; i < len ; i++)
                array[i] = i ;

        }

        public static void Randomnumber() //1.calling
        {
            Createarray();

            for (int i = 0; i < len ; i++)
            {
                (array[random.Next(0, len )], array[i]) = (array[i], array[random.Next(0, len )]);
            }


        }

        public static int Takenumber()
        {
            
            k++;
            if ( k == len ) k= 0;
            return array[k];
        }
    }
}
