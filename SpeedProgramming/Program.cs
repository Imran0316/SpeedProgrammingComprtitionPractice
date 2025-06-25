using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection.Emit;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Schema;
using Microsoft.SqlServer.Server;

namespace SpeedProgramming
{
    internal class Program
    {
        //class student
        //{
        //    public static void studAvg(int math, int urdu, int english)
        //    {
        //        int sumNum = math + urdu + english;
        //        int avg = sumNum / 3;
        //        Console.WriteLine(avg);

        //    }
        //}






        static void Main(string[] args)
        {
            //🎯 Task: Inverted Right-Angled Triangle of Stars

            //Console.WriteLine("Enter number");
            //int input = Convert.ToInt32(Console.ReadLine());
            //int numbers = 0;
            //for (int i = 1;i<=input;i++)
            //{
            //    for (int j = 0;j<=i;j++)
            //    {
            //        numbers++;
            //        Console.WriteLine(numbers);
            //    }
            //    Console.WriteLine();
            //}

            //Console.WriteLine("Enter number");
            ////int input = Convert.ToInt32(Console.ReadLine());

            //for (int i = 1;i<=input;i++)
            //{
            //    for (int k=1;k<=input -i;k++)
            //    {
            //        Console.Write(" ");
            //    }
            //    for (int j=0;j<=i;j++)
            //    {
            //        Console.Write("*");
            //    }
            //        Console.WriteLine();
            //}

            //int count = 0;
            //for (int i=0;i<=5;i++)
            //{

            //    for (int j=0;j<i;j++)
            //    {
            //        Console.Write("*");
            //    }

            //Console.WriteLine();
            //}
            //Console.WriteLine(count);


            // Write a C# program that:

            //Takes a string input from the user

            //Compresses the string by replacing repeating characters with the character +count

            //Displays the compressed string

            //Console.WriteLine("Enter something");
            //string input =  Console.ReadLine();
            //int counterA = 0;
            //int counterB = 0;
            //int counterC = 0;

            //for (int i=0;i < input.Length;i++)
            //{
            //    char c = input[i];
            //    if(c == 'a')
            //    {
            //        counterA++;
            //    }
            //    if (c == 'b')
            //    {
            //        counterB++;
            //    }
            //    if (c == 'c')
            //    {
            //        counterC++;
            //    }
            //}
            //Console.WriteLine( "a" +counterA);
            //Console.WriteLine("b" + counterB);
            //Console.WriteLine("c" + counterC);


            ////Write a C# program that:

            //Takes two strings as input

            //Checks if they are anagrams of each other


            //Console.WriteLine("Enter first word");
            //string Input1 = Console.ReadLine();

            //Console.WriteLine("Enter Second word");
            //string Input2 = Console.ReadLine();

            //Dictionary<char, int> frequency1 = new Dictionary<char, int>();

            //foreach(char ch in Input1)
            //{
            //    if (frequency1.ContainsKey(ch))
            //    {
            //        frequency1[ch]++;
            //    }
            //    else
            //    {
            //        frequency1[ch] = 1;
            //    }
            //}
            //foreach(var items in frequency1)
            //{
            //    Console.WriteLine($"{items.Key} {items.Value}");
            //}



            //Dictionary<char, int> frequency2 = new Dictionary<char, int>();

            //foreach (char ch in Input2)
            //{
            //    if (frequency2.ContainsKey(ch))
            //    {
            //        frequency2[ch]++;
            //    }
            //    else
            //    {
            //        frequency2[ch] = 1;
            //    }
            //}
            //foreach (var items in frequency2)
            //{
            //    Console.WriteLine($"{items.Key} {items.Value}");
            //}

            //bool isAnagram = true;

            //if (frequency1.Count != frequency2.Count)
            //{
            //    isAnagram = false;
            //}
            //else
            //{
            //    foreach(var pair in frequency1)
            //    {
            //        if(!frequency2.ContainsKey(pair.Key) || frequency2[pair.Key] != pair.Value)
            //        {
            //            isAnagram = false;
            //            break;
            //        }
            //    }
            //}

            //if (isAnagram)
            //{
            //    Console.WriteLine("this is anagram");
            //}
            //else
            //{
            //    Console.WriteLine("this is not  anagram");

            //}





            //Write a C# program that:

            //Takes a string input from the user


            //Finds and displays the character that appears the most times

            //Also shows how many times that character appeared

            //Console.WriteLine("Write something");
            //string UserInput = Console.ReadLine().ToLower();

            //Dictionary<char,int> frequency = new Dictionary<char,int>();

            //foreach (char ch in UserInput)
            //{
            //    if (ch == ' ') continue;
            //    if (frequency.ContainsKey(ch))
            //    {
            //        frequency[ch]++;
            //    }
            //    else
            //    {
            //        frequency[ch] = 1;
            //    }
            //}
            //Console.WriteLine(" Character frequencies :");
            //foreach (var items in frequency)
            //{
            //    Console.WriteLine($"{items.Key} : {items.Value}");
            //}


            ////Write a C# program that:

            //Takes a sentence as input

            //Counts how many times each character appears(excluding spaces)

            //Displays each character with its frequency  


            //Console.WriteLine("Enter something");
            //string UserInput = Console.ReadLine();


            //int charactersA = 0;
            //int charactersB = 0;
            //int charactersC = 0;
            //int charactersD = 0;

            //for (int i = 0;i < UserInput.Length;i++)
            //{
            //    char input = UserInput[i];

            //    if (input == 'a')
            //    {
            //        charactersA++;
            //    }
            //    if (input == 'b')
            //    {
            //        charactersB++;
            //    }
            //    if (input == 'c')
            //    {
            //        charactersC++;
            //    }
            //    if (input == 'd')
            //    {
            //        charactersD++;
            //    }
            //}
            //Console.WriteLine(" a :" + charactersA);
            //Console.WriteLine(" b :" + charactersB);
            //Console.WriteLine(" c :" + charactersC);
            //Console.WriteLine(" d :" + charactersD);



            /////Write a C# program that:

            // Takes a full sentence as input

            //Counts how many words are in the sentence

            //Displays the total word count

            //Console.WriteLine("Enter the sentence");
            //string UserInput = Console.ReadLine().Trim();

            //int countWords = 1;
            //for (int i = 0; i < UserInput.Length;i++)
            //{
            //    char count = UserInput[i];

            //    if(count == ' ')
            //    {
            //        countWords++;
            //    }
            //}
            //Console.WriteLine(countWords);





            ////Write a C# program that:

            // Takes a string input from the user


            // Counts how many times each vowel(a, e, i, o, u) appears

            // Displays the frequency of each vowel separately


            //Console.WriteLine("Enter any word");
            //string Input = Console.ReadLine().ToLower();

            //int CountA = 0;
            //int CountE = 0;
            //int CountI = 0;
            //int CountO = 0;
            //int CountU = 0;

            //for (int i = 0;i < Input.Length; i++)
            //{
            //    char check = Input[i];
            //    if (check == 'a')
            //    {
            //        CountA++;
            //    }
            //    if (check == 'e')
            //    {
            //        CountE++;
            //    }
            //    if (check == 'i')
            //    {
            //        CountI++;
            //    }
            //    if (check == 'o')
            //    {
            //        CountO++;
            //    }
            //    if (check == 'u')
            //    {
            //        CountU++;
            //    }


            //}
            //Console.WriteLine("a : " + CountA);
            //Console.WriteLine("e : " + CountE);
            //Console.WriteLine("i : " + CountI);
            //Console.WriteLine("o : " + CountO);
            //Console.WriteLine("u : " + CountU);






            //Write a C# program that:

            // Takes a string input from the user


            // Checks if the string is a palindrome

            //A palindrome is a word that reads the same forward and backward

            //Example: madam, level, civic
            //string confirm = "";
            //do
            //{
            //    Console.WriteLine("Enter the word");
            //    string userInput = Console.ReadLine().ToLower().Trim();


            //    string reverse = "";
            //    for (int i = userInput.Length - 1; i >= 0; i--)
            //    {
            //        reverse += userInput[i];
            //    }
            //    if (reverse == userInput)
            //    {
            //        Console.WriteLine("{0} is a palindrom ", userInput);
            //    }
            //    else
            //    {
            //        Console.WriteLine("{0} is not a palindrom ", userInput);
            //    }


            //    Console.WriteLine("Want to countinue type yes");
            //    confirm = Console.ReadLine();

            //} while (confirm == "yes");


            //Write a C# console program that:

            // Asks the user to enter a string

            // Counts how many vowels are in that string(a, e, i, o, u)

            //Displays the total number of vowels

            //Console.WriteLine("Enter any Word");
            //string word = Console.ReadLine();

            //word = word.ToLower();

            //int countVowel = 0;
            //string foundVowel = "";

            //for (int i = 0; i < word.Length; i++)
            //{
            //    char ch = word[i];

            //    if(ch == 'a' || ch == 'e' || ch == 'i' || ch == 'o' || ch == 'u')
            //    {
            //        countVowel++;
            //        foundVowel += ch + " ";
            //    }
            //}

            ////Console.WriteLine( word);
            //Console.WriteLine("Vowel Count = " + countVowel);
            //Console.WriteLine("Vowel = " + foundVowel);




            //Question 2: Create a class Student with a method to calculate average marks.

            //student.studAvg(20,30,40);







            // With array
            //   string ask;
            //do
            //{
            //    Console.WriteLine("Enter your name:");
            //    String name = Console.ReadLine();
            //    char[] chars = name.ToCharArray();
            //    Array.Reverse(chars);

            //    String reversed = new string(chars);
            //    Console.WriteLine(reversed);

            //    Console.WriteLine("Want to continue type 'yes':");
            //    ask = Console.ReadLine();


            //} while (ask == "yes");

            //MANUAL  METHOD;
            //string confirm;
            //do
            //{
            //    Console.WriteLine("Enter your name");
            //    string name = Console.ReadLine();
            //    string reversed = "";
            //    for (int i = name.Length - 1;i>=0;i--)
            //    {
            //       reversed += name[i];
            //    }
            //    Console.WriteLine(reversed);
            //    Console.WriteLine("Want to continue type 'yes':");
            //     confirm = Console.ReadLine();
            //} while (confirm == "yes");




        }


    }
}
