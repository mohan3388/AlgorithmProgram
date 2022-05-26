using System;
using AlgorithmsProblem;
class Program
{
    static void Main(String[] args)
    {
        Console.WriteLine("Welcome to the program");
        Console.WriteLine("1.Binary Serach Program\n2.Exit the program");
        bool check = true;
        while(check)
        {
            Console.WriteLine("Enter above option to execute");
            int option = Convert.ToInt32(Console.ReadLine());
            switch(option)
            {
                case 1:
                    const string File_Path = @"D:\dotnet\Algoritmprogram\AlgorithmProgram\AlgorithmsProblem\List.txt";
                    string words = File.ReadAllText(File_Path);
                    string[] arr = words.Split(',');
                    Console.WriteLine("Enter word to Search");
                    string a =Console.ReadLine();
                    Algorithm search = new Algorithm();
                    int result = search.BinarySearch(arr, a);
                    if (result == -1)
                        Console.WriteLine("Element not present");
                    else
                        Console.WriteLine("Element found at "+ result);
                    break;
                default:
                    check = false;
                    break;
            }
        }
    }
}