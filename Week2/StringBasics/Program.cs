using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace StringBasics
{
    internal class Program
    {

        static string reverseString(string str1)
        {
           
            StringBuilder sb1 = new StringBuilder();
            for (int i = str1.Length - 1; i >= 0; i--)
            {
                sb1.Append(str1[i]);
            }
            Console.WriteLine(sb1.ToString());
            return sb1.ToString();
        }

        
        static void countVowels(string str2)
        {
           
            List<char> lis = new List<char>() { 'a', 'e', 'i', 'o', 'u', 'A', 'E', 'I', 'O', 'U' };
            int count = 0;
            for (int i = 0; i < str2.Length; i++)
            {
                if (lis.Contains(str2[i])) count++;
            }
            Console.WriteLine("No of vowels:"+count);
        }

        
        static bool checkPalindrome(string str1)
        {
            str1=str1.ToLower();
            if (str1.Equals(reverseString(str1))) return true;
            return false;
        }

        static List<string> returnSubstring(string str)
        {
            List<string> list = new List<string>();
            for(int i = 0; i < str.Length; i++)
            {
                for(int j = i; j < str.Length; j++)
                {
                    list.Add(str.Substring(i, j - i + 1));
                }

            }
            return list;
        }

        static Dictionary<char,int> countCharacter(string str)
        {
            Dictionary<char,int>  dic = new Dictionary<char,int>();
            foreach(char c in str)
            {
                if (dic.ContainsKey(c)) dic[c]++;
                else dic.Add(c, 1);
            }
            return dic;
        }

        static void replaceCharacter(string str,char a,char b)
        {
            str=str.Replace(a, b);
            Console.WriteLine("New Formatted string:"+str);

        }

        static bool compareStrings(string str1,string str2)
        {
            if(str1.Equals(str2,StringComparison.OrdinalIgnoreCase)) return true;
            return false;
        }

        static string returnLongestWord(string str)
        {
            string[]array=str.Split(' ');
            string longestWord = array[0];
            foreach(string word in array)
            {
                if (word.Length >= longestWord.Length)longestWord = word;
            }
            return longestWord;

        }

        static string trimString(string str)
        {
            return str.Trim();
        }

        static bool checkAnagrams(string str1,string str2)
        {
            if (str1.Length != str2.Length) return false;
            char[] array1 = new char[str1.Length];
            char[]array2=new char[str2.Length];
            for(int i = 0; i < array1.Length; i++)
            {
                array1[i]=str1[i];
                array2[i] = str2[i];
            }
            Array.Sort(array1);
            Array.Sort(array2);
            str1 = new string(array1);
            str2=new string(array2);

            return str1.Equals(str2);
            
        }
        static int countWords(string str)
        {
            string[]array=str.Split(' ');
            foreach(string word in array)
            {
                Console.WriteLine(word);
            }
            return array.Length;
        }
        static void Main(string[] args)
        {

            //1.Reverse a StringProblem:
            //Write a method that takes a string as input and returns the reversed string.
            //Example:
            //Input: "hello"
            //Output: "olleh"
            Console.WriteLine("Task1:Reverse a StringProblem:");
            Console.WriteLine("Enter an input string:");
            string str1 = Console.ReadLine();
            reverseString(str1);
            Console.WriteLine("---------------------------------------------------");

            //2.Count Vowels in a String Problem:
            //Write a method that counts the number of vowels(a, e, i, o, u) in a given string.
            //Example:
            //Input: "Hello World"
            //Output: 3
            Console.WriteLine("Task2:Count Vowels in a String Problem:");
            Console.WriteLine("Enter an input string:");
            string str2 = Console.ReadLine();
            countVowels(str2);
            Console.WriteLine("---------------------------------------------------");

            //3. Palindrome Check Problem:
            //Write a method to check if a string is a palindrome(reads the same backward as forward).
            //Example:
            //Input: "racecar"
            //Output: true
            Console.WriteLine("Task3:Palindrome Check Problem:");
            Console.WriteLine("Enter an input string:");
            str1 = Console.ReadLine();
            if (checkPalindrome(str1)) { Console.WriteLine("String is Palindrome"); }
            else { Console.WriteLine("String is not palindrome"); }
            Console.WriteLine("---------------------------------------------------");

            //4.Find All Substrings:
            //Write a method that prints all possible substrings of a given string.
            //Example:
            //Input: "abc"
            //Output: "a", "b", "c", "ab", "bc", "abc"
            Console.WriteLine("Task4:Find All Substrings:");
            Console.WriteLine("Enter an input string:");
            str1 = Console.ReadLine();
            List<string> substringList = returnSubstring(str1);
            foreach (string sub in substringList)
            {
                Console.Write(sub + " ");
            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");

            //5.Character Frequency Count Problem:
            //Write a method to count the frequency of each character in a string.
            //Example:
            //Input: "hello"
            //Output: h: 1, e: 1, l: 2, o: 1
            Console.WriteLine("Task5:Character Frequency Count Problem:");
            Console.WriteLine("Enter an input string:");
            str1 = Console.ReadLine();
            Dictionary<char, int> dic = countCharacter(str1);
            foreach (KeyValuePair<char, int> kvp in dic)
            {
                Console.Write(kvp.Key + ":" + kvp.Value + "   ");

            }
            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------");

            //6.Replace a Character in a String Problem:
            //Write a method to replace all occurrences of a specified character in a string with another character.
            //Example:
            //Input: "banana", replace 'a' with 'o'
            //Output: "bonono"
            Console.WriteLine("Task6:Replace a Character in a String Problem:");
            Console.WriteLine("Enter an input string:");
            str1 = Console.ReadLine();
            Console.Write("Enter character you want to replace:");
            char char1 = char.Parse(Console.ReadLine());
            Console.Write("Enter character to replace with:");
            char char2 = char.Parse(Console.ReadLine());
            replaceCharacter(str1, char1, char2);
            Console.WriteLine("---------------------------------------------------");


            //7.String Comparison(Case - Insensitive) Problem:
            //Write a method that compares two strings in a case -insensitive manner.
            //Example:
            //Input: "hello", "HELLO"
            //Output: true
            Console.WriteLine("Task7: Comparison(Case - Insensitive) Problem");
            Console.Write("Enter string1:");
            str1 = Console.ReadLine();
            Console.Write("Enter string2:");
            str2 = Console.ReadLine();
            if (compareStrings(str1, str2)) { Console.WriteLine("Strings are equal"); }
            else { Console.WriteLine("Strings are not equal"); }
            Console.WriteLine("---------------------------------------------------");

            //8.Find the Longest Word in a Sentence Problem:
            //Write a method that takes a sentence as input and returns the longest word in the sentence.
            //Example:
            //Input: "The quick brown fox jumps"
            //Output: "jumps"
            Console.WriteLine("Task8: Find the Longest Word in a Sentence Problem");
            Console.Write("Enter any sentence:");
            string str = Console.ReadLine();
            Console.WriteLine("Longest word in a sentence:" + returnLongestWord(str));
            Console.WriteLine("---------------------------------------------------");

            //9.Remove Whitespace from a String Problem:
            //Write a method to remove all leading and trailing whitespace from a string.
            //Example:
            //Input: " hello world "
            //Output: "hello world"
            Console.WriteLine("Task9: Remove Whitespace from a String Problem");
            Console.Write("Enter an input string:");
            str = Console.ReadLine();
            Console.WriteLine("Output:" + trimString(str));
            Console.WriteLine("---------------------------------------------------");

            //10.Check for Anagrams Problem:
            //Write a method that checks if two strings are anagrams of each other(contain the same characters in
            //different orders).
            //Example:
            //Input: "listen", "silent"
            //Output: true
            Console.WriteLine("Task10: Check for Anagrams Problem");
            Console.Write("Enter string1:");
            str1 = Console.ReadLine();
            Console.Write("Enter string1:");
            str2 = Console.ReadLine();
            if (checkAnagrams(str1, str2))
            {
                Console.WriteLine("Output:" + "True");
            }
            else { Console.WriteLine("Output:" + "False"); };
            Console.WriteLine("---------------------------------------------------");

            //11.Count Words in a Sentence Problem:
            //Write a method that counts the number of words in a given sentence.
            //Example:
            //Input: "C# is fun"
            //Output: 3
            Console.WriteLine("Task11: Count Words in a Sentence Problem");
            Console.Write("Enter input sentence:");
            str1 = Console.ReadLine();
            Console.WriteLine("Output:" + countWords(str1));
            Console.WriteLine("---------------------------------------------------");


            //12.Split a Sentence into Words Problem:
            //Write a method that splits a sentence into words and prints each word on a new line.
            //Example: Input: "C# is great!"
            //Output:
            //C# 
            //is
            //great!
            Console.WriteLine("Task12: Split a Sentence into Words Problem:");
            Console.Write("Enter input sentence:");
            str1 = Console.ReadLine();
            countWords(str1);

            Console.WriteLine("---------------------------------------------------");



        }
    }
}
