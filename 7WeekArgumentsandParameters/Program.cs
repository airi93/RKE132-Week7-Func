﻿
using System.Net.NetworkInformation;

Console.WriteLine("Enter a word:");
string userInput = Console.ReadLine();

PrintAnyWord(userInput);  

static void PrintAnyWord(string anyString) /*function method*/
{
    anyString = anyString.ToUpper();
    for (int i = 0; i < 5; i++)
    {
        Console.WriteLine(anyString);
    }    
}