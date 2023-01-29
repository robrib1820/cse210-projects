using System;

public class Entry
{
    public string _journalEntry;
    public string _entryDate;
    public string _promptQuestion;

    public List<Journal> _tempJournalEntry = new List<Journal>();

    //Methods

    public void JournalEntry() {
        Console.WriteLine(_journalEntry);
        
    }
    public void Display() {
        foreach (Journal datas in _tempJournalEntry)
        {
            datas.DisplayEntries();
        }
    }
}