using System;
using System.Collections.Generic;

namespace LePendu
{
    public class Word
    {
        public string Text { get; set; }
        public int Length { get; }

        public Word(string text)
        {
            Text = text.ToUpper();
            Length = text.Length;
        }

        public int GetIndexOf(char letter)
        {
            return Text.IndexOf(letter);
        }
    }
}