using System;

namespace ScriptureMemorizer
{
    class Scripture
    {
        public Reference _reference { get; set; }
        public List<Word> _words { get; set; }

        public Scripture(Reference reference)
        {
            _reference = reference;
            _words = new List<Word>();
            string[] words = _reference._text.Split(' ');
            foreach (string word in words)
            {
                _words.Add(new Word(word));
            }
        }
        public void HideRandomWords(int numberToHide)
        {
            Random random = new Random();

            int hiddenCount = _words.Count(word => word._isHidden);
            int availableToHide = _words.Count - hiddenCount;
            numberToHide = Math.Min(numberToHide, availableToHide);

            while (numberToHide > 0)
            {
                int randomIndex = random.Next(0, _words.Count);

                if (!_words[randomIndex]._isHidden)
                {
                    _words[randomIndex].Hide();
                    numberToHide--;
                }
            }
        }

        public void GetDisplayText()
        {
            Console.Write($">>> {_reference._book} {_reference._chapter}:{_reference._verse}{(_reference._endVerse != null ? $"-{_reference._endVerse}" : "")}  <<<\n");
            Console.WriteLine();
            foreach (Word word in _words)
            {
                Console.Write(word.ToString() + " ");
            }
            Console.WriteLine();
        }
        public bool isCompletelyHidden()
        {
            foreach (Word word in _words)
            {
                if (!word._isHidden)
                {
                    return false;
                }
            }
            return true;
        }
    }
}