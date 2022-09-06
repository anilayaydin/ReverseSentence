using System;
using System.Text;

namespace _01_MySolution
{
    class Program
    {
        static string ReverseEachWord(String s)
        {

            if(string.IsNullOrEmpty(s))
                return s;
            
            StringBuilder result = new StringBuilder(s.Length);
            
            String [] arr = s.Split(" ");

            for(int i=0; i < arr.Length; i++) {
                result.Append(Reverse(arr[i]));
                if(i<=arr.Length-1)
                    result.Append(" ");
            }

            return result.ToString();
        }

        static string Reverse(string word) {

            if (string.IsNullOrEmpty(word)) {
                return word;
            }

            char[] arr = word.ToCharArray();

            Array.Reverse(arr);
            return new String(arr);
        }

        static void Main(string[] args)
        {
            Console.WriteLine(ReverseEachWord("Hello World"));
            Console.WriteLine(ReverseEachWord("Student number"));
            Console.WriteLine(ReverseEachWord("Hello"));
            Console.WriteLine(ReverseEachWord("Hi"));
            Console.WriteLine(ReverseEachWord(""));
            Console.WriteLine(ReverseEachWord(null));


        }
    }
}
