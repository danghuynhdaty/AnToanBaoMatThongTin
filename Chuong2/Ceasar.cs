using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chuong2
{
    public static class Ceasar
    {

        public static string Encrypt(string text, int key)
        {
            string str = "";

            for (int i = 0; i < text.Length; i++)
            {
                if (char.IsUpper(text[i]))
                {
                    str += (char)((text[i] + key - 65) % 26 + 65);
                }
                else
                {
                    str += (char)((text[i] + key - 97) % 26 + 97);
                }
            }

            return str;
        }

    }
}
