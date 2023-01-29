using System;

public class Entry
{
    
    public List<Journal> _tempJournalEntry = new List<Journal>();

    //Methods

    public void JournalEntry() {

    }
    public void Display() {
        foreach (Journal datas in _tempJournalEntry)
        {
            datas.DisplayEntries();
        }
    }
}