using System;

namespace ScriptureMemorizer
{
    class Reference
    {
        public string _book { get; set; }
        public int _chapter { get; set; }
        public int _verse { get; set; }
        public int? _endVerse { get; set; }
        public string _text { get; set; }

        public Reference(string book, int chapter, int verse, string text)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _text = text;
        }

        public Reference(string book, int chapter, int verse, int endVerse, string text)
        {
            _book = book;
            _chapter = chapter;
            _verse = verse;
            _endVerse = endVerse;
            _text = text;
        }
        public string GetDisplayText()
        {
            return _text;
        }
    }
}