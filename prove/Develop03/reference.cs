using System;

class Reference {
    //book, chapter and verse information
    private int _verse;
    private int _chapter;
    private string _book;

    private int _secondeVerse; //if necessary

    //constructors
    public Reference() {
        _book = "2 Néfi";
        _chapter = 31;
        _verse = 20;
    }
    public Reference(int verse, int secondeVerse) {
        _book = "2 Néfi";
        _chapter = 31;
        _verse = verse;
        _secondeVerse = secondeVerse;
    }
    // Getters and Setters
    public string GetReference() {
        string reference = _book +" "+ _chapter +" "+ _verse;
        return reference;
    }
    //Methods
    //THINK ABOUT OTHER METHODS AS NECESSARY
    

}
