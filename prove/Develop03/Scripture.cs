
public class Scripture
{
    private string[] words;
    private bool[] wordsVisibility;
    private int currentIndex = 0;
    public string Reference {get; private set; }


    wordsVisibility = new bool[words.Length];
    for (int i = 0; i < words.Length; i++) {
        wordsVisibility[i] = true;
    }
    

    public Scripture(string reference, string text)
    {
        Reference = reference;
        words = text.Split(' ');
        wordsVisibility = new bool[words.Length];
        for (int i = 0; i < words.Length; i++)
        {
        wordsVisibility[i] = true;
        }
    }
        //method to hide random words
    public void HideRandomWords(int count)
    {
        Random rnd = new Random();
        for (int i =0; i < count; i++)
        {
            int indexToHide = rnd.Next(words.Length);
            wordsVisibility[indexToHide] = false;
        }
    }

    public string GetScriptureWithHiddenWords()
    {
        var displayedText = new StringBuilder();
        for (int i = 0; i < words.Length; i++)
        {
            displayedText.Append(wordsVisibility[i] ? words[i] + " " : "_ "); //Append word or placeholder
        }
        return displayedText.ToString().Trim();
    }

    public bool AllWordsHidden()
    {
        foreach (bool isVisible in wordsVisibility)
        {
            if (isVisible) return false;
        }
        return true;
    }
}
