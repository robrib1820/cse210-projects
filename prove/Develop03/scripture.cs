using System;
class Scripture {
    private string _referenceText; // chapters Numbers
    private string _scriptureText; // scripture
    private string _wholeScripture;
    private List<string> listOfWords = new List<string>(); // text of the scripture
    // essa classe vai pegar o resultado final(renderizado) com palavras escondidas.

    //constructors
    //the constructor would have the responsibility of creating the list, and splitting up the words
    //in the string to create Word objects for each one and put them in the list.
    public Scripture() {
        
    }
    public Scripture(string reference, string scripture) {
        _referenceText = reference;
        _scriptureText= scripture;
        _wholeScripture = _referenceText + " - " + _scriptureText;
    }
    //Methods
    public void HideWords() {
        listOfWords = _wholeScripture.Split("").ToList();

        foreach (string word in listOfWords)
        {
        Console.WriteLine(word);
        }
    }
    public void GetScriptureText() {
        // Console.WriteLine(_wholeScripture);
        HideWords();
    }
    public List<string> list() {
        return listOfWords;
    }
}