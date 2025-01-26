using System;

namespace ScriptureMemorizer
{
    class Word
    {
        public string _text { get; set; }
        public bool _isHidden { get; set; }
        public Word(string text)
        {
            _text = text;
            _isHidden = false;
        }
        public void Hide()
        {
            _isHidden = true;
        }
        public void Show()
        {
            _isHidden = false;
        }
        public override string ToString()
        {
            if (_isHidden)
            {
                return new String('_', _text.Length);
            }
            else
            {
                return _text;
            }
        }
    }
}