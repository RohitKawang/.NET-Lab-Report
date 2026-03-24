using System;

class VowelConso
{
    public static void Main()
    {
        Console.WriteLine("Enter a character: ");
        char ch = char.Parse(Console.ReadLine());
        switch(ch){
            case 'a':
            case 'e':
            case 'i':
            case 'o':
            case 'u':
            case 'A':
            case 'E':
            case 'I':
            case 'O':
            case 'U':
                Console.WriteLine("Vowel");
                break;
            default:
                Console.WriteLine("Consonant");
                break;
        }
        Console.ReadLine();
    }
}