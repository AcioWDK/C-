using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace lower_to_upper
{
   public class ToUpper
    {
       public string upper(string text)
        {
         
            char[] textCharArr = text.ToCharArray();

            for(int i=0; i<textCharArr.Length; i++)
            {
                if (textCharArr[i] >= 'a' && textCharArr[i] <= 'z')
                    textCharArr[i] = (char)(textCharArr[i] - 32);

            }


            return new string(textCharArr);
        }
    }
}
