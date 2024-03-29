using System;
namespace chromatek
{
    class Program
    {
        public static int cnt = 0;
        public static string str;

        static void mixchar(String s, String res_str)
        {   
            if (s.Length == 0 && Program.str!=res_str)
            {
                
                //Console.WriteLine($"{res_str},{Program.str},{Program.str==res_str}");
                Console.WriteLine(res_str);
                Program.cnt++;
                return;
            }
      
            for(int i = 0 ;i < s.Length; i++)
            {
                if ( i == 0 || s[i-1] != s[i])  // если буквы подряд не повтаряются
                {
                    char ch = s[i];
                    String left_str = s.Substring(0, i);
                    String right_str = s.Substring(i + 1);
                    String rest = left_str + right_str;
                    //Console.WriteLine($"{s},{ch},{s.IndexOf(ch)}");
                    mixchar(rest, res_str + ch);
                }
            }
        }

        static void Main(string[] args)
        {
            Console.Write("Введите строку: ");
            Program.str = Console.ReadLine();
            //Program.str = "aaha";
            string res_str = "";
            //int n = str.Length;
            mixchar(str, res_str);
            Console.WriteLine($"Всего вариантов = {cnt}");
        }
    }
}
