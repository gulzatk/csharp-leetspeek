using System;
using System.Collections.Generic;

class LeetSpeekTranslator
{
    static void Main()
    {
        Console.WriteLine("Enter a sentence to translate to Leetspeek.");
        string userInput = Console.ReadLine();
        Translate(userInput);
        
    }

    static void Translate(string sentence)
    {
        string[] words = sentence.Split(' ');
        List<string> myStringList = new List<string>();
        string finalSentence = "";
        
        foreach(string word in words)
        {
            char[] characters = word.ToCharArray();
            
                
        
            string s;
            string[] newCharacters = new string[characters.Length];
        
            


            for (int i=0; i<characters.Length; i++)
            {   
                s = characters[i].ToString();
                
                if(s == "e")
                {
                    s = "3";
                    newCharacters[i] = s;
                }
                else if (s == "o")
                {
                    s = "0";
                    newCharacters[i] = s;
                }
                else if(s == "I")
                {
                    s = "1";
                    newCharacters[i] = s;
                }
                else if(s == "t")
                {
                    s = "7";
                    newCharacters[i] = s;
                }
                else if(s == "s")
                {   
                    s = "z";
                    
                    if(i ==0)
                    {
                        s = "s";
                    }
                    newCharacters[i] = s;
                }
                else
                {
                    newCharacters[i] = s;
                }

            
                // Console.WriteLine(newCharacters[i]);
            
                
                
            }
            string result = string.Join("" , newCharacters);
                Console.WriteLine(result);
            
                myStringList.Add(result);

        }

        foreach(string w in myStringList)
        {
            finalSentence += w + " ";
        }


        Console.WriteLine(finalSentence);
        
    }
        
}
