using System;

class Word {
    private string _word;
    private List<string> _words = new List<string>();

    private int _index;

    // mantém o texto de uma palavra única e se ela está escondia ou não.

    //Constructors
    //the constructor needs to set the visibitily or the user needs to pass in?
    public Word() {

    }
    //Methods
    public void Hide() {
        Random num = new Random();
        int randIndex = num.Next(_words.Count);
        string selectedNum = _words[randIndex];
        Console.WriteLine(selectedNum);
    }
    public void Shown() {

    }
    public void IsHidden() {

    }
    public void GetRenderedText(List<string> list) {
        _words = list;
    }
}