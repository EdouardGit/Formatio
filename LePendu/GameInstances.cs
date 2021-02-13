using System;
using System.Collections.Generic;


namespace LePendu
{
    public class GameInstances
    {


        public int MaxErrors { get; set; }
        public List<char> Guesses { get; }
        public List<char> Misses { get; }
        public List<Word> Words { get; }
        private Word wordToGuess { get;  }
        private Random rnd;
        private bool IsWin { get; set; }
        private string currentWordGuessed;
        
        
        public GameInstances(int maxErrors = 10)
        {
            rnd = new Random();
            MaxErrors = maxErrors;
            Words = new List<Word>
            {
                new Word("Programmation"),
                new Word("éléphant"),
                new Word("Truc"),
                new Word("Brol")
            };
            Guesses = new List<char>();
            Misses = new List<char>();
            wordToGuess = Words[rnd.Next(0, Words.Count)];
            rnd = new Random();
            MaxErrors = maxErrors;
            wordToGuess = Words[rnd.Next(0, Words.Count)];
            Console.Write("Le mot à deviner contiend ");
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Write(wordToGuess.Length);
            Console.ResetColor();
            //Console.Clear();
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine(" lettres");
        }
        public GameInstances(List<Word> words,int maxErrors = 10)
        {
            rnd = new Random();
            MaxErrors = maxErrors;
            Words = words;
            Guesses = new List<char>();
            Misses = new List<char>();
            wordToGuess = Words[rnd.Next(0, Words.Count)];
            
        }
    }

}