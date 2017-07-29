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
            int c;
            string file1="";
            string file2="";
            System.Console.WriteLine("Введите полный путь к файлу который хотите зашифровать или дешифровать");
            file1 = System.Console.ReadLine();
            System.Console.WriteLine("Введите путь к файлу в который хотите записать  результаты шифрования или дешифрования");
            file2 = System.Console.ReadLine();

            System.Console.WriteLine("Введите 1 если хотите зашифровать текст введие 2 если хотите дешифровать текст");
              c = Convert.ToInt32(System.Console.ReadLine());
              if (c == 1)
                  {
                  System.IO.StreamReader filer =
          new System.IO.StreamReader(file1);
                  while ((line = filer.ReadLine()) != null)
                      {
                      str += line;
                      }
                  filer.Close();
                  char[] text = new char[str.Length];
                  text = str.ToCharArray();
                  System.Console.WriteLine("Введите величину сдвига (число)");
                  int a = Convert.ToInt32(System.Console.ReadLine());
                  int b;
                  for (int i = 0; i < str.Length; i++)
                      {
                      b = (int)text[i] + a;
                      text[i] = (char)b;
                      }
                  System.Console.WriteLine(text);

                  System.IO.StreamWriter filew = new System.IO.StreamWriter(file2);
                  filew.Write(text);
                  filew.Close();
                  System.Console.ReadLine();
                  }
              else {
              System.IO.StreamReader filer =
new System.IO.StreamReader(file1);
              while ((line = filer.ReadLine()) != null)
                  {
                  str += line;
                  }
              filer.Close();
              char[] text = new char[str.Length];
              text = str.ToCharArray();
              System.Console.WriteLine("Введите величину сдвига (число)");
              int a = Convert.ToInt32(System.Console.ReadLine());
              int b;
              for (int i = 0; i < str.Length; i++)
                  {
                  b = (int)text[i] - a;
                  text[i] = (char)b;
                  }
              System.Console.WriteLine(text);

              System.IO.StreamWriter filew = new System.IO.StreamWriter(file2);
              filew.Write(text);
              filew.Close();
              System.Console.ReadLine();
                  }
    
            }
        }
    }
