using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication2
    {
    class Program
        {
        static void Main(string[] args)
            {
            string line;
            string str="";
            System.IO.StreamReader file =
    new System.IO.StreamReader(@"C:\Users\uzer33\Desktop\02_crypto\ConsoleApplication2\ConsoleApplication2\textSh.txt");
            while ((line = file.ReadLine()) != null)
                {
                str += line;
                }
            file.Close();
            char[] text = new char[str.Length];
            text = str.ToCharArray();
            System.Console.WriteLine("Введите величину сдвига (число)");
            int a =Convert.ToInt32(System.Console.ReadLine());
            int b;
            for (int i = 0; i < str.Length; i++)
                {
                b=(int)text[i]+a;
                text[i] = (char)b;
                }
            System.Console.WriteLine(text);

            System.IO.StreamWriter file1 =new System.IO.StreamWriter(@"C:\Users\uzer33\Desktop\02_crypto\ConsoleApplication2\ConsoleApplication2\textD.txt");
            file1.Write(text);
            file1.Close();
                System.Console.ReadLine();
    
            }
        }
    }
