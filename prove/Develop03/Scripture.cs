public class Scripture
{
    private Reference _reference;
    private List<Word> _words { get; set;}
    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(int numberToHide)
    {
        Random random = new Random();
        int wordsCount = _words.Count();
        List<int> indicesToHide = new List<int>();

        //List of indices of words currently visible
        List<int> visibleWordIndices = _words
            .Select((word, index) => new { word, index })
            .Where(x => !x.word.IsHidden())
            .Select(x => x.index)
            .ToList();

        // For when number of words is fewer than int wordsToHide
        int wordsLeftToHide = Math.Min(numberToHide, visibleWordIndices.Count);



        while (indicesToHide.Count < wordsLeftToHide)
        {
            int randomIndex = random.Next(visibleWordIndices.Count);
            int wordIndex = visibleWordIndices[randomIndex];
            if (!indicesToHide.Contains(wordIndex))
            {
                indicesToHide.Add(wordIndex);
                visibleWordIndices.RemoveAt(randomIndex); //Helps avoid re-selection
            }
        }

        foreach (int index in indicesToHide)
        {
            _words[index].Hide();
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()} - {string.Join(" ", _words.Select(word => word.GetDisplayText()))}";
    }
    public bool IsCompletelyHidden()
    {
        return _words.All(word => word.IsHidden());
    }
}