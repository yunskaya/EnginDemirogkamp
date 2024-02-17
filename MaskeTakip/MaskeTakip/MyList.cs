using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaskeTakip
{
    public class MyList
    {

        public string[] NewArray(String[] list, string addedValue)
        {
            //comment
            int diziUzunlugu = list.Length + 1;
            string[] newList = new string[diziUzunlugu];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            newList[diziUzunlugu - 1] = addedValue;

            return newList;
        }
        

        public string[] NewArray1(String[] list, string addedValue) 
        {
            String[] newList = new String[list.Length + 1];

            for (int i = 0; i < list.Length; i++)
            {
                newList[i] = list[i];
            }

            newList[list.Length] = addedValue;

            return newList; 
        
        }

    }
}
