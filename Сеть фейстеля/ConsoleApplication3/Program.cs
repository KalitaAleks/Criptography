using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
    {
    class Program
        {
        static void Main(string[] args)
            {
            int a=5, b=2, m=45678, y0=7;
            int[] y;
        

            string line;
            string input = "";
            int c;
            string output = "";
            string file1 = "";
            string file2 = "";
            int sd;
            System.Console.WriteLine("Введите полный путь к файлу который хотите зашифровать или дешифровать");
            file1 = System.Console.ReadLine();
            System.Console.WriteLine("Введите путь к файлу в который хотите записать  результаты шифрования или дешифрования");
            file2 = System.Console.ReadLine();
            System.Console.WriteLine("Введите 1 если хотите зашифровать документ, или 2 если хотите расшифровать документ");
            sd = Convert.ToInt32(System.Console.ReadLine());
            System.IO.StreamReader filer =
            new System.IO.StreamReader(file1);
            while ((line = filer.ReadLine()) != null)
                {
                input += line;
                }
            filer.Close();

            char[] text = new char[input.Length];
            text = input.ToCharArray();
            if (text.Length % 2 != 0) 
                {
                Array.Resize(ref text, text.Length + 1);
                text[text.Length - 1] = ' ';
                }
            y = new int[text.Length];
            y[0] = y0;
            for (int i = 1; i < y.Length; i++)
                {
                y[i] = (y[i - 1] * a + b) % m;
                }

            char right, left, swap;
            if (sd == 1)
                {
                for (int i = 0; i < input.Length; i = i + 2)
                    {
                    left = text[i];
                    right = text[i + 1];
                    int key = y[i];
                    for (int j = 5; j > 0; j--)
                        {
                        swap = (char)((int)left ^ key);
                        left = right;
                        right = swap;
                        if (key == y[i]) { key = y[i + 1]; }
                        else { key = y[i]; }
                        }
                    output += left;
                    output += right;
                    }
                }

            if (sd == 2)
                {
                for (int i = 0; i <input.Length; i = i + 2)
                    {
                    left = text[i];
                    right = text[i+1];
                    int key = y[i];
                    for (int j = 5; j > 0; j--)
                        {
                        swap = (char)((int)right ^ key);
                         right = left;
                        left = swap;
                        if (key == y[i]) { key = y[i+1]; }
                        else { key = y[i]; }
                        }
                    output += left;
                    output += right;
                    }
                }


            System.Console.WriteLine(output);
            System.IO.StreamWriter filew = new System.IO.StreamWriter(file2);
            filew.Write(output);
            filew.Close();
            System.Console.ReadLine();


            }
        }
    }
