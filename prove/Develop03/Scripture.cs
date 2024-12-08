 using System;

 
  public class Scripture
{
     private Reference _reference;
    private List<Word> _words;
    public Scripture(Reference reference, string text)
        {
            _reference = reference;
            _words = text.Split(' ').Select(word => new Word(word)).ToList();
        }
    public void HideRandomWords(int numberToHide)
        {
            var visibleWords = _words.Where(word => !word.IsHidden()).ToList();
            if (!visibleWords.Any()) return;

            var random = new Random();
            for (int i = 0; i < numberToHide && visibleWords.Any(); i++)
            {
                int index = random.Next(visibleWords.Count);
                visibleWords[index].Hide();
                visibleWords.RemoveAt(index);
            }
        }

        public string GetDisplayText()
        {
            return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
        }

        public bool IsCompletelyHidden()
        {
            return _words.All(word => word.IsHidden());
        }
    }
}