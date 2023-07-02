// See https://aka.ms/new-console-template for more information
using System;
using System.Collections;

public class Program
{
    static void Main()
    {
        Console.WriteLine("Please enter a URL:");
        string input = Console.ReadLine();
        string output = GenerateUrl(input);
        Console.WriteLine(output);
    }

    public static string GenerateUrl(string input)
    {
        // Convert the input string to lowercase
        var output = input.ToLower();

        // Define a character set to replace with hyphens
        var characterSet = new Hashtable()
        {
            { 'ç','c'},
            { 'ı','i'},
            { 'ö','o'},
            { 'ü','u'},
            { ' ','-'},
            { '/','-'},
            { 'ğ','g'},
            { '.','.'},
            { '?','-'},
            { '\'','-'},
            { '\"','-'},
            { ':','-'},
            { ';','-'},
            { ',','-'},
            { '@','-'},
            { '&','-'},
            { '*','-'},
            { '+','-'},
            { '=','-'},
            { '_','-'}
        };

        // Replace each character in the input string with its corresponding value in the character set
        foreach (DictionaryEntry item in characterSet)
        {
            output = output.Replace((char)item.Key, (char)item.Value);
        }

        // Return the output string
        return output;
    }
}
