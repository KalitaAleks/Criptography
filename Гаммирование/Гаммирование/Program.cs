using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Гаммирование
    {
    class Program
        {
        static void Main(string[] args)
            {
            int a, b, m, y0;
      int[] y;
             System.Console.WriteLine("Введите число a (множитель)");
             a = Convert.ToInt32(System.Console.ReadLine());
              System.Console.WriteLine("Введите число b (приращение)");
             b = Convert.ToInt32(System.Console.ReadLine());
              System.Console.WriteLine("Введите число m (модуль)");
             m = Convert.ToInt32(System.Console.ReadLine());
             System.Console.WriteLine("Введите число y0 (начальное состояние генератора)");
             y0 = Convert.ToInt32(System.Console.ReadLine());
             string line;
            string str="";
            string file1="";
            string file2="";
            System.Console.WriteLine("Введите полный путь к файлу который хотите зашифровать или дешифровать");
            file1 = System.Console.ReadLine();
            System.Console.WriteLine("Введите путь к файлу в который хотите записать  результаты шифрования или дешифрования");
            file2 = System.Console.ReadLine();

  
             
                  
                  System.IO.StreamReader filer =
          new System.IO.StreamReader(file1);
                  while ((line = filer.ReadLine()) != null)
                      {
                      str += line;
                      }
                  filer.Close();

                  char[] text = new char[str.Length];
                  text = str.ToCharArray();
                  y = new int[text.Length];
                  y[0] = y0;
                  for (int i = 1; i < y.Length; i++)
                  {
                  y[i] = (y[i - 1] * a + b) % m;
                  }

                  for (int i = 0; i < str.Length; i++)
                      {
                      b = (int)text[i] ^y[i];
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
